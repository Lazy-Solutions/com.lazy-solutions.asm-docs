## SplashScreen

`abstract class` in `AdvancedSceneManager.Loading`  /  Inherits from: `LoadingScreenBase`### Description
A class that contains callbacks for splash screens.

<b> Remarks:</b>
`SplashScreen` and `LoadingScreen` cannot coexist within the same scene.

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual IEnumerator OnClose()` | Called when splash scene is about to close. |
| `abstract virtual IEnumerator OnOpen()` | Called when splash scene is opened. |
| `virtual void OnValidate()` | _No documentation available._ |