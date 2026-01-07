## SplashFade

`class` in `AdvancedSceneManager.Defaults`  /  Inherits from: `SplashScreen`### Description
A default splash screen that fades the background in and out during startup.

### Fields

| Member | Description |
|--------|-------------|
| `Image background` | Background image displayed during the splash sequence. |
| `CanvasGroup groupBackground` | Canvas group used to control the fade effect of the background. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual IEnumerator OnClose()` | Called when the loading screen is about to close. |
| `virtual IEnumerator OnOpen()` | Called when the loading screen is opened. |