## Blocklist

`class` in `AdvancedSceneManager.Models`### Description
Represents a blocklist.

### Properties

| Member | Description |
|--------|-------------|
| `int32 count` | Gets how many paths are added to this blocklist. |
| `string Item` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void Add(string path)` | Adds `path` to blocklist. |
| `void Change(int32 i, string newPath)` | Changes the path at the specified index in this blocklist. |
| `boolean Contains(string path)` | Gets if this blocklist contains `path`. |
| `IEnumerable<string> Enumerate()` | Enumerates the paths are added to this blocklist. |
| `boolean Get(int32 index, String& path)` | _No documentation available._ |
| `boolean MatchesFilter(string path)` | Gets if `path` matches this blocklist. |
| `boolean MatchesFilter(string path, IEnumerable<string> list)` | Gets if `path` matches this blocklist. |
| `void Remove(string path)` | Removes `path` from this blocklist. |
| `void RemoveAt(int32 index)` | Removes the entry at `index` from this blocklist. |