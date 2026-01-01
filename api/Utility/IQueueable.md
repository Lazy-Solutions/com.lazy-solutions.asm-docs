## IQueueable

`interface` in `AdvancedSceneManager.Utility`### Description
Represents a queueable item.

<b> Remarks:</b>
See also `QueueUtility`1`.

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual boolean CanQueue()` | Called to make sure the item can actually be queued. |
| `abstract virtual void OnCancel()` | Called when queueable is cancelled. |
| `abstract virtual void OnTurn(Action onComplete)` | Called when it is this queueables turn. |