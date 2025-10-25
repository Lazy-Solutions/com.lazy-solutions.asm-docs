## Scene

`class` in `AdvancedSceneManager.Models`  /  Inherits from: `ASMModel`### Description
Represents a scene. This scene can be dragged dropped, and is used by ASM to perform operations on the wrapped unity scene.

<b> Remarks:</b>
A scene can be imported in the ASM window (via notification / popup), or by using `SceneImportUtility`.

### Properties

| Member | Description |
|--------|-------------|
| `string address` | Gets the addressable address for this scene. |
| `string asmPath` | Gets the path of this `Scene`. |
| `EditorPersistentOption autoOpenInEditor` | Specifies whatever this scene should be opened automatically outside of play-mode. |
| `List<Scene> autoOpenInEditorScenes` | Specifies the scenes that should trigger this scene to open when `autoOpenInEditor` is set to `WhenAnyOfTheFollowingScenesAreOpened`. |
| `IEnumerable<CrossSceneReference> crossSceneReferences { get; }` | Enumerates the cross-scene references defined on this scene. |
| `Events events` | Gets the unity events for this scene. |
| `boolean hasSceneAsset` | Gets if `m_sceneAsset` has a value. |
| `Scene[] ignoreInputBindingsForScenes` | Specifies scenes where input bindings should be ignored while open (for this scene). |
| `InputBinding[] inputBindings` | Gets or sets the input bindings for this scene. |
| `Scene inputBindingsLoadingScene` | Specifies loading screen to use when opening or closing this scene using a input binding. |
| `Nullable<Scene> internalScene { get; }` | Gets the `Scene` that this scene is associated with. |
| `boolean isActive` | Gets if this scene is currently active. |
| `boolean isAddressable` | Gets or sets if this scene is enabled for addressables. |
| `boolean isDefaultASMScene` | Gets if this is a default ASM scene. |
| `boolean isDontDestroyOnLoad` | Gets if this scene is the dontDestroyOnLoad scene. |
| `boolean isDynamic` | Gets if this scene is dynamic, it is not persisted to disk. |
| `boolean isImported` | Gets whatever the scene is tracked by ASM. |
| `boolean isIncludedInBuilds` | Gets whatever this scene is included in build. |
| `boolean isLoadingScreen { get; }` | Gets if this scene is a loading screen. |
| `boolean isLocked` | Gets if this scene is locked. |
| `boolean isNonPersistant` | Gets whatever this scene will close normally after a collection closes. |
| `boolean isOpen` | Gets whatever the scene is open. |
| `boolean isOpenInHierarchy` | Gets whatever the scene is open in the hierarchy, this is `true` if scene is currently loading, if scene is preloaded, if scene is fully open. |
| `boolean isPersistent` | Gets if this scene is opened as persistent. |
| `boolean isPreloaded` | Gets whatever the scene is preloaded. |
| `boolean isQueued` | _No documentation available._ |
| `boolean isSpecial` | Gets if this is a 'special' scene. |
| `boolean isSplashScreen { get; }` | Gets if this scene is a splash screen. |
| `boolean keepOpenWhenCollectionsClose` | Specifies whatever this scene will remain open when collections close. |
| `boolean keepOpenWhenNewCollectionWouldReopen` | Specifies whatever this will remain open when a newly opened collection would have reopened it. |
| `LoadPriority loadPriority` | Specifies the `LoadPriority` to use when opening this scene. |
| `string lockMessage` | Gets or sets the message to be displayed when unlocking this scene. |
| `boolean openOnPlayMode` | Specifies whatever this scene should be opened when entering playmode. |
| `boolean openOnStartup` | Specifies whatever this scene should be opened on startup. |
| `string path { get; }` | Gets the path of the associated `SceneAsset`. |
| `SceneAsset sceneAsset { get; }` | Gets the associated `SceneAsset`. |
| `string sceneAssetGUID` | Gets the asset id of `sceneAsset`. |
| `string sceneLoader` | Specifies what `SceneLoader` to use. |
| `SceneState state` | _No documentation available._ |

### Static Fields

| Member | Description |
|--------|-------------|
| `readonly string AssetSearchString` | Gets: 
```
t:AdvancedSceneManager.Models.Scene
```

 Used in [String)](https://learn.microsoft.com/dotnet/api/m:unityeditor.assetdatabase.findassets(system.string)). |
| `string InGameToolbarDescription` | Gets the description for the in-game toolbar scene. |
| `string PauseScreenDescription` | Gets the description for the default pause screen scene. |

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerable<Scene> Find(Func<Scene, boolean> predicate)` | _No documentation available._ |
| `Scene Find(string q)` | _No documentation available._ |
| `IEnumerable<Scene> Find<TSceneLoader>()` | _No documentation available._ |
| `IEnumerable<Scene> FindOpen(string q)` | _No documentation available._ |
| `IEnumerable<Scene> FindOpen(Func<Scene, boolean> predicate)` | _No documentation available._ |
| `boolean IsEqual(object left, object right)` | _No documentation available._ |
| `boolean TryFind(string q, Scene& scene)` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void _Activate()` | Activates this scene. |
| `void _CloseWithLoadingScreen(Scene loadingScene)` | _No documentation available._ |
| `void _OpenAndActivate()` | Opens this scene and activates it. |
| `void _OpenWithLoadingScreen(Scene loadingScene)` | _No documentation available._ |
| `void Activate()` | Activates this scene. |
| `void AddCrossSceneReference(CrossSceneReference reference)` | Adds a cross-scene reference for this scene. |
| `void ClearSceneLoader()` | Clears custom scene loader for this scene. This means normal ASM functionality will be used. |
| `virtual SceneOperation Close()` | Closes this scene. |
| `SceneOperation CloseWithLoadingScreen(Scene loadingScene)` | Closes this scene with the specified `loadingScene`. |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(Scene other)` | _No documentation available._ |
| `boolean Equals(Nullable<Scene> other)` | _No documentation available._ |
| `boolean Equals(SceneAsset other)` | _No documentation available._ |
| `boolean EvalOpenAsPersistent(SceneCollection parentCollection, SceneCollection collectionToOpen)` | Evaluates whether this scene should remain open as persistent. |
| `T FindObject<T>()` | _No documentation available._ |
| `boolean FindObject<T>(T& component)` | _No documentation available._ |
| `IEnumerable<T> FindObjects<T>()` | _No documentation available._ |
| `SceneLoader GetEffectiveSceneLoader()` | Gets the effective, contextual, scene loader for this scene. `null` if none found (this means normal ASM loader will be used). |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `IEnumerable<GameObject> GetRootGameObjects()` | Gets the root game objects in this `Scene`. |
| `SceneLoader GetSceneLoader()` | Gets the scene loader specified for this scene. `null` if none set. |
| `string GetTooltip()` | Gets the SceneField tooltip. |
| `virtual boolean IsMatch(string q)` | Gets if `q` matches `name`, `id`, `path`. |
| `virtual SceneOperation Open()` | Opens this scene. |
| `SceneOperation OpenAndActivate()` | Opens this scene and activates it. |
| `SceneOperation OpenWithLoadingScreen(Scene loadingScene)` | Opens this scene with the specified `loadingScene`. |
| `virtual SceneOperation Preload()` | Preloads this scene. |
| `SceneOperation Preload(Action onPreloaded)` | Preloads this scene. |
| `void RemoveCrossSceneReference(CrossSceneReference reference)` | Removes a cross-scene reference for this scene. |
| `virtual SceneOperation Reopen()` | Reopens this scene. |
| `void SetAutoOpenIn(SceneCollection collection, boolean openSceneWhenCollectionOpen)` | Toggles whatever this scene should be automatically opened when a collection is opened. No effect if scene is not already contained within collection. |
| `void SetSceneLoader<T>()` | _No documentation available._ |
| `boolean ShouldAutoOpenIn(SceneCollection collection)` | Gets whatever the scene should automatically open, when this collection is opened. |
| `virtual SceneOperation ToggleOpen()` | Toggles this scene open or closed. |
| `virtual string ToString()` | _No documentation available._ |
| `boolean UsesSceneLoader<T>()` | _No documentation available._ |