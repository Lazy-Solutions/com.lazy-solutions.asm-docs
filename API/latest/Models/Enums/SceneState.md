## SceneState

`enum` in `AdvancedSceneManager.Models.Enums`  /  Inherits from: `Enum`### Description
Specifies that state of a scene.

### Static Fields

| Member | Description |
|--------|-------------|
| `SceneState NotOpen` | The scene is not open. |
| `SceneState Open` | The scene is open. |
| `SceneState Opening` | The scene is currently being opened. Mutually exclusive to `Preloading`. |
| `SceneState Preloaded` | The scene is currently preloaded. |
| `SceneState Preloading` | The scene is currently being preloaded. Mutually exclusive to `Opening`. |
| `SceneState Queued` | The scene is in queue to be opened. |
| `SceneState Unknown` | The state of the scene is unknown. (An issue probably occured while checking state) |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |