## OnLoadAttribute

`class` in `AdvancedSceneManager.Callbacks`  /  Inherits from: `DiscoverableAttribute`### Description
Occurs when ASM has finished initializing, after domain reload, editor startup, or before startup process in a build.

<b> Remarks:</b>
Aims to replace:

```

```


```

```


Combines them, and is safely usable both in and outside the editor.

### Properties

| Member | Description |
|--------|-------------|
| `string friendlyDescription` | Specifies the description to be shown in the diag UI tooltip. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual boolean IsValidTarget(MemberInfo member)` | Gets if `member` is a valid target for this attribute callback. |