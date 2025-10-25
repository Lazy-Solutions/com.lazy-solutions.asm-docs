## IApp

`interface` in `AdvancedSceneManager.DependencyInjection`### Description
Manages startup and quit processes.

<b> Remarks:</b>
Usage: `app`.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isASMPlay` | _No documentation available._ |
| `boolean isQuitting` | _No documentation available._ |
| `boolean isRestart` | _No documentation available._ |
| `boolean isStartupFinished` | _No documentation available._ |
| `StartupProps startupProps` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void CancelQuit()` | _No documentation available._ |
| `abstract virtual void CancelStartup()` | _No documentation available._ |
| `abstract virtual void Exit()` | _No documentation available._ |
| `abstract virtual void Quit(boolean fade, Nullable<Color> fadeColor, single fadeDuration)` | _No documentation available._ |
| `abstract virtual void RegisterQuitCallback(Func<IEnumerator> coroutine)` | _No documentation available._ |
| `abstract virtual void Restart(StartupProps props)` | _No documentation available._ |
| `abstract virtual Async<boolean> RestartAsync(StartupProps props)` | _No documentation available._ |
| `abstract virtual void UnregisterQuitCallback(Func<IEnumerator> coroutine)` | _No documentation available._ |