## IProfileManager

`interface` in `AdvancedSceneManager.DependencyInjection`### Description
Manages the current profile.

### Properties

| Member | Description |
|--------|-------------|
| `Profile current` | _No documentation available._ |
| `Profile defaultProfile` | The profile to force everyone in this project to use. |
| `Profile forceProfile` | The profile to force everyone in this project to use. |

### Events

| Member | Description |
|--------|-------------|
| `event Action onProfileChanged` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual Profile Create(string name)` | _No documentation available._ |
| `abstract virtual Profile CreateEmpty(string name, boolean useDefaultSpecialScenes, boolean useDefaultBindingScenes)` | _No documentation available._ |
| `abstract virtual void Delete(Profile profile)` | _No documentation available._ |
| `abstract virtual void Duplicate(Profile profile)` | _No documentation available._ |
| `abstract virtual void SetProfile(Profile profile, boolean updateBuildSettings)` | _No documentation available._ |