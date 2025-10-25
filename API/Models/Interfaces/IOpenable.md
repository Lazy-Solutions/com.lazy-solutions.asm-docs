## IOpenable

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Defines members for openable assets.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isOpen` | Gets if this `IOpenable` is open. |
| `boolean isQueued` | Gets if this `IOpenable` is queued to be opened. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void _Close()` | _No documentation available._ |
| `abstract virtual void _Open()` | _No documentation available._ |
| `abstract virtual void _Reopen()` | _No documentation available._ |
| `abstract virtual void _ToggleOpen()` | _No documentation available._ |
| `abstract virtual SceneOperation Close()` | Closes this `IOpenable`. |
| `abstract virtual SceneOperation Open()` | Opens this `IOpenable`. |
| `abstract virtual SceneOperation Reopen()` | Reopens this `IOpenable`. |
| `abstract virtual SceneOperation ToggleOpen()` | Toggles this `IOpenable` open or closed. |