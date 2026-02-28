## SessionStateHelper

`class` in `AdvancedSceneManager.Services`

### Description
A helper wrapper for `UnityEditor.SessionState`, uses type name + property name for naming.

### Methods

| Member | Description |
|--------|-------------|
| `T GetProperty&lt;T&gt;(T defaultValue, string propertyName)` | Gets a session wide persisted value. |
| `T GetValue&lt;T&gt;(T defaultValue, string propertyName)` | Gets a session wide persisted value. |
| `void SetProperty&lt;T&gt;(T value, string propertyName)` | Sets a session wide persisted value. |
| `void SetValue&lt;T&gt;(T value, string propertyName)` | Sets a session wide persisted value. |