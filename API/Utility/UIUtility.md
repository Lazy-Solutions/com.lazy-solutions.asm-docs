## UIUtility

`static class` in `AdvancedSceneManager.Utility`### Description
Provides utility methods for working with `VisualElement`.

### Static Methods

| Member | Description |
|--------|-------------|
| `Awaitable AsTask(IVisualElementScheduledItem scheduledItem)` | _No documentation available._ |
| `IVisualElementScheduledItem Fade(VisualElement view, single to, single duration, Action onComplete)` | Fades the element. |
| `VisualElementScheduledItemAwaiter GetAwaiter(IVisualElementScheduledItem scheduledItem)` | _No documentation available._ |
| `void Hide(VisualElement element, boolean fade)` | Hides the element using `None`. |
| `boolean IsVisible(VisualElement element)` | Gets `DisplayStyle` is `Flex`. |
| `void SetVisible(VisualElement element, boolean visible)` | Sets `DisplayStyle` based on `visible`. |
| `void Show(VisualElement element, boolean fade)` | Shows the element using `Flex`. |