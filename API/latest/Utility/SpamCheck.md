## SpamCheck

`class` in `AdvancedSceneManager.Utility`### Description
Provides an easy way to check for spamming.

### Static Properties

| Member | Description |
|--------|-------------|
| `SpamCheck Global` | Gets the global spam check. |

### Properties

| Member | Description |
|--------|-------------|
| `single executeCooldown` | Gets or sets the cooldown. |
| `boolean isEnabled` | Gets or sets if this `SpamCheck` is enabled. |
| `single lastExecute { get; }` | Gets the time an action was executed last. |
| `single timeSinceLastExecute` | Gets the time an action was executed last. |

### Methods

| Member | Description |
|--------|-------------|
| `void Execute(Action action)` | Runs action if allowed. |
| `boolean IsSpam()` | Gets if an action was executed not long enough ago. |
| `void MarkAsExecuted()` | Marks this spam check as executed, disallowing any actions until cooldown has run out. |