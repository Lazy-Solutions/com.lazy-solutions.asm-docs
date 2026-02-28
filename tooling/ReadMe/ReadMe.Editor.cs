#if UNITY_EDITOR
using System.Linq;
using UnityEditor;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UIElements;

namespace AdvancedSceneManager.Documentation
{

    partial class ReadMe : ScriptableObject
    {

        [CustomEditor(typeof(ReadMe), isFallback = true)]
        [CanEditMultipleObjects]
        class Editor : UnityEditor.Editor
        {

            enum InstallStatus
            {
                Checking, Installing, Installed, Uninstalled, Error
            }

            private const string package = "gwaredd/UnityMarkdownViewer";
            private const string repo = "https://github.com/gwaredd/UnityMarkdownViewer.git";
            private const string packageName = "com.mischief.markdownviewer";

            InstallStatus status;
            Button installButton;

            IVisualElementScheduledItem scheduledItem;

            new ReadMe target => (ReadMe)base.target;

            protected override bool ShouldHideOpenButton() => true;

            public override VisualElement CreateInspectorGUI()
            {
                if (!GetView(out var view))
                    return view;

                // Link
                view.Q<Label>("link-github").RegisterCallback<ClickEvent>(OpenRepoLink);
                view.Q<Label>("link-guides").RegisterCallback<ClickEvent>(OpenGuides);
                view.Q<Label>("link-api-docs").RegisterCallback<ClickEvent>(OpenAPIDocs);

                installButton = view.Q<Button>("button-install");
                installButton.RegisterCallback<ClickEvent>(OnButtonClick);
                CheckIfInstalled();

                return view;
            }

            private void OnDisable()
            {
                scheduledItem?.Pause();
                scheduledItem = null;
            }

            bool GetView(out VisualElement view)
            {
                if (target.template && target.guidesReadMe && target.apiDocsReadMe)
                    view = target.template.Instantiate();
                else
                    view = null; //Make unity display fields

                return view is not null;
            }

            void OpenRepoLink(ClickEvent e) => Application.OpenURL(repo);
            void OpenGuides(ClickEvent e) => Open(target.guidesReadMe);
            void OpenAPIDocs(ClickEvent e) => Open(target.apiDocsReadMe);

            void Open(TextAsset asset)
            {
                Selection.activeObject = asset;
                EditorGUIUtility.PingObject(asset);
            }

            void OnButtonClick(ClickEvent e)
            {
                if (status == InstallStatus.Installed)
                    OpenInPackageManager();
                else if (status == InstallStatus.Uninstalled)
                    Install();
            }

            void CheckIfInstalled()
            {

                status = InstallStatus.Checking;
                UpdateButton();

                var listRequest = Client.List();

                scheduledItem?.Pause();
                scheduledItem = installButton.schedule.Execute(() =>
                {
                    if (!listRequest.IsCompleted)
                        return;

                    if (listRequest.Status != StatusCode.Success)
                        SetStatus(listRequest.Error);
                    else
                        SetStatus(listRequest.Result.Any(p => p.name == packageName && p.packageId.Contains(package))
                            ? InstallStatus.Installed
                            : InstallStatus.Uninstalled);

                    scheduledItem.Pause();
                }).Every(200);

            }

            void Install()
            {

                status = InstallStatus.Installing;
                UpdateButton();

                var addRequest = Client.Add(repo);

                scheduledItem?.Pause();
                scheduledItem = installButton.schedule.Execute(() =>
                {
                    if (!addRequest.IsCompleted)
                        return;

                    if (addRequest.Status != StatusCode.Success)
                        SetStatus(addRequest.Error);
                    else
                        SetStatus(InstallStatus.Installed);

                    scheduledItem.Pause();
                }).Every(200);

            }

            void OpenInPackageManager() =>
                UnityEditor.PackageManager.UI.Window.Open(packageName);

            void UpdateButton()
            {
                installButton.SetEnabled(status is (InstallStatus.Installed or InstallStatus.Uninstalled));
                installButton.text = status switch
                {
                    InstallStatus.Checking => "📦 Checking package...",
                    InstallStatus.Installing => "⬇️ Installing UnityMarkdownViewer...",
                    InstallStatus.Installed => "✅ UnityMarkdownViewer already installed",
                    InstallStatus.Uninstalled => "📦 Install UnityMarkdownViewer",
                    InstallStatus.Error => "❌ Failed to install (see console)",

                    _ => "📦 Checking package..."
                };
            }

            void SetStatus(InstallStatus status)
            {
                this.status = status;
                UpdateButton();
            }

            void SetStatus(Error error)
            {
                SetStatus(InstallStatus.Error);
                Debug.LogError(error.message);
            }

        }

    }

}

#endif