## SceneCollection

`class` in `AdvancedSceneManager.Models`  /  Inherits from: `ASMModel`### Description
Represents a collection of scenes, that should open at the same time.

<b> Remarks:</b>
Only one collection can be fully open at a time; additive collections are supported but not considered fully open.

### Properties

| Member | Description |
|--------|-------------|
| `Scene activeScene` | Specifies the scene that should be activated after collection is opened. |
| `IEnumerable<Scene> allScenes` | Gets both `scenes` and `loadingScene`. |
| `int32 count` | _No documentation available._ |
| `string description` | _No documentation available._ |
| `Scene effectiveLoadingScene` | Gets effective loading screen depending on `loadingScreenUsage`. |
| `Events events` | Gets the unity events for this scene. |
| `boolean hasScenes` | Gets if this collection has any scenes. |
| `Scene[] ignoreInputBindingsForScenes` | Specifies scenes where input bindings should be ignored while open (for this collection). |
| `InputBinding[] inputBindings` | Gets or sets the input bindings for this collection. |
| `boolean isIncluded` | Gets whatever this collection should be included in build. |
| `boolean isLocked` | Gets if this collection is locked. |
| `boolean isOpen` | Gets if this collection is open. |
| `boolean isOpenAdditive` | Gets if this collection is opened additively. |
| `boolean isOpenNonAdditive` | Gets if this collection is opened additively. |
| `boolean isPreloaded` | Gets if this collection is currently preloaded. |
| `boolean isQueued` | _No documentation available._ |
| `boolean isStartupCollection` | Gets if this is a startup collection. |
| `Scene Item` | _No documentation available._ |
| `Scene loadingScene` | The loading screen that is associated with this collection. |
| `LoadingScreenUsage loadingScreenUsage` | Specifies what loading screen to use. |
| `LoadPriority loadPriority` | Specifies the `LoadPriority` to use when opening this collection. |
| `string lockMessage` | Gets or sets the message to be displayed when unlocking this collection. |
| `boolean openAsPersistent` | Specifies whatever this collection should be opened as persistent. |
| `Profile profile` | The profile that this collection is associated with. |
| `IEnumerable<string> scenePaths` | _No documentation available._ |
| `IEnumerable<Scene> scenes` | _No documentation available._ |
| `List<Scene> scenesThatShouldNotAutomaticallyOpen` | Specifies scenes that should not open automatically. |
| `IEnumerable<Scene> scenesToAutomaticallyOpen` | Gets the scenes that should open automatically when collection is opened (when in openAll param is `false`). |
| `boolean setActiveSceneWhenOpenedAsAdditive` | Specifies whatever `activeScene` should be set, when collection is opened as additive. |
| `CollectionStartupOption startupOption` | Specifies startup option. |
| `string title` | _No documentation available._ |
| `boolean unloadUnusedAssets` | Calls `UnloadUnusedAssets` after collection is opened or closed. |
| `ScriptableObject userData` | The extra data that is associated with this collection. |

### Static Fields

| Member | Description |
|--------|-------------|
| `readonly string AssetSearchString` | Gets: 
```
t:AdvancedSceneManager.Models.SceneCollection
```

 Used in [String)](https://learn.microsoft.com/dotnet/api/m:unityeditor.assetdatabase.findassets(system.string)). |

### Static Methods

| Member | Description |
|--------|-------------|
| `SceneCollection Find(string q, boolean activeProfile)` | Finds a collection based on its title or id. |
| `ISceneCollection FindCollectionAll(string q, boolean activeProfile)` | Finds a `SceneCollection`, `StandaloneCollection`, `DefaultASMScenesCollection`, or `DynamicCollection` based on its title or id. Supports removed collections. |
| `boolean TryFind(string q, SceneCollection& collection, boolean activeProfile)` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void _OpenAdditive()` | _No documentation available._ |
| `void _PreloadAdditive()` | _No documentation available._ |
| `virtual SceneOperation Close()` | Closes this collection. |
| `boolean Contains(Scene scene)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(SceneCollection other)` | _No documentation available._ |
| `boolean FindProfile(Profile& profile)` | _No documentation available._ |
| `Profile FindProfile()` | Find the `Profile` that this collection is associated with. |
| `IEnumerator<Scene> GetEnumerator()` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual boolean IsMatch(string q)` | Matches this collection against the query string. |
| `virtual void OnPropertyChanged(string propertyName)` | Invoke `PropertyChanged`. |
| `virtual void OnValidate()` | _No documentation available._ |
| `virtual SceneOperation Open()` | Opens this collection. |
| `SceneOperation Open(boolean openAll)` | Opens this collection. |
| `SceneOperation OpenAdditive(boolean openAll)` | Opens this collection as additive. |
| `virtual SceneOperation Preload()` | Preloads this collection. |
| `SceneOperation Preload(boolean openAll)` | Preloads this collection. |
| `SceneOperation PreloadAdditive(boolean openAll)` | Preloads this collection as additive. |
| `virtual SceneOperation Reopen()` | Reopens this collection. |
| `SceneOperation Reopen(boolean openAll)` | Reopens this collection. |
| `void SetAutoOpen(Scene scene, boolean openSceneWhenCollectionOpen)` | Sets whatever the scene should automatically open, when this collection is opened. |
| `boolean ShouldAutoOpen(Scene scene)` | Gets whatever the scene should automatically open, when this collection is opened. |
| `virtual SceneOperation ToggleOpen()` | Toggles this collection open or closed. |
| `SceneOperation ToggleOpen(boolean openAll)` | Toggles this collection open and closed. |
| `virtual string ToString()` | _No documentation available._ |
| `T UserData<T>()` | _No documentation available._ |