## EventCallbackManager`1

`class` in `AdvancedSceneManager.Callbacks.Events`### Description
Manages event callbacks.

<b> Remarks:</b>
You probably want to use either `events` or `events`.

### Methods

| Member | Description |
|--------|-------------|
| `IEnumerator InvokeCallback<TEventType>(When when, string callerFile, int32 callerLine)` | _No documentation available._ |
| `IEnumerator InvokeCallback<TEventType>(TEventType e, When when, string callerFile, int32 callerLine)` | _No documentation available._ |
| `void InvokeCallbackSync<TEventType>(When when)` | _No documentation available._ |
| `void InvokeCallbackSync<TEventType>(TEventType e, When when)` | _No documentation available._ |
| `void RegisterCallback<TEventType>(EventCallback<TEventType> callback, When when, string key)` | _No documentation available._ |
| `void UnregisterCallback(string key)` | Unregisters a previously registered event callback. |
| `void UnregisterCallback<TEventType>(EventCallback<TEventType> callback, When when, string key)` | _No documentation available._ |