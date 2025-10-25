## LoadingScreenUtility

`static class` in `AdvancedSceneManager.Utility`### Description
Manager for loading screens.

### Static Properties

| Member | Description |
|--------|-------------|
| `Scene defaultLoadingScreen` | Gets the current default loading screen. |
| `Scene fade` | Finds the default fade loading screen. Can be set through project settings, or in scene loading section of the settings popup. |
| `boolean isAnyLoadingScreenOpen` | Gets if any loading screens are open. |
| `IEnumerable<LoadingScreenBase> loadingScreens` | The currently open loading screens. |
| `IEnumerable<ILoadProgressListener> loadProgressListeners` | The currently open loading screens. |

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerator CloseAll()` | Hide all loading screens. |
| `IEnumerator CloseLoadingScreen(Scene scene)` | _No documentation available._ |
| `IEnumerator CloseLoadingScreen(LoadingScreenBase loadingScreen, boolean closeScene)` | Hide the loading screen. |
| `IEnumerator CloseLoadingScreenScene(Scene scene)` | Close the scene that contained a loading screen. |
| `SceneOperation DoAction(Scene scene, Action action, Action<LoadingScreenBase> loadingScreenCallback)` | _No documentation available._ |
| `SceneOperation DoAction(Scene scene, Func<IEnumerator> coroutine, Action<LoadingScreenBase> loadingScreenCallback)` | Opens loading screen, performs action and hides loading screen again. |
| `IEnumerator FadeIn(LoadingScreenBase loadingScreen, single duration, Nullable<Color> color)` | Fades in the screen. |
| `Async<LoadingScreen> FadeOut(single duration, Nullable<Color> color)` | Fades out the screen. |
| `boolean IsLoadingScreenOpen(Scene scene)` | Gets if this scene is a loading screen. |
| `Async<LoadingScreen> OpenLoadingScreen(SceneOperation operation, Action<LoadingScreen> callbackBeforeBegin)` | _No documentation available._ |
| `Async<LoadingScreen> OpenLoadingScreen(Scene loadingScene, SceneOperation operation, Action<LoadingScreen> callbackBeforeBegin)` | _No documentation available._ |
| `Async<T> OpenLoadingScreen<T>(SceneOperation operation, Action<T> callbackBeforeBegin)` | _No documentation available._ |
| `Async<T> OpenLoadingScreen<T>(Scene loadingScene, SceneOperation operation, Action<T> callbackBeforeBegin)` | _No documentation available._ |
| `AsyncOperation Preload(AsyncOperation asyncOperation, Func`1& activateCallback)` | _No documentation available._ |
| `void RegisterLoadProgressListener(ILoadProgressListener listener)` | Registers a `ILoadProgressListener` that will receive callbacks when progress is reported from ASM. |
| `void ReportProgress(ILoadProgressData progress)` | Report progress. |
| `GlobalCoroutine ReportProgress(AsyncOperation asyncOperation, SceneOperationKind kind, SceneOperation operation, Scene scene)` | Returns a coroutine that returns when `isDone` becomes `true`. |
| `void UnregisterLoadProgressListener(ILoadProgressListener listener)` | Unregisters a `ILoadProgressListener` that was registered using [ILoadProgressListener)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.utility.loadingscreenutility.registerloadprogresslistener(advancedscenemanager.loading.iloadprogresslistener)). |