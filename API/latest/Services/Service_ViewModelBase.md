## Service\_ViewModelBase

`abstract class` in `AdvancedSceneManager.Services`

### Description
Shared base class for services and view models.

### Methods

| Member | Description |
|--------|-------------|
| `void RegisterEvent&lt;T&gt;(EventCallback&lt;T&gt; callback)` | Registers an event callback that is automatically unregistered when view is removed. |
| `void UnregisterEvent&lt;T&gt;(EventCallback&lt;T&gt; callback)` | Unregisters an event callback. |