## ISceneCallbacks

`interface` in `AdvancedSceneManager.Callbacks`### Description
Base interface for `MonoBehaviour` callbacks. Just implement any of the following to have ASM call them during scene operations.
            
- `ISceneOpen`, `ISceneClose`, `ICollectionOpen`, `ICollectionClose`
- `ISceneOpenCoroutine`, `ISceneCloseCoroutine`, `ICollectionOpen`, `ICollectionCloseCoroutine`
- `ISceneOpenAwaitable`, `ISceneCloseAwaitable`, `ICollectionOpenAwaitable`, `ICollectionCloseAwaitable`
- `ICollectionExtraDataCallbacks`, `ICollectionExtraDataCallbacksCoroutine`, `ICollectionExtraDataCallbacksAwaitable`