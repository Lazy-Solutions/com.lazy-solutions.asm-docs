## ASMSettings

`class` in `AdvancedSceneManager.Models`  /  Inherits from: `ASMScriptableSingleton<ASMSettings>`### Description
Contains the project wide ASM settings.

<b> Remarks:</b>
Manages initialization, as this `ScriptableObject` is core to ASM, and nothing works without it.

### Properties

| Member | Description |
|--------|-------------|
| `boolean allowCollectionLocking` | Specifies whatever asm will allow locking collections. |
| `boolean allowLoadingScenesInParallel` | Specifies if scenes should be loaded in parallel, rather than sequentially. |
| `boolean allowSceneLocking` | Specifies whatever asm will allow locking scenes. |
| `boolean allowUpdateCheck` | _No documentation available._ |
| `string assetPath` | Specifies the path where profiles and imported scenes should be generated to. |
| `boolean autoUpdateBuildScenes` | Specifies whatever build scene list should be automatically updated. |
| `Profile buildProfile` | The profile to use during build. |
| `Color buildUnitySplashScreenColor` | This is the color of the unity splash screen, used to make the transition from unity splash screen to ASM smooth, this is set before building. `black` is used when the unity splash screen is disabled. |
| `boolean checkForDuplicateSceneOperations` | By default, ASM checks for duplicate scene operations, since this is usually caused by mistake, but this will disable that. |
| `CustomData customData` | Specifies custom data. |
| `Profile defaultProfile` | The profile to use when none is set. |
| `boolean enableCrossSceneReferences` | Gets or sets whatever cross-scene references should be enabled. |
| `boolean enableGUIDReferences` | Gets or sets whatever GUID references should be enabled. |
| `Scene fadeScene` | Specifies the scene to use for certain methods, i.e. [FadeOut(float, Color?, Action<float>)](https://learn.microsoft.com/dotnet/api/!:loadingscreenutility.fadeout(float, color?, action<float>)). |
| `Profile forceProfile` | The profile to force everyone in this project to use. |
| `boolean isNetcodeValidationEnabled` | Specifies whatever ASM should validate scenes in netcode. |
| `boolean preventSpammingEventMethods` | By default, ASM will prevent spam calling event methods (i.e. calling Scene.Open() from a button press), but this will disable that. |
| `boolean reverseUnloadOrderOnCollectionClose` | Specifies whatever collections should unload scenes in the reverse order. |
| `SceneImportOption sceneImportOption` | Gets or sets when to automatically import scenes. |
| `single spamCheckCooldown` | Sets the default cooldown for `SpamCheck`. |
| `InputBinding[] toolbarBindings` | Specifies the bindings to open the ASM toolbar, if enabled. |
| `boolean toolbarButtonVisible` | Specifies whatever the ASM toolbar button should be visible. |
| `boolean toolbarEnabled` | Specifies whatever the ASM toolbar should be enabled. |

### Fields

| Member | Description |
|--------|-------------|
| `SceneImportOption m_sceneImportOption` | _No documentation available._ |

### Static Methods

| Member | Description |
|--------|-------------|
| `void OnInitialized(Action action)` | Runs the callback when ASMSettings has initialized. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual void Save()` | _No documentation available._ |
| `void SetBuildProfile(Profile profile)` | Sets the build profile. |