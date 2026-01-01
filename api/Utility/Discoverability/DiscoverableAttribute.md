## DiscoverableAttribute

`abstract class` in `AdvancedSceneManager.Utility.Discoverability`  /  Inherits from: `Attribute`### Description
Represents the base attribute for discoverable attributes.

### Properties

| Member | Description |
|--------|-------------|
| `string friendlyDescription` | Specifies the description to be shown in the diag UI tooltip. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual boolean IsValidTarget(MemberInfo member)` | Gets if `member` is a valid target for this attribute callback. |
| `virtual void LogError(MemberInfo member, string message)` | Logs an error to console. Uses a standard template. |