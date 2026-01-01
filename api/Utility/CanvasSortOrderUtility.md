## CanvasSortOrderUtility

`static class` in `AdvancedSceneManager.Utility`### Description
An utility class to manage sort order on canvases.

### Static Properties

| Member | Description |
|--------|-------------|
| `Canvas GetBottomCanvas` | _No documentation available._ |
| `Canvas GetTopCanvas` | _No documentation available._ |

### Static Methods

| Member | Description |
|--------|-------------|
| `void PutAbove(Canvas canvas, Canvas target)` | Inserts this canvas above target. |
| `void PutAtBottom(Canvas canvas)` | Sets the sort order on this canvas to be on bottom of all other canvases managed by `CanvasSortOrderUtility`. |
| `void PutBelow(Canvas canvas, Canvas target)` | Inserts this canvas below target. |
| `void PutOnTop(Canvas canvas)` | Sets the sort order on this canvas to be on top of all other canvases managed by `CanvasSortOrderUtility`. |
| `void Remove(Canvas canvas)` | _No documentation available._ |