## IProjectSettings

`interface` in `AdvancedSceneManager.DependencyInjection`### Description

### Properties

| Member | Description |
|--------|-------------|
| `boolean allowCollectionLocking` | Specifies whatever asm will allow locking collections. |
| `boolean allowSceneLocking` | Specifies whatever asm will allow locking scenes. |
| `string assetPath` | Specifies the path where profiles and imported scenes should be generated to. |
| `Profile buildProfile` | The profile to use during build. |
| `Color buildUnitySplashScreenColor` | This is the color of the unity splash screen, used to make the transition from unity splash screen to ASM smooth, this is set before building. `black` is used when the unity splash screen is disabled. |
| `boolean checkForDuplicateSceneOperations` | By default, ASM checks for duplicate scene operations, since this is usually caused by mistake, but this will disable that. |
| `CustomData customData` | Specifies custom data. |
| `Profile defaultProfile` | The profile to use when none is set. |
| `boolean enableCrossSceneReferences` | Gets or sets whatever cross-scene references should be enabled. |
| `Scene fadeScene` | Specifies the scene to use for certain methods, i.e. [Color})](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.utility.loadingscreenutility.fadeout(system.single,system.nullable{unityengine.color})). |
| `Profile forceProfile` | The profile to force everyone in this project to use. |
| `boolean preventSpammingEventMethods` | By default, ASM will prevent spam calling event methods (i.e. calling Scene.Open() from a button press), but this will disable that. |
| `boolean reverseUnloadOrderOnCollectionClose` | Specifies whatever collections should unload scenes in the reverse order. |
| `SceneImportOption sceneImportOption` | Gets or sets when to automatically import scenes. |
| `single spamCheckCooldown` | Sets the default cooldown for `SpamCheck`. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void Save()` | Saves the singleton to disk after a delay. |
| `abstract virtual void SaveNow()` | Saves the singleton to disk. |
| `abstract virtual void SetBuildProfile(Profile profile)` | _No documentation available._ |