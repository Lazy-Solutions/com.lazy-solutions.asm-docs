## SceneImportUtility

`class` in `AdvancedSceneManager.SceneImport`  /  Inherits from: `AssetPostprocessor`

### Description
Contains utility functions for importing / un-importing scenes.

<b> Remarks:</b>
Only available in editor.

### Static Properties

| Member | Description |
|--------|-------------|
| `IEnumerable&lt;IGrouping&lt;string, Scene&gt;&gt; duplicateScenes` | Gets the duplicate imported scenes. |
| `IEnumerable&lt;string&gt; dynamicScenes` | Gets the list of dynamic scenes in the current profile. |
| `IEnumerable&lt;Scene&gt; importedBlacklistedScenes` | Gets the list of imported scenes that are blacklisted. |
| `IEnumerable&lt;string&gt; importedScenes` | Gets the list of imported scenes in the project. |
| `IEnumerable&lt;Scene&gt; invalidScenes` | Gets the list of imported scenes that do not have an associated scene asset. |
| `IEnumerable&lt;Scene&gt; scenesWithBadPath` | Gets the list of imported scenes that do not match their asset path. |
| `IEnumerable&lt;string&gt; unimportedScenes` | Gets the list of unimported scenes in the project, that are available for import. |
| `IEnumerable&lt;Scene&gt; untrackedScenes` | Gets the list of scenes that are imported, but are, for whatever reason, not tracked by AssetRef. |

### Static Methods

| Member | Description |
|--------|-------------|
| `bool GetImportedScene(string sceneAssetPath, out Scene scene)` | Attempts to get the imported scene matching the specified scene asset path. |
| `Scene GetImportedSceneByItsOwnPath(string path)` | Gets the imported scene asset by its own asset path. |
| `IEnumerable&lt;Scene&gt; GetImportedScenes(IEnumerable&lt;string&gt; sceneAssetPaths)` | Gets imported scenes matching the specified scene asset paths. |
| `IEnumerable&lt;Scene&gt; Import(IEnumerable&lt;string&gt; sceneAssetPaths, bool notify)` | Imports the specified scenes. |
| `IEnumerable&lt;Scene&gt; Import(IEnumerable&lt;string&gt; sceneAssetPaths, string importFolder, bool notify)` | Imports the specified scenes into the given folder. |
| `Scene Import(string sceneAssetPath, bool notify, bool track)` | Imports a single scene asset. |
| `Scene Import(string sceneAssetPath, string importFolder, bool notify, bool track, bool skipImportedCheck, bool skipValidCheck)` | Imports a single scene asset into the given folder. |
| `void Unimport(IEnumerable&lt;string&gt; scenes, bool notify)` | Unimports the specified scenes. |
| `void Unimport(IEnumerable&lt;Scene&gt; scenes, bool notify)` | Unimports the specified scenes. |
| `void Unimport(Scene scene, bool notify)` | Unimports the specified scene. |