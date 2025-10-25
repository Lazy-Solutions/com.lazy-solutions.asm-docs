## ASMUserSettings

`class` in `AdvancedSceneManager.Models`  /  Inherits from: `ASMScriptableSingleton<ASMUserSettings>`### Description
Contains settings that are stored locally, that aren't synced to source control.

<b> Remarks:</b>
Only available in editor.

### Properties

| Member | Description |
|--------|-------------|
| `Profile activeProfile` | Specifies the active profile in editor. |
| `boolean alwaysDisplaySearch` | Determines whatever search should always be displayed, and not just when actively searching. |
| `boolean alwaysSaveScenesWhenEnteringPlayMode` | Specifies whatever scenes should always auto save when entering play mode using ASM play button. |
| `string cachedLatestVersion` | Gets or sets the cached latest version information. |
| `string cachedPatchNotes` | Gets or sets the cached patch notes. |
| `boolean clearCollectionWhenEnteringPlayMode` | Specifies whatever ASM should clear open collection when entering play mode. |
| `boolean displayCollectionAddButton` | Specifies the collection add hover button should be displayed. |
| `boolean displayCollectionTemplatesButton` | Specifies the collection templates hover button should be displayed. |
| `boolean displayDynamicCollectionAddButton` | Specifies the dynamic collection add hover button should be displayed. |
| `boolean displayDynamicCollectionMenuButton` | Specifies the dynamic collection menu hover button should be displayed. |
| `boolean displayHierarchyIndicators` | Specifies whatever the hierarchy indicators should be visible. |
| `boolean displaySceneTooltips` | Specifies whatever SceneField will display tooltips. |
| `boolean displaySyncedIndicator` | Specifies that the 'synced' hierarchy indicator should be shown for synced scenes when using netcode. |
| `boolean editorOnly` | _No documentation available._ |
| `single hierarchyIndicatorsOffset` | Gets or sets the offset ASM will use for hierarchy indicators. |
| `string lastPatchWhenNotified` | Gets or sets the last patch version when user was notified. |
| `string lastUpdateCheck` | Gets or sets the timestamp of the last update check. |
| `boolean logBuildScenes` | Specifies whatever ASM should log when build scene list is updated. |
| `boolean logImport` | Specifies whatever ASM should log when a [ASMModelBase](https://learn.microsoft.com/dotnet/api/!:asmmodelbase) is imported. |
| `boolean logLoading` | Specifies whatever ASM should log when a scene is loaded. |
| `boolean logOperation` | Specifies whatever ASM should log during scene operations. |
| `boolean logStartup` | Specifies whatever ASM should log during startup. |
| `boolean logTracking` | Specifies whatever ASM should log when a scene is tracked after loaded. |
| `boolean openCollectionOnSceneAssetOpen` | When `true`: opens the first found collection that a scene is contained in when opening an SceneAsset in editor. |
| `IEnumerable<SceneCollection> pinnedOverlayCollections` | Enumerates the pinned collections in the collection overlay. |
| `boolean splashDisplayInEditor` | Specifies whatever splash scene should be displayed in the editor. |
| `boolean startupProcessOnCollectionPlay` | Specifies whatever startup process should run when pressing collection play button. |
| `int32 toolbarButtonCount` | Specifies how many buttons should be placed in toolbar. |
| `single toolbarPlayButtonOffset` | Specifies offset for toolbar play buttons. |
| `UpdateInterval updateInterval` | Gets or sets the interval for checking ASM updates. |

### Methods

| Member | Description |
|--------|-------------|
| `void PinCollectionToOverlay(SceneCollection collection, Nullable<int32> index)` | Pins a collection to the collection overlay. |
| `void ToolbarAction(int32 i, SceneCollection& collection, Boolean& runStartupProcess)` | _No documentation available._ |
| `void ToolbarAction(int32 i, SceneCollection collection, boolean runStartupProcess)` | Sets the scene collection to open for the specified toolbar button, if any. |
| `void UnpinCollectionFromOverlay(SceneCollection collection)` | Unpins a collection from the collection overlay. |