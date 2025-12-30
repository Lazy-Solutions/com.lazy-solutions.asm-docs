using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using UnityEditor;

namespace AdvancedSceneManager.Documentation
{

    public static partial class DocumentationUtility
    {

        public static MemberDocumentation GetDocumentation(this MemberInfo member)
        {

            // If it's a getter/setter, redirect to the property
            if (member is MethodInfo mi && mi.IsSpecialName && (mi.Name.StartsWith("get_") || mi.Name.StartsWith("set_")))
            {
                var prop = mi.DeclaringType?.GetProperty(mi.Name.Substring(4), BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
                if (prop is not null)
                    member = prop;
            }

            if (XML.docs.TryGetValue(member, out var doc) && doc is not null)
                return doc;

            doc = XML.ParseDocument(member);
            XML.docs.Add(member, doc);

            return doc;

        }

        public static void ClearCache()
        {
            XML.documents.Clear();
            XML.docs.Clear();
        }

        public static class XML
        {

            internal readonly static Dictionary<Assembly, XmlDocument> documents = new();
            internal static readonly Dictionary<MemberInfo, MemberDocumentation> docs = new();

            public static XmlDocument ReadDocument(MemberInfo member)
            {
                var assembly = (member as Type)?.Assembly
                            ?? member.DeclaringType?.Assembly
                            ?? throw new InvalidOperationException($"Couldn't find assembly for {member}.");

                if (documents.TryGetValue(assembly, out var doc))
                    return doc;

                var file = Path.ChangeExtension(assembly.Location, ".xml");

                // Only try to load if the xml file exists
                if (!File.Exists(file))
                {
                    // Skip docs for external/system assemblies
                    documents[assembly] = null;
                    return null;
                }

                doc = new XmlDocument();
                doc.Load(file);
                documents[assembly] = doc;

                return doc;
            }

            public static MemberDocumentation ParseDocument(MemberInfo member)
            {
                var document = ReadDocument(member);
                if (document == null)
                    return new MemberDocumentation { Member = member }; // no docs available

                var id = GetXmlDocID(member);
                var node = document.SelectSingleNode($"/doc/members/member[@name='{id}']");

                if (node is null)
                    return new MemberDocumentation { Member = member };

                return ParseNode(node, member);
            }

            public static string GetXmlDocID(MemberInfo member) =>
                member switch
                {
                    Type type => $"T:{type.FullName}",
                    MethodInfo method => $"M:{method.DeclaringType.FullName}.{method.Name}{GetParameters(method.GetParameters())}",
                    ConstructorInfo ctor => $"M:{ctor.DeclaringType.FullName}.#ctor{GetParameters(ctor.GetParameters())}",
                    PropertyInfo prop => $"P:{prop.DeclaringType.FullName}.{prop.Name}",
                    FieldInfo field => $"F:{field.DeclaringType.FullName}.{field.Name}",
                    EventInfo ev => $"E:{ev.DeclaringType.FullName}.{ev.Name}",
                    _ => throw new NotSupportedException($"Unsupported member: {member}"),
                };

            private static string GetParameters(ParameterInfo[] parameters)
            {

                if (parameters.Length == 0)
                    return string.Empty;

                return $"({string.Join(",", parameters.Select(p => FormatTypeName(p.ParameterType)))})";

            }

            static string FormatTypeName(Type type)
            {

                if (type.IsGenericType)
                {
                    // Handle generic type arguments
                    var genericTypeDef = type.GetGenericTypeDefinition();
                    var typeName = genericTypeDef.FullName;
                    typeName = typeName.Substring(0, typeName.IndexOf('`'));
                    return typeName + "{" + string.Join(",", type.GetGenericArguments().Select(FormatTypeName)) + "}";
                }

                if (type.IsArray)
                    return FormatTypeName(type.GetElementType()) + "[]";

                return type.FullName;

            }

            static MemberDocumentation ParseNode(XmlNode node, MemberInfo member)
            {
                var documentation = new MemberDocumentation { Member = member };

                if (node["summary"] is XmlNode summaryNode)
                    documentation.Summary = ParseDocumentationNode(summaryNode);

                if (node["remarks"] is XmlNode remarksNode)
                    documentation.Remarks = ParseDocumentationNode(remarksNode);

                if (node["inheritdoc"] is XmlNode inheritNode)
                {
                    var cref = inheritNode.Attributes?["cref"]?.Value;
                    if (!string.IsNullOrEmpty(cref))
                    {
                        documentation.InheritsFrom = ResolveCref(cref);
                    }
                    else
                    {
                        documentation.InheritsFrom = FindBaseMember(member);
                    }
                }

                return documentation;
            }

            static string ParseDocumentationNode(XmlNode node)
            {

                if (node == null)
                    return string.Empty;

                var sb = new StringBuilder();

                foreach (XmlNode child in node.ChildNodes)
                {
                    switch (child.NodeType)
                    {
                        case XmlNodeType.Text:
                            sb.Append(child.Value);
                            break;

                        case XmlNodeType.Element:
                            switch (child.Name)
                            {
                                case "paramref":
                                case "typeparamref":
                                    sb.Append('`').Append(child.Attributes?["name"]?.Value).Append('`');
                                    break;

                                case "see":
                                case "seealso":
                                    {
                                        var langword = child.Attributes?["langword"]?.Value;
                                        var cref = child.Attributes?["cref"]?.Value;

                                        if (!string.IsNullOrEmpty(langword))
                                        {
                                            sb.Append('`').Append(langword.ToLowerInvariant()).Append('`');
                                        }
                                        else if (!string.IsNullOrEmpty(cref))
                                        {
                                            var display = cref.Split('.').Last();
                                            if (display.Contains(":"))
                                                display = display[(display.IndexOf(':') + 1)..];

                                            // Try resolve
                                            var resolved = ResolveCref(cref);
                                            if (resolved != null)
                                            {
                                                sb.Append('`').Append(display).Append('`');
                                            }
                                            else
                                            {
                                                // External placeholder
                                                var urlSafe = cref.Replace("T:", "").Replace("+", ".");
                                                sb.Append($"[{display}](https://learn.microsoft.com/dotnet/api/{urlSafe.ToLowerInvariant()})");
                                            }
                                        }
                                        else
                                        {
                                            sb.Append(child.InnerText);
                                        }
                                        break;
                                    }

                                case "c":
                                    sb.Append('`').Append(child.InnerText.Trim()).Append('`');
                                    break;

                                case "code":
                                    sb.AppendLine().AppendLine("```")
                                      .AppendLine(child.InnerText.Trim())
                                      .AppendLine("```").AppendLine();
                                    break;

                                case "para":
                                    sb.AppendLine().AppendLine(ParseDocumentationNode(child));
                                    break;

                                case "list":
                                    sb.AppendLine();
                                    var items = child.SelectNodes("item/description");
                                    if (items != null)
                                    {
                                        foreach (XmlNode item in items)
                                            sb.Append("- ").Append(ParseDocumentationNode(item)).AppendLine();
                                    }
                                    break;

                                default:
                                    // unknown tag → fallback to inner text
                                    sb.Append(child.InnerText);
                                    break;
                            }
                            break;
                    }
                }

                return sb.ToString().Trim();

            }

            static MemberInfo FindBaseMember(MemberInfo member)
            {
                if (member is MethodInfo mi)
                {
                    // base class virtual/override
                    var baseDef = mi.GetBaseDefinition();
                    if (baseDef != mi)
                        return baseDef;

                    // interfaces
                    foreach (var iface in mi.DeclaringType.GetInterfaces())
                    {
                        var map = mi.DeclaringType.GetInterfaceMap(iface);
                        for (int i = 0; i < map.TargetMethods.Length; i++)
                            if (map.TargetMethods[i] == mi)
                                return map.InterfaceMethods[i];
                    }
                }
                else if (member is PropertyInfo pi)
                {
                    // base class property
                    var baseType = pi.DeclaringType.BaseType;
                    while (baseType != null)
                    {
                        var baseProp = baseType.GetProperty(pi.Name,
                            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                        if (baseProp != null)
                            return baseProp;
                        baseType = baseType.BaseType;
                    }

                    // interfaces (handle explicit implementations)
                    foreach (var iface in pi.DeclaringType.GetInterfaces())
                    {
                        var map = pi.DeclaringType.GetInterfaceMap(iface);
                        for (int i = 0; i < map.TargetMethods.Length; i++)
                        {
                            var target = map.TargetMethods[i];
                            if (pi.GetAccessors(true).Contains(target))
                                return iface.GetProperty(map.InterfaceMethods[i].Name);
                        }
                    }
                }
                else if (member is EventInfo ei)
                {
                    // base class event
                    var baseType = ei.DeclaringType.BaseType;
                    while (baseType != null)
                    {
                        var baseEvt = baseType.GetEvent(ei.Name,
                            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                        if (baseEvt != null)
                            return baseEvt;
                        baseType = baseType.BaseType;
                    }

                    // interface events (similar to properties)
                    foreach (var iface in ei.DeclaringType.GetInterfaces())
                    {
                        var ifaceEvt = iface.GetEvent(ei.Name);
                        if (ifaceEvt != null)
                            return ifaceEvt;
                    }
                }
                else if (member is Type t)
                {
                    // base class
                    if (t.BaseType != null)
                        return t.BaseType;

                    // or maybe first interface?
                    // (not always meaningful to inherit docs from an interface type though)
                    var iface = t.GetInterfaces().FirstOrDefault();
                    if (iface != null)
                        return iface;
                }

                // fields: generally no inheritance
                return null;
            }

            static MemberInfo ResolveCref(string cref)
            {
                // Strip prefix like "T:", "M:", "P:" etc.
                var kind = cref[0];
                var name = cref.Substring(2);

                // Replace '+' with '.' for nested types if needed
                name = name.Replace('+', '.');

                foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
                {
                    switch (kind)
                    {
                        case 'T': // type
                            var type = asm.GetType(name);
                            if (type != null) return type;
                            break;

                        case 'P': // property
                        case 'F': // field
                        case 'M': // method
                        case 'E': // event
                            var parts = name.Split('.');
                            var typeName = string.Join(".", parts.Take(parts.Length - 1));
                            var memberName = parts.Last();

                            var declaringType = asm.GetType(typeName);
                            if (declaringType != null)
                            {
                                var member = declaringType.GetMember(memberName,
                                    BindingFlags.Public | BindingFlags.NonPublic |
                                    BindingFlags.Static | BindingFlags.Instance).FirstOrDefault();
                                if (member != null) return member;
                            }
                            break;
                    }
                }

                return null;
            }

        }

    }

}
