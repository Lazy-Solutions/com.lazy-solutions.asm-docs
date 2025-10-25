## CollectionDeletedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when a collection is deleted from a profile.

<b> Remarks:</b>
Hard delete, not recoverable. Happens after undo period.

### Properties

| Member | Description |
|--------|-------------|
| `ISceneCollection collection` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(ISceneCollection& collection)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(CollectionDeletedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |