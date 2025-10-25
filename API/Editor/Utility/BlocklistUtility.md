## BlocklistUtility

`static class` in `AdvancedSceneManager.Editor.Utility`### Description
Provides utility functions for managing blocklists.

### Static Properties

| Member | Description |
|--------|-------------|
| `Blocklist blacklist` | Gets the blacklist that ASM uses to determine scenes available for import. |
| `Blocklist whitelist` | Gets the whitelist that ASM uses to determine scenes available for import. |

### Static Methods

| Member | Description |
|--------|-------------|
| `boolean IsBlacklisted(string path)` | Gets whatever the path is blacklisted. |
| `boolean IsWhitelisted(string path)` | Gets whatever the path is whitelisted. |