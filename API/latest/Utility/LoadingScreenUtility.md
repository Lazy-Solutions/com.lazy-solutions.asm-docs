## LoadingScreenUtility

`static class` in `AdvancedSceneManager.Utility`

### Description
Manager for loading screens.

### Static Properties

| Member | Description |
|--------|-------------|
| `bool isAnyLoadingScreenOpen` | \_No documentation available.\_ |
| `IEnumerable&lt;ILoadProgressListener&gt; loadProgressListeners` | \_No documentation available.\_ |
| `IEnumerable&lt;LoadingScreenReference&gt; openLoadingScreens` | \_No documentation available.\_ |

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerator CloseAll()` | Hide all loading screens. |
| `Awaitable&lt;bool&gt; CloseLoadingScreen(LoadingScreenReference loadingScreen)` | Close the loading screen. |
| `SceneOperation DoAction(Scene scene, Action action, Action&lt;LoadingScreenReference&gt; loadingScreenCallback)` | \_No documentation available.\_ |
| `SceneOperation DoAction(Scene scene, Func&lt;IEnumerator&gt; coroutine, Action&lt;LoadingScreenReference&gt; loadingScreenCallback)` | \_No documentation available.\_ |
| `IEnumerator FadeIn(LoadingScreenReference loadingScreen, float duration, Color? color)` | Fades in the screen. |
| `Awaitable&lt;LoadingScreenReference&gt; FadeOut(float duration, Color? color)` | Fades out the screen. |
| `bool IsLoadingScreenOpen(LoadingScreenReference loadingScreen)` | Gets if this scene is a loading screen. |
| `Awaitable&lt;LoadingScreenReference&gt; OpenLoadingScreen(SceneOperation operation, Action&lt;LoadingScreenReference&gt; callbackBeforeBegin)` | \_No documentation available.\_ |
| `Awaitable&lt;LoadingScreenReference&gt; OpenLoadingScreen(LoadingScreenReference loadingScreen, SceneOperation operation, Action&lt;LoadingScreenReference&gt; callbackBeforeBegin)` | \_No documentation available.\_ |
| `AsyncOperation Preload(AsyncOperation asyncOperation, out Func&lt;IEnumerator&gt; activateCallback)` | Sets `AsyncOperation.allowSceneActivation` to `false`. |
| `void RegisterLoadProgressListener(ILoadProgressListener listener)` | Registers a `Loading.ILoadProgressListener` that will receive callbacks when progress is reported from ASM. |
| `void ReportProgress(ILoadProgressData progress)` | Report progress. |
| `GlobalCoroutine ReportProgress(AsyncOperation asyncOperation, SceneOperationKind kind, SceneOperation operation, Scene scene)` | Returns a coroutine that returns when `AsyncOperation.isDone` becomes `true`. |
| `void UnregisterLoadProgressListener(ILoadProgressListener listener)` | Unregisters a `Loading.ILoadProgressListener` that was registered using `ILoadingScreenService.RegisterLoadProgressListener`. |