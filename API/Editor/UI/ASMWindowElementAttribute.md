## ASMWindowElementAttribute

`class` in `AdvancedSceneManager.Editor.UI`  /  Inherits from: `DiscoverableAttribute`### Description
Specifies a method or view model class that should be used as a callback to insert a visual element into the ASM window.

<b> Remarks:</b>
When specified on a class it should implement [IViewModel](https://learn.microsoft.com/dotnet/api/!:iviewmodel).

### Properties

| Member | Description |
|--------|-------------|
| `boolean canToggleVisible` | Gets if this element can be toggled visible or hidden. |
| `string friendlyDescription` | _No documentation available._ |
| `boolean isVisibleByDefault` | Gets if this element is visible by default. |
| `ElementLocation location` | Gets the location of this element. |
| `string name` | A name to distinguish this from other attributes on the same method. |

### Static Methods

| Member | Description |
|--------|-------------|
| `boolean IsDefaultASMScene(VisualElement element)` | Gets if this element is hosted within the default ASM scenes collection. |
| `boolean IsHostedWithinSettingsPage(VisualElement element)` | Gets if this element is hosted within the settings page. |
| `boolean IsStandalone(VisualElement element)` | Gets if this element is hosted within the standalone collection. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual boolean IsValidTarget(MemberInfo member)` | _No documentation available._ |