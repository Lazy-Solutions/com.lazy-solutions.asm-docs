using UnityEngine;
using UnityEngine.UIElements;

#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.Requests;
#endif

#if ASM_DEV
[CreateAssetMenu(fileName = "readme", menuName = "Advanced Scene Manager/readme")]
#endif
public partial class ReadMe : ScriptableObject
{
    public StyleSheet style; // assign your USS here
}

#if UNITY_EDITOR
partial class ReadMe : ScriptableObject
{
    [CustomEditor(typeof(ReadMe), isFallback = true)]
    [CanEditMultipleObjects]
    class Editor : UnityEditor.Editor
    {
        protected override bool ShouldHideOpenButton() => true;

        public override VisualElement CreateInspectorGUI()
        {
            var container = new VisualElement();
            container.styleSheets.Add(((ReadMe)target).style);

            // Title
            var title = new Label("Welcome to ASM Docs");
            title.AddToClassList("title");
            container.Add(title);

            // Explanation
            var guidesInfo = new Label("The <b>Guides</b> folder contains hand-written articles, while the <b>API</b> folder contains generated C# documentation.");
            guidesInfo.AddToClassList("paragraph");
            container.Add(guidesInfo);

            var markdownInfo = new Label("Documentation is written in Markdown. To view it inside Unity, you’ll need a Markdown viewer package, such as:");
            markdownInfo.AddToClassList("paragraph");
            container.Add(markdownInfo);

            // Link
            var link = new Label("View on GitHub");
            link.AddToClassList("link");
            link.RegisterCallback<ClickEvent>(_ => Application.OpenURL("https://github.com/gwaredd/UnityMarkdownViewer.git"));
            container.Add(link);

            // Separator
            var line = new VisualElement();
            line.AddToClassList("separator");
            container.Add(line);

            // Install button
            var button = new Button() { text = "📦 Checking package..." };
            button.AddToClassList("button");
            button.SetEnabled(false);
            container.Add(button);

            ListRequest listRequest = Client.List(true); // true = include dependencies

            // poll until the list request finishes
            IVisualElementScheduledItem pollList = null;
            pollList = button.schedule.Execute(() =>
            {
                if (listRequest.IsCompleted)
                {
                    if (listRequest.Status == StatusCode.Success)
                    {
                        bool installed = false;
                        foreach (var package in listRequest.Result)
                        {
                            if (package.packageId.Contains("gwaredd/UnityMarkdownViewer"))
                            {
                                installed = true;
                                break;
                            }
                        }

                        if (installed)
                        {
                            button.text = "✅ UnityMarkdownViewer already installed";
                            button.SetEnabled(false);
                        }
                        else
                        {
                            button.text = "📦 Install UnityMarkdownViewer";
                            button.SetEnabled(true);

                            button.clicked += () =>
                            {
                                button.SetEnabled(false);
                                button.text = "⬇️ Installing UnityMarkdownViewer...";

                                var addRequest = Client.Add("https://github.com/gwaredd/UnityMarkdownViewer.git");

                                // poll until add request finishes
                                IVisualElementScheduledItem pollAdd = null;
                                pollAdd = button.schedule.Execute(() =>
                                {
                                    if (addRequest.IsCompleted)
                                    {
                                        if (addRequest.Status == StatusCode.Success)
                                        {
                                            button.text = "✅ UnityMarkdownViewer installed!";
                                        }
                                        else
                                        {
                                            button.text = "❌ Failed to install (see console)";
                                        }

                                        pollAdd.Pause(); // stop polling
                                    }
                                }).Every(200);
                            };
                        }
                    }
                    else
                    {
                        button.text = "❌ Failed to check packages";
                    }

                    pollList.Pause(); // stop polling once listRequest completes
                }
            }).Every(200);

            return container;
        }
    }
}
#endif
