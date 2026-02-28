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
| `abstract virtual void Register<TService>(TService service)` | _No documentation available._ |
| `abstract virtual void Register<TService>()` | _No documentation available._ |
| `abstract virtual void Register<TService, TImplementation>()` | _No documentation available._ |
| `abstract virtual void Register<TService, TImplementation>(TImplementation service)` | _No documentation available._ |
| `abstract virtual void Resolve(object obj)` | Resolves dependencies for the specified object. |
| `abstract virtual void Unregister<T>()` | _No documentation available._ |
| `abstract virtual void Unregister(Type type)` | Unregisters a service by type. |