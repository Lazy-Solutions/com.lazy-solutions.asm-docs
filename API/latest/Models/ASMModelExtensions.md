## ASMModelExtensions

`static class` in `AdvancedSceneManager.Models`

### Description
Provides utility methods for working with `Models.SceneCollection`.

### Static Methods

| Member | Description |
|--------|-------------|
| `void Add&lt;T&gt;(T collection, Scene\[\] scenes)` | Adds a scene to this `Models.SceneCollection`. |
| `void AddEmptyScene&lt;T&gt;(T collection)` | Adds an empty scene field to this `Models.SceneCollection`. |
| `SceneOperation CloseAll(IEnumerable&lt;Scene&gt; scenes)` | Closes the `scenes`. |
| `SceneOperation CloseAll(IEnumerable&lt;Scene&gt; scenes, LoadingScreenReference loadingScreen)` | Closes the `scenes`. |
| `int IndexOf&lt;T&gt;(T collection, Scene scene)` | Finds the index of `scene`. |
| `void Insert&lt;T&gt;(T collection, int index, Scene scene)` | Inserts a scene at the specified index in this collection. |
| `void Move&lt;T&gt;(T collection, int oldIndex, int newIndex)` | Moves a scene field to a new index. |
| `SceneOperation OpenAdditive(IEnumerable&lt;SceneCollection&gt; collections)` | Opens the `collections` as additive. |
| `SceneOperation OpenAdditive(IEnumerable&lt;SceneCollection&gt; collections, SceneCollection activeCollection)` | Opens the `collections` as additive. |
| `SceneOperation OpenAdditive(IEnumerable&lt;SceneCollection&gt; collections, SceneCollection activeCollection, Scene loadingScene)` | Opens the `collections` as additive. |
| `SceneOperation OpenAll(IEnumerable&lt;Scene&gt; scenes)` | Opens the `scenes`. |
| `SceneOperation OpenAll(IEnumerable&lt;Scene&gt; scenes, LoadingScreenReference loadingScreen)` | Opens the `scenes`. |
| `SceneOperation OpenWithAdditive(SceneCollection collection, SceneCollection\[\] extraAdditiveCollections)` | Opens this `collection` and then opens `extraAdditiveCollections` as additive. |
| `void Remove&lt;T&gt;(T collection, Scene scene)` | Removes a scene from this `Models.SceneCollection`. |
| `void RemoveAt&lt;T&gt;(T collection, int index)` | Removes a scene at the specified index from this `Models.SceneCollection`. |
| `bool Replace&lt;T&gt;(T collection, int index, Scene scene)` | Replaces a scene at the specified index. |