## IApp

`interface` in `AdvancedSceneManager.DependencyInjection`### Description
Manages startup and quit processes.

<b> Remarks:</b>
Usage: `app`.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isASMPlay` | Gets whatever we're currently in ASM play mode. |
| `boolean isQuitting` | Gets whatever ASM is currently in the process of quitting the game. |
| `boolean isRestart` | Gets if ASM has been restarted, or is currently restarting. |
| `boolean isStartupFinished` | Gets if startup process is finished. |
| `StartupProps startupProps` | Gets the props that should be used for startup process. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void CancelQuit()` | Cancels the current quit process. |
| `abstract virtual void CancelStartup()` | Cancels startup process. |
| `abstract virtual void Exit()` | Exits the application immediately. |
| `abstract virtual void Quit(boolean fade, Nullable<Color> fadeColor, single fadeDuration)` | _No documentation available._ |
| `abstract virtual void RegisterQuitCallback(Func<IEnumerator> coroutine)` | _No documentation available._ |
| `abstract virtual void Restart(StartupProps props)` | _No documentation available._ |
| `abstract virtual Async<boolean> RestartAsync(StartupProps props)` | _No documentation available._ |
| `abstract virtual void UnregisterQuitCallback(Func<IEnumerator> coroutine)` | _No documentation available._ |