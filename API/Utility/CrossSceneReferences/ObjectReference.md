## ObjectReference

`class` in `AdvancedSceneManager.Utility.CrossSceneReferences`### Description
A reference to an object in a scene.

### Properties

| Member | Description |
|--------|-------------|
| `Scene asmScene` | _No documentation available._ |
| `boolean isTargetingComponent` | _No documentation available._ |
| `boolean isTargetingField` | _No documentation available._ |

### Fields

| Member | Description |
|--------|-------------|
| `string componentType` | _No documentation available._ |
| `int32 componentTypeIndex` | _No documentation available._ |
| `string field` | _No documentation available._ |
| `string fieldType` | _No documentation available._ |
| `int32 index` | _No documentation available._ |
| `boolean isTargetingArray` | _No documentation available._ |
| `boolean isTargetingUnityEvent` | _No documentation available._ |
| `string objectID` | _No documentation available._ |
| `string scene` | _No documentation available._ |

### Static Methods

| Member | Description |
|--------|-------------|
| `void ResetValue(ResolvedReference variable)` | _No documentation available._ |
| `ResolveStatus SetValue(ResolvedReference variable, ResolvedReference value)` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `ValueTuple<string, string, string, int32, string, int32, boolean, ValueTuple<boolean>> AsTuple()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(ObjectReference x, ObjectReference y)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `int32 GetHashCode(ObjectReference obj)` | _No documentation available._ |
| `boolean IsValid(boolean returnTrueWhenSceneIsUnloaded)` | Returns true if the reference is still valid. |
| `ResolvedReference Resolve()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |
| `string ToString(boolean includeScene, boolean includeGameObject)` | _No documentation available._ |
| `ObjectReference With(Component component)` | Adds data about a component. |
| `ObjectReference With(Nullable<int32> unityEventIndex, Nullable<int32> arrayIndex)` | Adds data about an unity event. |