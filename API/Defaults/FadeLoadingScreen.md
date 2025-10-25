## FadeLoadingScreen

`class` in `AdvancedSceneManager.Defaults`  /  Inherits from: `LoadingScreen`### Description
A default loading screen script. Fades screen out, then fades screen in when loading is done. Does not display progress.

### Fields

| Member | Description |
|--------|-------------|
| `Color color` | The color of the background. |
| `Image fadeBackground` | The image of which to set background color. |
| `single fadeDuration` | The duration to fade in and out for. |
| `CanvasGroup fadeGroup` | The `CanvasGroup` to fade in and out. |
| `Nullable<single> fadeInDurationOverride` | Programmatic override for `fadeDuration`, which is saved in scene file. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual IEnumerator OnClose()` | Called when the loading screen is about to close. |
| `virtual IEnumerator OnOpen()` | Called when the loading screen is opened. |