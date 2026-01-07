## BlocklistUtility

`static class` in `AdvancedSceneManager.SceneImport`### Description
Provides utility functions for managing blocklists.

### Static Properties

| Member | Description |
|--------|-------------|
| `Blocklist blacklist` | Gets the blacklist that ASM uses to determine scenes available for import. |
| `Blocklist whitelist` | Gets the whitelist that ASM uses to determine scenes available for import. |

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerable<string> EnumerateDiscoverableBlacklistPaths()` | Enumerates all discoverable blacklist paths. |
| `void EnumerateDiscoverableBlocklist(IEnumerable`1& blacklist, IEnumerable`1& whitelist)` | _No documentation available._ |
| `IEnumerable<string> EnumerateDiscoverableWhitelistPaths()` | Enumerates all discoverable whitelist paths. |
| `boolean IsBlacklisted(string path)` | Gets whatever the path is blacklisted. |
| `boolean IsWhitelisted(string path)` | Gets whatever the path is whitelisted. |