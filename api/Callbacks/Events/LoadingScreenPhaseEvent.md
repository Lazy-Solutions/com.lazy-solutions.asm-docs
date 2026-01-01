## LoadingScreenPhaseEvent

`abstract class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `SceneOperationEventBase`### Description
The base class for loading screen phase event callbacks.

<b> Remarks:</b>
See `LoadingScreenOpenPhaseEvent`, `LoadingScreenClosePhaseEvent`.

### Properties

| Member | Description |
|--------|-------------|
| `Scene loadingScene` | _No documentation available._ |
| `LoadingScreen openedLoadingScreen` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(Scene& loadingScene, LoadingScreen& openedLoadingScreen)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(SceneOperationEventBase other)` | _No documentation available._ |
| `virtual boolean Equals(LoadingScreenPhaseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |