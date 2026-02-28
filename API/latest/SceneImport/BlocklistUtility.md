## BlocklistUtility

`static class` in `AdvancedSceneManager.SceneImport`

### Description
Provides utility functions for managing blocklists.

### Static Properties

| Member | Description |
|--------|-------------|
| `Blocklist blacklist` | Gets the blacklist that ASM uses to determine scenes available for import. |
| `Blocklist whitelist` | Gets the whitelist that ASM uses to determine scenes available for import. |

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerable&lt;string&gt; EnumerateDiscoverableBlacklistPaths()` | Enumerates all discoverable blacklist paths. |
| `void EnumerateDiscoverableBlocklist(out IEnumerable&lt;string&gt; blacklist, out IEnumerable&lt;string&gt; whitelist)` | Enumerates all discoverable blocklist paths. |
| `IEnumerable&lt;string&gt; EnumerateDiscoverableWhitelistPaths()` | Enumerates all discoverable whitelist paths. |
| `bool IsBlacklisted(string path)` | Gets whatever the path is blacklisted. |
| `bool IsWhitelisted(string path)` | Gets whatever the path is whitelisted. |