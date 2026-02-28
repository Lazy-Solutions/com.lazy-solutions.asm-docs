## IOpenableScene

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Defines members for openable scenes.

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void _Activate()` | Activates the scene. |
| `abstract virtual void _OpenAndActivate()` | Opens and activates the scene. |
| `abstract virtual void Activate()` | Activates the scene. |
| `abstract virtual SceneOperation CloseWithLoadingScreen(Scene loadingScene)` | Closes the scene using the specified loading screen. |
| `abstract virtual SceneOperation OpenAndActivate()` | Opens and activates the scene. |
| `abstract virtual SceneOperation OpenWithLoadingScreen(Scene loadingScene)` | Opens the scene using the specified loading screen. |