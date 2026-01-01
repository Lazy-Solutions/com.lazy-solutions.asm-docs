## SceneLoader

`abstract class` in `AdvancedSceneManager.Core`### Description
Specifies a scene loader.

### Properties

| Member | Description |
|--------|-------------|
| `boolean activeInPlayMode` | Specifies whatever this loader will run in play mode or not. |
| `boolean activeOutsideOfPlayMode` | Specifies whatever this loader will run outside of play mode or not. |
| `boolean addScenesToBuildSettings` | Specifies whatever scenes using this loader should be added to build settings scene list. |
| `boolean canBeActivated` | Gets whatever this loader may be activated in the current context. |
| `Indicator indicator` | Specifies the indicator on scene fields for this scene loader. |
| `boolean isGlobal` | Specifies if this scene loader will can be applied to all scenes. Otherwise scenes will have to be explicitly flagged to open with this loader. |
| `string Key` | Gets the key for this scene loader. |
| `string sceneToggleText` | Specifies the text to display on the toggle in scene popup. Only has an effect if `isGlobal` is `false`. |
| `string sceneToggleTooltip` | Specifies the tooltip to display on the toggle in scene popup. Only has an effect if `isGlobal` is `false`. |

### Static Methods

| Member | Description |
|--------|-------------|
| `string GetKey<T>()` | _No documentation available._ |
| `string GetKey<T>(T obj)` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual boolean CanHandleScene(Scene scene)` | Gets whatever this scene loader can handle the scene. |
| `IEnumerator LoadDefault(SceneLoadArgs e)` | Loads scene using default ASM loaders. |
| `abstract virtual IEnumerator LoadScene(Scene scene, SceneLoadArgs e)` | Loads the scene specified in e.scene. |
| `IEnumerator UnloadDefault(SceneUnloadArgs e)` | Unloads scene using default ASM loaders. |
| `abstract virtual IEnumerator UnloadScene(Scene scene, SceneUnloadArgs e)` | Unloads the scene specified in e.scene. |