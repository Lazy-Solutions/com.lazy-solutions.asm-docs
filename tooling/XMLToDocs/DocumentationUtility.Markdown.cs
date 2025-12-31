using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
                sb.AppendLine("### Description");
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

                var members = type.GetMembers(
                    BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly
                );

                // Sections
                GenerateSection(sb, "Static Properties", members.OfType<PropertyInfo>().Where(p => p.IsStatic()), nestedLevel);
                GenerateSection(sb, "Properties", members.OfType<PropertyInfo>().Where(p => !p.IsStatic()), nestedLevel);

                GenerateSection(sb, "Static Fields", members.OfType<FieldInfo>().Where(f => f.IsStatic), nestedLevel);
                GenerateSection(sb, "Fields", members.OfType<FieldInfo>().Where(f => !f.IsStatic), nestedLevel);

                GenerateSection(sb, "Static Events", members.OfType<EventInfo>().Where(e => e.AddMethod?.IsStatic ?? false), nestedLevel);
                GenerateSection(sb, "Events", members.OfType<EventInfo>().Where(e => !(e.AddMethod?.IsStatic ?? false)), nestedLevel);

                GenerateSection(sb, "Static Methods", members.OfType<MethodInfo>().Where(m => m.IsStatic && !m.IsSpecialName), nestedLevel);
                GenerateSection(sb, "Methods", members.OfType<MethodInfo>().Where(m => !m.IsStatic && !m.IsSpecialName), nestedLevel);

                return sb.ToString().TrimEnd();
            }

            // --- New Helpers ---

            private static void GenerateHeader(StringBuilder sb, Type type, int nestedLevel)
            {
                // Main name
                sb.AppendLine(GetHeader(type.Name, nestedLevel));

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
                sb.Append($"`{kind}` in `{type.Namespace}`");

                // Inheritance (only for classes/structs, not interfaces/enums)
                if (type.BaseType is Type baseType && baseType != typeof(object))
                {
                    sb.Append($"  /  Inherits from: `{baseType.GetFriendlyTypeName()}`");
                }
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

                    var summary = doc?.GetEffective(d => d.Summary) ?? "_No documentation available._";
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
