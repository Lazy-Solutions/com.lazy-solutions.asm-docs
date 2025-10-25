## ViewModelContext

`struct` in `AdvancedSceneManager.Editor.UI`  /  Inherits from: `ValueType`### Description
Provides info about where a view model is hosted at in the ASM window.

### Properties

| Member | Description |
|--------|-------------|
| `ISceneCollection baseCollection` | Gets the associated collection as `ISceneCollection`, if hosted by a collection element. |
| `SceneCollection collection` | Gets the associated collection as `SceneCollection`, if hosted by a collection element. |
| `object customParam` | Gets the custom parameter that as passed from host. |
| `DefaultASMScenesCollection defaultASMCollection` | Gets the associated collection as `DefaultASMScenesCollection`, if hosted by a collection element. |
| `DynamicCollection dynamicCollection` | Gets the associated collection as `DynamicCollection`, if hosted by a collection element. |
| `Scene scene` | Gets the associated scene, if hosted by a scene element. |
| `Nullable<int32> sceneIndex` | Gets the associated scene index, if hosted by a scene element, inside a collection element. |
| `StandaloneCollection standaloneCollection` | Gets the associated collection as `StandaloneCollection`, if hosted by a collection element. |

### Methods

| Member | Description |
|--------|-------------|
| `T OfType<T>()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |