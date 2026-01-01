## App

`class` in `AdvancedSceneManager.Core`### Description
Manages startup and quit processes.

<b> Remarks:</b>
Usage: `app`.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isASMPlay { get; }` | Gets whatever we're currently in ASM play mode. |
| `boolean isQuitting { get; }` | Gets whatever ASM is currently in the process of quitting the game. |
| `boolean isRestart { get; }` | Gets if ASM has been restarted, or is currently restarting. |
| `boolean isRunningStartupProcess { get; }` | Gets if ASM startup process is running. |
| `boolean isStartupFinished { get; }` | Gets if startup process is finished. |
| `ProgressScope startupProgressScope { get; }` | Gets the progress scope used during startup. |
| `StartupProps startupProps` | Gets the props that should be used for startup process. |

### Methods

| Member | Description |
|--------|-------------|
| `void CancelQuit()` | Cancels the current quit process. |
| `void CancelStartup()` | Cancels startup process. |
| `void Exit()` | Exits the application immediately. |
| `void Play(StartupProps props)` | _No documentation available._ |
| `void Quit(boolean fade, Nullable<Color> fadeColor, single fadeDuration)` | Quits the application with optional fade effect. |
| `void RegisterQuitCallback(Func<IEnumerator> coroutine)` | Register a callback to be called before quit. |
| `void Restart(StartupProps props)` | _No documentation available._ |
| `Async<boolean> RestartAsync(StartupProps props)` | _No documentation available._ |
| `void UnregisterQuitCallback(Func<IEnumerator> coroutine)` | Unregister a callback that was to be called before quit. |