## SceneOperation

`class` in `AdvancedSceneManager.Core`  /  Inherits from: `CustomYieldInstruction`### Description
A scene operation is a queueable operation that can open or close scenes. See also: [SceneAction](https://learn.microsoft.com/dotnet/api/!:sceneaction).

### Static Properties

| Member | Description |
|--------|-------------|
| `SceneOperation done` | Gets a `SceneOperation` that has already completed. |

### Properties

| Member | Description |
|--------|-------------|
| `boolean acceptsSubOperations { get; }` | Gets if this operation is currently executing open callbacks. If so, sub operations is temporarily accepted. |
| `IEnumerable<Scene> close { get; }` | Gets the scenes specified to close. |
| `IEnumerable<Scene> closedScenes` | Gets the scenes that was closed during this operation. |
| `SceneCollection collection { get; }` | Specifies the collection that is being opened or closed. |
| `string description { get; }` | Specifies description for coroutine. |
| `EventCallbackManager<SceneOperationEventBase> events { get; }` | Gets the event manager for this operation. |
| `SceneOperationFlags flags { get; }` | Gets the operation flags this operation will use. |
| `Scene focus { get; }` | Sets focus to the specified scene. Overrides selected scene in collections. |
| `boolean focusSingleScene { get; }` | Sets the first opened scene as active. |
| `IEnumerable<Scene> ignoreForActivation { get; }` | Gets the scenes that should not be activated. |
| `boolean isCollectionCloseOperation { get; }` | Gets whatever this operation is about to close `collection`. |
| `boolean isDefaultASMScene { get; }` | Gets if this scene was opened from the default ASM scene collection. |
| `boolean isFrozen { get; }` | Gets if this operation is frozen, as in, can its properties be changed? |
| `boolean isStandaloneScene { get; }` | Gets if this scene was opened from the standalone collection. |
| `boolean keepWaiting` | Inherited from [CustomYieldInstruction](https://learn.microsoft.com/dotnet/api/!:customyieldinstruction). Tells unity whatever the operation is done or not. |
| `Scene loadingScene { get; }` | Gets the specified loading screen. |
| `Action<LoadingScreen> loadingScreenCallback { get; }` | Gets the specified loading screen callback. |
| `LoadPriority loadPriority { get; }` | Gets the `LoadPriority` this operation will use. |
| `IEnumerable<Scene> open { get; }` | Gets the scenes specified to open. |
| `LoadingScreen openedLoadingScreen { get; }` | Gets the loading screen that was opened by this operation. |
| `IEnumerable<Scene> openedScenes` | Gets the scenes that was opened during this operation. |
| `IEnumerable<Scene> preload { get; }` | Gets the scenes specified to preload. |
| `single progress` | Gets the total progress of this operation. |
| `ProgressScope progressScope { get; }` | Gets the progress scope associated with this operation. |
| `boolean reportsProgress { get; }` | Gets if this scene operation reports progress. |
| `boolean runSceneCallbacksOutsideOfPlayMode { get; }` | Gets whatever scene callbacks should run outside of play mode. |
| `boolean setActiveCollectionScene { get; }` | Specifies whatever active scene should be set when possible. |
| `Nullable<boolean> unloadUnusedAssets { get; }` | Gets whatever [UnloadUnusedAssets](https://learn.microsoft.com/dotnet/api/!:resources.unloadunusedassets) should be called at the end (before loading screen). |
| `boolean useLoadingScene { get; }` | Gets whatever a loading screen should be used. |
| `boolean wasCancelled { get; }` | Gets if this scene operation is cancelled. |

### Static Methods

| Member | Description |
|--------|-------------|
| `SceneOperation Queue()` | Queues a new scene operation. |
| `SceneOperation Start()` | Starts a new scene operation, ignoring queue. |

### Methods

| Member | Description |
|--------|-------------|
| `SceneOperation Activate(Scene scene)` | Sets focus to the specified scene. Overrides selected scene in collections. If `null`, then the first scene opened will be set as active. |
| `void Cancel()` | Cancel this operation. |
| `SceneOperation Close(SceneCollection collection)` | _No documentation available._ |
| `SceneOperation Close(Scene[] scenes)` | Specifies the scenes to close. |
| `SceneOperation Close(IEnumerable<Scene> scenes)` | _No documentation available._ |
| `SceneOperation CloseAll(Scene[] except)` | Closes all scenes prior to opening any scenes. |
| `SceneOperation CloseAll(boolean loadingScene, boolean splashScreen, boolean persistent, IEnumerable<Scene> except)` | Closes all scenes prior to opening any scenes. |
| `SceneOperation CloseAllNonPersistent(Scene[] except)` | Closes all non-persistent scenes prior to opening any scenes. |
| `SceneOperation DisableProgressReporting()` | Disables progress reporting for this operation. |
| `SceneOperation Focus(Scene scene)` | Sets focus to the specified scene. Overrides selected scene in collections. |
| `SceneOperation IgnoreForActivation(IEnumerable<Scene> scenes)` | Specifies scenes that should not be activated. |
| `SceneOperation OnProgressChanged(Action<single> callback)` | Adds a callback when progress changed. |
| `SceneOperation Open(SceneCollection collection, boolean openAll)` | _No documentation available._ |
| `SceneOperation Open(Scene[] scenes)` | Specifies the scenes to open. |
| `SceneOperation Open(IEnumerable<Scene> scenes)` | _No documentation available._ |
| `SceneOperation OpenAndActivate(Scene scene)` | Opens the scene, and makes sure it is activated afterwards. |
| `SceneOperation Preload(Scene[] scenes)` | Specifies scenes to preload. |
| `SceneOperation Preload(IEnumerable<Scene> scenes)` | Specifies scenes to preload. |
| `SceneOperation PrependOpen(Scene[] scenes)` | _No documentation available._ |
| `SceneOperation PrependOpen(IEnumerable<Scene> scenes, boolean ignoreForActivation)` | _No documentation available._ |
| `SceneOperation RegisterCallback<TEventType>(EventCallback<TEventType> callback, When when, string key)` | _No documentation available._ |
| `SceneOperation RemoveOnProgressChangedCallback(Action<single> callback)` | Removes a callback when progress changed. |
| `SceneOperation RunSceneCallbacksOutsidePlayMode(boolean value)` | Specifies whatever scene callbacks should run outside of play mode. |
| `SceneOperation UnloadUsedAssets()` | Specifies whatever [UnloadUnusedAssets](https://learn.microsoft.com/dotnet/api/!:resources.unloadunusedassets) should be called at the end (before loading screen). |
| `SceneOperation UnregisterCallback<TEventType>(EventCallback<TEventType> callback, When when, string key)` | _No documentation available._ |
| `void UnregisterCallback<TEventType>(string key)` | _No documentation available._ |
| `void WaitFor(SceneOperation operation)` | Waits for the specified scene operation to complete before continuing. |
| `SceneOperation With(SceneCollection collection, boolean setActiveScene, boolean isCloseOperation)` | Specifies an associated collection. |
| `SceneOperation With(Scene loadingScene, boolean useLoadingScene)` | Specifies loading screen to use. |
| `SceneOperation With(boolean useLoadingScene)` | Specifies loading screen to use. |
| `SceneOperation With(Action<LoadingScreen> loadingScreenCallback)` | Specifies a callback when loading screen is opened, before `OnOpen` is called. |
| `SceneOperation With(LoadPriority loadPriority)` | Sets the `LoadPriority` this operation will use. |
| `SceneOperation With(SceneOperationFlags flags)` | Sets the operation flags this operation will use. |
| `SceneOperation WithFriendlyText(string text)` | Specifies description for operation coroutine. |
| `SceneOperation WithLoadingScreen(Scene loadingScene, boolean useLoadingScene)` | Specifies loading screen to use. |
| `SceneOperation WithLoadingScreen(boolean useLoadingScene)` | Specifies whatever loading screen should be used. |
| `SceneOperation WithoutLoadingScreen(boolean useLoadingScene)` | Specifies whatever loading screen should be used. |