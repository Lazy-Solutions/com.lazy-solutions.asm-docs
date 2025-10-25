## ILockable

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Specifies a object that can be locked, using `LockUtility`.

<b> Remarks:</b>
Available, but no effect in build.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isLocked` | Gets if this `ILockable` is locked. |
| `string lockMessage` | Gets or sets the message to be displayed when unlocking this `ILockable`. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void Save()` | Saves this `ILockable`. |