## IServiceContainer

`interface` in `AdvancedSceneManager.Services`### Description
A container for managing services and DI.

<b> Remarks:</b>
Accessible via:

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual IEnumerable<TService> Find<TService>()` | _No documentation available._ |
| `abstract virtual TService Get<TService>()` | _No documentation available._ |
| `abstract virtual IReadOnlyDictionary<Type, object> GetAll()` | Gets all registered services. |
| `abstract virtual boolean IsResolvable(MemberInfo member, boolean static)` | Determines whether the DI system can invoke the specified method or constructor, automatically injecting parameters as necessary. |
| `abstract virtual void Register<TService>(TService service)` | _No documentation available._ |
| `abstract virtual void Register<TService>()` | _No documentation available._ |
| `abstract virtual void Register<TService, TImplementation>()` | _No documentation available._ |
| `abstract virtual void Register<TService, TImplementation>(TImplementation service)` | _No documentation available._ |
| `abstract virtual void Resolve<T>(T obj)` | _No documentation available._ |
| `abstract virtual boolean TryInvoke(MemberInfo member, Exception& exception, object[] parameters)` | _No documentation available._ |
| `abstract virtual boolean TryInvoke<T>(MemberInfo member, T& returnValue, Exception& exception, object[] parameters)` | _No documentation available._ |
| `abstract virtual boolean TryInvoke(MemberInfo member)` | Attempts to invoke the specified member without parameters. |
| `abstract virtual void Unregister<T>()` | _No documentation available._ |
| `abstract virtual void Unregister(Type type)` | Unregisters a service by type. |
| `abstract virtual void Unregister<T>(T service)` | _No documentation available._ |