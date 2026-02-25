using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

class DocumentationWindow : EditorWindow
{

    [SerializeField]
    private VisualTreeAsset m_VisualTreeAsset = default;

    [MenuItem("Window/UI Toolkit/DocumentationWindow")]
    public static void ShowExample()
    {
        DocumentationWindow wnd = GetWindow<DocumentationWindow>();
        wnd.titleContent = new GUIContent("DocumentationWindow");
    }

    public void CreateGUI()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // VisualElements objects can contain other VisualElement following a tree hierarchy.
        VisualElement label = new Label("Hello World! From C#");
        root.Add(label);

        // Instantiate UXML
        VisualElement labelFromUXML = m_VisualTreeAsset.Instantiate();
        root.Add(labelFromUXML);
    }

}

record HeaderView(VisualElement view)
{ }

record ReadmeView(VisualElement view)
{ }

record BrowserView(VisualElement view)
{ }

namespace System.Runtime.CompilerServices
{
    //"Hack" to enable records, exposed externally as normal class
    sealed class IsExternalInit { }
}
