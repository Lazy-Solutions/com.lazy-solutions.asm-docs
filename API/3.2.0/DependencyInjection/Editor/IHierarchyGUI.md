## IHierarchyGUI

`interface` in `AdvancedSceneManager.DependencyInjection.Editor`### Description
An utility for adding extra icons to scene fields in the hierarchy window.

<b> Remarks:</b>
Only available in editor.

### Properties

| Member | Description |
|--------|-------------|
| `GUIStyle defaultStyle` | The default style for text in hierarchy. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void AddGameObjectGUI(HierarchyGameObjectGUI onGUI, int32 index)` | _No documentation available._ |
| `abstract virtual void AddSceneGUI(HierarchySceneGUI onGUI, int32 index)` | _No documentation available._ |
| `abstract virtual void RemoveGameObjectGUI(HierarchyGameObjectGUI onGUI)` | _No documentation available._ |
| `abstract virtual void RemoveSceneGUI(HierarchySceneGUI onGUI)` | _No documentation available._ |
| `abstract virtual void Repaint()` | Can be used to ensure repaint of the HierarchyWindow. |