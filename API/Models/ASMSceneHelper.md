## ASMSceneHelper

`class` in `AdvancedSceneManager.Models`  /  Inherits from: `ScriptableObject`### Description
Provides helper methods for opening, closing, and managing scenes and collections.
            Intended for use from `UnityEvent`.

### Static Properties

| Member | Description |
|--------|-------------|
| `ASMSceneHelper instance` | Gets the global instance of `ASMSceneHelper`. |

### Properties

| Member | Description |
|--------|-------------|
| `string name` | The name of the object. |

### Methods

| Member | Description |
|--------|-------------|
| `void _Activate(Scene scene)` | _No documentation available._ |
| `void _CancelPreload()` | Cancels the preload. All preloaded scenes will be fully loaded (limitation by Unity), then closed. No ASM scene callbacks will be called. |
| `void _Close(SceneCollection collection)` | _No documentation available._ |
| `void _Close(Scene scene)` | _No documentation available._ |
| `void _FinishPreload()` | _No documentation available._ |
| `void _Open(SceneCollection collection)` | _No documentation available._ |
| `void _Open(Scene scene)` | _No documentation available._ |
| `void _OpenAdditive(SceneCollection collection)` | _No documentation available._ |
| `void _OpenAndActivate(Scene scene)` | _No documentation available._ |
| `void _Preload(SceneCollection collection)` | _No documentation available._ |
| `void _Preload(Scene scene)` | _No documentation available._ |
| `void _PreloadAdditive(SceneCollection collection)` | _No documentation available._ |
| `void _Reopen(SceneCollection collection)` | _No documentation available._ |
| `void _Reopen(Scene scene)` | _No documentation available._ |
| `void _ToggleOpen(SceneCollection collection)` | _No documentation available._ |
| `void _ToggleOpen(Scene scene)` | _No documentation available._ |
| `void Activate(Scene scene)` | _No documentation available._ |
| `SceneOperation CancelPreload()` | Cancels the preload. All preloaded scenes will be fully loaded (limitation by Unity), then closed. No ASM scene callbacks will be called. |
| `SceneOperation Close(SceneCollection collection)` | _No documentation available._ |
| `SceneOperation Close(Scene scene)` | _No documentation available._ |
| `SceneOperation CloseWithLoadingScreen(Scene scene, Scene loadingScene)` | _No documentation available._ |
| `SceneOperation FinishPreload()` | _No documentation available._ |
| `void Open(SceneCollection collection)` | _No documentation available._ |
| `SceneOperation Open(SceneCollection collection, boolean openAll)` | Opens the specified collection. |
| `SceneOperation Open(Scene scene)` | _No documentation available._ |
| `SceneOperation OpenAdditive(SceneCollection collection, boolean openAll)` | Opens the collection as additive. |
| `void OpenAdditive(SceneCollection collection)` | _No documentation available._ |
| `SceneOperation OpenAndActivate(Scene scene)` | _No documentation available._ |
| `void OpenWhereNameStartsWith(string name)` | Opens all scenes whose names start with the specified string. |
| `SceneOperation OpenWithLoadingScreen(Scene scene, Scene loadingScene)` | _No documentation available._ |
| `SceneOperation Preload(SceneCollection collection, boolean openAll)` | Preloads the specified collection. |
| `SceneOperation Preload(Scene scene, Action onPreloaded)` | Preloads the scene. |
| `SceneOperation PreloadAdditive(SceneCollection collection, boolean openAll)` | Preloads the collection as additive. |
| `void Quit()` | _No documentation available._ |
| `void Reopen(SceneCollection collection)` | _No documentation available._ |
| `SceneOperation Reopen(Scene scene)` | _No documentation available._ |
| `void Restart()` | _No documentation available._ |
| `void RestartCollection()` | Reopens the currently active `openCollection`. |
| `SceneOperation ToggleOpen(SceneCollection collection, boolean openAll)` | Toggles the collection open or closed. |
| `SceneOperation ToggleOpen(SceneCollection collection)` | _No documentation available._ |
| `SceneOperation ToggleOpen(Scene scene)` | _No documentation available._ |
| `SceneOperation ToggleOpenState(Scene scene)` | _No documentation available._ |