## SceneObjectReferenceCache

`class` in `AdvancedSceneManager.Utility`  /  Inherits from: `MonoBehaviour`### Description
Represents a in-scene cache for game objects. Enables fast lookup, instead of scanning heirarchy.

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerable<ValueTuple<string, object>> Enumerate(Scene scene)` | Enumerates all cached references. |
| `boolean Get(Scene scene, string key, Object& obj)` | _No documentation available._ |
| `void Remove(Scene scene, string key)` | Removes a cached reference. |
| `void Set(Scene scene, string key, object obj)` | Set the object to cache. |