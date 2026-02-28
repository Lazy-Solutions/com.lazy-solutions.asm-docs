## FilteredEventProxy`1

`sealed class` in `AdvancedSceneManager.Callbacks.Events`### Description
Manages event callbacks, filtered for `TEventBase`.

<b> Remarks:</b>
You probably want to use either [String)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.models.scene.registercallback``1(advancedscenemanager.callbacks.events.eventcallback{``0},advancedscenemanager.callbacks.events.when,system.string)) or [String)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.models.scenecollection.registercallback``1(advancedscenemanager.callbacks.events.eventcallback{``0},advancedscenemanager.callbacks.events.when,system.string)).

### Methods

| Member | Description |
|--------|-------------|
| `void RegisterCallback<T>(EventCallback<T> callback, When when, string key)` | _No documentation available._ |
| `void UnregisterCallback<T>(EventCallback<T> callback, When when, string key)` | _No documentation available._ |