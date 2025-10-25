## IUserSettings

`interface` in `AdvancedSceneManager.DependencyInjection.Editor`### Description
The user specific ASM settings, not synced to source control.

<b> Remarks:</b>
May not be available in `[InitializeOnLoad]` and similar, use [Action)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.scenemanager.oninitialized(system.action)) or `OnLoadAttribute` to ensure you're not calling too early.

Only available in editor.

### Properties

| Member | Description |
|--------|-------------|
| `Profile activeProfile` | Specifies the active profile in editor. |
| `boolean alwaysDisplaySearch` | Determines whatever search should always be displayed, and not just when actively searching. |
| `boolean alwaysSaveScenesWhenEnteringPlayMode` | Specifies whatever scenes should always auto save when entering play mode using ASM play button. |
| `boolean displayHierarchyIndicators` | Specifies whatever the hierarchy indicators should be visible. |
| `boolean editorOnly` | _No documentation available._ |
| `boolean logBuildScenes` | Specifies whatever ASM should log when build scene list is updated. |
| `boolean logImport` | Specifies whatever ASM should log when a [ASMModelBase](https://learn.microsoft.com/dotnet/api/!:asmmodelbase) is imported. |
| `boolean logLoading` | Specifies whatever ASM should log when a scene is loaded. |
| `boolean logOperation` | Specifies whatever ASM should log during scene operations. |
| `boolean logStartup` | Specifies whatever ASM should log during startup. |
| `boolean logTracking` | Specifies whatever ASM should log when a scene is tracked after loaded. |
| `boolean openCollectionOnSceneAssetOpen` | When `true`: opens the first found collection that a scene is contained in when opening an SceneAsset in editor. |
| `IEnumerable<SceneCollection> pinnedOverlayCollections` | Enumerates the pinned collections in the collection overlay. |
| `boolean startupProcessOnCollectionPlay` | Specifies whatever startup process should run when pressing collection play button. |
| `int32 toolbarButtonCount` | Specifies how many buttons should be placed in toolbar. |
| `single toolbarPlayButtonOffset` | Specifies offset for toolbar play buttons. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void PinCollectionToOverlay(SceneCollection collection, Nullable<int32> index)` | _No documentation available._ |
| `abstract virtual void Save()` | Saves the singleton to disk after a delay. |
| `abstract virtual void SaveNow()` | Saves the singleton to disk. |
| `abstract virtual void ToolbarAction(int32 i, SceneCollection& collection, Boolean& runStartupProcess)` | _No documentation available._ |
| `abstract virtual void ToolbarAction(int32 i, SceneCollection collection, boolean runStartupProcess)` | _No documentation available._ |
| `abstract virtual void UnpinCollectionFromOverlay(SceneCollection collection)` | _No documentation available._ |