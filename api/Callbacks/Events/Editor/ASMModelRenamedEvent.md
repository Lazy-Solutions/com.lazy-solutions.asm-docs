## ASMModelRenamedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when an ASM model is renamed.

### Properties

| Member | Description |
|--------|-------------|
| `ASMModelBase model` | The model that was renamed. |
| `string newName` | The new name of the model. |
| `string oldName` | The previous name of the model. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(ASMModelBase& model, String& oldName, String& newName)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(ASMModelRenamedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |