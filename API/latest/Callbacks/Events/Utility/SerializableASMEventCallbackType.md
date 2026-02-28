## SerializableASMEventCallbackType

`class` in `AdvancedSceneManager.Callbacks.Events.Utility`### Description
Represents a serializable event callback type.

<b> Remarks:</b>
Provides [SceneOperationEventBase})](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.callbacks.events.utility.serializableasmeventcallbacktype.registercallback(system.string,advancedscenemanager.core.sceneoperation,advancedscenemanager.callbacks.events.eventcallback{advancedscenemanager.callbacks.events.sceneoperationeventbase})) for easily registering the callback.
            
Also provides a property drawer.

### Fields

| Member | Description |
|--------|-------------|
| `string typeName` | The `AssemblyQualifiedName`. |
| `When when` | Represents when this event is to be called. |

### Methods

| Member | Description |
|--------|-------------|
| `boolean IsValid()` | Gets if this event callback type is valid. |
| `void RegisterCallback(string key, SceneOperation operation, EventCallback<SceneOperationEventBase> callback)` | Register callback on `operation`. |
| `void RegisterGlobalCallback(string key, EventCallback<EventCallbackBase> callback)` | Register callback globally. |
| `virtual string ToString()` | _No documentation available._ |
| `SceneOperation UnregisterCallback(string key, SceneOperation operation)` | Unregisters the callback on `operation`. |
| `void UnregisterGlobalCallback(string key)` | Unregisters the callback globally. |