## Profile

`class` in `AdvancedSceneManager.Models`  /  Inherits from: `ASMModelBase`### Description
A profile for ASM, contains settings and collections.

### Properties

| Member | Description |
|--------|-------------|
| `IEnumerable<ISceneCollection> allCollections` | Gets `collections`, `standaloneScenes`, `defaultASMScenes`, `dynamicCollections`. |
| `IEnumerable<Scene> allScenes` | Gets all scenes, including child profile scenes. |
| `boolean autoUpdateBuildScenes` | Specifies whatever build scene list should be automatically updated. |
| `IEnumerable<Profile> childProfiles` | Gets the child profiles for this profile. |
| `IEnumerable<Scene> childProfileScenes` | Gets all scenes from child profiles. |
| `IEnumerable<SceneCollection> childProfileStartupCollections` | Gets all startup collections from child profiles. |
| `IEnumerable<Scene> childProfileStartupScenes` | Gets all startup scenes from child profiles. |
| `IEnumerable<SceneCollection> collections` | Gets the collections contained within this profile. |
| `DefaultASMScenesCollection defaultASMScenes` | Gets the default asm scenes collection contained within this profile. |
| `IEnumerable<DynamicCollection> dynamicCollections` | Gets the dynamic collections contained within this profile. |
| `boolean isActive` | Gets if this profile is set as active. |
| `LoadingScreenReference loadingScreen` | The default loading scene. |
| `boolean notify` | Specifies whatever this profile should trigger a notification when imported. |
| `string notifyMessage` | Specifies the notification messasge, when `notify` is `true`. |
| `boolean preventAssignmentIfNullAndUnityHasABuildProfileActive` | Gets or sets whether ASM should prevent writing the build scene list to Unity’s active build profile when `unityBuildProfile` is `null`. |
| `IEnumerable<ISceneCollection> removedCollections` | Gets all removed collections in this profile. |
| `IEnumerable<Scene> scenes` | Gets the scenes managed by this profile. |
| `IEnumerable<Scene> specialScenes` | Gets default loading screen, splash screen and startup loading screen. |
| `LoadingScreenReference splashScreen` | The splash scene. |
| `StandaloneCollection standaloneScenes` | Gets the standalone scenes contained within this profile. |
| `IEnumerable<SceneCollection> startupCollections` | Gets the collections that will be opened on startup. |
| `Scene startupScene` | The startup scene. |
| `IEnumerable<Scene> startupScenes` | Gets the scenes flagged to open on startup. |
| `BuildProfile unityBuildProfile` | Gets or sets the `BuildProfile` that ASM should write its scene list to when the profile is active. Set to `null` to write to the global list, or to the active build profile if one is active. |
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
| `void AddChildProfile(Profile profile)` | Add a child profile. |
| `void AddCollection(ISceneCollection collection)` | Adds a collection. |
| `void ClearCollections()` | Clear `collections`, `dynamicCollections`, `removedCollections`. Does not prompt undo. |
| `void ClearRemovedCollections()` | Clear removed collections. |
| `boolean Contains(ISceneCollection collection, boolean checkRemoved)` | Gets whatever this profile contains the specified collection. |
| `void CreateCollection()` | Creates a new collection with title 'New collection'. |
| `void CreateCollection(SceneCollection& collection)` | _No documentation available._ |
| `SceneCollection CreateCollection(string title)` | Create a collection and add it to this profile. |
| `SceneCollection CreateCollection(SceneCollectionTemplate template)` | Create a collection from a template. |
| `void CreateDynamicCollection()` | Creates a dynamic collection with default values. |
| `DynamicCollection CreateDynamicCollection(string path, string title)` | Creates a dynamic collection with the specified path and optional title. |
| `void Delete(ISceneCollection collection)` | Deletes a collection. Does not prompt undo. |
| `IEnumerable<ISceneCollection> FindCollections(Scene scene)` | Finds all collection that the scene is included in. Includes dynamic collections. |
| `IEnumerable<ISceneCollection> FindUntrackedCollections()` | Gets all collections saved as sub assets of this profile, that are not referenced in it. |
| `int32 IndexOf(SceneCollection collection)` | Gets the index of the specified collection. |
| `int32 IndexOf(DynamicCollection collection)` | Gets the index of the specified collection. |
| `boolean IsStartupCollection(SceneCollection collection)` | Gets if the specified collection is a startup collection. |
| `virtual void OnPropertyChanged(string propertyName)` | Invoke `PropertyChanged`. |
| `virtual void OnValidate()` | _No documentation available._ |
| `void Remove(ISceneCollection collection)` | Removes a collection. Prompts undo. |
| `void RemoveChildProfile(Profile profile)` | Remove a child profile. |
| `void Restore(ISceneCollection collection)` | Restores a collection that has been removed. |
| `virtual string ToString()` | _No documentation available._ |