## ASMModel

`abstract class` in `AdvancedSceneManager.Models`  /  Inherits from: `ASMModelBase`### Description
Serves as the abstract base class for models that can be opened, closed, and preloaded.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isOpen` | _No documentation available._ |
| `boolean isPreloaded` | _No documentation available._ |
| `boolean isQueued` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual void _CancelPreload()` | Cancels all active preloads. |
| `virtual void _Close()` | Closes this asset. |
| `virtual void _FinishPreload()` | Finishes all active preloads. |
| `virtual void _Open()` | Opens this asset. |
| `virtual void _Preload()` | Preloads this asset. |
| `virtual void _Reopen()` | Reopens this asset. |
| `virtual void _ToggleOpen()` | Toggles this asset open or closed. |
| `virtual SceneOperation CancelPreload()` | Cancels all active preloads. |
| `abstract virtual SceneOperation Close()` | Closes this asset. |
| `virtual SceneOperation FinishPreload()` | Finishes all active preloads. |
| `abstract virtual SceneOperation Open()` | Opens this asset. |
| `abstract virtual SceneOperation Preload()` | Preloads this asset. |
| `abstract virtual SceneOperation Reopen()` | Reopens this asset. |
| `abstract virtual SceneOperation ToggleOpen()` | Toggles this asset open or closed. |