## DependencyInjectionUtility

`static class` in `AdvancedSceneManager.DependencyInjection`

### Description
Provides utility methods and accessors for dependency injection within ASM.

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerable&lt;(Type, DependencyInjectionUtility.IInjectable)&gt; EnumerateServices()` | Enumerates all currently registered injectable services. |
| `T GetService&lt;T&gt;()` | Gets a service of the specified type. |
| `DependencyInjectionUtility.IInjectable GetService(Type type)` | Gets a service matching the specified type. |
| `IEnumerable&lt;T&gt; GetServices&lt;T&gt;()` | Gets all services assignable to the specified interface type. |
| `void Remove&lt;T&gt;(Type type, T service)` | Removes the specified service instance from the dependency list. |