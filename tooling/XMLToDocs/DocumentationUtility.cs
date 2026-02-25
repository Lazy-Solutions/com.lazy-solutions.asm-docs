using System;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using UnityEditor;

namespace AdvancedSceneManager.Documentation
{

    public static partial class DocumentationUtility
    {

        public static MemberDocumentation GetDocumentation<T>() =>
            GetDocumentation(typeof(T));

        public static MemberDocumentation GetDocumentation(Type type) =>
            GetDocumentation(member: type);

        public static MemberDocumentation GetDocumentation<T>(Expression<Func<T>> func) =>
            GetDocumentation(GetMemberInfo(func.Body));

        private static MemberInfo GetMemberInfo(Expression expr)
        {
            return expr switch
            {
                MethodCallExpression callExpr => callExpr.Method,
                MemberExpression memberExpr => memberExpr.Member,
                UnaryExpression unaryExpr => GetMemberInfo(unaryExpr.Operand),
                _ => throw new NotSupportedException($"Unsupported expression type {expr.GetType().Name}")
            };
        }

        /// <summary>Generates a markdown file for every type in the assembly, using namespaces for folder structure.</summary>
        /// <param name="assembly">The assembly to generate docs for.</param>
        /// <param name="outputFolder">The root folder to generate docs to.</param>
        /// <param name="namespaceToTrim">Trims the namespace string from the left, removing the root namespace from the folder structure.</param>
        /// <param name="showFolderWhenDone">Displays the file explorer at <paramref name="outputFolder"/> when done, if <see langword="true"/>.</param>
        public static void GenerateOpinionatedDocs(Assembly assembly, string outputFolder, string namespaceToTrim = null, bool showFolderWhenDone = false, Action<(string file, int fileIndex, int fileCount)> progress = null)
        {

            namespaceToTrim = namespaceToTrim?.TrimEnd('.');

            if (Directory.Exists(outputFolder))
                Directory.Delete(outputFolder, recursive: true);
            Directory.CreateDirectory(outputFolder);

            var types = assembly.ExportedTypes.Where(t => t.Namespace != null && !t.Namespace.Contains("CodeGenerated")).ToList();
            var i = 0;
            foreach (var type in types)
            {

                var relativeNamespace = GetRelativeNamespace(type.Namespace, namespaceToTrim);
                var subfolder = Path.Combine(outputFolder, relativeNamespace.Replace('.', Path.DirectorySeparatorChar));

                var safeName = ToSafeFileName(type);

                var file = $"{subfolder}/{safeName}.md".Replace("\\", "/");

                i += 1;
                progress?.Invoke((file, i, types.Count));

                Directory.CreateDirectory(Path.GetDirectoryName(file)!);

                var md = Markdown.GenerateMarkdown(type);
                File.WriteAllText(file, md);

            }

            AssetDatabase.Refresh();

            if (showFolderWhenDone)
                EditorUtility.RevealInFinder(outputFolder);

        }

        static string GetRelativeNamespace(string namespaceStr, string namespaceToTrim)
        {

            if (string.IsNullOrEmpty(namespaceStr))
                return string.Empty;

            if (!string.IsNullOrEmpty(namespaceToTrim) &&
                namespaceStr.Equals(namespaceToTrim, StringComparison.Ordinal))
                return string.Empty;

            if (!string.IsNullOrEmpty(namespaceToTrim) &&
                namespaceStr.StartsWith(namespaceToTrim + ".", StringComparison.Ordinal))
                return namespaceStr.Substring(namespaceToTrim.Length + 1);

            return namespaceStr;

        }

        static string ToSafeFileName(Type type)
        {

            var name = type.Name;

            // Handle generics (e.g. List`1 -> List_Of_T)
            if (type.IsGenericType)
            {
                var baseName = name.Split('`')[0];
                var args = type.GetGenericArguments()
                               .Select(a => ToSafeFileName(a).Replace(".md", "")); // recursive, no extension
                name = baseName + "_Of_" + string.Join("_", args);
            }

            // Handle nested types
            name = name.Replace("+", ".");

            // Handle arrays
            if (type.IsArray)
                name = ToSafeFileName(type.GetElementType()!) + "_Array";

            // Handle by-ref types
            if (type.IsByRef)
                name = ToSafeFileName(type.GetElementType()!) + "_Ref";

            // Handle pointer types
            if (type.IsPointer)
                name = ToSafeFileName(type.GetElementType()!) + "_Ptr";

            // Replace invalid filename chars with '-'
            name = string.Concat(name.Select(c =>
                Path.GetInvalidFileNameChars().Contains(c) ? '-' : c));

            return name;

        }

    }

}
