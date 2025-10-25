## SceneImportUtility

`class` in `AdvancedSceneManager.Editor.Utility`  /  Inherits from: `AssetPostprocessor`### Description
Contains utility functions for importing / un-importing scenes.

### Static Properties

| Member | Description |
|--------|-------------|
| `IEnumerable<IGrouping<string, Scene>> duplicateScenes` | Gets the duplicate imported scenes. |
| `IEnumerable<string> dynamicScenes` | Gets the list of dynamic scenes in the current profile. |
| `IEnumerable<Scene> importedBlacklistedScenes` | Gets the list of imported scenes that are blacklisted. |
| `IEnumerable<string> importedScenes` | Gets the list of imported scenes in the project. |
| `IEnumerable<Scene> invalidScenes` | Gets the list of imported scenes that do not have an associated scene asset. |
| `IEnumerable<Scene> scenesWithBadPath` | Gets the list of imported scenes that do not match their asset path. |
| `IEnumerable<string> unimportedScenes` | Gets the list of unimported scenes in the project, that are available for import. |
| `IEnumerable<Scene> untrackedScenes` | Gets the list of scenes that are imported, but are, for whatever reason, not tracked by AssetRef. |

### Static Methods

| Member | Description |
|--------|-------------|
| `boolean GetImportedScene(string sceneAssetPath, Scene& scene)` | _No documentation available._ |
| `Scene GetImportedSceneByItsOwnPath(string path)` | _No documentation available._ |
| `IEnumerable<Scene> GetImportedScenes(IEnumerable<string> sceneAssetPaths)` | _No documentation available._ |
| `IEnumerable<Scene> Import(IEnumerable<string> sceneAssetPaths, boolean notify)` | _No documentation available._ |
| `IEnumerable<Scene> Import(IEnumerable<string> sceneAssetPaths, string importFolder, boolean notify)` | _No documentation available._ |
| `Scene Import(string sceneAssetPath, boolean notify, boolean track)` | _No documentation available._ |
| `Scene Import(string sceneAssetPath, string importFolder, boolean notify, boolean track, boolean skipImportedCheck)` | _No documentation available._ |
| `void Unimport(IEnumerable<string> scenes, boolean notify)` | _No documentation available._ |
| `void Unimport(IEnumerable<Scene> scenes, boolean notify)` | _No documentation available._ |
| `void Unimport(Scene scene, boolean notify)` | _No documentation available._ |