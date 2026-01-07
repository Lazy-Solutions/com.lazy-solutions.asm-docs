## LoadingScreenUtility

`static class` in `AdvancedSceneManager.Utility`### Description
Manager for loading screens.

### Static Properties

| Member | Description |
|--------|-------------|
| `Scene defaultFadeScreen` | Finds the default fade loading screen. Can be set through project settings, or in scene loading section of the settings popup. |
| `boolean isAnyLoadingScreenOpen` | Gets if any loading screens are open. |
| `IEnumerable<ILoadProgressListener> loadProgressListeners` | The currently open loading screens. |
| `IEnumerable<LoadingScreenReference> openLoadingScreens` | The currently open loading screens. |

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerator CloseAll()` | Hide all loading screens. |
| `Awaitable<boolean> CloseLoadingScreen(LoadingScreenReference loadingScreen)` | _No documentation available._ |
| `SceneOperation DoAction(Scene scene, Action action, Action<LoadingScreenReference> loadingScreenCallback)` | _No documentation available._ |
| `SceneOperation DoAction(Scene scene, Func<IEnumerator> coroutine, Action<LoadingScreenReference> loadingScreenCallback)` | _No documentation available._ |
| `IEnumerator FadeIn(LoadingScreenReference loadingScreen, single duration, Nullable<Color> color)` | _No documentation available._ |
| `Awaitable<LoadingScreenReference> FadeOut(single duration, Nullable<Color> color)` | _No documentation available._ |
| `boolean IsLoadingScreenOpen(LoadingScreenReference loadingScreen)` | _No documentation available._ |
| `Awaitable<LoadingScreenReference> OpenLoadingScreen(SceneOperation operation, Action<LoadingScreenReference> callbackBeforeBegin)` | _No documentation available._ |
| `Awaitable<LoadingScreenReference> OpenLoadingScreen(LoadingScreenReference loadingScreen, SceneOperation operation, Action<LoadingScreenReference> callbackBeforeBegin)` | _No documentation available._ |
| `AsyncOperation Preload(AsyncOperation asyncOperation, Func`1& activateCallback)` | _No documentation available._ |
| `void RegisterLoadProgressListener(ILoadProgressListener listener)` | _No documentation available._ |
| `void ReportProgress(ILoadProgressData progress)` | _No documentation available._ |
| `GlobalCoroutine ReportProgress(AsyncOperation asyncOperation, SceneOperationKind kind, SceneOperation operation, Scene scene)` | Returns a coroutine that returns when `isDone` becomes `true`. |
| `void UnregisterLoadProgressListener(ILoadProgressListener listener)` | _No documentation available._ |