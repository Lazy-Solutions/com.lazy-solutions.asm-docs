## SplashASM

`class` in `AdvancedSceneManager.Defaults`  /  Inherits from: `SplashScreen`### Description
A default splash screen script. Fades splash screen in and out.

### Fields

| Member | Description |
|--------|-------------|
| `Camera _camera` | Camera used for rendering the splash screen. |
| `Image background` | Background image shown during the splash sequence. |
| `CanvasGroup groupBackground` | Canvas group controlling the background fade. |
| `CanvasGroup groupLogo` | Canvas group controlling the logo fade. |
| `Image logo` | Logo image displayed in the splash screen. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual IEnumerator OnClose()` | Called when the loading screen is about to close. |
| `virtual IEnumerator OnOpen()` | Called when the loading screen is opened. |