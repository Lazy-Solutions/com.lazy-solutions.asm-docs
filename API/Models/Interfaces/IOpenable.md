## IOpenable

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Defines members for openable assets.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isOpen` | Gets whether this asset is currently open. |
| `boolean isQueued` | Gets whether this asset is queued to be opened or closed. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void _Close()` | Closes this asset. |
| `abstract virtual void _Open()` | Opens this asset. |
| `abstract virtual void _Reopen()` | Reopens this asset. |
| `abstract virtual void _ToggleOpen()` | Toggles this asset open or closed. |
| `abstract virtual SceneOperation Close()` | Closes this asset. |
| `abstract virtual SceneOperation Open()` | Opens this asset. |
| `abstract virtual SceneOperation Reopen()` | Reopens this asset. |
| `abstract virtual SceneOperation ToggleOpen()` | Toggles this asset open or closed. |