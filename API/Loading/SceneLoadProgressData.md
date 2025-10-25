## SceneLoadProgressData

`struct` in `AdvancedSceneManager.Loading`  /  Inherits from: `ValueType`### Description
The default implementation of `ILoadProgressData`, used by ASM in most cases.

### Properties

| Member | Description |
|--------|-------------|
| `SceneOperation operation` | The operation that started this operation. |
| `SceneOperationKind operationKind` | The kind of operation this is. |
| `Scene scene` | The scene that is being loaded or unloaded. Can be null. |
| `single value` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual string ToString()` | _No documentation available._ |