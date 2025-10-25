## EventCallbackUtility

`static class` in `AdvancedSceneManager.Callbacks.Events`### Description
Provides utility functions for working with event callbacks.

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerable<Type> GetCallbackTypes()` | Enumerates all callback types. |
| `int32 GetInvokationOrder<TEventType>()` | _No documentation available._ |
| `int32 GetInvokationOrder(Type type)` | Gets the invokation order of the event callback type. |
| `boolean IsWhenApplicable<TEventType>()` | _No documentation available._ |
| `boolean IsWhenApplicable(Type type)` | Gets if the specified callback event uses `When` enum. |
| `SceneOperation RegisterAllCallbacks(string key, SceneOperation operation, EventCallback<EventCallbackBase> callback, When when)` | Registers callback for all events. |
| `void RegisterAllCallbacksGlobal(string key, EventCallback<EventCallbackBase> callback, When when)` | Registers callback for all events. |
| `SceneOperation UnregisterCallback(string key, SceneOperation operation)` | Unregisters callback using `key`. |
| `void UnregisterCallbackGlobal(string key)` | Unregisters callback using `key`. |