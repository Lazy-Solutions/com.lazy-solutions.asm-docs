## GuidReferenceUtility

`class` in `AdvancedSceneManager.Utility`### Description
An utility for referencing objects globally.

### Static Methods

| Member | Description |
|--------|-------------|
| `string Add(GameObject obj)` | Adds a persistent reference to this `GameObject`. |
| `GuidReference Find(string id)` | Finds a reference if it exists. |
| `string GenerateID()` | Generates an id. |
| `string GetOrAddPersistent(GameObject obj)` | Adds a persistent reference to this `GameObject`. |
| `boolean HasReference(string id)` | Gets if reference exists. |
| `boolean IsRegistered(GuidReference reference)` | Gets if reference exists. |
| `void Remove(GameObject obj, boolean saveScene)` | Removes a persistent reference to this `GameObject`. |
| `boolean TryFind(string id, GuidReference& obj)` | _No documentation available._ |