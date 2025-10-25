## SceneManager

`static class` in `AdvancedSceneManager`### Description
The central Advanced Scene Manager API. Provides access to the most important things in ASM.

### Static Properties

| Member | Description |
|--------|-------------|
| `App app` | Manages startup and quit processes. |
| `AssetsProxy assets` | Provides access to the scenes, collections and profiles managed by ASM. |
| `EventCallbackManager<EventCallbackBase> events` | Provides access to global ASM event callbacks. |
| `boolean isInitialized` | Gets whatever ASM is initialized. Calling ASM methods may fail if `false`, this is due to `ASMSettings` singleton not being loaded yet. |
| `SceneCollection openCollection` | Gets the collection that is currently open. |
| `IEnumerable<Scene> openScenes` | Gets the scenes that are open. |
| `Package package` | Contains info about the ASM package. |
| `IEnumerable<Scene> preloadedScenes` | Gets the scenes that are preloaded. |
| `Profile profile` | Gets the currently active profile. |
| `Runtime runtime` | Manages runtime functionality for Advanced Scene Manager such as open scenes and collection. |
| `SettingsProxy settings` | Provides access to ASM settings. |

### Static Methods

| Member | Description |
|--------|-------------|
| `void Initialize()` | Initializes ASM if, for whatever reason, it did not automatically initialize. |
| `void OnInitialized(Action action)` | Call `action` when ASM has initialized. |