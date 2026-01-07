## IDiscoverablesService

`interface` in `AdvancedSceneManager.Services`### Description
A service that manages discoverables, types or members decorated with a subclass of `[]`, like `[]`.

<b> Remarks:</b>
Allows for centralized management, optimized discovery, and caching.

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual boolean Find(string identifier, Nullable`1& discoverable)` | _No documentation available._ |
| `abstract virtual boolean GetDiscoverable<T>(Nullable`1& discoverable)` | _No documentation available._ |
| `abstract virtual boolean GetDiscoverable<T, TAttribute>(Nullable`1& discoverable)` | _No documentation available._ |
| `abstract virtual boolean GetDiscoverable(Expression<Func<object>> expression, Nullable`1& discoverable)` | _No documentation available._ |
| `abstract virtual boolean GetDiscoverable<TAttribute>(Expression<Func<object>> expression, Nullable`1& discoverable)` | _No documentation available._ |
| `abstract virtual IEnumerable<DiscoveredMember> GetMembers()` | Get members decorated with the specified attribute. |
| `abstract virtual IEnumerable<DiscoveredMember> GetMembers<T>()` | Get members decorated with the specified attribute. |
| `abstract virtual void InvalidateCache()` | Invalidates the discoverable cache. |
| `abstract virtual void Invoke<T>(object[] parameters)` | _No documentation available._ |