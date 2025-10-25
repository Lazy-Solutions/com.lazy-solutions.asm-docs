## SceneCollectionTemplate

`class` in `AdvancedSceneManager.Models.Utility`  /  Inherits from: `SceneCollection`### Description
Represents a template for a `SceneCollection`.

### Properties

| Member | Description |
|--------|-------------|
| `string name` | _No documentation available._ |

### Static Methods

| Member | Description |
|--------|-------------|
| `SceneCollectionTemplate CreateTemplate(SceneCollection collection)` | Creates `SceneCollectionTemplate` from the specified `SceneCollection`. |
| `SceneCollectionTemplate CreateTemplate(string title)` | Creates `SceneCollectionTemplate` using default properties. |

### Methods

| Member | Description |
|--------|-------------|
| `void Apply(SceneCollection collection)` | Applies a `SceneCollectionTemplate` on this `SceneCollection`. |
| `SceneCollection CreateCollection(Profile profile)` | Creates a `SceneCollection` from this `SceneCollectionTemplate`. |