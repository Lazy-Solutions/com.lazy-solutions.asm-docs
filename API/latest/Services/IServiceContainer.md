## IServiceContainer

`interface` in `AdvancedSceneManager.Services`

### Description
A container for managing services and DI.

<b> Remarks:</b>
Accessible via:

### Methods

| Member | Description |
|--------|-------------|
| `IEnumerable&lt;TService&gt; Find&lt;TService&gt;()` | Finds all services of the specified type. |
| `TService Get&lt;TService&gt;()` | Gets the service of the specified type. |
| `IReadOnlyDictionary&lt;Type, object&gt; GetAll()` | Gets all registered services. |
| `void Register&lt;TService&gt;(TService service)` | Registers a service instance. |
| `void Register&lt;TService&gt;()` | Registers a service type to be instantiated automatically. |
| `void Register&lt;TService, TImplementation&gt;()` | Registers a service type with its implementation type. |
| `void Register&lt;TService, TImplementation&gt;(TImplementation service)` | Registers a service type with its implementation instance. |
| `void Resolve(object obj)` | Resolves dependencies for the specified object. |
| `void Unregister&lt;T&gt;()` | Unregisters a service type. |
| `void Unregister(Type type)` | Unregisters a service by type. |