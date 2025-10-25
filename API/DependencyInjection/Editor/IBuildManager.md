## IBuildManager

`interface` in `AdvancedSceneManager.DependencyInjection.Editor`### Description
Provides functions for building, and build events.

<b> Remarks:</b>
Only available in editor.

### Events

| Member | Description |
|--------|-------------|
| `event Action<PostBuildEventArgs> postBuild` | Occurs after build. |
| `event Action<BuildReport> preBuild` | Occurs before build. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual BuildReport DoBuild(string path, boolean attachProfiler, boolean runGameWhenBuilt, boolean dev, BuildOptions customOptions)` | _No documentation available._ |
| `abstract virtual BuildReport DoBuild(BuildPlayerOptions options)` | _No documentation available._ |
| `abstract virtual IEnumerable<ValueTuple<EditorBuildSettingsScene, Reason>> GetOrderedList()` | Gets an ordered list of all scenes that ASM would set in the build settings. |
| `abstract virtual boolean IsEnabled(string path, Reason& reason)` | _No documentation available._ |
| `abstract virtual boolean IsIncluded(Scene scene, Reason& reason)` | _No documentation available._ |
| `abstract virtual void UpdateSceneList()` | Updates the scene build settings. |
| `abstract virtual void UpdateSceneList(boolean ignorePlaymodeCheck)` | _No documentation available._ |