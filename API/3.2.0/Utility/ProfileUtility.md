## ProfileUtility

`static class` in `AdvancedSceneManager.Utility`### Description
Provides utility methods for working with profiles.

### Static Properties

| Member | Description |
|--------|-------------|
| `Profile buildProfile` | Gets the build profile. |
| `Profile defaultProfile` | Gets the default profile. |
| `Profile forceProfile` | Gets the force profile. |
| `SerializedObject serializedObject { get; }` | Gets the cached `SerializedObject` for the current profile. |

### Static Events

| Member | Description |
|--------|-------------|
| `event Action onProfileChanged` | Occurs when `profile` changes. |

### Static Methods

| Member | Description |
|--------|-------------|
| `void SetProfile(Profile profile, boolean updateBuildSettings)` | Sets the profile to be used by ASM. |