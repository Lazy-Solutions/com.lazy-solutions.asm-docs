## IconBounceLoadingScreen

`class` in `AdvancedSceneManager.Defaults`  /  Inherits from: `FadeLoadingScreen`### Description
A default loading screen script. Displays progress with a bouncing icon.

### Fields

| Member | Description |
|--------|-------------|
| `RectTransform BackgroundTransform` | Specifies the transform for the background. |
| `single duration` | Specifies the icon rotate duration. |
| `single IconStartRotationZ` | Specifies the icon start rotation. |
| `Vector2 IconStartSize` | Specifies the icon start size. |
| `RectTransform IconTransform` | Specifies the transform for the icon. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual IEnumerator OnClose()` | Called when the loading screen is about to close. |
| `virtual IEnumerator OnOpen()` | Called when the loading screen is opened. |