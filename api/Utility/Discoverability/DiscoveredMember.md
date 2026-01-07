## DiscoveredMember

`struct` in `AdvancedSceneManager.Utility.Discoverability`  /  Inherits from: `ValueType`### Description
A member that was found using `IDiscoverablesService`.

### Properties

| Member | Description |
|--------|-------------|
| `DiscoverableAttribute attribute { get; }` | Gets the attribute of this discoverable. |
| `boolean isValid` | Gets if this discovered member is valid. |
| `MemberInfo member { get; }` | Gets the member of this discoverable. |

### Static Methods

| Member | Description |
|--------|-------------|
| `string GetIdentifier(MemberInfo member)` | Gets an identifier that points to the found member. |

### Methods

| Member | Description |
|--------|-------------|
| `boolean Equals(DiscoveredMember other)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `string GetIdentifier()` | Gets an identifier that points to the found member. |
| `virtual string ToString()` | Gets a formatted string of this discoverable. |