## IPreloadable

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Defines members related to preloading.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isPreloaded` | Gets if this `IPreloadable` is currently preloaded. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void _CancelPreload()` | _No documentation available._ |
| `abstract virtual void _FinishPreload()` | _No documentation available._ |
| `abstract virtual void _Preload()` | _No documentation available._ |
| `abstract virtual SceneOperation CancelPreload()` | Cancels the current preloads. |
| `abstract virtual SceneOperation FinishPreload()` | Finishes the current preloads. |
| `abstract virtual SceneOperation Preload()` | Preloads this `IPreloadable`. |