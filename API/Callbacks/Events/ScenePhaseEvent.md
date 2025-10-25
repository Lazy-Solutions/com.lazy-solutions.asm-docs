## ScenePhaseEvent

`abstract class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `SceneOperationEventBase`### Description
The base class for scene phase event callbacks.

<b> Remarks:</b>
See `SceneClosePhaseEvent`, `SceneOpenPhaseEvent`, `ScenePreloadPhaseEvent`.

### Properties

| Member | Description |
|--------|-------------|
| `IEnumerable<Scene> scenes` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(IEnumerable`1& scenes)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(SceneOperationEventBase other)` | _No documentation available._ |
| `virtual boolean Equals(ScenePhaseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |