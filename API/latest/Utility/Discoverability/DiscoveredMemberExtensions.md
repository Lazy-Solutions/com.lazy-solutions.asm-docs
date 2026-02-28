## DiscoveredMemberExtensions

`static class` in `AdvancedSceneManager.Utility.Discoverability`

### Description
Provides extension methods for DiscoveredMember.

### Static Methods

| Member | Description |
|--------|-------------|
| `bool As&lt;TAttribute, TMember&gt;(DiscoveredMember discoveredMember, out TAttribute attribute, out TMember member)` | Gets the discoverable as `TAttribute` and `TMember`, if possible. |
| `IEnumerable&lt;ValueTuple&lt;TAttribute, TMember&gt;&gt; OfType&lt;TAttribute, TMember&gt;(IEnumerable&lt;DiscoveredMember&gt; discoveredMember)` | Gets the discoverables of type `TAttribute` and `TMember`. |