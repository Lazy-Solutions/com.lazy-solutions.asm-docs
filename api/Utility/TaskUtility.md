## TaskUtility

`static class` in `AdvancedSceneManager.Utility`### Description
Provides utility methods for working with tasks.

### Static Methods

| Member | Description |
|--------|-------------|
| `CoroutineAwaiter GetAwaiter(IEnumerator coroutine)` | Gets an awaiter that allows awaiting the coroutine. |
| `Awaitable<boolean> StartCoroutineAsAwaitable(IEnumerator coroutine)` | Runs a coroutine as an `Awaitable`1`. |
| `Task StartCoroutineAsTask(IEnumerator coroutine)` | Runs a coroutine as a `Task`. |
| `Awaitable WhenAll(Awaitable[] items)` | Waits for all awaitable to finish. |