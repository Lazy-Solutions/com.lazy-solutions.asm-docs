## IAssetsProvider

`interface` in `AdvancedSceneManager.DependencyInjection`### Description
Provides access to the scenes, collections and profiles managed by ASM.

### Properties

| Member | Description |
|--------|-------------|
| `IEnumerable<SceneCollection> collections` | _No documentation available._ |
| `DefaultScenes defaults` | _No documentation available._ |
| `IEnumerable<Profile> profiles` | _No documentation available._ |
| `IEnumerable<Scene> scenes` | _No documentation available._ |
| `IEnumerable<SceneCollectionTemplate> templates` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual IEnumerable<T> Enumerate<T>()` | _No documentation available._ |