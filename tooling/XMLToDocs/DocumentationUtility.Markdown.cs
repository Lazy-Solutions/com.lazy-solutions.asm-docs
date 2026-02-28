using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace AdvancedSceneManager.Documentation
{

    public static partial class DocumentationUtility
    {

        static StringBuilder _AppendLine(this StringBuilder sb, string line) =>
            sb._AppendLine(string.Empty, line);

        static StringBuilder _AppendLine(this StringBuilder sb, string header, string line)
        {

            if (string.IsNullOrEmpty(line?.Replace(">", "")?.Trim()))
                return sb;

            if (!string.IsNullOrEmpty(header))
                sb.AppendLine("\n<b> " + header + "</b>");

            if (!string.IsNullOrEmpty(line))
                sb.AppendLine(line);

            return sb;

        }

        public static class Markdown
        {
            public static string GenerateMarkdown(Type type, int nestedLevel = 0)
            {
                var sb = new StringBuilder();

                // Header
                GenerateHeader(sb, type, nestedLevel);

                // Description
                sb.AppendLine("\n\n### Description");
                var doc = type.GetDocumentation();
                if (doc != null)
                {
                    sb._AppendLine(doc.GetEffective(d => d.Summary));
                    sb._AppendLine("Remarks:", doc.GetEffective(d => d.Remarks));
                }
                else
                {
                    sb.AppendLine("_No documentation available._");
                }

                sb.AppendLine();

                if (type.IsEnum)
                    GenerateEnumSection(sb, type, nestedLevel);
                else if (type.IsDelegate())
                    GenerateDelegateSection(sb, type, nestedLevel);
                else
                    GenerateTypeMembersSection(sb, type, nestedLevel);

                return sb.ToString().TrimEnd();
            }

            private static void GenerateEnumSection(StringBuilder sb, Type type, int nestedLevel)
            {
                sb.AppendLine("### Values\n");

                sb.AppendLine("| Name | Description |");
                sb.AppendLine("|------|-------------|");

                var fields = type.GetFields(BindingFlags.Public | BindingFlags.Static);

                foreach (var field in fields)
                {
                    var doc = field.GetDocumentation();
                    var summary = Escape(doc?.GetEffective(d => d.Summary) ?? "_No documentation available._");

                    sb.AppendLine($"| `{field.Name}` | {summary} |");
                }

                sb.AppendLine();
            }

            private static void GenerateDelegateSection(StringBuilder sb, Type type, int nestedLevel)
            {
                sb.AppendLine("### Signature\n");

                var invoke = type.GetMethod("Invoke");
                if (invoke == null)
                {
                    sb.AppendLine("_Invalid delegate definition._");
                    return;
                }

                var returnType = invoke.ReturnType.GetFriendlyTypeName();
                var parameters = string.Join(", ",
                    invoke.GetParameters()
                          .Select(p => $"{p.ParameterType.GetFriendlyTypeName()} {p.Name}"));

                sb.AppendLine($"`{returnType} {type.GetFriendlyTypeName()}({parameters})`");
                sb.AppendLine();
            }

            private static void GenerateTypeMembersSection(StringBuilder sb, Type type, int nestedLevel)
            {
                var members = type
                    .GetMembers(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly)
                    .Where(IsRealMember);

                // Sections
                GenerateSection(sb, "Static Properties", members.OfType<PropertyInfo>().Where(p => p.IsStatic()), nestedLevel);
                GenerateSection(sb, "Properties", members.OfType<PropertyInfo>().Where(p => !p.IsStatic()), nestedLevel);

                GenerateSection(sb, "Static Fields", members.OfType<FieldInfo>().Where(f => f.IsStatic), nestedLevel);
                GenerateSection(sb, "Fields", members.OfType<FieldInfo>().Where(f => !f.IsStatic), nestedLevel);

                GenerateSection(sb, "Static Events", members.OfType<EventInfo>().Where(e => e.AddMethod?.IsStatic ?? false), nestedLevel);
                GenerateSection(sb, "Events", members.OfType<EventInfo>().Where(e => !(e.AddMethod?.IsStatic ?? false)), nestedLevel);

                GenerateSection(sb, "Static Methods", members.OfType<MethodInfo>().Where(m => m.IsStatic && !m.IsSpecialName), nestedLevel);
                GenerateSection(sb, "Methods", members.OfType<MethodInfo>().Where(m => !m.IsStatic && !m.IsSpecialName), nestedLevel);
            }

            private static bool IsRealMember(MemberInfo member)
            {
                switch (member)
                {
                    case MethodBase m when m.IsSpecialName:
                        return false;

                    case PropertyInfo p when p.IsSpecialName:
                        return false;

                    case EventInfo e when e.IsSpecialName:
                        return false;

                    case FieldInfo f when f.IsSpecialName:
                        return false;

                    case ConstructorInfo:
                        return false; //In ASM, we don't want constructor docs (it always results in obvious, generic descriptions)
                }

                if (member.Name.Contains("$"))
                    return false;

                if (member.Name == "value__")
                    return false;

                if (member.Name.StartsWith("<"))
                    return false;

                if (member.GetCustomAttribute<CompilerGeneratedAttribute>() != null)
                    return false;

                if (member.DeclaringType != null && typeof(MulticastDelegate).IsAssignableFrom(member.DeclaringType))
                    return false;

                return true;
            }

            // --- New Helpers ---

            private static void GenerateHeader(StringBuilder sb, Type type, int nestedLevel)
            {
                // Main name
                sb.AppendLine(GetHeader(Escape(type.GetFriendlyTypeName()), nestedLevel));

                // Kind
                var kind = type.IsClass ? "class" :
                           type.IsInterface ? "interface" :
                           type.IsEnum ? "enum" :
                           type.IsValueType ? "struct" : "type";

                if (type.IsAbstract && type.IsSealed)
                    kind = "static " + kind;
                else if (type.IsAbstract && type.IsClass)
                    kind = "abstract " + kind;
                else if (type.IsSealed && type.IsClass)
                    kind = "sealed " + kind;

                // Namespace + Assembly
                string container =
                    type.DeclaringType != null
                        ? GetFriendlyContainerName(type.DeclaringType)
                        : type.Namespace;

                sb.Append($"`{kind}` in `{container}`");

                // Inheritance (only for classes/structs, not interfaces/enums)
                if (type.BaseType is Type baseType && baseType != typeof(object) && baseType != typeof(ValueType) && baseType != typeof(MulticastDelegate))
                {
                    sb.Append($"  /  Inherits from: `{Escape(baseType.GetFriendlyTypeName())}`");
                }
            }

            private static string Escape(string str)
            {
                if (string.IsNullOrEmpty(str))
                    return str;

                return str
                    .Replace("&", "&amp;")
                    .Replace("<", "&lt;")
                    .Replace(">", "&gt;")
                    .Replace("|", "\\|")
                    .Replace("_", "\\_")
                    .Replace("*", "\\*")
                    .Replace("[", "\\[")
                    .Replace("]", "\\]")
                    .Replace("#", "\\#");
            }

            private static string GetFriendlyContainerName(Type type)
            {
                if (type.DeclaringType != null)
                    return GetFriendlyContainerName(type.DeclaringType) + "." + Escape(type.GetFriendlyTypeName());

                return type.Namespace + "." + type.Name;
            }

            private static void GenerateSection(StringBuilder sb, string header, IEnumerable<MemberInfo> members, int nestedLevel)
            {
                var list = members
                    .Where(m => !(m is MethodInfo mi && mi.IsSpecialName))
                    .OrderBy(m => m.Name)
                    .ToList();

                if (list.Count == 0)
                    return;

                sb.AppendLine(GetHeader(header, nestedLevel + 1));
                sb.AppendLine("| Member | Description |");
                sb.AppendLine("|--------|-------------|");

                foreach (var member in list)
                {
                    var doc = member.GetDocumentation();
                    var signature = "`" + member.GetSignature(includeAccessModifiers: false, includeStaticIndicator: false) + "`"; // no `static` here

                    var summary = Escape(doc?.GetEffective(d => d.Summary) ?? "_No documentation available._");
                    summary = summary?.Replace("|", "\\|");

                    sb.AppendLine($"| {signature} | {summary} |");
                }

                sb.AppendLine();
            }

            private static string GetHeader(string text, int nestedLevel = 0)
            {
                var effectiveLevel = Math.Min(6, 2 + nestedLevel);
                return $"{new string('#', effectiveLevel)} {text}\n";
            }
        }

    }

}
