## DiscoverableAttribute

`abstract class` in `AdvancedSceneManager.Utility.Discoverability`  /  Inherits from: `Attribute`### Description
Represents the base attribute for discoverable attributes.

### Properties

| Member | Description |
|--------|-------------|
| `string friendlyDescription` | Specifies the description to be shown in the diag UI tooltip. |
| `TargetInfo target` | Specifies what the target should look like. |

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerable<DiscoveredMember> Enumerate<T>()` | _No documentation available._ |
| `IEnumerable<ValueTuple<T, T2>> Enumerate<T, T2>()` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual boolean IsValidTarget(MemberInfo member)` | Gets if `member` is a valid target for this attribute callback. |
| `virtual void LogError(MemberInfo member, string message)` | Logs an error to console. Uses a standard template. |