## ISceneManager

`interface` in `AdvancedSceneManager.DependencyInjection`### Description
Manages runtime functionality for Advanced Scene Manager such as open scenes and collection.

### Properties

| Member | Description |
|--------|-------------|
| `Scene activeScene` | Gets the currently active scene, assuming it has been imported into ASM. |
| `SceneOperation currentOperation` | Gets the current active operation in the queue. |
| `Scene dontDestroyOnLoad` | Gets the dontDestroyOnLoad scene. |
| `boolean isBusy` | Gets whatever ASM is busy with any scene operations. |
| `IEnumerable<SceneCollection> openAdditiveCollections` | Gets the collections that are opened as additive. |
| `SceneCollection openCollection` | Gets the collection that is currently open. |
| `IEnumerable<Scene> openScenes` | Gets the scenes that are currently open. |
| `IEnumerable<Scene> preloadedScenes` | Gets the scenes that are preloaded. |
| `IEnumerable<SceneOperation> queuedOperations` | Gets the current scene operation queue. |
| `IEnumerable<SceneOperation> runningOperations` | The currently running scene operations. |

### Events

| Member | Description |
|--------|-------------|
| `event Action<SceneCollection> collectionClosed` | Occurs when a collection is closed. |
| `event Action<SceneCollection> collectionOpened` | Occurs when a collection is opened. |
| `event Action<Scene> sceneClosed` | Occurs when a scene is closed. |
| `event Action<Scene> sceneOpened` | Occurs when a scene is opened. |
| `event Action<Scene> scenePreloaded` | Occurs when a scene is preloaded. |
| `event Action<Scene> scenePreloadFinished` | Occurs when a previously preloaded scene is opened. |
| `event Action startedWorking` | Occurs when ASM has started working and is running scene operations. |
| `event Action stoppedWorking` | Occurs when ASM has finished working and no scene operations are running. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void Activate(Scene scene)` | _No documentation available._ |
| `abstract virtual void AddSceneLoader<T>()` | _No documentation available._ |
| `abstract virtual SceneOperation CancelPreload()` | Cancels the preload. All preloaded scenes will be fully loaded (limitation by Unity), then closed. No ASM scene callbacks will be called. |
| `abstract virtual SceneOperation Close(IEnumerable<Scene> scenes)` | _No documentation available._ |
| `abstract virtual SceneOperation Close(Scene[] scenes)` | _No documentation available._ |
| `abstract virtual SceneOperation Close(Scene scene)` | _No documentation available._ |
| `abstract virtual SceneOperation Close(SceneCollection collection)` | _No documentation available._ |
| `abstract virtual SceneOperation CloseAll(boolean exceptLoadingScreens, boolean exceptUnimported, Scene[] except)` | _No documentation available._ |
| `abstract virtual SceneOperation FinishPreload()` | _No documentation available._ |
| `abstract virtual SceneLoader GetLoaderForScene(Scene scene, boolean useOnlyGlobal)` | _No documentation available._ |
| `abstract virtual SceneState GetState(Scene scene)` | _No documentation available._ |
| `abstract virtual IEnumerable<SceneLoader> GetToggleableSceneLoaders()` | Gets a list of all added scene loaders that can be toggled scene by scene. |
| `abstract virtual boolean IsTracked(Scene scene)` | _No documentation available._ |
| `abstract virtual boolean IsTracked(SceneCollection collection)` | _No documentation available._ |
| `abstract virtual SceneOperation Open(IEnumerable<Scene> scenes)` | _No documentation available._ |
| `abstract virtual SceneOperation Open(Scene[] scenes)` | _No documentation available._ |
| `abstract virtual SceneOperation Open(Scene scene)` | _No documentation available._ |
| `abstract virtual SceneOperation Open(SceneCollection collection, boolean openAll)` | _No documentation available._ |
| `abstract virtual SceneOperation OpenAdditive(IEnumerable<SceneCollection> collections, SceneCollection activeCollection, Scene loadingScene)` | _No documentation available._ |
| `abstract virtual SceneOperation OpenAdditive(SceneCollection collection, boolean openAll)` | _No documentation available._ |
| `abstract virtual SceneOperation OpenAndActivate(Scene scene)` | _No documentation available._ |
| `abstract virtual SceneOperation OpenWithLoadingScreen(IEnumerable<Scene> scene, Scene loadingScreen)` | _No documentation available._ |
| `abstract virtual SceneOperation OpenWithLoadingScreen(Scene scene, Scene loadingScreen)` | _No documentation available._ |
| `abstract virtual SceneOperation Preload(Scene scene, Action onPreloaded)` | _No documentation available._ |
| `abstract virtual void RemoveSceneLoader<T>()` | _No documentation available._ |
| `abstract virtual SceneOperation ToggleOpen(Scene scene)` | _No documentation available._ |
| `abstract virtual SceneOperation ToggleOpen(SceneCollection collection, boolean openAll)` | _No documentation available._ |
| `abstract virtual void Track(Scene scene)` | _No documentation available._ |
| `abstract virtual void Track(Scene scene, Scene unityScene)` | _No documentation available._ |
| `abstract virtual void Track(SceneCollection collection, boolean isAdditive)` | _No documentation available._ |
| `abstract virtual boolean Untrack(Scene scene)` | _No documentation available._ |
| `abstract virtual void Untrack(SceneCollection collection, boolean isAdditive)` | _No documentation available._ |
| `abstract virtual void UntrackCollections()` | Untracks all collections. |
| `abstract virtual void UntrackScenes()` | Untracks all open scenes. |