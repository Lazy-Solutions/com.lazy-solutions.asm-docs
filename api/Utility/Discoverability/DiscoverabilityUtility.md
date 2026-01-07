## DiscoverabilityUtility

`static class` in `AdvancedSceneManager.Utility.Discoverability`### Description
Provides utility methods for dealing and managing discoverables, a centralized attribute callback system.

### Static Methods

| Member | Description |
|--------|-------------|
| `boolean As<TAttribute, TMember>(DiscoveredMember discoveredMember, TAttribute& attribute, TMember& member)` | _No documentation available._ |
| `boolean Find(string identifier, Nullable`1& discoverable)` | _No documentation available._ |
| `boolean GetDiscoverable<T>(Nullable`1& discoverable)` | _No documentation available._ |
| `boolean GetDiscoverable<T, TAttribute>(Nullable`1& discoverable)` | _No documentation available._ |
| `boolean GetDiscoverable(Expression<Func<object>> expression, Nullable`1& discoverable)` | _No documentation available._ |
| `boolean GetDiscoverable<TAttribute>(Expression<Func<object>> expression, Nullable`1& discoverable)` | _No documentation available._ |
| `IEnumerable<DiscoveredMember> GetMembers()` | Get members decorated with the specified attribute. |
| `IEnumerable<DiscoveredMember> GetMembers<T>()` | Get members decorated with the specified attribute. |
| `void InvalidateCache()` | Invalidates the discoverable cache. |
| `void Invoke<T>(object[] parameters)` | _No documentation available._ |
| `IEnumerable<ValueTuple<TAttribute, TMember>> OfType<TAttribute, TMember>(IEnumerable<DiscoveredMember> discoveredMember)` | _No documentation available._ |