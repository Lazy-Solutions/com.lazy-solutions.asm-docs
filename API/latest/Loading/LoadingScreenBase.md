## LoadingScreenBase

`abstract class` in `AdvancedSceneManager.Loading`  /  Inherits from: `MonoBehaviour`### Description
A generic base class for loading screens. You probably want to inherit from `LoadingScreen` though.

<b> Remarks:</b>
When multiple loading screens exist within the same scene, only the first found one will be used.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isClosing { get; }` | Gets whatever we're currently closing. |
| `boolean isOpen { get; }` | Gets whatever we're currently open. |
| `boolean isOpening { get; }` | Gets whatever we're currently opening. |

### Fields

| Member | Description |
|--------|-------------|
| `Canvas canvas` | The canvas that this loading screen uses.

This will automatically register canvas with `CanvasSortOrderUtility`, to automatically manage canvas sort order. |

### Methods

| Member | Description |
|--------|-------------|
| `boolean HasPressedAnyKey()` | Gets if any key has been pressed this frame. |
| `abstract virtual IEnumerator OnClose()` | Called when the loading screen is about to close. |
| `abstract virtual IEnumerator OnOpen()` | Called when the loading screen is opened. |
| `virtual void OnProgressChanged(ILoadProgressData progress)` | Called when progress changes for the associated scene operation. |
| `WaitUntil WaitForAnyKey()` | Returns `WaitUntil` that waits for user to press any key. |