## ProfileDependent`1

`class` in `AdvancedSceneManager.Models.Utility`  /  Inherits from: `ScriptableObject`### Description
Specifies a `T` that changes depending on active `Profile`.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isValid` | Gets if the current state of this `T` is valid. |

### Fields

| Member | Description |
|--------|-------------|
| `Dict<T> list` | The list of proxies for this `T`. |

### Methods

| Member | Description |
|--------|-------------|
| `T2 DoAction<T2>(Func<T, T2> action)` | _No documentation available._ |
| `void DoAction(Action<T> action)` | _No documentation available._ |
| `boolean GetModel(T& scene)` | _No documentation available._ |
| `T GetModel()` | Gets the selected scene. |