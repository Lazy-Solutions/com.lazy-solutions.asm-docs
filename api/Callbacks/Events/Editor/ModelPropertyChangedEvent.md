## ModelPropertyChangedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when an ASM model property changes. This is the same as `INotifyPropertyChanged`.

<b> Remarks:</b>
`Empty` will be used when `INotifyPropertyChanged` is called from `onvalidate`.

### Properties

| Member | Description |
|--------|-------------|
| `ASMModelBase model` | The model had a property changed. |
| `string propertyName` | The name of the property that changed. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(ASMModelBase& model, String& propertyName)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(ModelPropertyChangedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |