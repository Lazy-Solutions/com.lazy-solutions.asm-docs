## MainThreadUtility

`static class` in `AdvancedSceneManager.Utility`### Description
An utility for running actions on the main thread.

Only usable in play mode.

### Static Properties

| Member | Description |
|--------|-------------|
| `boolean isEnabled` | Gets whatever `MainThreadUtility` is enabled, set to `false` in source code to disable. |
| `boolean isOnMainThread` | Gets if the thread we're currently on is the main thread. |
| `boolean IsRunning` | Gets if main thread utility is running. |

### Static Methods

| Member | Description |
|--------|-------------|
| `T Invoke<T>(Func<T> func)` | _No documentation available._ |
| `void Invoke(Action action)` | Queues the action to be run on the main thread, during the next frame. |
| `T Invoke<T>(Func<T> func, boolean mainThread)` | _No documentation available._ |
| `void Invoke(Action action, boolean mainThread)` | Invokes the `action`. |
| `void Start()` | Starts main thread utility coroutine. |
| `void Stop()` | Stops main thread utility coroutine. |