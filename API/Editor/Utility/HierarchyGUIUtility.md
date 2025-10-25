## HierarchyGUIUtility

`static class` in `AdvancedSceneManager.Editor.Utility`### Description
An utility for adding extra icons to scene fields in the hierarchy window.

<b> Remarks:</b>
Only available in editor.

### Static Properties

| Member | Description |
|--------|-------------|
| `GUIStyle defaultStyle { get; }` | The default style for text in hierarchy. |

### Static Methods

| Member | Description |
|--------|-------------|
| `void AddGameObjectGUI(HierarchyGameObjectGUI onGUI, int32 index)` | _No documentation available._ |
| `void AddSceneGUI(HierarchySceneGUI onGUI, int32 index)` | _No documentation available._ |
| `boolean GetObj(int32 instanceID, Object& obj, String& name, String& scenePath)` | _No documentation available._ |
| `void RemoveGameObjectGUI(HierarchyGameObjectGUI onGUI)` | _No documentation available._ |
| `void RemoveSceneGUI(HierarchySceneGUI onGUI)` | _No documentation available._ |
| `void Repaint()` | Can be used to ensure repaint of the HierarchyWindow. |