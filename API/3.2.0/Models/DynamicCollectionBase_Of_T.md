## DynamicCollectionBase`1

`abstract class` in `AdvancedSceneManager.Models`  /  Inherits from: `ASMModelBase`### Description
Base class for dynamic collections.

### Properties

| Member | Description |
|--------|-------------|
| `int32 count` | Gets the count of scenes or scene paths contained in this collection. |
| `string description` | Gets the description of this collection. |
| `boolean hasScenes` | Gets if this collection has any scenes. |
| `T Item` | _No documentation available._ |
| `Profile profile` | Gets the profile that contains this collection. Cached. |
| `IEnumerable<string> scenePaths` | Gets the scene paths contained in this collection. |
| `IEnumerable<T> scenes` | Gets the scenes or scene paths contained in this collection. |
| `string title` | Gets the title of this collection. |

### Methods

| Member | Description |
|--------|-------------|
| `boolean Contains(T scene)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(DynamicCollectionBase<T> other)` | _No documentation available._ |
| `boolean FindProfile(Profile& profile)` | _No documentation available._ |
| `Profile FindProfile()` | Finds the profile that contains this collection. |
| `IEnumerator<T> GetEnumerator()` | Gets an enumerator for the scenes or scene paths contained in this collection. |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual boolean IsMatch(string q)` | Matches this collection against the query string. |
| `virtual string ToString()` | Returns the title of this collection. |