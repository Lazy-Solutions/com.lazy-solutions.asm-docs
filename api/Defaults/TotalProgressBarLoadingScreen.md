## TotalProgressBarLoadingScreen

`class` in `AdvancedSceneManager.Defaults`  /  Inherits from: `LoadingScreen`### Description
A default loading screen that displays a total progress bar during scene loading.

### Methods

| Member | Description |
|--------|-------------|
| `virtual IEnumerator OnClose()` | Called when the loading screen is about to close. |
| `virtual IEnumerator OnOpen()` | Called when the loading screen is opened. |
| `virtual void OnProgressChanged(ILoadProgressData progress)` | Called when progress changes for the associated scene operation. |