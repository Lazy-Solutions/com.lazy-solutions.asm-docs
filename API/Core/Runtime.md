## Runtime

`class` in `AdvancedSceneManager.Core`### Description
Manages runtime functionality for Advanced Scene Manager such as open scenes and collection.

### Properties

| Member | Description |
|--------|-------------|
| `Scene activeScene` | Gets the currently active scene, assuming it has been imported into ASM. |
| `SceneOperation currentOperation` | Gets the current active operation in the queue. |
| `Scene dontDestroyOnLoad` | Gets the dontDestroyOnLoad scene. |
| `boolean isBusy` | Gets whatever ASM is busy with any scene operations. |
| `boolean isPreloadedCollectionAdditive { get; }` | Gets if `preloadedCollection` is additive. |
| `IEnumerable<SceneCollection> openAdditiveCollections` | Gets the collections that are opened as additive. |
| `SceneCollection openCollection` | Gets the collection that is currently open. |
| `IEnumerable<Scene> openScenes` | Gets the scenes that are currently open. |
| `SceneCollection preloadedCollection { get; }` | Gets the currently preloaded collection. |
| `IEnumerable<Scene> preloadedScenes` | Gets the scenes that are preloaded. |
| `IEnumerable<SceneOperation> queuedOperations` | Gets the current scene operation queue. |
| `IEnumerable<SceneOperation> runningOperations` | The currently running scene operations. |
| `IEnumerable<Scene> unimportedScenes` | Gets all open Unity scenes that are not imported into ASM. |

### Fields

| Member | Description |
|--------|-------------|
| `Action onAllScenesClosed` | Occurs when the last user scene closes. |

### Events

| Member | Description |
|--------|-------------|
| `event Action<SceneCollection> collectionClosed` | Occurs when a collection is closed. |
| `event Action<SceneCollection> collectionOpened` | Occurs when a collection is opened. |
| `event Action<Scene> sceneClosed` | Occurs when a scene is closed. |
| `event Action sceneLoaderAdded` | Occurs when a `SceneLoader` is added. |
| `event Action sceneLoaderRemoved` | Occurs when a `SceneLoader` is removed. |
| `event Action<ValueTuple<Scene, Type, Type>> sceneLoaderToggled` | Occurs when a `SceneLoader` is toggled for a scene. |
| `event Action<Scene> sceneOpened` | Occurs when a scene is opened. |
| `event Action<Scene> scenePreloaded` | Occurs when a scene is preloaded. |
| `event Action<Scene> scenePreloadFinished` | Occurs when a previously preloaded scene is opened. |
| `event Action startedWorking` | Occurs when ASM has started working and is running scene operations. |
| `event Action stoppedWorking` | Occurs when ASM has finished working and no scene operations are running. |

### Methods

| Member | Description |
|--------|-------------|
| `void Activate(Scene scene)` | Activates this scene. |
| `void AddProgressListener(ILoadProgressListener listener)` | _No documentation available._ |
| `void AddSceneLoader<T>()` | _No documentation available._ |
| `SceneOperation CancelPreload()` | Cancels the preload. All preloaded scenes will be fully loaded (limitation by Unity), then closed. No ASM scene callbacks will be called. |
| `SceneOperation Close(SceneCollection collection)` | Closes `collection`. |
| `SceneOperation Close(SceneOperation operation, SceneCollection collection)` | _No documentation available._ |
| `SceneOperation Close(Scene scene)` | Closes this scene. |
| `SceneOperation Close(Scene[] scenes)` | _No documentation available._ |
| `SceneOperation Close(IEnumerable<Scene> scenes)` | Closes this scene. |
| `SceneOperation Close(IEnumerable<Scene> scenes, boolean skipEmptySceneCheck)` | _No documentation available._ |
| `SceneOperation CloseAll(boolean exceptLoadingScreens, boolean exceptUnimported, Scene[] except)` | Closes all scenes and collections. |
| `IEnumerator CloseUnimportedScenes()` | Closes all open Unity scenes that are not imported into ASM. |
| `SceneOperation CloseWithLoadingScreen(Scene scene, Scene loadingScreen)` | _No documentation available._ |
| `SceneOperation CloseWithLoadingScreen(IEnumerable<Scene> scene, Scene loadingScreen)` | _No documentation available._ |
| `IEnumerable<Scene> EvalScenesToClose(SceneCollection closeCollection, SceneCollection nextCollection, SceneCollection additiveCloseCollection)` | Evaluate the scenes that would close. |
| `IEnumerable<Scene> EvalScenesToOpen(SceneCollection collection, boolean openAll)` | Evaluate the scenes that would open. |
| `SceneOperation FinishPreload()` | Finish loading preloaded scenes. |
| `void ForceTrack(Scene scene)` | Tracks a scene that doesn't have a associated unity scene. |
| `SceneLoader GetLoaderForScene(Scene scene, boolean useOnlyGlobal)` | Gets the loader for `scene`. |
| `SceneLoader GetSceneLoader(string sceneLoader)` | Returns the scene loader with the specified key. |
| `Type GetSceneLoaderType(string sceneLoader)` | Returns the scene loader type with the specified key. |
| `SceneState GetState(Scene scene)` | _No documentation available._ |
| `IEnumerable<SceneLoader> GetToggleableSceneLoaders()` | Gets a list of all added scene loaders that can be toggled scene by scene. |
| `boolean IsQueued(SceneCollection collection)` | Gets if this collection is currently queued to be opened. |
| `boolean IsQueued(Scene scene)` | Gets if this scene is queued to be opened. |
| `boolean IsTracked(Scene scene)` | Gets whatever this scene is tracked as open. |
| `boolean IsTracked(SceneCollection collection)` | Gets whatever this collection is tracked as open. |
| `SceneOperation Open(SceneCollection collection, boolean openAll)` | Opens the collection. |
| `SceneOperation Open(Scene scene)` | Opens this scene. |
| `SceneOperation Open(Scene[] scenes)` | _No documentation available._ |
| `SceneOperation Open(IEnumerable<Scene> scenes)` | Opens this scene. |
| `SceneOperation OpenAdditive(SceneCollection collection, boolean openAll)` | Opens the collection without closing existing scenes. |
| `SceneOperation OpenAdditive(IEnumerable<SceneCollection> collections, SceneCollection activeCollection, Scene loadingScene)` | Opens the collection without closing existing scenes. |
| `SceneOperation OpenAndActivate(Scene scene)` | Opens this scene and activates it. |
| `SceneOperation OpenWithLoadingScreen(Scene scene, Scene loadingScreen)` | _No documentation available._ |
| `SceneOperation OpenWithLoadingScreen(IEnumerable<Scene> scene, Scene loadingScreen)` | _No documentation available._ |
| `SceneOperation Preload(IEnumerable<Scene> scenes, Action<Scene> onPreloaded)` | Preloads the scenes. |
| `SceneOperation Preload(SceneCollection collection, boolean openAll)` | Preloads the collection. |
| `SceneOperation Preload(Scene scene, Action onPreloaded)` | _No documentation available._ |
| `SceneOperation Preload(Action<Scene> onPreloaded, Scene[] scenes)` | Preloads the specified scenes. |
| `SceneOperation Preload(Scene[] scenes)` | Preloads the specified scenes. |
| `SceneOperation PreloadAdditive(SceneCollection collection, boolean openAll)` | Preloads the collection as additive. |
| `void RemoveProgressListener(ILoadProgressListener listener)` | _No documentation available._ |
| `void RemoveSceneLoader<T>()` | _No documentation available._ |
| `SceneOperation Reopen(SceneCollection collection, boolean openAll)` | Reopens the collection. |
| `SceneOperation Reopen(Scene scene)` | Reopens this scene. |
| `SceneOperation Reopen(IEnumerable<Scene> scene)` | _No documentation available._ |
| `SceneOperation ToggleOpen(SceneCollection collection, boolean openAll)` | Toggles the collection open or closed. |
| `SceneOperation ToggleOpen(Scene scene)` | Toggles this scene open or closed. |
| `void Track(Scene scene, Scene unityScene)` | Tracks the specified scene as open. |
| `void Track(Scene scene)` | _No documentation available._ |
| `void Track(SceneCollection collection, boolean isAdditive)` | Tracks the collection as open. |
| `boolean Untrack(Scene scene)` | Untracks the specified scene as open. |
| `void Untrack(SceneCollection collection, boolean isAdditive)` | Untracks the collection. |
| `void UntrackCollections()` | Untracks all collections. |
| `void UntrackScenes()` | Untracks all open scenes. |