#if ASM
using AdvancedSceneManager.Callbacks;
using AdvancedSceneManager.Editor.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using Debug = UnityEngine.Debug;

namespace AdvancedSceneManager.Documentation.ASMSupport
{

    static class ASMSupport
    {

        [ASMWindowElement(ElementLocation.Header, isVisibleByDefault: true)]
        static VisualElement ViewDocsButton()
        {

            var button = new Button() { text = "\uf518", tooltip = "View ASM documentation" };
            button.UseFontAwesome(solid: true);

            button.RegisterCallback<ClickEvent>(e =>
            {
                var asset = AssetDatabase.LoadAssetAtPath<ReadMe>(Package.readMePath);
                Selection.activeObject = asset;
                ProjectWindowUtil.ShowCreatedAsset(asset);
            });

            return button;

        }

#if ASM_DEV

        [ASMWindowElement(ElementLocation.Header)]
        static VisualElement GenerateDocsButton()
        {

            var button = new Button() { text = "\uf60f", tooltip = "Generate documentation from code" };
            button.UseFontAwesome(brands: true);

            button.RegisterCallback<ClickEvent>(e =>
            {
                EditorUtility.DisplayProgressBar("Generating docs...", "", 0);

                try
                {
                    GenerateMarkdown();
                    CombineApiDocs();
                }
                catch (Exception ex)
                {
                    Log.Exception(ex);
                }

                EditorUtility.ClearProgressBar();
            });

            return button;

        }

        static void GenerateMarkdown()
        {

            var folder = Path.GetFullPath(Package.apiFolder);

            if (Directory.Exists(folder))
                Directory.Delete(folder, recursive: true);
            Directory.CreateDirectory(folder);

            var types = typeof(SceneManager).Assembly.ExportedTypes.Where(t => t.Namespace != null && !t.Namespace.Contains("CodeGenerated")).ToList();
            var i = 0;
            foreach (var type in types)
            {
                var subfolder = $"{folder}/{type.Namespace.Replace("AdvancedSceneManager", "")?.Replace(".", "/") ?? string.Empty}";

                var safeName = ToSafeFileName(type);

                var file = $"{subfolder}/{safeName}.md";
                EditorUtility.DisplayProgressBar("Generating docs...", file, i++ / (float)types.Count);

                Directory.CreateDirectory(Path.GetDirectoryName(file)!);

                var md = DocumentationUtility.Markdown.GenerateMarkdown(type);
                File.WriteAllText(file, md);
            }

            EditorUtility.RevealInFinder(folder);

        }

        static void CombineApiDocs()
        {
            var outputPath = Path.GetFullPath(Package.folder + "/combined/");
            Directory.CreateDirectory(outputPath);
            EditorUtility.DisplayProgressBar("Generating docs...", "Finalizing...", 1);

            const int MaxCombinedSize = 500_000;

            var files = Directory
                .EnumerateFiles(Package.folder, "*.md", SearchOption.AllDirectories)
                .Where(f => !f.Contains("/combined/") && !f.Contains("\\combined\\"))
                .OrderBy(f => f, StringComparer.OrdinalIgnoreCase)
                .ToList();

            int part = 1;
            var builder = new StringBuilder();
            int currentSize = 0;

            void Flush()
            {
                if (builder.Length == 0)
                    return;

                var filePath = Path.Combine(outputPath, $"ASM-docs-part-{part++}.md");
                File.WriteAllText(filePath, builder.ToString());

                builder.Clear();
                currentSize = 0;
            }

            foreach (var file in files)
            {
                var content = File.ReadAllText(file);

                var header =
                    "---\n" +
                    $"# {Path.GetFileNameWithoutExtension(file)}\n" +
                    "<!--\n" +
                    $"source: {Path.GetRelativePath(Package.folder, file)}\n" +
                    "-->\n\n";

                var wrapped = header + content + "\n\n";

                if (currentSize + wrapped.Length > MaxCombinedSize)
                    Flush();

                builder.Append(wrapped);
                currentSize += wrapped.Length;
            }

            Flush();
        }

        static string ToSafeFileName(Type type)
        {
            string name = type.Name;

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

        [OnLoad]
        static async Task ASMDocDllExporter()
        {

            var progress = Progress.Start("Generating documentation xml", "AdvancedSceneManager.csproj", Progress.Options.Indefinite);

            try
            {

                var psi = new ProcessStartInfo("dotnet", "build AdvancedSceneManager.csproj")
                {
                    WorkingDirectory = Path.Combine(Application.dataPath, ".."),
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using var p = new Process { StartInfo = psi };

                var output = new List<string>();
                p.OutputDataReceived += (s, e) => { if (e.Data != null) output.Add(e.Data); };
                p.ErrorDataReceived += (s, e) => { if (e.Data != null) output.Add("[ERR] " + e.Data); };

                p.Start();
                p.BeginOutputReadLine();
                p.BeginErrorReadLine();

                // wait with timeout
                var exited = await Task.Run(() => p.WaitForExit((int)TimeSpan.FromSeconds(30).TotalMilliseconds));

                if (!exited)
                {
                    try { p.Kill(); } catch { /* ignore */ }
                    p.CancelOutputRead();
                    p.CancelErrorRead();
                    Debug.LogError($"dotnet build timed out after 30s and was killed.\n{string.Join("\n", output)}");
                    return;
                }

                if (p.ExitCode != 0)
                {
                    Debug.LogError($"dotnet build failed (exit {p.ExitCode}).\n{string.Join("\n", output)}");
                    return;
                }
            }
            catch (Exception ex)
            {
                Debug.LogError($"[ASMDocDllExporter] Failed: {ex}");
            }

            Progress.Remove(progress);

        }

#endif

    }

}
#endif