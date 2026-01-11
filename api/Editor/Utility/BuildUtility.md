## BuildUtility

`static class` in `AdvancedSceneManager.Editor.Utility`### Description
Provides functions for building, and build events.

<b> Remarks:</b>
Only available in editor.

### Static Events

| Member | Description |
|--------|-------------|
| `event Action<PostBuildEventArgs> postBuild` | Occurs after build. |
| `event Action<BuildReport> preBuild` | Occurs before build. |

### Static Methods

| Member | Description |
|--------|-------------|
| `BuildReport DoBuild(string path, boolean attachProfiler, boolean runGameWhenBuilt, boolean dev, BuildOptions customOptions)` | Performs a build of the active build profile if one exists, otherwise falls back to Unity's legacy build pipeline. |
| `BuildReport DoBuild(BuildPlayerOptions opts)` | Performs a build using the legacy `BuildPlayerOptions` API. |
| `BuildReport DoBuild(BuildPlayerWithProfileOptions options)` | _No documentation available._ |
| `IEnumerable<ValueTuple<EditorBuildSettingsScene, Reason>> GetOrderedList()` | Gets an ordered list of all scenes that ASM would set in the build settings. |
| `boolean IsEnabled(string path, Reason& reason)` | _No documentation available._ |
| `boolean IsIncluded(Scene scene, Reason& reason)` | _No documentation available._ |
| `void UpdateSceneList()` | Updates the scene build settings. |
| `void UpdateSceneList(boolean ignorePlayModeCheck, boolean force)` | Updates the scene build settings from the ASM profile. |