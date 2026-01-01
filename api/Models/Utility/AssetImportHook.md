## AssetImportHook

`class` in `AdvancedSceneManager.Models.Utility`### Description
Collects imported assets when added.

<b> Remarks:</b>
Only available in editor.

### Properties

| Member | Description |
|--------|-------------|
| `IEnumerable<SceneAsset> addedScenes` | Enumerates the collected `SceneAsset`. |
| `IEnumerable<ASMModelBase> importedModels` | Enumerates the collected assets. |
| `boolean removeAssetsOnDispose` | Specifies whatever collected ASM assets should be removed on `Dispose`. |
| `boolean removeSceneAssetsOnDispose` | Specifies whatever collected `SceneAsset` should be removed on `Dispose`. |

### Methods

| Member | Description |
|--------|-------------|
| `void Dispose()` | Releases the hook. |
| `void Release()` | Releases hook, and optionally removes assets, if specified by `removeAssetsOnDispose` and `removeSceneAssetsOnDispose`. |
| `void RemoveAll(boolean removeSceneAssets)` | Removes all collected ASM assets, and optionally all `SceneAsset`. |
| `void RemoveAllAndRelease(boolean removeSceneAssets)` | Removes all collected ASM assets, and optionally all `SceneAsset`, then releases. |