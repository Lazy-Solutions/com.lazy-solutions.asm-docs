## ObjectReference

`class` in `AdvancedSceneManager.Utility.CrossSceneReferences`### Description
Represents a reference to an object within a scene.

### Properties

| Member | Description |
|--------|-------------|
| `Scene asmScene` | Gets the corresponding ASM scene, if found. |
| `boolean isTargetingComponent` | Returns whether this reference targets a component. |
| `boolean isTargetingField` | Returns whether this reference targets a field. |

### Fields

| Member | Description |
|--------|-------------|
| `string componentType` | The assembly-qualified name of the referenced component type. |
| `int32 componentTypeIndex` | The index of the component within its GameObject. |
| `string field` | The name of the referenced field, if applicable. |
| `string fieldType` | The assembly-qualified type name of the referenced field. |
| `int32 index` | The element index if targeting an array or UnityEvent. |
| `boolean isTargetingArray` | Whether this reference targets an array element. |
| `boolean isTargetingUnityEvent` | Whether this reference targets a UnityEvent entry. |
| `string objectID` | The unique object identifier of the referenced object. |
| `string scene` | The path of the scene this reference belongs to. |

### Static Methods

| Member | Description |
|--------|-------------|
| `void ResetValue(ResolvedReference variable)` | Resets the referenced value. |
| `ResolveStatus SetValue(ResolvedReference variable, ResolvedReference value)` | Sets the referenced value to another resolved reference. |

### Methods

| Member | Description |
|--------|-------------|
| `ValueTuple<string, string, string, int32, string, int32, boolean, ValueTuple<boolean>> AsTuple()` | Returns a tuple representation of this reference. |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(ObjectReference x, ObjectReference y)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `int32 GetHashCode(ObjectReference obj)` | _No documentation available._ |
| `boolean IsValid(boolean returnTrueWhenSceneIsUnloaded)` | Returns whether this reference is still valid. |
| `ResolvedReference Resolve()` | Resolves this reference to its target. |
| `virtual string ToString()` | _No documentation available._ |
| `string ToString(boolean includeScene, boolean includeGameObject)` | Returns a string representation of this reference. |
| `ObjectReference With(Component component)` | Adds data about a component to this reference. |
| `ObjectReference With(Nullable<int32> unityEventIndex, Nullable<int32> arrayIndex)` | Adds array or UnityEvent index data to this reference. |