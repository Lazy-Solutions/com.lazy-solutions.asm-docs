## SceneLoadArgs

`class` in `AdvancedSceneManager.Core`  /  Inherits from: `SceneLoaderArgsBase`### Description
Specifies arguments for [SceneLoadArgs)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.core.sceneloader.loadscene(advancedscenemanager.models.scene,advancedscenemanager.core.sceneloadargs)).

### Properties

| Member | Description |
|--------|-------------|
| `boolean isPreload { get; }` | Specifies if the scene should be preloaded. |

### Methods

| Member | Description |
|--------|-------------|
| `boolean CheckIsIncluded(boolean logError)` | Checks if the scene is actually included in build. |
| `Scene GetOpenedScene()` | Gets the `Scene` that was opened by this override. |
| `void SetCompleted(Scene scene)` | Notifies ASM that the load is done. |
| `void SetCompleted(Scene scene, Func<IEnumerator> preloadCallback)` | _No documentation available._ |
| `void SetCompletedWithoutScene()` | Sets this loader as complete even though no scene was loaded. |