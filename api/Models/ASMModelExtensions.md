## ASMModelExtensions

`static class` in `AdvancedSceneManager.Models`### Description
Provides utility methods for working with `SceneCollection`.

### Static Methods

| Member | Description |
|--------|-------------|
| `void Add<T>(T collection, Scene[] scenes)` | _No documentation available._ |
| `void AddEmptyScene<T>(T collection)` | _No documentation available._ |
| `SceneOperation CloseAll(IEnumerable<Scene> scenes)` | Closes the `scenes`. |
| `SceneOperation CloseAll(IEnumerable<Scene> scenes, LoadingScreenReference loadingScreen)` | Closes the `scenes`. |
| `int32 IndexOf<T>(T collection, Scene scene)` | _No documentation available._ |
| `void Insert<T>(T collection, int32 index, Scene scene)` | _No documentation available._ |
| `void Move<T>(T collection, int32 oldIndex, int32 newIndex)` | _No documentation available._ |
| `SceneOperation OpenAdditive(IEnumerable<SceneCollection> collections)` | Opens the `collections` as additive. |
| `SceneOperation OpenAdditive(IEnumerable<SceneCollection> collections, SceneCollection activeCollection)` | Opens the `collections` as additive. |
| `SceneOperation OpenAdditive(IEnumerable<SceneCollection> collections, SceneCollection activeCollection, Scene loadingScene)` | Opens the `collections` as additive. |
| `SceneOperation OpenAll(IEnumerable<Scene> scenes)` | Opens the `scenes`. |
| `SceneOperation OpenAll(IEnumerable<Scene> scenes, LoadingScreenReference loadingScreen)` | Opens the `scenes`. |
| `SceneOperation OpenWithAdditive(SceneCollection collection, SceneCollection[] extraAdditiveCollections)` | Opens this `collection` and then opens `extraAdditiveCollections` as additive. |
| `void Remove<T>(T collection, Scene scene)` | _No documentation available._ |
| `void RemoveAt<T>(T collection, int32 index)` | _No documentation available._ |
| `boolean Replace<T>(T collection, int32 index, Scene scene)` | _No documentation available._ |