## CoroutineAwaiter

`class` in `AdvancedSceneManager.Utility`### Description
Provides an awaiter for coroutines, allowing them to be awaited like tasks.

<b> Remarks:</b>
See also [IEnumerator)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.utility.taskutility.getawaiter(system.collections.ienumerator)).

### Properties

| Member | Description |
|--------|-------------|
| `boolean IsCompleted` | Gets whether the coroutine has completed. |

### Methods

| Member | Description |
|--------|-------------|
| `void GetResult()` | Retrieves the result of the coroutine. |
| `void OnCompleted(Action continuation)` | Registers a continuation to be invoked when the coroutine completes. |