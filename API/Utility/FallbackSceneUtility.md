## FallbackSceneUtility

`static class` in `AdvancedSceneManager.Utility`### Description
An utility class that manages the default scene, called 'AdvancedSceneManager'.

<b> Remarks:</b>
The default scene allows us to more easily close all scenes when we need to, since unity requires at least one scene to be open at any time.

### Static Properties

| Member | Description |
|--------|-------------|
| `boolean isActive` | _No documentation available._ |

### Static Fields

| Member | Description |
|--------|-------------|
| `string Name` | _No documentation available._ |

### Static Methods

| Member | Description |
|--------|-------------|
| `string GetPath()` | Gets the fallback scene. |
| `Scene GetScene()` | Gets the fallback scene. |
| `boolean IsFallbackScene(Scene scene)` | Gets whatever the specified scene is the default scene. |