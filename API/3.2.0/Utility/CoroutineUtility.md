## CoroutineUtility

`static class` in `AdvancedSceneManager.Utility`

### Description
An utility class that helps with running coroutines detached from `UnityEngine.MonoBehaviour`.

### Static Properties

| Member | Description |
|--------|-------------|
| `IEnumerable&lt;GlobalCoroutine&gt; coroutines` | Gets all currently active coroutines. |

### Static Methods

| Member | Description |
|--------|-------------|
| `GlobalCoroutine Chain(Func&lt;IEnumerator&gt;\[\] coroutines)` | Runs the coroutines in sequence, wrapped in a single `Utility.GlobalCoroutine`. |
| `GlobalCoroutine Chain(Func&lt;IEnumerator&gt;\[\] coroutines, string description)` | Runs the coroutines in sequence, wrapped in a single `Utility.GlobalCoroutine`. |
| `GlobalCoroutine Chain(IEnumerable&lt;Func&lt;IEnumerator&gt;&gt; coroutines, string description)` | Runs the coroutines in sequence, wrapped in a single `Utility.GlobalCoroutine`. |
| `void Run(Action action, TimeSpan after, string description, string callerFile, int callerLine, string callerName)` | Runs the action after the specified time. |
| `void Run(Action action, float? after, bool nextFrame, Func&lt;bool&gt; when, string description, string callerFile, int callerLine, string callerName)` | Runs the action after the specified time. |
| `GlobalCoroutine StartCoroutine(IEnumerator coroutine, Action onComplete, string description, string callerFile, int callerLine)` | Runs the coroutine using `Utility.CoroutineUtility`, which means it won't be tied to a `UnityEngine.MonoBehaviour` and will persist through scene close. |
| `GlobalCoroutine StartCoroutineGlobal(MonoBehaviour \_, IEnumerator coroutine, Action onComplete, string description, string callerFile, int callerLine)` | Runs the coroutine using `Utility.CoroutineUtility`, which means it won't be tied to a `UnityEngine.MonoBehaviour` and will persist through scene close. |
| `void StopAllCoroutines()` | Stops all global coroutines. |
| `void StopCoroutine(GlobalCoroutine coroutine)` | Stops the coroutine. |
| `GlobalCoroutine Timer(Action action, TimeSpan interval, string description, string callerFile, int callerLine, string callerName)` | Runs the action every interval. |
| `GlobalCoroutine TimerRealtime(Action action, TimeSpan interval, string callerFile, int callerLine, string callerName)` | Runs the action every interval. Using unscaled time. |
| `IEnumerator WaitAll(Func&lt;IEnumerator&gt;\[\] coroutines)` | Wait for all coroutines to complete. |
| `IEnumerator WaitAll(string description, Func&lt;IEnumerator&gt;\[\] coroutines)` | Wait for all coroutines to complete. |
| `IEnumerator WaitAll(IEnumerable&lt;Func&lt;IEnumerator&gt;&gt; coroutines, Func&lt;bool&gt; isCancelled, string description)` | Wait for all coroutines to complete. |
| `IEnumerator WaitAll(GlobalCoroutine\[\] coroutines)` | Wait for all coroutines to complete. |
| `IEnumerator WaitAll(GlobalCoroutine\[\] coroutines, Func&lt;bool&gt; isCancelled)` | Wait for all coroutines to complete. |