## SceneUtility

`static class` in `AdvancedSceneManager.Utility`### Description
An utility class to perform actions on scenes.

### Static Properties

| Member | Description |
|--------|-------------|
| `Scene dontDestroyOnLoadScene` | Gets the dontDestroyOnLoad scene. Returns null if not open. |
| `boolean hasAnyScenes` | Gets if there are any scenes open that are not dynamically created, and not yet saved to disk. |
| `boolean isStartupScene` | Gets if current, and only, scene is the startup scene. |
| `int32 unitySceneCount` | The current number of Scenes. |

### Static Methods

| Member | Description |
|--------|-------------|
| `void AddScript<T>(Scene scene, Action<T> configure)` | _No documentation available._ |
| `boolean ASMScene(Component component, Scene& scene)` | _No documentation available._ |
| `Scene ASMScene(GameObject gameObject, Scene& scene)` | _No documentation available._ |
| `Scene ASMScene(Component component)` | _No documentation available._ |
| `Scene ASMScene(GameObject gameObject)` | _No documentation available._ |
| `boolean ASMScene(Scene thisScene, Scene& scene)` | _No documentation available._ |
| `Scene ASMScene(Scene scene)` | Gets the associated ASM `Scene`. |
| `boolean ASMScene(SceneAsset thisScene, Scene& scene)` | _No documentation available._ |
| `Scene ASMScene(SceneAsset scene)` | Finds the asm representation of this `SceneAsset`. |
| `IEnumerable<SceneAsset> Create(string[] paths)` | _No documentation available._ |
| `IEnumerable<SceneAsset> Create(IEnumerable<string> paths)` | _No documentation available._ |
| `SceneAsset Create(string path)` | Creates a scene at the specified path. |
| `Scene CreateAddressableScene(string name, AssetReference assetReference)` | Creates an addressable, runtime-only, scene. |
| `Scene CreateAndImport(string path)` | Creates and imports a scene. |
| `IEnumerable<Scene> CreateAndImport(string[] paths)` | _No documentation available._ |
| `IEnumerable<Scene> CreateAndImport(IEnumerable<string> paths)` | _No documentation available._ |
| `void CreateAsset(string folder, string baseClass, string namespaceName, string name)` | Creates a scene asset and script based on the specified base class. |
| `Scene CreateDynamic(string name, LocalPhysicsMode localPhysicsMode)` | Creates a scene at runtime, that is not saved to disk. |
| `GameObject CreateHere(MonoBehaviour mono)` | Creates a game object in this scene. |
| `GameObject CreateHere(MonoBehaviour mono, string name)` | Creates a game object in this scene. |
| `GameObject CreateHere(MonoBehaviour mono, string name, Type[] components)` | Creates a game object in this scene. |
| `TComponent CreateHere<TComponent>(MonoBehaviour mono, string gameObjectName)` | Creates a game object in this scene. |
| `void CreateLoadingScreenAsset(string folder, string name, string namespaceName)` | Creates a loading screen scene and its corresponding script. |
| `void CreateSplashScreenAsset(string folder, string name, string namespaceName)` | Creates a splash screen scene and its corresponding script. |
| `void Disable(Scene scene)` | Sets all root objects as disabled. |
| `void Enable(Scene scene)` | Sets all root objects as enabled. |
| `IEnumerable<Scene> EvaluateFinalSceneList(Profile profile, StartupProps props)` | _No documentation available._ |
| `IEnumerable<Scene> EvaluateFinalSceneList(IEnumerable<SceneCollection> collections)` | Evaluate the final scene list after opening a sequence of collections. |
| `Scene Find(string q)` | Find scenes by name or path. |
| `IEnumerable<Scene> Find(Func<Scene, boolean> predicate)` | Find scenes by predicate. |
| `Scene FindAddressableScene(AssetReference assetReference)` | Finds the scene with the associated `AssetReference`. |
| `boolean FindCollection(Scene scene, SceneCollection& collection)` | _No documentation available._ |
| `SceneCollection FindCollection(Scene scene)` | Attempts to find best match for collection. |
| `IEnumerable<SceneCollection> FindCollections(Scene scene, boolean allProfiles)` | Finds which collections that this scene is a part of. |
| `IEnumerable<SceneCollection> FindCollections(Scene scene, Profile profile)` | Finds which collections that this scene is a part of. |
| `IEnumerable<Scene> FindOpen(string q)` | Find open scenes by name or path. |
| `IEnumerable<Scene> FindOpen(Func<Scene, boolean> predicate)` | Find open scenes by predicate. |
| `IEnumerable<Scene> GetAllOpenUnityScenes()` | Get all open unity scenes. |
| `Scene Import(SceneAsset scene)` | _No documentation available._ |
| `IEnumerable<Scene> Import(IEnumerable<SceneAsset> scene)` | _No documentation available._ |
| `Scene Import(string scene)` | Imports the scene into ASM and returns it. Returns already imported scene if already imported. |
| `IEnumerable<Scene> Import(string[] scene)` | Imports the scene into ASM and returns it. Returns already imported scene if already imported. |
| `boolean IsIncluded(Scene scene)` | Gets if the scene is included in build. |
| `void MergeScenes(Scene targetScene, Scene[] scenes)` | Merges the specified scenes into the target scene. |
| `void MergeScenes(string targetScenePath, string[] scenePaths)` | Merges the specified scenes into the target scene. |
| `void MergeScenesPreserveOriginal(Scene targetScene, Scene[] scenes)` | Merges the specified scenes into the target scene, preserving the originals. |
| `void MergeScenesPreserveOriginal(string targetScenePath, string[] scenePaths)` | Merges the specified scenes into the target scene, preserving the originals. |
| `void Move(GameObject obj, Scene scene)` | _No documentation available._ |
| `void Move(GameObject obj, Scene scene)` | _No documentation available._ |
| `void MoveAfter(Scene sceneToMove, Scene otherScene)` | Moves the scene after another scene. |
| `void MoveBefore(Scene sceneToMove, Scene otherScene)` | Moves the scene before another scene in the heirarchy. |
| `GameObject MoveHere(MonoBehaviour mono, GameObject obj)` | Moves `obj` to this scene. |
| `void MoveToBottom(Scene sceneToMove)` | Moves the scene to the bottom in the hierarchy. |
| `void MoveToNewScene(GameObject[] objects)` | Moves the object to a new scene. |
| `void MoveToTop(Scene sceneToMove)` | Moves the scene to the top in the hierarchy. |
| `void RemoveScript<T>(Scene scene, boolean removeGameObject)` | _No documentation available._ |
| `void SetEnabled(Scene scene, boolean isEnabled)` | Sets all root objects as enabled / disabled. |
| `void Unimport(SceneAsset scene)` | _No documentation available._ |
| `void Unimport(IEnumerable<SceneAsset> scene)` | _No documentation available._ |
| `void Unimport(string[] scene)` | Unimports the scene from ASM. No effect if scene not imported. |
| `void Unimport(Scene scene)` | _No documentation available._ |
| `void Unimport(IEnumerable<Scene> scene)` | _No documentation available._ |
| `void Unimport(Scene[] scene)` | Unimports the scene from ASM. No effect if scene not imported. |