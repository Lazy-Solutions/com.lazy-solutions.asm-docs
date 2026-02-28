## SceneBindingUtility

`static class` in `AdvancedSceneManager.Utility`### Description
Provides utility functions relating to scene bindings.

<b> Remarks:</b>
Only available if input system is installed.

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerable<ValueTuple<SceneCollection, Scene, InputBinding>> GetBindings()` | Gets all bindings in the project. |
| `boolean IsDuplicate(InputButton binding)` | Gets if the binding is assigned to multiple scenes / collections. |
| `boolean WasOpenedByBinding(SceneCollection collection)` | Gets if `collection` was opened by a binding. |
| `boolean WasOpenedByBinding(Scene scene)` | Gets if the scene was opened by a binding. |