## DependencyInjectionUtility

`static class` in `AdvancedSceneManager.DependencyInjection`### Description
Provides utility methods and accessors for dependency injection within ASM.

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerable<ValueTuple<Type, IInjectable>> EnumerateServices()` | Enumerates all currently registered injectable services. |
| `T GetService<T>()` | _No documentation available._ |
| `IInjectable GetService(Type type)` | Gets a service matching the specified type. |
| `IEnumerable<T> GetServices<T>()` | _No documentation available._ |
| `void Remove<T>(Type type, T service)` | _No documentation available._ |