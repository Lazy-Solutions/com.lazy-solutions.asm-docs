## ProfileDependent&lt;T&gt;

`class` in `AdvancedSceneManager.Models.Utility`  /  Inherits from: `ScriptableObject`

### Description
Specifies a `T` that changes depending on active `Models.Profile`.

### Properties

| Member | Description |
|--------|-------------|
| `bool isValid` | Gets if the current state of this `T` is valid. |

### Fields

| Member | Description |
|--------|-------------|
| `ProfileDependent&lt;T&gt;.Dict&lt;T&gt; list` | The list of proxies for this `T`. |

### Methods

| Member | Description |
|--------|-------------|
| `T2 DoAction&lt;T2&gt;(Func&lt;T, T2&gt; action)` | Performs an action on the scene. |
| `void DoAction(Action&lt;T&gt; action)` | Performs an action on the scene. |
| `bool GetModel(out T scene)` | Gets the selected scene. |
| `T GetModel()` | Gets the selected scene. |