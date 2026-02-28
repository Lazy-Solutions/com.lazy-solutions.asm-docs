## ASMModelBase

`abstract class` in `AdvancedSceneManager.Models.Internal`  /  Inherits from: `ScriptableObject`### Description
A base class for `Profile`, `SceneCollection` and `Scene`.

### Properties

| Member | Description |
|--------|-------------|
| `string id` | Gets the id of this `ASMModelBase`. |
| `boolean isHidden` | Specifies if this ASM asset is hidden. If it is, it won't show up in UI, and won't be enumerated when using `assets`. |
| `string name` | Gets the name of this model. |

### Events

| Member | Description |
|--------|-------------|
| `event Action onDestroy` | Called when object is destroyed. |
| `event PropertyChangedEventHandler PropertyChanged` | Called when a property changes. |

### Static Methods

| Member | Description |
|--------|-------------|
| `string GenerateID()` | Generate id. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual boolean IsMatch(string q)` | Determines whether the specified query matches this model. |
| `virtual void OnDestroy()` | Called when this object is destroyed. |
| `virtual void OnPropertyChanged(string propertyName)` | Invoke `PropertyChanged`. |
| `virtual void OnValidate()` | _No documentation available._ |
| `virtual void Save()` | Saves the singleton to disk after a delay. |
| `void SaveNow()` | Saves the singleton to disk. |
| `void SaveNow(boolean setDirty)` | Saves the singleton to disk. |