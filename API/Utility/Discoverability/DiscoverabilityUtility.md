## DiscoverabilityUtility

`static class` in `AdvancedSceneManager.Utility.Discoverability`### Description
Provides utility methods for dealing and managing discoverables, a centralized attribute callback system.

### Static Properties

| Member | Description |
|--------|-------------|
| `boolean isInitialized { get; }` | Gets if discoverables has been initialized. |

### Static Methods

| Member | Description |
|--------|-------------|
| `boolean As<TAttribute, TMember>(DiscoveredMember discoveredMember, TAttribute& attribute, TMember& member)` | _No documentation available._ |
| `IEnumerable<DiscoveredMember> GetMembers()` | Get members decorated with the specified attribute. |
| `IEnumerable<DiscoveredMember> GetMembers<T>()` | Get members decorated with the specified attribute. |
| `void Invoke<T>(object[] parameters)` | _No documentation available._ |
| `IEnumerable<ValueTuple<TAttribute, TMember>> OfType<TAttribute, TMember>(IEnumerable<DiscoveredMember> discoveredMember)` | _No documentation available._ |