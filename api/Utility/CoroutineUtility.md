## CoroutineUtility

`static class` in `AdvancedSceneManager.Utility`### Description
An utility class that helps with running coroutines detached from `MonoBehaviour`.

### Static Properties

| Member | Description |
|--------|-------------|
| `IEnumerable<GlobalCoroutine> coroutines` | Gets all currently active coroutines. |

### Static Methods

| Member | Description |
|--------|-------------|
| `GlobalCoroutine Chain(Func<IEnumerator>[] coroutines)` | Runs the coroutines in sequence, wrapped in a single `GlobalCoroutine`. |
| `GlobalCoroutine Chain(Func<IEnumerator>[] coroutines, string description)` | Runs the coroutines in sequence, wrapped in a single `GlobalCoroutine`. |
| `GlobalCoroutine Chain(IEnumerable<Func<IEnumerator>> coroutines, string description)` | Runs the coroutines in sequence, wrapped in a single `GlobalCoroutine`. |
| `void Run(Action action, TimeSpan after, string description, string callerFile, int32 callerLine, string callerName)` | Runs the action after the specified time. |
| `void Run(Action action, Nullable<single> after, boolean nextFrame, Func<boolean> when, string description, string callerFile, int32 callerLine, string callerName)` | Runs the action after the specified time. |
| `GlobalCoroutine StartCoroutine(IEnumerator coroutine, Action onComplete, string description, string callerFile, int32 callerLine)` | _No documentation available._ |
| `GlobalCoroutine StartCoroutineGlobal(MonoBehaviour _, IEnumerator coroutine, Action onComplete, string description, string callerFile, int32 callerLine)` | Runs the coroutine using `CoroutineUtility`, which means it won't be tied to a `MonoBehaviour` and will persist through scene close. |
| `void StopAllCoroutines()` | Stops all global coroutines. |
| `void StopCoroutine(GlobalCoroutine coroutine)` | Stops the coroutine. |
| `GlobalCoroutine Timer(Action action, TimeSpan interval, string description, string callerFile, int32 callerLine, string callerName)` | Runs the action every interval. |
| `GlobalCoroutine TimerRealtime(Action action, TimeSpan interval, string callerFile, int32 callerLine, string callerName)` | Runs the action every interval. Using unscaled time. |
| `IEnumerator WaitAll(Func<IEnumerator>[] coroutines)` | Wait for all coroutines to complete. |
| `IEnumerator WaitAll(string description, Func<IEnumerator>[] coroutines)` | Wait for all coroutines to complete. |
| `IEnumerator WaitAll(IEnumerable<Func<IEnumerator>> coroutines, Func<boolean> isCancelled, string description)` | Wait for all coroutines to complete. |
| `IEnumerator WaitAll(GlobalCoroutine[] coroutines)` | Wait for all coroutines to complete. |
| `IEnumerator WaitAll(GlobalCoroutine[] coroutines, Func<boolean> isCancelled)` | Wait for all coroutines to complete. |