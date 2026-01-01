## EventCallbackBase

`abstract class` in `AdvancedSceneManager.Callbacks.Events`### Description
The base class for all event callbacks.

### Properties

| Member | Description |
|--------|-------------|
| `List<Func<IEnumerator>> waitFor { get; }` | A list of coroutines that [operation](https://learn.microsoft.com/dotnet/api/!:operation) should wait for. It will not proceed until all coroutines are done. |
| `When when` | Specifies when this event callback was invoked, before or after the action it represents. If applicable. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `virtual boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |
| `void WaitFor(IEnumerator coroutine)` | Specifies a coroutine that the operation should wait for. |
| `void WaitFor(Func<IEnumerator> coroutine)` | Specifies a coroutine that the operation should wait for. |
| `void WaitFor(GlobalCoroutine coroutine)` | Specifies a coroutine that the operation should wait for. |
| `void WaitFor(Func<GlobalCoroutine> coroutine)` | Specifies a coroutine that the operation should wait for. |
| `void WaitFor(Awaitable awaitable)` | Specifies a coroutine that the operation should wait for. |
| `void WaitFor(Func<Awaitable> awaitable)` | Specifies a coroutine that the operation should wait for. |