## QueueUtility`1

`static class` in `AdvancedSceneManager.Utility`### Description
A utility that provides queuing.

### Static Properties

| Member | Description |
|--------|-------------|
| `boolean isBusy` | Gets whatever any items in the queue are running. |
| `IEnumerable<T> queue` | Gets the items currently in queue. |
| `IEnumerable<T> running` | Gets the items that are currently running. |

### Static Events

| Member | Description |
|--------|-------------|
| `event Action queueEmpty` | Occurs when an queued item finishes and queue is empty. |
| `event Action queueFilled` | Occurs when an queued is added. |

### Static Methods

| Member | Description |
|--------|-------------|
| `boolean IsQueued(T queueable)` | _No documentation available._ |
| `boolean IsRunning(T queueable)` | _No documentation available._ |
| `void Stop(T queueable)` | _No documentation available._ |
| `void StopAll()` | Cancels all queued and running items. |