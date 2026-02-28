## CallbackUtility

`static class` in `AdvancedSceneManager.Callbacks`### Description
Provides utilities for discovering and invoking scene and collection callbacks.
            Handles interfaces derived from `ISceneCallbacks` and their coroutine/awaitable counterparts.

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerator DoCollectionCloseCallbacks(SceneCollection collection)` | Invokes all collection close callbacks on the specified `collection`. |
| `IEnumerator DoCollectionOpenCallbacks(SceneCollection collection)` | Invokes all collection open callbacks on the specified `collection`. |
| `IEnumerator DoSceneCloseCallbacks(Scene scene)` | Invokes all scene close callbacks on the specified `scene`. |
| `IEnumerator DoSceneOpenCallbacks(Scene scene)` | Invokes all scene open callbacks on the specified `scene`. |
| `FluentInvokeAPI<T> Invoke<T>()` | _No documentation available._ |