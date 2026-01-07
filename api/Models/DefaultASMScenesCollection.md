## DefaultASMScenesCollection

`sealed class` in `AdvancedSceneManager.Models`  /  Inherits from: `DynamicCollectionBase<Scene>`### Description
Collection containing default ASM scenes, if they have been imported.

### Properties

| Member | Description |
|--------|-------------|
| `IEnumerable<string> scenePaths` | Gets the scene paths of the default scenes. |
| `IEnumerable<Scene> scenes` | Gets the default scenes from the ASM package samples. |

### Fields

| Member | Description |
|--------|-------------|
| `boolean isImported` | Gets whether the default scenes have been imported. |

### Static Methods

| Member | Description |
|--------|-------------|
| `void ImportScenes()` | Imports the default ASM scenes from the package samples. |
| `void Unimport()` | Removes the imported default ASM scenes. |