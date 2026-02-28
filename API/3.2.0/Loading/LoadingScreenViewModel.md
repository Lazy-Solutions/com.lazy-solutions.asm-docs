## LoadingScreenViewModel

`abstract class` in `AdvancedSceneManager.Loading`  /  Inherits from: `ViewModel`### Description
The base class for loading screen view models.

### Properties

| Member | Description |
|--------|-------------|
| `boolean handleDisplayInEditorAutomatically` | Determines whether ASM should automatically handle editor-only display logic based on `displayInEditor`. |
| `UIDocument uiDocument { get; }` | Gets the `UIDocument` that is rendering the view. |

### Methods

| Member | Description |
|--------|-------------|
| `void EnsureCameraExists()` | Ensures that a camera exists for rendering this loading screen. |