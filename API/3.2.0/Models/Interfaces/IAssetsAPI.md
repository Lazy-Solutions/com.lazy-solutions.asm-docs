## IAssetsAPI

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Provides access to the scenes, collections and profiles managed by ASM.

<b> Remarks:</b>
May not be available in `[InitializeOnLoad]` and similar, use [Action)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.scenemanager.oninitialized(system.action)) or `OnLoadAttribute` to ensure you're not calling too early.

### Properties

| Member | Description |
|--------|-------------|
| `IEnumerable<SceneCollectionTemplate> collectionTemplates` | Enumerates all collection templates tracked by ASM. |
| `IAssetsAPIDefaultScenes defaults` | Provides access to the default ASM scenes. |
| `IEnumerable<Profile> profiles` | Enumerates all profiles tracked by ASM. |
| `ASMSceneHelper sceneHelper` | Provides access to the scene helper. |
| `IEnumerable<Scene> scenes` | Enumerates all imported scenes tracked by ASM. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual IEnumerable<T> Enumerate<T>()` | Enumerates all assets. |
| `abstract virtual IEnumerable<IASMModel> Enumerate()` | Enumerates all assets. |