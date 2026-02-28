## ResolveStatus

`enum` in `AdvancedSceneManager.Utility.CrossSceneReferences`  /  Inherits from: `Enum`### Description
Specifies the result of a resolve.

### Static Fields

| Member | Description |
|--------|-------------|
| `ResolveStatus ComponentNotFound` | The referenced component could not be found. |
| `ResolveStatus IndexOutOfRange` | The referenced array or event index was out of range. |
| `ResolveStatus InvalidField` | The referenced field could not be found. |
| `ResolveStatus InvalidObjectPath` | The object path was invalid or could not be found. |
| `ResolveStatus SceneIsNotOpen` | The referenced scene is not currently open. |
| `ResolveStatus Succeeded` | The reference was successfully resolved. |
| `ResolveStatus TypeMismatch` | The resolved value type does not match the expected type. |
| `ResolveStatus Unknown` | An unknown error occurred during resolution. |
| `ResolveStatus Unresolved` | The reference has not been resolved yet. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |