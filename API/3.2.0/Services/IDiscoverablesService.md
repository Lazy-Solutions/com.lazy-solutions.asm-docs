## IDiscoverablesService

`interface` in `AdvancedSceneManager.Services`

### Description
A service that manages discoverables, types or members decorated with a subclass of `[Discoverability.DiscoverableAttribute]`, like `[UnityEditor.InitializeOnLoadAttribute]`.

<b> Remarks:</b>
Allows for centralized management, optimized discovery, and caching.

### Methods

| Member | Description |
|--------|-------------|
| `bool Find(string identifier, out DiscoveredMember? discoverable)` | Finds the discovered member with the specified `identifier`. |
| `bool GetDiscoverable&lt;T&gt;(out DiscoveredMember? discoverable)` | Gets `T` as a discoverable, assuming its a valid discoverable. |
| `bool GetDiscoverable&lt;T, TAttribute&gt;(out DiscoveredMember? discoverable)` | Gets `T` as a discoverable, assuming its a valid discoverable of type `TAttribute`. |
| `bool GetDiscoverable(Expression&lt;Func&lt;object&gt;&gt; expression, out DiscoveredMember? discoverable)` | Gets expression as a discoverable. |
| `bool GetDiscoverable&lt;TAttribute&gt;(Expression&lt;Func&lt;object&gt;&gt; expression, out DiscoveredMember? discoverable)` | Gets expression as a discoverable, assuming its a valid discoverable of type `TAttribute`. |
| `IEnumerable&lt;DiscoveredMember&gt; GetInstanceMembersOn&lt;TDiscoverable&gt;(Type type)` | Gets all instance decorated with `TDiscoverable` on `type`. |
| `IEnumerable&lt;DiscoveredMember&gt; GetMembers()` | Get members decorated with the specified attribute. |
| `IEnumerable&lt;DiscoveredMember&gt; GetMembers&lt;T&gt;()` | Get members decorated with the specified attribute. |
| `IEnumerable&lt;DiscoveredMember&gt; GetStaticMembersOn&lt;TDiscoverable&gt;(Type type)` | Gets all static members decorated with `TDiscoverable` on `type`. |
| `void InvalidateCache()` | Invalidates the discoverable cache. |