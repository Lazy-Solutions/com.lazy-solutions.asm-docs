## UIFadeExtensions

`static class` in `AdvancedSceneManager.Utility`### Description
Provides extension methods for `CanvasGroup`.

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerator Fade(CanvasGroup group, single to, single duration, boolean setBlocksRaycasts)` | Animates the alpha of a `CanvasGroup`. |
| `IEnumerator Fade(Graphic text, single to, single duration, boolean ignoreTimeScale)` | Animates the alpha of a `Graphic`. |
| `IEnumerator Fade(RectTransform element, single to, single duration, boolean ignoreTimeScale)` | Animates the alpha of all `Graphic` found on `element` and children. |
| `IEnumerator Fade(UIBehaviour element, single to, single duration, boolean ignoreTimeScale)` | Animates the alpha of all `Graphic` found on `element` and children. |