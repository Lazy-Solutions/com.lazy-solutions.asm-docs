## ResolvedReference

`struct` in `AdvancedSceneManager.Utility.CrossSceneReferences`  /  Inherits from: `ValueType`### Description
Represents a resolved `ObjectReference`.

### Fields

| Member | Description |
|--------|-------------|
| `Component component` | The resolved `Component`, if applicable. |
| `FieldInfo field` | The resolved `FieldInfo`, if applicable. |
| `GameObject gameObject` | The resolved `GameObject`, if applicable. |
| `boolean hasBeenRemoved` | Whether the reference target has been removed. |
| `int32 index` | The element index if targeting an array or event list. |
| `boolean isTargetingArray` | Whether the reference targets an array element. |
| `boolean isTargetingUnityEvent` | Whether the reference targets a UnityEvent entry. |
| `object resolvedTarget` | The resolved target object. |
| `ResolveStatus result` | The result of the resolution. |
| `Nullable<Scene> scene` | The scene containing the resolved object, if any. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual string ToString()` | _No documentation available._ |
| `string ToString(boolean includeScene, boolean includeGameObject)` | Returns a string representation of this reference. |