## FadeLoadingScreen

`class` in `AdvancedSceneManager.Defaults`  /  Inherits from: `LoadingScreen`### Description
A default loading screen script. Fades screen out, then fades screen in when loading is done. Does not display progress.

### Fields

| Member | Description |
|--------|-------------|
| `Color color` | _No documentation available._ |
| `Image fadeBackground` | _No documentation available._ |
| `single fadeDuration` | _No documentation available._ |
| `CanvasGroup fadeGroup` | _No documentation available._ |
| `Nullable<single> fadeInDurationOverride` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual IEnumerator OnClose()` | Called when the loading screen is about to close. |
| `virtual IEnumerator OnOpen()` | Called when the loading screen is opened. |