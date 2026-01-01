## ProfileDependentCollection

`class` in `AdvancedSceneManager.Models.Utility`  /  Inherits from: `ProfileDependent<SceneCollection>`### Description
Represents a `SceneCollection` that changes depending on the active `Profile`.

### Properties

| Member | Description |
|--------|-------------|
| `SceneCollection collection` | Gets the `SceneCollection` associated with the currently active `Profile`. |
| `boolean isOpen` | Gets whether the collection is currently open. |
| `boolean isQueued` | Gets whether the collection is queued to be opened or closed. |

### Methods

| Member | Description |
|--------|-------------|
| `void _Close()` | Closes the collection. |
| `void _Open()` | Opens the collection. |
| `void _OpenAdditive()` | Opens the collection as additive. |
| `void _Preload()` | Preloads the collection. |
| `void _PreloadAdditive()` | Preloads the collection as additive. |
| `void _Reopen()` | Reopens the collection. |
| `void _ToggleOpen()` | Toggles the open state of the collection. |
| `SceneOperation Close()` | Closes the collection. |
| `SceneOperation Open()` | Opens the collection. |
| `SceneOperation Open(boolean openAll)` | Opens the collection. |
| `SceneOperation OpenAdditive()` | Opens the collection as additive. |
| `SceneOperation OpenAdditive(boolean openAll)` | Opens the collection as additive. |
| `SceneOperation Preload()` | Preloads the collection. |
| `SceneOperation Preload(boolean openAll)` | Preloads the collection. |
| `SceneOperation PreloadAdditive()` | Preloads the collection as additive. |
| `SceneOperation PreloadAdditive(boolean openAll)` | Preloads the collection as additive. |
| `SceneOperation Reopen()` | Reopens the collection. |
| `SceneOperation Reopen(boolean openAll)` | Reopens the collection. |
| `SceneOperation ToggleOpen()` | Toggles the open state of the collection. |
| `SceneOperation ToggleOpen(boolean openAll)` | Toggles the open state of the collection. |