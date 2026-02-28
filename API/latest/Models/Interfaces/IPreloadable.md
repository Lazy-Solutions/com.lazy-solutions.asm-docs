## IPreloadable

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Defines members for assets that support preloading.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isPreloaded` | Gets whether this asset is currently preloaded. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void _CancelPreload()` | Cancels all active preloads. |
| `abstract virtual void _FinishPreload()` | Finishes all active preloads. |
| `abstract virtual void _Preload()` | Preloads this asset. |
| `abstract virtual SceneOperation CancelPreload()` | Cancels all active preloads. |
| `abstract virtual SceneOperation FinishPreload()` | Finishes all active preloads. |
| `abstract virtual SceneOperation Preload()` | Preloads this asset. |