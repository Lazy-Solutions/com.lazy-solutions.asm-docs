## IProfileManager

`interface` in `AdvancedSceneManager.DependencyInjection`### Description
Manages the current profile.

### Properties

| Member | Description |
|--------|-------------|
| `Profile current` | Gets the currently active profile. |
| `Profile defaultProfile` | The profile to force everyone in this project to use. |
| `Profile forceProfile` | The profile to force everyone in this project to use. |

### Events

| Member | Description |
|--------|-------------|
| `event Action onProfileChanged` | Occurs when `profile` changes. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual Profile Create(string name)` | _No documentation available._ |
| `abstract virtual Profile CreateEmpty(string name, boolean useDefaultSpecialScenes)` | _No documentation available._ |
| `abstract virtual void Delete(Profile profile)` | _No documentation available._ |
| `abstract virtual void Duplicate(Profile profile)` | _No documentation available._ |
| `abstract virtual void SetProfile(Profile profile, boolean updateBuildSettings)` | _No documentation available._ |