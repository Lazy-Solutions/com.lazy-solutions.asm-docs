## SceneLoaderArgsBase

`abstract class` in `AdvancedSceneManager.Core`### Description
Base class for `SceneLoadArgs` and `SceneUnloadArgs`.

### Properties

| Member | Description |
|--------|-------------|
| `SceneCollection collection { get; }` | The collection that the scene belongs to, if any. |
| `string errorMessage { get; }` | The error message if `isError` is `true`. |
| `boolean isError { get; }` | Indicates whether this operation resulted in an error. |
| `boolean isLoadingScreen` | Gets whether the associated scene is a loading screen. |
| `boolean isSplashScreen` | Gets whether the associated scene is a splash screen. |
| `SceneOperation operation { get; }` | The `SceneOperation` representing the current load or unload operation. |
| `boolean reportProgress { get; }` | Determines whether progress should be reported during this operation. |
| `Scene scene { get; }` | The scene associated with this loading or unloading operation. |

### Methods

| Member | Description |
|--------|-------------|
| `void SetError(string message)` | Marks this operation as failed with the specified error message. |