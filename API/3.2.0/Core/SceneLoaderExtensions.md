## SceneLoaderExtensions

`static class` in `AdvancedSceneManager.Core`### Description
Provides extensions for scene loading.

<b> Remarks:</b>
This provides access to direct scene loading / unloading, which bypasses many checks that .Open() / .Close() has. Make sure to test thoroughly.

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerator Load(Scene scene, SceneLoadArgs e)` | _No documentation available._ |
| `IEnumerator Load(Scene scene, boolean isPreload, SceneOperation operation, SceneCollection collection, boolean reportsProgress, Nullable<ThreadPriority> loadPriority, Action onLoaded, Action<string> onError, boolean useOnlyGlobal)` | Loads the scene using a scene loader. |
| `IEnumerator Unload(Scene scene, SceneUnloadArgs e)` | _No documentation available._ |
| `IEnumerator Unload(Scene scene, SceneOperation operation, SceneCollection collection, boolean reportsProgress, Nullable<ThreadPriority> loadPriority, Action onUnloaded, Action<string> onError, boolean useOnlyGlobal)` | Unloads the scene using a scene loader. |