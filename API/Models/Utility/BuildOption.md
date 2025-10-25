## BuildOption

`class` in `AdvancedSceneManager.Models.Utility`### Description
Represents an enabled state depending on build context (editor, dev build, non-dev build).

### Properties

| Member | Description |
|--------|-------------|
| `boolean enableInDevBuild` | Gets whatever we should be enabled in dev build. |
| `boolean enableInEditor` | Gets whatever we should be enabled in editor. |
| `boolean enableInNonDevBuild` | Gets whatever we should be enabled in non-dev build. |

### Events

| Member | Description |
|--------|-------------|
| `event PropertyChangedEventHandler PropertyChanged` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `boolean GetIsEnabledInCurrentContext()` | Get whatever we should be enabled in the current context. |