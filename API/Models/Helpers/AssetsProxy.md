## AssetsProxy

`sealed class` in `AdvancedSceneManager.Models.Helpers`### Description
Provides access to the scenes, collections and profiles managed by ASM.

### Properties

| Member | Description |
|--------|-------------|
| `IEnumerable<SceneCollection> collections` | Enumerates all collections. |
| `DefaultScenes defaults` | Provides access to the default ASM scenes. |
| `IEnumerable<Profile> profiles` | Enumerates all profiles in the project. |
| `IEnumerable<Scene> scenes` | Enumerates all scenes. |
| `IEnumerable<SceneCollectionTemplate> templates` | Enumerates all templates. |

### Methods

| Member | Description |
|--------|-------------|
| `IEnumerable<T> Enumerate<T>()` | _No documentation available._ |