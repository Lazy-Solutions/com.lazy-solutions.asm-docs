## ASMSceneHelper

`class` in `AdvancedSceneManager.Models`  /  Inherits from: `ScriptableObject`### Description
Represents scene helper. Contains functions for opening / closing collections and scenes from `UnityEvent`.

### Static Properties

| Member | Description |
|--------|-------------|
| `ASMSceneHelper instance` | Gets a reference to scene helper. |

### Properties

| Member | Description |
|--------|-------------|
| `string name` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void _Activate(Scene scene)` | _No documentation available._ |
| `void _CancelPreload()` | _No documentation available._ |
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
| `SceneOperation CancelPreload()` | _No documentation available._ |
| `SceneOperation Close(SceneCollection collection)` | _No documentation available._ |
| `SceneOperation Close(Scene scene)` | _No documentation available._ |
| `SceneOperation CloseWithLoadingScreen(Scene scene, Scene loadingScene)` | _No documentation available._ |
| `SceneOperation FinishPreload()` | _No documentation available._ |
| `void Open(SceneCollection collection)` | _No documentation available._ |
| `SceneOperation Open(SceneCollection collection, boolean openAll)` | Opens the collection. |
| `SceneOperation Open(Scene scene)` | _No documentation available._ |
| `SceneOperation OpenAdditive(SceneCollection collection, boolean openAll)` | _No documentation available._ |
| `void OpenAdditive(SceneCollection collection)` | _No documentation available._ |
| `SceneOperation OpenAndActivate(Scene scene)` | _No documentation available._ |
| `void OpenWhereNameStartsWith(string name)` | Open all scenes that starts with the specified name. |
| `SceneOperation OpenWithLoadingScreen(Scene scene, Scene loadingScene)` | _No documentation available._ |
| `SceneOperation Preload(SceneCollection collection, boolean openAll)` | Preloads the collection. |
| `SceneOperation Preload(Scene scene, Action onPreloaded)` | _No documentation available._ |
| `SceneOperation PreloadAdditive(SceneCollection collection, boolean openAll)` | Preloads the collection as additive. |
| `void Quit()` | _No documentation available._ |
| `void Reopen(SceneCollection collection)` | _No documentation available._ |
| `SceneOperation Reopen(Scene scene)` | _No documentation available._ |
| `void Restart()` | _No documentation available._ |
| `void RestartCollection()` | Re-opens `openCollection`. |
| `SceneOperation ToggleOpen(SceneCollection collection, boolean openAll)` | Toggles the collection open or closed. |
| `SceneOperation ToggleOpen(SceneCollection collection)` | _No documentation available._ |
| `SceneOperation ToggleOpen(Scene scene)` | _No documentation available._ |
| `SceneOperation ToggleOpenState(Scene scene)` | _No documentation available._ |