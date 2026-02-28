## ICollectionClose

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is closed.

Called after loading screen has opened, if one is defined, or else just before collection is closed.

            See also:
            
- `ICollectionClose`
- `ICollectionCloseCoroutine`
- `ICollectionCloseAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void OnCollectionClose(SceneCollection collection)` | Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is closed.

Called after loading screen has opened, if one is defined, or else just before collection is closed.

            See also:
            
- `ICollectionClose`
- `ICollectionCloseCoroutine`
- `ICollectionCloseAwaitable` |