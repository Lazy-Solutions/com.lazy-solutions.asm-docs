## Async`1

`class` in `AdvancedSceneManager.Utility`  /  Inherits from: `CustomYieldInstruction`### Description
Represents a async operation that returns a value.

### Static Properties

| Member | Description |
|--------|-------------|
| `Async<T> complete` | Gets a `Async`1` that is already completed. |

### Properties

| Member | Description |
|--------|-------------|
| `boolean keepWaiting` | Indicates if coroutine should be kept suspended. |
| `T value` | Gets the value that was produced by the async operation. |

### Static Methods

| Member | Description |
|--------|-------------|
| `Async<T> FromResult(T result)` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void OnComplete(Action<T> callback)` | _No documentation available._ |