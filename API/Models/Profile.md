## Profile

`class` in `AdvancedSceneManager.Models`  /  Inherits from: `ASMModelBase`### Description
A profile for ASM, contains settings and collections.

### Properties

| Member | Description |
|--------|-------------|
| `IEnumerable<ISceneCollection> allCollections` | Gets `collections`, `standaloneScenes`, `defaultASMScenes`, `dynamicCollections`. |
| `IEnumerable<SceneCollection> collections` | Gets the collections contained within this profile. |
| `DefaultASMScenesCollection defaultASMScenes` | Gets the default asm scenes collection contained within this profile. |
| `IEnumerable<DynamicCollection> dynamicCollections` | Gets the dynamic collections contained within this profile. |
| `boolean isActive` | Gets if this profile is set as active. |
| `Scene loadingScene` | The default loading scene. |
| `boolean notify` | Specifies whatever this profile should trigger a notification when imported. |
| `string notifyMessage` | Specifies the notification messasge, when `notify` is `true`. |
| `IEnumerable<ISceneCollection> removedCollections` | Gets all removed collections in this profile. |
| `IEnumerable<Scene> scenes` | Gets the scenes managed by this profile. |
| `IEnumerable<Scene> specialScenes` | Gets default loading screen, splash screen and startup loading screen. |
| `Scene splashScene` | The splash scene. |
| `StandaloneCollection standaloneScenes` | Gets the standalone scenes contained within this profile. |
| `IEnumerable<SceneCollection> startupCollections` | Gets the collections that will be opened on startup. |
| `Scene startupScene` | The startup scene. |
| `IEnumerable<Scene> startupScenes` | Gets the scenes flagged to open on startup. |
| `BuildProfile unityBuildProfile` | Gets or sets the `BuildProfile` that ASM should write scene list to, when profile is active. Set to `null` to write to global list. |
| `boolean unloadUnusedAssetsForStandalone` | Enable or disable ASM calling `UnloadUnusedAssets` after standalone scenes has been opened or closed. |

### Static Fields

| Member | Description |
|--------|-------------|
| `readonly string AssetSearchString` | Gets 't:AdvancedSceneManager.Models.Profile', the string to use in [String)](https://learn.microsoft.com/dotnet/api/m:unityeditor.assetdatabase.findassets(system.string)). |

### Static Methods

| Member | Description |
|--------|-------------|
| `Profile Create(string name)` | Creates a new profile, with default scenes and collections. |
| `Profile CreateEmpty(string name, boolean useDefaultSpecialScenes)` | Creates a new empty profile. |
| `void Delete(Profile profile)` | Deletes the specified profile. |
| `void Duplicate(Profile profile)` | Duplicate the specified profile. |
| `Profile Find(string q)` | Finds the profile with the specified name or id. |
| `boolean TryFind(string q, Profile& profile)` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void AddDefaultASMScenes()` | Adds the default ASM scenes collection. |
| `void AddDynamicCollection<T>(DynamicCollectionBase<T> collection)` | _No documentation available._ |
| `void ClearCollections()` | Clear `collections`, `dynamicCollections`, `removedCollections`. |
| `void ClearRemovedCollections()` | Clear removed collections. |
| `boolean Contains(ISceneCollection collection, boolean checkRemoved)` | Gets whatever this profile contains the specified collection. |
| `void CreateCollection()` | Creates a new collection with title 'New collection'. |
| `void CreateCollection(SceneCollection& collection)` | _No documentation available._ |
| `SceneCollection CreateCollection(string title)` | Create a collection and add it to this profile. |
| `SceneCollection CreateCollection(SceneCollectionTemplate template)` | Create a collection from a template. |
| `void CreateDynamicCollection()` | Creates a dynamic collection with default values. |
| `DynamicCollection CreateDynamicCollection(string path, string title)` | Creates a dynamic collection with the specified path and optional title. |
| `void Delete(ISceneCollection collection)` | Deletes a collection from this profile. This does not add it to undo. |
| `void DeleteDynamicCollection(DynamicCollection collection)` | Deletes a dynamic collection from this profile (no undo). |
| `IEnumerable<ISceneCollection> FindCollections(Scene scene)` | Finds all collection that the scene is included in. Includes dynamic collections. |
| `IEnumerable<ISceneCollection> FindUntrackedCollections()` | Gets all collections saved as sub assets of this profile, that are not referenced in it. |
| `int32 IndexOf(SceneCollection collection)` | Gets the index of the specified collection. |
| `int32 IndexOf(DynamicCollection collection)` | Gets the index of the specified collection. |
| `boolean IsStartupCollection(SceneCollection collection)` | Gets if the specified collection is a startup collection. |
| `virtual void OnPropertyChanged(string propertyName)` | Invoke `PropertyChanged`. |
| `virtual void OnValidate()` | _No documentation available._ |
| `void Remove(ISceneCollection collection)` | Removes a collection from this profile. This adds it to undo. |
| `void RemoveDefaultASMScenes()` | Removes the default ASM scenes collection. |
| `void RemoveDynamicCollection(DynamicCollection collection)` | Removes a dynamic collection from this profile. This adds it to undo. |
| `void Restore(ISceneCollection collection)` | Restores a collection that has been removed. |
| `virtual string ToString()` | _No documentation available._ |