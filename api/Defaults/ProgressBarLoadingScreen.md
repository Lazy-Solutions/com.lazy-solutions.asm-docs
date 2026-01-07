## ProgressBarLoadingScreen

`class` in `AdvancedSceneManager.Defaults`  /  Inherits from: `FadeLoadingScreen`### Description
A default loading screen script. Displays progress with a progress bar.

### Fields

| Member | Description |
|--------|-------------|
| `Slider slider` | Specifies the slider to use as progress bar. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual IEnumerator OnClose()` | Called when the loading screen is about to close. |
| `virtual IEnumerator OnOpen()` | Called when the loading screen is opened. |
| `virtual void OnProgressChanged(ILoadProgressData progress)` | Called when progress changes for the associated scene operation. |