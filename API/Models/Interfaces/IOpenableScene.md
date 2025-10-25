## IOpenableScene

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Defines methods for openable scenes.

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void _Activate()` | _No documentation available._ |
| `abstract virtual void _OpenAndActivate()` | _No documentation available._ |
| `abstract virtual void Activate()` | Activates the `IOpenableScene`. |
| `abstract virtual SceneOperation CloseWithLoadingScreen(Scene loadingScene)` | Closes the `IOpenableScene` with the specified `loadingScene`. |
| `abstract virtual SceneOperation OpenAndActivate()` | Opens the `IOpenableScene` and activates it. |
| `abstract virtual SceneOperation OpenWithLoadingScreen(Scene loadingScene)` | Opens the `IOpenableScene` with the specified `loadingScene`. |