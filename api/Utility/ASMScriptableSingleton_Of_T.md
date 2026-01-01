## ASMScriptableSingleton`1

`abstract class` in `AdvancedSceneManager.Utility`  /  Inherits from: `ScriptableSingleton<T>`### Description
A `ScriptableSingleton`1` that supports build.

### Properties

| Member | Description |
|--------|-------------|
| `boolean editorOnly` | Specifies that build support will not be applied to this `ScriptableSingleton`1`. |
| `SerializedObject serializedObject` | Gets a cached `SerializedObject` for this `ScriptableSingleton`1`. |

### Events

| Member | Description |
|--------|-------------|
| `event PropertyChangedEventHandler PropertyChanged` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void OnPropertyChanged(string propertyName)` | _No documentation available._ |
| `virtual void OnValidate()` | _No documentation available._ |
| `virtual void Save()` | Saves the singleton to disk after a delay. |
| `virtual void SaveNow()` | Saves the singleton to disk. |