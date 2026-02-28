## ISceneManager

`interface` in `AdvancedSceneManager.DependencyInjection`

### Description

### Properties

| Member | Description |
|--------|-------------|
| `Scene activeScene` | \_No documentation available.\_ |
| `SceneOperation currentOperation` | \_No documentation available.\_ |
| `Scene dontDestroyOnLoad` | \_No documentation available.\_ |
| `bool isBusy` | \_No documentation available.\_ |
| `IEnumerable&lt;SceneCollection&gt; openAdditiveCollections` | \_No documentation available.\_ |
| `SceneCollection openCollection` | \_No documentation available.\_ |
| `IEnumerable&lt;Scene&gt; openScenes` | \_No documentation available.\_ |
| `IEnumerable&lt;Scene&gt; preloadedScenes` | \_No documentation available.\_ |
| `IEnumerable&lt;SceneOperation&gt; queuedOperations` | \_No documentation available.\_ |
| `IEnumerable&lt;SceneOperation&gt; runningOperations` | \_No documentation available.\_ |

### Events

| Member | Description |
|--------|-------------|
| `event Action&lt;SceneCollection&gt; collectionClosed` | Occurs when a collection is closed. |
| `event Action&lt;SceneCollection&gt; collectionOpened` | Occurs when a collection is opened. |
| `event Action&lt;Scene&gt; sceneClosed` | Occurs when a scene is closed. |
| `event Action&lt;Scene&gt; sceneOpened` | Occurs when a scene is opened. |
| `event Action&lt;Scene&gt; scenePreloaded` | Occurs when a scene is preloaded. |
| `event Action&lt;Scene&gt; scenePreloadFinished` | Occurs when a previously preloaded scene is opened. |
| `event Action startedWorking` | Occurs when ASM has started working and is running scene operations. |
| `event Action stoppedWorking` | Occurs when ASM has finished working and no scene operations are running. |

### Methods

| Member | Description |
|--------|-------------|
| `void Activate(Scene scene)` | Activates this scene. |
| `void AddSceneLoader&lt;T&gt;()` | Adds a scene loader. |
| `SceneOperation CancelPreload()` | Cancels the preload. All preloaded scenes will be fully loaded (limitation by Unity), then closed. No ASM scene callbacks will be called. |
| `SceneOperation Close(IEnumerable&lt;Scene&gt; scenes)` | Closes `collection`. |
| `SceneOperation Close(Scene\[\] scenes)` | Closes `collection`. |
| `SceneOperation Close(Scene scene)` | Closes `collection`. |
| `SceneOperation Close(SceneCollection collection)` | Closes `collection`. |
| `SceneOperation CloseAll(bool exceptLoadingScreens, bool exceptUnimported, Scene\[\] except)` | Closes all scenes and collections. |
| `SceneOperation FinishPreload()` | \_No documentation available.\_ |
| `SceneLoader GetLoaderForScene(Scene scene, bool useOnlyGlobal)` | Gets the loader for `scene`. |
| `SceneState GetState(Scene scene)` | \_No documentation available.\_ |
| `IEnumerable&lt;SceneLoader&gt; GetToggleableSceneLoaders()` | Gets a list of all added scene loaders that can be toggled scene by scene. |
| `bool IsTracked(Scene scene)` | Gets whatever this scene is tracked as open. |
| `bool IsTracked(SceneCollection collection)` | Gets whatever this scene is tracked as open. |
| `SceneOperation Open(IEnumerable&lt;Scene&gt; scenes)` | Opens the collection. |
| `SceneOperation Open(Scene\[\] scenes)` | Opens the collection. |
| `SceneOperation Open(Scene scene)` | Opens the collection. |
| `SceneOperation Open(SceneCollection collection, bool openAll)` | Opens the collection. |
| `SceneOperation OpenAdditive(IEnumerable&lt;SceneCollection&gt; collections, SceneCollection activeCollection, LoadingScreenReference loadingScreen)` | Opens the collection without closing existing scenes. |
| `SceneOperation OpenAdditive(SceneCollection collection, bool openAll)` | Opens the collection without closing existing scenes. |
| `SceneOperation OpenAndActivate(Scene scene)` | Opens this scene and activates it. |
| `SceneOperation OpenWithLoadingScreen(IEnumerable&lt;Scene&gt; scene, Scene loadingScreen)` | Opens this scene with the specified `loadingScene`. |
| `SceneOperation OpenWithLoadingScreen(Scene scene, Scene loadingScreen)` | Opens this scene with the specified `loadingScene`. |
| `SceneOperation Preload(Scene scene, Action onPreloaded)` | Preloads the scenes. |
| `void RemoveSceneLoader&lt;T&gt;()` | \_No documentation available.\_ |
| `SceneOperation ToggleOpen(Scene scene)` | Toggles the collection open or closed. |
| `SceneOperation ToggleOpen(SceneCollection collection, bool openAll)` | Toggles the collection open or closed. |
| `void Track(Scene scene)` | Tracks the specified scene as open. |
| `void Track(Scene scene, Scene unityScene)` | Tracks the specified scene as open. |
| `void Track(SceneCollection collection, bool isAdditive)` | Tracks the specified scene as open. |
| `bool Untrack(Scene scene)` | Untracks the specified scene as open. |
| `void Untrack(SceneCollection collection, bool isAdditive)` | Untracks the specified scene as open. |
| `void UntrackCollections()` | Untracks all collections. |
| `void UntrackScenes()` | Untracks all open scenes. |