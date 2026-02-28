## Scene.Events

`struct` in `AdvancedSceneManager.Models.Scene`

### Description
A struct providing unity events.

### Fields

| Member | Description |
|--------|-------------|
| `UnityEvent&lt;Scene&gt; OnClose` | Occurs when this scene is closed. |
| `UnityEvent&lt;Scene, SceneCollection&gt; OnCollectionClosed` | Occurs when a collection closed this scene. |
| `UnityEvent&lt;Scene, SceneCollection&gt; OnCollectionOpened` | Occurs when a collection opened this scene. |
| `UnityEvent&lt;Scene&gt; OnOpen` | Occurs when this scene is opened. |
| `UnityEvent&lt;bool&gt; OnOpenChanged` | Occurs when this scene is opened or closed, provides the open status as a bool. |
| `UnityEvent&lt;Scene&gt; OnPreload` | Occurs when this scene is preloaded. |
| `UnityEvent&lt;Scene&gt; OnPreloadFinished` | Occurs when preload is finished for this scene. |