## RuntimeSceneLoader

`class` in `AdvancedSceneManager.Core`  /  Inherits from: `SceneLoader`### Description
A scene loader that uses the normal play mode API. 
            
See [LoadSceneMode)](https://learn.microsoft.com/dotnet/api/m:unityengine.scenemanagement.scenemanager.loadsceneasync(system.string,unityengine.scenemanagement.loadscenemode)).

See [Scene)](https://learn.microsoft.com/dotnet/api/m:unityengine.scenemanagement.scenemanager.unloadsceneasync(unityengine.scenemanagement.scene)).

### Properties

| Member | Description |
|--------|-------------|
| `boolean activeOutsideOfPlayMode` | Specifies whatever this loader will run outside of play mode or not. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual boolean CanHandleScene(Scene scene)` | Gets whatever this scene loader can handle the scene. |
| `virtual IEnumerator LoadScene(Scene scene, SceneLoadArgs e)` | Loads the scene specified in e.scene. |
| `virtual IEnumerator UnloadScene(Scene scene, SceneUnloadArgs e)` | Unloads the scene specified in e.scene. |