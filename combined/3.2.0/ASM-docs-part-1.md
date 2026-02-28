---
# ActionUtility
<!--
source: API\3.2.0\Callbacks\ActionUtility.md
-->

## ActionUtility

`static class` in `AdvancedSceneManager.Callbacks`### Description
Contains utility functions for `Action`.

### Static Methods

| Member | Description |
|--------|-------------|
| `void LogInvoke(Action action)` | Tries to invoke the action, then logs error to the console if an error occurred. |
| `void TryInvoke(Action action)` | Tries to invoke the action, eats the exception. |
| `boolean TryInvoke(Action action, Exception& exception)` | _No documentation available._ |

---
# CallbackUtility
<!--
source: API\3.2.0\Callbacks\CallbackUtility.md
-->

## CallbackUtility

`static class` in `AdvancedSceneManager.Callbacks`### Description
Provides utilities for discovering and invoking scene and collection callbacks.
            Handles interfaces derived from `ISceneCallbacks` and their coroutine/awaitable counterparts.

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerator DoCollectionCloseCallbacks(SceneCollection collection)` | Invokes all collection close callbacks on the specified `collection`. |
| `IEnumerator DoCollectionOpenCallbacks(SceneCollection collection)` | Invokes all collection open callbacks on the specified `collection`. |
| `IEnumerator DoSceneCloseCallbacks(Scene scene)` | Invokes all scene close callbacks on the specified `scene`. |
| `IEnumerator DoSceneOpenCallbacks(Scene scene)` | Invokes all scene open callbacks on the specified `scene`. |
| `FluentInvokeAPI<T> Invoke<T>()` | _No documentation available._ |

---
# Callback_Of_T
<!--
source: API\3.2.0\Callbacks\Callback_Of_T.md
-->

## Callback

`sealed class` in `AdvancedSceneManager.Callbacks`  /  Inherits from: `MulticastDelegate`### Description

### Methods

| Member | Description |
|--------|-------------|
| `virtual IAsyncResult BeginInvoke(T obj, boolean isEnabled, AsyncCallback callback, object object)` | _No documentation available._ |
| `virtual IEnumerator EndInvoke(IAsyncResult result)` | _No documentation available._ |
| `virtual IEnumerator Invoke(T obj, boolean isEnabled)` | _No documentation available._ |

---
# AllScenesClosedEvent
<!--
source: API\3.2.0\Callbacks\Events\AllScenesClosedEvent.md
-->

## AllScenesClosedEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `EventCallbackBase`### Description
Occurs when all user scenes have been closed and only ASM fallback scene remains open.

<b> Remarks:</b>
Use this to gracefully handle the situation — for example, by returning to the main menu or similar.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(AllScenesClosedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# CalledForAttribute
<!--
source: API\3.2.0\Callbacks\Events\CalledForAttribute.md
-->

## CalledForAttribute

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `Attribute`### Description

### Properties

| Member | Description |
|--------|-------------|
| `When[] when` | _No documentation available._ |

---
# CollectionCloseEvent
<!--
source: API\3.2.0\Callbacks\Events\CollectionCloseEvent.md
-->

## CollectionCloseEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `CollectionEvent`### Description
Occurs when a collection is closed.

<b> Remarks:</b>
Called when: `Unspecified` (it will be ignored).

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(SceneCollection& collection)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(CollectionEvent other)` | _No documentation available._ |
| `virtual boolean Equals(CollectionCloseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# CollectionEvent
<!--
source: API\3.2.0\Callbacks\Events\CollectionEvent.md
-->

## CollectionEvent

`abstract class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `SceneOperationEventBase`### Description
The base class for collection event callbacks.

<b> Remarks:</b>
See `CollectionOpenEvent`, `CollectionCloseEvent`.

### Properties

| Member | Description |
|--------|-------------|
| `SceneCollection collection` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(SceneCollection& collection)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(SceneOperationEventBase other)` | _No documentation available._ |
| `virtual boolean Equals(CollectionEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# CollectionOpenEvent
<!--
source: API\3.2.0\Callbacks\Events\CollectionOpenEvent.md
-->

## CollectionOpenEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `CollectionEvent`### Description
Occurs when a collection is opened.

<b> Remarks:</b>
Called when: `Unspecified` (it will be ignored).

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(SceneCollection& collection)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(CollectionEvent other)` | _No documentation available._ |
| `virtual boolean Equals(CollectionOpenEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ASMModelRenamedEvent
<!--
source: API\3.2.0\Callbacks\Events\Editor\ASMModelRenamedEvent.md
-->

## ASMModelRenamedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when an ASM model is renamed.

### Properties

| Member | Description |
|--------|-------------|
| `ASMModelBase model` | The model that was renamed. |
| `string newName` | The new name of the model. |
| `string oldName` | The previous name of the model. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(ASMModelBase& model, String& oldName, String& newName)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(ASMModelRenamedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ASMSettingsChangedEvent
<!--
source: API\3.2.0\Callbacks\Events\Editor\ASMSettingsChangedEvent.md
-->

## ASMSettingsChangedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when a setting in ASM changes.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(ASMSettingsChangedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ASMWindowCloseEvent
<!--
source: API\3.2.0\Callbacks\Events\Editor\ASMWindowCloseEvent.md
-->

## ASMWindowCloseEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when the ASM editor window is closed.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(ASMWindowCloseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ASMWindowOpenEvent
<!--
source: API\3.2.0\Callbacks\Events\Editor\ASMWindowOpenEvent.md
-->

## ASMWindowOpenEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when the ASM editor window is opened.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(ASMWindowOpenEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# BeforeASMPlayModeEvent
<!--
source: API\3.2.0\Callbacks\Events\Editor\BeforeASMPlayModeEvent.md
-->

## BeforeASMPlayModeEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs before ASM enters play mode when ASM play button is used.

### Properties

| Member | Description |
|--------|-------------|
| `StartupProps props` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(StartupProps& props)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(BeforeASMPlayModeEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# CollectionAddedEvent
<!--
source: API\3.2.0\Callbacks\Events\Editor\CollectionAddedEvent.md
-->

## CollectionAddedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when a collection is added to a profile.

### Properties

| Member | Description |
|--------|-------------|
| `ISceneCollection collection` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(ISceneCollection& collection)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(CollectionAddedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# CollectionDeletedEvent
<!--
source: API\3.2.0\Callbacks\Events\Editor\CollectionDeletedEvent.md
-->

## CollectionDeletedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when a collection is deleted from a profile.

<b> Remarks:</b>
Hard delete, not recoverable. Happens after undo period.

### Properties

| Member | Description |
|--------|-------------|
| `ISceneCollection collection` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(ISceneCollection& collection)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(CollectionDeletedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# CollectionRemovedEvent
<!--
source: API\3.2.0\Callbacks\Events\Editor\CollectionRemovedEvent.md
-->

## CollectionRemovedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when a collection is removed from a profile.

<b> Remarks:</b>
Soft delete, still recoverable. Triggers undo period.

### Properties

| Member | Description |
|--------|-------------|
| `ISceneCollection collection` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(ISceneCollection& collection)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(CollectionRemovedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# CollectionRestoredEvent
<!--
source: API\3.2.0\Callbacks\Events\Editor\CollectionRestoredEvent.md
-->

## CollectionRestoredEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when a collection is restored after remove, before hard delete.

### Properties

| Member | Description |
|--------|-------------|
| `ISceneCollection collection` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(ISceneCollection& collection)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(CollectionRestoredEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ModelPropertyChangedEvent
<!--
source: API\3.2.0\Callbacks\Events\Editor\ModelPropertyChangedEvent.md
-->

## ModelPropertyChangedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when an ASM model property changes. This is the same as `INotifyPropertyChanged`.

<b> Remarks:</b>
`Empty` will be used when `INotifyPropertyChanged` is called from `onvalidate`.

### Properties

| Member | Description |
|--------|-------------|
| `ASMModelBase model` | The model had a property changed. |
| `string propertyName` | The name of the property that changed. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(ASMModelBase& model, String& propertyName)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(ModelPropertyChangedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# OnWindowDisableEvent
<!--
source: API\3.2.0\Callbacks\Events\Editor\OnWindowDisableEvent.md
-->

## OnWindowDisableEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when the ASM editor window is disabled.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(OnWindowDisableEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# OnWindowEnableEvent
<!--
source: API\3.2.0\Callbacks\Events\Editor\OnWindowEnableEvent.md
-->

## OnWindowEnableEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when the ASM editor window is enabled.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(OnWindowEnableEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# OnWindowFocusEvent
<!--
source: API\3.2.0\Callbacks\Events\Editor\OnWindowFocusEvent.md
-->

## OnWindowFocusEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when the ASM editor window gains focus.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(OnWindowFocusEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# OnWindowLostFocusEvent
<!--
source: API\3.2.0\Callbacks\Events\Editor\OnWindowLostFocusEvent.md
-->

## OnWindowLostFocusEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when the ASM editor window loses focus.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(OnWindowLostFocusEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# PlayModeChangedEvent
<!--
source: API\3.2.0\Callbacks\Events\Editor\PlayModeChangedEvent.md
-->

## PlayModeChangedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when the unity play mode state changes.

<b> Remarks:</b>
Wrapper for `playModeStateChanged`.

### Properties

| Member | Description |
|--------|-------------|
| `PlayModeStateChange state` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(PlayModeStateChange& state)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(PlayModeChangedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ProfileAddedEvent
<!--
source: API\3.2.0\Callbacks\Events\Editor\ProfileAddedEvent.md
-->

## ProfileAddedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when a profile is added to ASM.

<b> Remarks:</b>
Does not support [IEnumerator)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.callbacks.events.eventcallbackbase.waitfor(system.collections.ienumerator)) or any of its overloads.

### Properties

| Member | Description |
|--------|-------------|
| `Profile profile` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(Profile& profile)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(ProfileAddedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ProfileChangedEvent
<!--
source: API\3.2.0\Callbacks\Events\Editor\ProfileChangedEvent.md
-->

## ProfileChangedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when the active profile is changed.

### Properties

| Member | Description |
|--------|-------------|
| `Profile profile` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(Profile& profile)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(ProfileChangedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ProfileRemovedEvent
<!--
source: API\3.2.0\Callbacks\Events\Editor\ProfileRemovedEvent.md
-->

## ProfileRemovedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when a profile is removed from ASM.

<b> Remarks:</b>
Does not support [IEnumerator)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.callbacks.events.eventcallbackbase.waitfor(system.collections.ienumerator)) or any of its overloads.

### Properties

| Member | Description |
|--------|-------------|
| `Profile profile` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(Profile& profile)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(ProfileRemovedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# SceneImportedEvent
<!--
source: API\3.2.0\Callbacks\Events\Editor\SceneImportedEvent.md
-->

## SceneImportedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when a scene is imported into ASM.

### Properties

| Member | Description |
|--------|-------------|
| `Scene scene` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(Scene& scene)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(SceneImportedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# SceneLoaderToggledEvent
<!--
source: API\3.2.0\Callbacks\Events\Editor\SceneLoaderToggledEvent.md
-->

## SceneLoaderToggledEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when the scene loader for a given scene is changed.

### Properties

| Member | Description |
|--------|-------------|
| `Type newSceneLoader` | _No documentation available._ |
| `Type oldSceneLoader` | _No documentation available._ |
| `Scene scene` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(Scene& scene, Type& oldSceneLoader, Type& newSceneLoader)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(SceneLoaderToggledEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ScenesAvailableForImportChangedEvent
<!--
source: API\3.2.0\Callbacks\Events\Editor\ScenesAvailableForImportChangedEvent.md
-->

## ScenesAvailableForImportChangedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when either `unimportedScenes`, `importedScenes`, or `invalidScenes` has changed.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(ScenesAvailableForImportChangedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# SceneUnimportedEvent
<!--
source: API\3.2.0\Callbacks\Events\Editor\SceneUnimportedEvent.md
-->

## SceneUnimportedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when a scene is unimported from ASM.

### Properties

| Member | Description |
|--------|-------------|
| `Scene scene` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(Scene& scene)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(SceneUnimportedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# UpdateCheckedEvent
<!--
source: API\3.2.0\Callbacks\Events\Editor\UpdateCheckedEvent.md
-->

## UpdateCheckedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs after ASM has checked for updates.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(UpdateCheckedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# EndPhaseEvent
<!--
source: API\3.2.0\Callbacks\Events\EndPhaseEvent.md
-->

## EndPhaseEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `SceneOperationEventBase`### Description
Occurs before operation has stopped working, but after its practically done.

<b> Remarks:</b>
Called when: `Unspecified` (it will be ignored).

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(SceneOperationEventBase other)` | _No documentation available._ |
| `virtual boolean Equals(EndPhaseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# EventCallbackBase
<!--
source: API\3.2.0\Callbacks\Events\EventCallbackBase.md
-->

## EventCallbackBase

`abstract class` in `AdvancedSceneManager.Callbacks.Events`### Description
The base class for all event callbacks.

### Properties

| Member | Description |
|--------|-------------|
| `List<Func<IEnumerator>> waitFor { get; }` | A list of coroutines that `SceneOperation` should wait for. It will not proceed until all coroutines are done. |
| `When when` | Specifies when this event callback was invoked, before or after the action it represents. If applicable. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `virtual boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |
| `void WaitFor(IEnumerator coroutine)` | Specifies a coroutine that the operation should wait for. |
| `void WaitFor(Func<IEnumerator> coroutine)` | Specifies a coroutine that the operation should wait for. |
| `void WaitFor(GlobalCoroutine coroutine)` | Specifies a coroutine that the operation should wait for. |
| `void WaitFor(Func<GlobalCoroutine> coroutine)` | Specifies a coroutine that the operation should wait for. |
| `void WaitFor(Awaitable awaitable)` | Specifies a coroutine that the operation should wait for. |
| `void WaitFor(Func<Awaitable> awaitable)` | Specifies a coroutine that the operation should wait for. |

---
# EventCallbackManager_Of_TEventBase
<!--
source: API\3.2.0\Callbacks\Events\EventCallbackManager_Of_TEventBase.md
-->

## EventCallbackManager`1

`class` in `AdvancedSceneManager.Callbacks.Events`### Description
Manages event callbacks.

<b> Remarks:</b>
You probably want to use either `events` or `events`.

### Methods

| Member | Description |
|--------|-------------|
| `IEnumerator InvokeCallback<TEventType>(When when, string callerFile, int32 callerLine)` | _No documentation available._ |
| `IEnumerator InvokeCallback<TEventType>(TEventType e, When when, string callerFile, int32 callerLine)` | _No documentation available._ |
| `void InvokeCallbackSync<TEventType>(When when)` | _No documentation available._ |
| `void InvokeCallbackSync<TEventType>(TEventType e, When when)` | _No documentation available._ |
| `void RegisterCallback<TEventType>(EventCallback<TEventType> callback, When when, string key)` | _No documentation available._ |
| `void UnregisterCallback(string key)` | Unregisters a previously registered event callback. |
| `void UnregisterCallback<TEventType>(EventCallback<TEventType> callback, When when, string key)` | _No documentation available._ |

---
# EventCallbackUtility
<!--
source: API\3.2.0\Callbacks\Events\EventCallbackUtility.md
-->

## EventCallbackUtility

`static class` in `AdvancedSceneManager.Callbacks.Events`### Description
Provides utility functions for working with event callbacks.

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerable<Type> GetCallbackTypes()` | Enumerates all callback types. |
| `int32 GetInvocationOrder<TEventType>()` | _No documentation available._ |
| `int32 GetInvocationOrder(Type type)` | Gets the invocation order of the event callback type. |
| `boolean IsWhenApplicable<TEventType>()` | _No documentation available._ |
| `boolean IsWhenApplicable(Type type)` | Gets if the specified callback event uses `When` enum. |
| `SceneOperation RegisterAllCallbacks(string key, SceneOperation operation, EventCallback<EventCallbackBase> callback, When when)` | Registers callback for all events. |
| `void RegisterAllCallbacksGlobal(string key, EventCallback<EventCallbackBase> callback, When when)` | Registers callback for all events. |
| `SceneOperation UnregisterCallback(string key, SceneOperation operation)` | Unregisters callback using `key`. |
| `void UnregisterCallbackGlobal(string key)` | Unregisters callback using `key`. |

---
# EventCallback_Of_TEventType
<!--
source: API\3.2.0\Callbacks\Events\EventCallback_Of_TEventType.md
-->

## EventCallback`1

`sealed class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `MulticastDelegate`### Description
Callback for scene operations.

### Methods

| Member | Description |
|--------|-------------|
| `virtual IAsyncResult BeginInvoke(TEventType evt, AsyncCallback callback, object object)` | _No documentation available._ |
| `virtual void EndInvoke(IAsyncResult result)` | _No documentation available._ |
| `virtual void Invoke(TEventType evt)` | _No documentation available._ |

---
# FilteredEventProxy_Of_TEventBase
<!--
source: API\3.2.0\Callbacks\Events\FilteredEventProxy_Of_TEventBase.md
-->

## FilteredEventProxy`1

`sealed class` in `AdvancedSceneManager.Callbacks.Events`### Description
Manages event callbacks, filtered for `TEventBase`.

<b> Remarks:</b>
You probably want to use either [String)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.models.scene.registercallback``1(advancedscenemanager.callbacks.events.eventcallback{``0},advancedscenemanager.callbacks.events.when,system.string)) or [String)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.models.scenecollection.registercallback``1(advancedscenemanager.callbacks.events.eventcallback{``0},advancedscenemanager.callbacks.events.when,system.string)).

### Methods

| Member | Description |
|--------|-------------|
| `void RegisterCallback<T>(EventCallback<T> callback, When when, string key)` | _No documentation available._ |
| `void UnregisterCallback<T>(EventCallback<T> callback, When when, string key)` | _No documentation available._ |

---
# GlobalCoroutinesChanged
<!--
source: API\3.2.0\Callbacks\Events\GlobalCoroutinesChanged.md
-->

## GlobalCoroutinesChanged

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `EventCallbackBase`### Description
Occurs when `CoroutineUtility` starts or ends a coroutine.

### Properties

| Member | Description |
|--------|-------------|
| `IEnumerable<GlobalCoroutine> coroutines` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(IEnumerable`1& coroutines)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(GlobalCoroutinesChanged other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# InvocationOrderAttribute
<!--
source: API\3.2.0\Callbacks\Events\InvocationOrderAttribute.md
-->

## InvocationOrderAttribute

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `Attribute`### Description

### Properties

| Member | Description |
|--------|-------------|
| `int32 order` | _No documentation available._ |

---
# LoadingScreenClosePhaseEvent
<!--
source: API\3.2.0\Callbacks\Events\LoadingScreenClosePhaseEvent.md
-->

## LoadingScreenClosePhaseEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `LoadingScreenPhaseEvent`### Description
Occurs when a loading screen is closed.

<b> Remarks:</b>
Called regardless if operation actually opens one or not.
            
            Called when: `Before`, `After`.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(LoadingScreenReference& loadingScreen)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(LoadingScreenPhaseEvent other)` | _No documentation available._ |
| `virtual boolean Equals(LoadingScreenClosePhaseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# LoadingScreenOpenPhaseEvent
<!--
source: API\3.2.0\Callbacks\Events\LoadingScreenOpenPhaseEvent.md
-->

## LoadingScreenOpenPhaseEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `LoadingScreenPhaseEvent`### Description
Occurs when a loading screen is opened.

<b> Remarks:</b>
Called regardless if operation actually opens one or not.
            
            Called when: `Before`, `After`.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(LoadingScreenReference& loadingScreen)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(LoadingScreenPhaseEvent other)` | _No documentation available._ |
| `virtual boolean Equals(LoadingScreenOpenPhaseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# LoadingScreenPhaseEvent
<!--
source: API\3.2.0\Callbacks\Events\LoadingScreenPhaseEvent.md
-->

## LoadingScreenPhaseEvent

`abstract class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `SceneOperationEventBase`### Description
The base class for loading screen phase event callbacks.

<b> Remarks:</b>
See `LoadingScreenOpenPhaseEvent`, `LoadingScreenClosePhaseEvent`.

### Properties

| Member | Description |
|--------|-------------|
| `LoadingScreenReference loadingScreen` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(LoadingScreenReference& loadingScreen)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(SceneOperationEventBase other)` | _No documentation available._ |
| `virtual boolean Equals(LoadingScreenPhaseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# QuitEvent
<!--
source: API\3.2.0\Callbacks\Events\QuitEvent.md
-->

## QuitEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `EventCallbackBase`### Description
Occurs when the application is quitting through `SceneManager.app.Quit()`.

This event will not be raised if the default Unity quit flow is used.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(QuitEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# SceneCloseEvent
<!--
source: API\3.2.0\Callbacks\Events\SceneCloseEvent.md
-->

## SceneCloseEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `SceneEvent`### Description
Occurs when a scene is closed.

<b> Remarks:</b>
Called when: `Before`, `After`.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(Scene& scene)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(SceneEvent other)` | _No documentation available._ |
| `virtual boolean Equals(SceneCloseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# SceneClosePhaseEvent
<!--
source: API\3.2.0\Callbacks\Events\SceneClosePhaseEvent.md
-->

## SceneClosePhaseEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `ScenePhaseEvent`### Description
Occurs when operation starts and finishes closing scenes.

<b> Remarks:</b>
Called when: `Before`, `After`.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(IEnumerable`1& scenes)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(ScenePhaseEvent other)` | _No documentation available._ |
| `virtual boolean Equals(SceneClosePhaseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# SceneEvent
<!--
source: API\3.2.0\Callbacks\Events\SceneEvent.md
-->

## SceneEvent

`abstract class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `SceneOperationEventBase`### Description
The base class for scene event callbacks.

<b> Remarks:</b>
See `SceneOpenEvent`, `SceneCloseEvent`, `ScenePreloadEvent`.

### Properties

| Member | Description |
|--------|-------------|
| `Scene scene` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(Scene& scene)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(SceneOperationEventBase other)` | _No documentation available._ |
| `virtual boolean Equals(SceneEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# SceneManagerBecameBusyEvent
<!--
source: API\3.2.0\Callbacks\Events\SceneManagerBecameBusyEvent.md
-->

## SceneManagerBecameBusyEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `EventCallbackBase`### Description
Occurs when ASM becomes busy, as in: a scene operation is queued, or started without queue, assuming it was idle beforehand.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(SceneManagerBecameBusyEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# SceneManagerBecameIdleEvent
<!--
source: API\3.2.0\Callbacks\Events\SceneManagerBecameIdleEvent.md
-->

## SceneManagerBecameIdleEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `EventCallbackBase`### Description
Occurs when ASM becomes idle, as in: scene operation queue is empty and no non-queued operations are running.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(SceneManagerBecameIdleEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# SceneOpenEvent
<!--
source: API\3.2.0\Callbacks\Events\SceneOpenEvent.md
-->

## SceneOpenEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `SceneEvent`### Description
Occurs when a scene is opened.

<b> Remarks:</b>
Called when: `Before`, `After`.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(Scene& scene)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(SceneEvent other)` | _No documentation available._ |
| `virtual boolean Equals(SceneOpenEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# SceneOpenPhaseEvent
<!--
source: API\3.2.0\Callbacks\Events\SceneOpenPhaseEvent.md
-->

## SceneOpenPhaseEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `ScenePhaseEvent`### Description
Occurs when operation starts and finishes opening scenes.

<b> Remarks:</b>
Called when: `Before`, `After`.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(IEnumerable`1& scenes)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(ScenePhaseEvent other)` | _No documentation available._ |
| `virtual boolean Equals(SceneOpenPhaseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# SceneOperationEventBase
<!--
source: API\3.2.0\Callbacks\Events\SceneOperationEventBase.md
-->

## SceneOperationEventBase

`abstract class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `EventCallbackBase`### Description
The base class for all scene operation event callbacks.

### Properties

| Member | Description |
|--------|-------------|
| `SceneOperation operation` | The operation that invoked this event callback. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(SceneOperationEventBase other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ScenePhaseEvent
<!--
source: API\3.2.0\Callbacks\Events\ScenePhaseEvent.md
-->

## ScenePhaseEvent

`abstract class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `SceneOperationEventBase`### Description
The base class for scene phase event callbacks.

<b> Remarks:</b>
See `SceneClosePhaseEvent`, `SceneOpenPhaseEvent`, `ScenePreloadPhaseEvent`.

### Properties

| Member | Description |
|--------|-------------|
| `IEnumerable<Scene> scenes` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(IEnumerable`1& scenes)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(SceneOperationEventBase other)` | _No documentation available._ |
| `virtual boolean Equals(ScenePhaseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ScenePreloadEvent
<!--
source: API\3.2.0\Callbacks\Events\ScenePreloadEvent.md
-->

## ScenePreloadEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `SceneEvent`### Description
Occurs when a scene is preloaded.

<b> Remarks:</b>
Called when: `Before`, `After`.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(Scene& scene)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(SceneEvent other)` | _No documentation available._ |
| `virtual boolean Equals(ScenePreloadEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ScenePreloadPhaseEvent
<!--
source: API\3.2.0\Callbacks\Events\ScenePreloadPhaseEvent.md
-->

## ScenePreloadPhaseEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `ScenePhaseEvent`### Description
Occurs when operation starts and finishes preloading scenes.

<b> Remarks:</b>
Called when: `Before`, `After`.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(IEnumerable`1& scenes)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(ScenePhaseEvent other)` | _No documentation available._ |
| `virtual boolean Equals(ScenePreloadPhaseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# StartPhaseEvent
<!--
source: API\3.2.0\Callbacks\Events\StartPhaseEvent.md
-->

## StartPhaseEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `SceneOperationEventBase`### Description
Occurs before operation has begun working, but after it has started.

<b> Remarks:</b>
Properties has not been frozen at this point, and can be changed.
            
            Called when: `Unspecified` (it will be ignored).

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(SceneOperationEventBase other)` | _No documentation available._ |
| `virtual boolean Equals(StartPhaseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# StartupCancelledEvent
<!--
source: API\3.2.0\Callbacks\Events\StartupCancelledEvent.md
-->

## StartupCancelledEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `EventCallbackBase`### Description
Occurs when ASM startup is cancelled before completion.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(StartupCancelledEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# StartupFinishedEvent
<!--
source: API\3.2.0\Callbacks\Events\StartupFinishedEvent.md
-->

## StartupFinishedEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `EventCallbackBase`### Description
Occurs when ASM startup has completed successfully.

### Properties

| Member | Description |
|--------|-------------|
| `StartupProps props` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(StartupProps& props)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(StartupFinishedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# StartupStartedEvent
<!--
source: API\3.2.0\Callbacks\Events\StartupStartedEvent.md
-->

## StartupStartedEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `EventCallbackBase`### Description
Occurs when ASM startup begins, opening any collections or scenes flagged to load during startup.

### Properties

| Member | Description |
|--------|-------------|
| `StartupProps props` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(StartupProps& props)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(StartupStartedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ASMCallbackEventPropertyDrawerFilterAttribute
<!--
source: API\3.2.0\Callbacks\Events\Utility\ASMCallbackEventPropertyDrawerFilterAttribute.md
-->

## ASMCallbackEventPropertyDrawerFilterAttribute

`class` in `AdvancedSceneManager.Callbacks.Events.Utility`  /  Inherits from: `Attribute`### Description
Applies a filter to the types displayed in `ASMEventCallbackPropertyDrawer`, used for `SerializableASMEventCallbackType` fields.

### Properties

| Member | Description |
|--------|-------------|
| `Type[] HiddenTypes` | Specifies the types to hide in the list. |

---
# SerializableASMEventCallbackType
<!--
source: API\3.2.0\Callbacks\Events\Utility\SerializableASMEventCallbackType.md
-->

## SerializableASMEventCallbackType

`class` in `AdvancedSceneManager.Callbacks.Events.Utility`### Description
Represents a serializable event callback type.

<b> Remarks:</b>
Provides [SceneOperationEventBase})](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.callbacks.events.utility.serializableasmeventcallbacktype.registercallback(system.string,advancedscenemanager.core.sceneoperation,advancedscenemanager.callbacks.events.eventcallback{advancedscenemanager.callbacks.events.sceneoperationeventbase})) for easily registering the callback.
            
Also provides a property drawer.

### Fields

| Member | Description |
|--------|-------------|
| `string typeName` | The `AssemblyQualifiedName`. |
| `When when` | Represents when this event is to be called. |

### Methods

| Member | Description |
|--------|-------------|
| `boolean IsValid()` | Gets if this event callback type is valid. |
| `void RegisterCallback(string key, SceneOperation operation, EventCallback<SceneOperationEventBase> callback)` | Register callback on `operation`. |
| `void RegisterGlobalCallback(string key, EventCallback<EventCallbackBase> callback)` | Register callback globally. |
| `virtual string ToString()` | _No documentation available._ |
| `SceneOperation UnregisterCallback(string key, SceneOperation operation)` | Unregisters the callback on `operation`. |
| `void UnregisterGlobalCallback(string key)` | Unregisters the callback globally. |

---
# When
<!--
source: API\3.2.0\Callbacks\Events\When.md
-->

## When

`enum` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `Enum`### Description
Specifies when the event callback is invoked for the action it represents.

### Static Fields

| Member | Description |
|--------|-------------|
| `When After` | Specifies that the event callback was invoked after the action it represents. |
| `When Before` | Specifies that the event callback should be invoked before the action it represents. |
| `When Unspecified` | Specifies that the event callback runs both `Before` and `After`, if applicable. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# FluentInvokeAPI_Of_T
<!--
source: API\3.2.0\Callbacks\FluentInvokeAPI_Of_T.md
-->

## FluentInvokeAPI`1

`sealed class` in `AdvancedSceneManager.Callbacks`### Description

### Properties

| Member | Description |
|--------|-------------|
| `boolean hasDefaultCallback` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `IEnumerator On(SceneCollection collection, Scene[] additionalScenes)` | _No documentation available._ |
| `IEnumerator On(Scene[] scenes)` | _No documentation available._ |
| `IEnumerator On(ScriptableObject[] scriptableObjects)` | _No documentation available._ |
| `IEnumerator OnAllOpenScenes()` | _No documentation available._ |
| `FluentInvokeAPI<T> WithCallback(Callback<T> callback)` | _No documentation available._ |
| `FluentInvokeAPI<T> WithParam(object param)` | _No documentation available._ |

---
# ICollectionClose
<!--
source: API\3.2.0\Callbacks\ICollectionClose.md
-->

## ICollectionClose

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is closed.

Called after loading screen has opened, if one is defined, or else just before collection is closed.

            See also:
            
- `ICollectionClose`
- `ICollectionCloseCoroutine`
- `ICollectionCloseAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void OnCollectionClose(SceneCollection collection)` | Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is closed.

Called after loading screen has opened, if one is defined, or else just before collection is closed.

            See also:
            
- `ICollectionClose`
- `ICollectionCloseCoroutine`
- `ICollectionCloseAwaitable` |

---
# ICollectionCloseAwaitable
<!--
source: API\3.2.0\Callbacks\ICollectionCloseAwaitable.md
-->

## ICollectionCloseAwaitable

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is closed.

Called after loading screen has opened, if one is defined, or else just before collection is closed.

            See also:
            
- `ICollectionClose`
- `ICollectionCloseCoroutine`
- `ICollectionCloseAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual Awaitable OnCollectionClose(SceneCollection collection)` | Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is closed.

Called after loading screen has opened, if one is defined, or else just before collection is closed.

            See also:
            
- `ICollectionClose`
- `ICollectionCloseCoroutine`
- `ICollectionCloseAwaitable` |

---
# ICollectionCloseCoroutine
<!--
source: API\3.2.0\Callbacks\ICollectionCloseCoroutine.md
-->

## ICollectionCloseCoroutine

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is closed.

Called after loading screen has opened, if one is defined, or else just before collection is closed.

            See also:
            
- `ICollectionClose`
- `ICollectionCloseCoroutine`
- `ICollectionCloseAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual IEnumerator OnCollectionClose(SceneCollection collection)` | Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is closed.

Called after loading screen has opened, if one is defined, or else just before collection is closed.

            See also:
            
- `ICollectionClose`
- `ICollectionCloseCoroutine`
- `ICollectionCloseAwaitable` |

---
# ICollectionExtraDataCallbacks
<!--
source: API\3.2.0\Callbacks\ICollectionExtraDataCallbacks.md
-->

## ICollectionExtraDataCallbacks

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callbacks for a `ScriptableObject` that has been set as extra data for a collection.
            
            See also:
            
- `ICollectionExtraDataCallbacks`
- `ICollectionExtraDataCallbacksCoroutine`
- `ICollectionExtraDataCallbacksAwaitable`

---
# ICollectionExtraDataCallbacksAwaitable
<!--
source: API\3.2.0\Callbacks\ICollectionExtraDataCallbacksAwaitable.md
-->

## ICollectionExtraDataCallbacksAwaitable

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callbacks for a `ScriptableObject` that has been set as extra data for a collection.
            
            See also:
            
- `ICollectionExtraDataCallbacks`
- `ICollectionExtraDataCallbacksCoroutine`
- `ICollectionExtraDataCallbacksAwaitable`

---
# ICollectionExtraDataCallbacksCoroutine
<!--
source: API\3.2.0\Callbacks\ICollectionExtraDataCallbacksCoroutine.md
-->

## ICollectionExtraDataCallbacksCoroutine

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callbacks for a `ScriptableObject` that has been set as extra data for a collection.
            
            See also:
            
- `ICollectionExtraDataCallbacks`
- `ICollectionExtraDataCallbacksCoroutine`
- `ICollectionExtraDataCallbacksAwaitable`

---
# ICollectionOpen
<!--
source: API\3.2.0\Callbacks\ICollectionOpen.md
-->

## ICollectionOpen

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is opened.

Called before loading screen is hidden, if one is defined, or else just when collection has opened.

            See also:
            
- `ICollectionOpen`
- `ICollectionOpen`
- `ICollectionOpenAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void OnCollectionOpen(SceneCollection collection)` | Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is opened.

Called before loading screen is hidden, if one is defined, or else just when collection has opened.

            See also:
            
- `ICollectionOpen`
- `ICollectionOpen`
- `ICollectionOpenAwaitable` |

---
# ICollectionOpenAwaitable
<!--
source: API\3.2.0\Callbacks\ICollectionOpenAwaitable.md
-->

## ICollectionOpenAwaitable

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is opened.

Called before loading screen is hidden, if one is defined, or else just when collection has opened.

            See also:
            
- `ICollectionOpen`
- `ICollectionOpen`
- `ICollectionOpenAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual Awaitable OnCollectionOpen(SceneCollection collection)` | Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is opened.

Called before loading screen is hidden, if one is defined, or else just when collection has opened.

            See also:
            
- `ICollectionOpen`
- `ICollectionOpen`
- `ICollectionOpenAwaitable` |

---
# ICollectionOpenCoroutine
<!--
source: API\3.2.0\Callbacks\ICollectionOpenCoroutine.md
-->

## ICollectionOpenCoroutine

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is opened.

Called before loading screen is hidden, if one is defined, or else just when collection has opened.

            See also:
            
- `ICollectionOpen`
- `ICollectionOpen`
- `ICollectionOpenAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual IEnumerator OnCollectionOpen(SceneCollection collection)` | Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is opened.

Called before loading screen is hidden, if one is defined, or else just when collection has opened.

            See also:
            
- `ICollectionOpen`
- `ICollectionOpen`
- `ICollectionOpenAwaitable` |

---
# ISceneCallbacks
<!--
source: API\3.2.0\Callbacks\ISceneCallbacks.md
-->

## ISceneCallbacks

`interface` in `AdvancedSceneManager.Callbacks`### Description
Base interface for `MonoBehaviour` callbacks. Just implement any of the following to have ASM call them during scene operations.
            
- `ISceneOpen`, `ISceneClose`, `ICollectionOpen`, `ICollectionClose`
- `ISceneOpenCoroutine`, `ISceneCloseCoroutine`, `ICollectionOpen`, `ICollectionCloseCoroutine`
- `ISceneOpenAwaitable`, `ISceneCloseAwaitable`, `ICollectionOpenAwaitable`, `ICollectionCloseAwaitable`
- `ICollectionExtraDataCallbacks`, `ICollectionExtraDataCallbacksCoroutine`, `ICollectionExtraDataCallbacksAwaitable`

---
# ISceneClose
<!--
source: API\3.2.0\Callbacks\ISceneClose.md
-->

## ISceneClose

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when the scene that a `MonoBehaviour` is contained within is closed.

<b> Remarks:</b>
See also:
            
- `ISceneClose`
- `ISceneCloseCoroutine`
- `ISceneCloseAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void OnSceneClose()` | Callback for when the scene that a `MonoBehaviour` is contained within is closed. |

---
# ISceneCloseAwaitable
<!--
source: API\3.2.0\Callbacks\ISceneCloseAwaitable.md
-->

## ISceneCloseAwaitable

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when the scene that a `MonoBehaviour` is contained within is closed.

<b> Remarks:</b>
See also:
            
- `ISceneClose`
- `ISceneCloseCoroutine`
- `ISceneCloseAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual Awaitable OnSceneClose()` | Callback for when the scene that a `MonoBehaviour` is contained within is closed. |

---
# ISceneCloseCoroutine
<!--
source: API\3.2.0\Callbacks\ISceneCloseCoroutine.md
-->

## ISceneCloseCoroutine

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when the scene that a `MonoBehaviour` is contained within is closed.

<b> Remarks:</b>
See also:
            
- `ISceneClose`
- `ISceneCloseCoroutine`
- `ISceneCloseAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual IEnumerator OnSceneClose()` | Callback for when the scene that a `MonoBehaviour` is contained within is closed. |

---
# ISceneOpen
<!--
source: API\3.2.0\Callbacks\ISceneOpen.md
-->

## ISceneOpen

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when the scene that a `MonoBehaviour` is contained within is opened.
            See also:
            
- `ISceneOpen`
- `ISceneOpenCoroutine`
- `ISceneOpenAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void OnSceneOpen()` | Callback for when the scene that a `MonoBehaviour` is contained within is opened.
            See also:
            
- `ISceneOpen`
- `ISceneOpenCoroutine`
- `ISceneOpenAwaitable` |

---
# ISceneOpenAwaitable
<!--
source: API\3.2.0\Callbacks\ISceneOpenAwaitable.md
-->

## ISceneOpenAwaitable

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when the scene that a `MonoBehaviour` is contained within is opened.
            See also:
            
- `ISceneOpen`
- `ISceneOpenCoroutine`
- `ISceneOpenAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual Awaitable OnSceneOpen()` | Callback for when the scene that a `MonoBehaviour` is contained within is opened.
            See also:
            
- `ISceneOpen`
- `ISceneOpenCoroutine`
- `ISceneOpenAwaitable` |

---
# ISceneOpenCoroutine
<!--
source: API\3.2.0\Callbacks\ISceneOpenCoroutine.md
-->

## ISceneOpenCoroutine

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when the scene that a `MonoBehaviour` is contained within is opened.
            See also:
            
- `ISceneOpen`
- `ISceneOpenCoroutine`
- `ISceneOpenAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual IEnumerator OnSceneOpen()` | Callback for when the scene that a `MonoBehaviour` is contained within is opened.
            See also:
            
- `ISceneOpen`
- `ISceneOpenCoroutine`
- `ISceneOpenAwaitable` |

---
# OnCollectionCloseAttribute
<!--
source: API\3.2.0\Callbacks\OnCollectionCloseAttribute.md
-->

## OnCollectionCloseAttribute

`class` in `AdvancedSceneManager.Callbacks`  /  Inherits from: `SceneCallbackAttribute`### Description

### Properties

| Member | Description |
|--------|-------------|
| `TargetInfo target` | _No documentation available._ |

---
# OnCollectionOpenAttribute
<!--
source: API\3.2.0\Callbacks\OnCollectionOpenAttribute.md
-->

## OnCollectionOpenAttribute

`class` in `AdvancedSceneManager.Callbacks`  /  Inherits from: `SceneCallbackAttribute`### Description

### Properties

| Member | Description |
|--------|-------------|
| `TargetInfo target` | _No documentation available._ |

---
# OnLoadAttribute
<!--
source: API\3.2.0\Callbacks\OnLoadAttribute.md
-->

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

---
# OnSceneCloseAttribute
<!--
source: API\3.2.0\Callbacks\OnSceneCloseAttribute.md
-->

## OnSceneCloseAttribute

`class` in `AdvancedSceneManager.Callbacks`  /  Inherits from: `SceneCallbackAttribute`### Description

### Properties

| Member | Description |
|--------|-------------|
| `TargetInfo target` | _No documentation available._ |

---
# OnSceneOpenAttribute
<!--
source: API\3.2.0\Callbacks\OnSceneOpenAttribute.md
-->

## OnSceneOpenAttribute

`class` in `AdvancedSceneManager.Callbacks`  /  Inherits from: `SceneCallbackAttribute`### Description

### Properties

| Member | Description |
|--------|-------------|
| `TargetInfo target` | _No documentation available._ |

---
# SceneCallbackAttribute
<!--
source: API\3.2.0\Callbacks\SceneCallbackAttribute.md
-->

## SceneCallbackAttribute

`abstract class` in `AdvancedSceneManager.Callbacks`  /  Inherits from: `DiscoverableAttribute`### Description

---
# App
<!--
source: API\3.2.0\Core\App.md
-->

## App

`class` in `AdvancedSceneManager.Core`### Description
Manages startup and quit processes.

<b> Remarks:</b>
Usage: `app`.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isASMPlay { get; }` | Gets whatever we're currently in ASM play mode. |
| `boolean isQuitting { get; }` | Gets whatever ASM is currently in the process of quitting the game. |
| `boolean isRestart { get; }` | Gets if ASM has been restarted, or is currently restarting. |
| `boolean isRunningStartupProcess { get; }` | Gets if ASM startup process is running. |
| `boolean isStartupFinished { get; }` | Gets if startup process is finished. |
| `ProgressScope startupProgressScope { get; }` | Gets the progress scope used during startup. |
| `StartupProps startupProps` | Gets the props that should be used for startup process. |

### Methods

| Member | Description |
|--------|-------------|
| `void CancelQuit()` | Cancels the current quit process. |
| `void CancelStartup()` | Cancels startup process. |
| `void Exit()` | Exits the application immediately. |
| `void Play(StartupProps props)` | _No documentation available._ |
| `Awaitable Quit(boolean fade, Nullable<Color> fadeColor, single fadeDuration)` | Quits the application with optional fade effect. |
| `void RegisterQuitCallback(Func<IEnumerator> coroutine)` | Register a callback to be called before quit. |
| `void Restart(StartupProps props)` | _No documentation available._ |
| `Async<boolean> RestartAsync(StartupProps props)` | _No documentation available._ |
| `void UnregisterQuitCallback(Func<IEnumerator> coroutine)` | Unregister a callback that was to be called before quit. |

---
# Indicator
<!--
source: API\3.2.0\Core\Indicator.md
-->

## Indicator

`struct` in `AdvancedSceneManager.Core`  /  Inherits from: `ValueType`### Description

### Properties

| Member | Description |
|--------|-------------|
| `Nullable<Color> color` | _No documentation available._ |
| `Func<Texture2D> icon` | _No documentation available._ |
| `Action<Scene> onClick` | _No documentation available._ |
| `string text` | _No documentation available._ |
| `string tooltip` | _No documentation available._ |
| `boolean useFontAwesome` | _No documentation available._ |
| `boolean useFontAwesomeBrands` | _No documentation available._ |

---
# Package
<!--
source: API\3.2.0\Core\Package.md
-->

## Package

`class` in `AdvancedSceneManager.Core`### Description
Contains info about the ASM package.

<b> Remarks:</b>
Only available in editor.

### Properties

| Member | Description |
|--------|-------------|
| `string folder` | The folder that ASM is contained within. |
| `string id` | The id of this package. |
| `string version { get; }` | The version of ASM. |

---
# Runtime
<!--
source: API\3.2.0\Core\Runtime.md
-->

## Runtime

`class` in `AdvancedSceneManager.Core`### Description
Manages runtime functionality for Advanced Scene Manager such as open scenes and collection.

### Properties

| Member | Description |
|--------|-------------|
| `Scene activeScene` | Gets the currently active scene, assuming it has been imported into ASM. |
| `SceneOperation currentOperation` | Gets the current active operation in the queue. |
| `Scene dontDestroyOnLoad` | Gets the dontDestroyOnLoad scene. |
| `boolean isBusy` | Gets whatever ASM is busy with any scene operations. |
| `boolean isPreloadedCollectionAdditive { get; }` | Gets if `preloadedCollection` is additive. |
| `IEnumerable<SceneCollection> openAdditiveCollections` | Gets the collections that are opened as additive. |
| `SceneCollection openCollection` | Gets the collection that is currently open. |
| `IEnumerable<Scene> openScenes` | Gets the scenes that are currently open. |
| `SceneCollection preloadedCollection { get; }` | Gets the currently preloaded collection. |
| `IEnumerable<Scene> preloadedScenes` | Gets the scenes that are preloaded. |
| `IEnumerable<SceneOperation> queuedOperations` | Gets the current scene operation queue. |
| `IEnumerable<SceneOperation> runningOperations` | The currently running scene operations. |
| `IEnumerable<Scene> unimportedScenes` | Gets all open Unity scenes that are not imported into ASM. |

### Fields

| Member | Description |
|--------|-------------|
| `Action onAllScenesClosed` | Occurs when the last user scene closes. |

### Events

| Member | Description |
|--------|-------------|
| `event Action<SceneCollection> collectionClosed` | Occurs when a collection is closed. |
| `event Action<SceneCollection> collectionOpened` | Occurs when a collection is opened. |
| `event Action<Scene> sceneClosed` | Occurs when a scene is closed. |
| `event Action sceneLoaderAdded` | Occurs when a `SceneLoader` is added. |
| `event Action sceneLoaderRemoved` | Occurs when a `SceneLoader` is removed. |
| `event Action<ValueTuple<Scene, Type, Type>> sceneLoaderToggled` | Occurs when a `SceneLoader` is toggled for a scene. |
| `event Action<Scene> sceneOpened` | Occurs when a scene is opened. |
| `event Action<Scene> scenePreloaded` | Occurs when a scene is preloaded. |
| `event Action<Scene> scenePreloadFinished` | Occurs when a previously preloaded scene is opened. |
| `event Action startedWorking` | Occurs when ASM has started working and is running scene operations. |
| `event Action stoppedWorking` | Occurs when ASM has finished working and no scene operations are running. |

### Methods

| Member | Description |
|--------|-------------|
| `void Activate(Scene scene)` | Activates this scene. |
| `void AddProgressListener(ILoadProgressListener listener)` | _No documentation available._ |
| `void AddSceneLoader<T>()` | _No documentation available._ |
| `SceneOperation CancelPreload()` | Cancels the preload. All preloaded scenes will be fully loaded (limitation by Unity), then closed. No ASM scene callbacks will be called. |
| `SceneOperation Close(SceneCollection collection)` | Closes `collection`. |
| `SceneOperation Close(SceneOperation operation, SceneCollection collection)` | _No documentation available._ |
| `SceneOperation Close(Scene scene)` | Closes this scene. |
| `SceneOperation Close(Scene[] scenes)` | _No documentation available._ |
| `SceneOperation Close(IEnumerable<Scene> scenes)` | Closes this scene. |
| `SceneOperation Close(IEnumerable<Scene> scenes, boolean skipEmptySceneCheck)` | _No documentation available._ |
| `SceneOperation CloseAll(boolean exceptLoadingScreens, boolean exceptUnimported, Scene[] except)` | Closes all scenes and collections. |
| `IEnumerator CloseUnimportedScenes()` | Closes all open Unity scenes that are not imported into ASM. |
| `SceneOperation CloseWithLoadingScreen(Scene scene, Scene loadingScreen)` | _No documentation available._ |
| `SceneOperation CloseWithLoadingScreen(IEnumerable<Scene> scene, Scene loadingScreen)` | _No documentation available._ |
| `IEnumerable<Scene> EvalScenesToClose(SceneCollection closeCollection, SceneCollection nextCollection, SceneCollection additiveCloseCollection)` | Evaluate the scenes that would close. |
| `IEnumerable<Scene> EvalScenesToOpen(SceneCollection collection, boolean openAll)` | Evaluate the scenes that would open. |
| `SceneOperation FinishPreload()` | Finish loading preloaded scenes. |
| `void ForceTrack(Scene scene)` | Tracks a scene that doesn't have a associated unity scene. |
| `SceneLoader GetLoaderForScene(Scene scene, boolean useOnlyGlobal)` | Gets the loader for `scene`. |
| `SceneLoader GetSceneLoader(string sceneLoader)` | Returns the scene loader with the specified key. |
| `Type GetSceneLoaderType(string sceneLoader)` | Returns the scene loader type with the specified key. |
| `SceneState GetState(Scene scene)` | _No documentation available._ |
| `IEnumerable<SceneLoader> GetToggleableSceneLoaders()` | Gets a list of all added scene loaders that can be toggled scene by scene. |
| `boolean IsQueued(SceneCollection collection)` | Gets if this collection is currently queued to be opened. |
| `boolean IsQueued(Scene scene)` | Gets if this scene is queued to be opened. |
| `boolean IsTracked(Scene scene)` | Gets whatever this scene is tracked as open. |
| `boolean IsTracked(SceneCollection collection)` | Gets whatever this collection is tracked as open. |
| `SceneOperation Open(SceneCollection collection, boolean openAll)` | Opens the collection. |
| `SceneOperation Open(Scene scene)` | Opens this scene. |
| `SceneOperation Open(Scene[] scenes)` | _No documentation available._ |
| `SceneOperation Open(IEnumerable<Scene> scenes)` | Opens this scene. |
| `SceneOperation OpenAdditive(SceneCollection collection, boolean openAll)` | Opens the collection without closing existing scenes. |
| `SceneOperation OpenAdditive(IEnumerable<SceneCollection> collections, SceneCollection activeCollection, LoadingScreenReference loadingScreen)` | Opens the collection without closing existing scenes. |
| `SceneOperation OpenAndActivate(Scene scene)` | Opens this scene and activates it. |
| `SceneOperation OpenWithLoadingScreen(Scene scene, Scene loadingScreen)` | _No documentation available._ |
| `SceneOperation OpenWithLoadingScreen(IEnumerable<Scene> scene, Scene loadingScreen)` | _No documentation available._ |
| `SceneOperation Preload(IEnumerable<Scene> scenes, Action<Scene> onPreloaded)` | Preloads the scenes. |
| `SceneOperation Preload(SceneCollection collection, boolean openAll)` | Preloads the collection. |
| `SceneOperation Preload(Scene scene, Action onPreloaded)` | _No documentation available._ |
| `SceneOperation Preload(Action<Scene> onPreloaded, Scene[] scenes)` | Preloads the specified scenes. |
| `SceneOperation Preload(Scene[] scenes)` | Preloads the specified scenes. |
| `SceneOperation PreloadAdditive(SceneCollection collection, boolean openAll)` | Preloads the collection as additive. |
| `void RemoveProgressListener(ILoadProgressListener listener)` | _No documentation available._ |
| `void RemoveSceneLoader<T>()` | _No documentation available._ |
| `SceneOperation Reopen(SceneCollection collection, boolean openAll)` | Reopens the collection. |
| `SceneOperation Reopen(Scene scene)` | Reopens this scene. |
| `SceneOperation Reopen(IEnumerable<Scene> scene)` | _No documentation available._ |
| `SceneOperation ToggleOpen(SceneCollection collection, boolean openAll)` | Toggles the collection open or closed. |
| `SceneOperation ToggleOpen(Scene scene)` | Toggles this scene open or closed. |
| `void Track(Scene scene, Scene unityScene)` | Tracks the specified scene as open. |
| `void Track(Scene scene)` | _No documentation available._ |
| `void Track(SceneCollection collection, boolean isAdditive)` | Tracks the collection as open. |
| `boolean Untrack(Scene scene)` | Untracks the specified scene as open. |
| `void Untrack(SceneCollection collection, boolean isAdditive)` | Untracks the collection. |
| `void UntrackCollections()` | Untracks all collections. |
| `void UntrackScenes()` | Untracks all open scenes. |

---
# RuntimeSceneLoader
<!--
source: API\3.2.0\Core\RuntimeSceneLoader.md
-->

## RuntimeSceneLoader

`class` in `AdvancedSceneManager.Core`  /  Inherits from: `SceneLoader`### Description
A scene loader that uses the normal play mode API. 
            
See [LoadSceneMode)](https://learn.microsoft.com/dotnet/api/m:unityengine.scenemanagement.scenemanager.loadsceneasync(system.string,unityengine.scenemanagement.loadscenemode)).

See [Scene)](https://learn.microsoft.com/dotnet/api/m:unityengine.scenemanagement.scenemanager.unloadsceneasync(unityengine.scenemanagement.scene)).

### Properties

| Member | Description |
|--------|-------------|
| `boolean activeOutsideOfPlayMode` | Specifies whatever this loader will run outside of play mode or not. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual boolean CanHandleScene(Scene scene)` | Gets whatever this scene loader can handle the scene. |
| `virtual IEnumerator LoadScene(Scene scene, SceneLoadArgs e)` | Loads the scene specified in e.scene. |
| `virtual IEnumerator UnloadScene(Scene scene, SceneUnloadArgs e)` | Unloads the scene specified in e.scene. |

---
# SceneLoadArgs
<!--
source: API\3.2.0\Core\SceneLoadArgs.md
-->

## SceneLoadArgs

`class` in `AdvancedSceneManager.Core`  /  Inherits from: `SceneLoaderArgsBase`### Description
Specifies arguments for [SceneLoadArgs)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.core.sceneloader.loadscene(advancedscenemanager.models.scene,advancedscenemanager.core.sceneloadargs)).

### Properties

| Member | Description |
|--------|-------------|
| `boolean isPreload { get; }` | Specifies if the scene should be preloaded. |

### Methods

| Member | Description |
|--------|-------------|
| `boolean CheckIsIncluded(boolean logError)` | Checks if the scene is actually included in build. |
| `Scene GetOpenedScene()` | Gets the `Scene` that was opened by this override. |
| `void SetCompleted(Scene scene)` | Notifies ASM that the load is done. |
| `void SetCompleted(Scene scene, Func<IEnumerator> preloadCallback)` | _No documentation available._ |
| `void SetCompletedWithoutScene()` | Sets this loader as complete even though no scene was loaded. |

---
# SceneLoader
<!--
source: API\3.2.0\Core\SceneLoader.md
-->

## SceneLoader

`abstract class` in `AdvancedSceneManager.Core`### Description
Specifies a scene loader.

### Properties

| Member | Description |
|--------|-------------|
| `boolean activeInPlayMode` | Specifies whatever this loader will run in play mode or not. |
| `boolean activeOutsideOfPlayMode` | Specifies whatever this loader will run outside of play mode or not. |
| `boolean addScenesToBuildSettings` | Specifies whatever scenes using this loader should be added to build settings scene list. |
| `boolean canBeActivated` | Gets whatever this loader may be activated in the current context. |
| `Indicator indicator` | Specifies the indicator on scene fields for this scene loader. |
| `boolean isGlobal` | Specifies if this scene loader will can be applied to all scenes. Otherwise scenes will have to be explicitly flagged to open with this loader. |
| `string Key` | Gets the key for this scene loader. |
| `string sceneToggleText` | Specifies the text to display on the toggle in scene popup. Only has an effect if `isGlobal` is `false`. |
| `string sceneToggleTooltip` | Specifies the tooltip to display on the toggle in scene popup. Only has an effect if `isGlobal` is `false`. |

### Static Methods

| Member | Description |
|--------|-------------|
| `string GetKey<T>()` | _No documentation available._ |
| `string GetKey<T>(T obj)` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual boolean CanHandleScene(Scene scene)` | Gets whatever this scene loader can handle the scene. |
| `IEnumerator LoadDefault(SceneLoadArgs e)` | Loads scene using default ASM loaders. |
| `abstract virtual IEnumerator LoadScene(Scene scene, SceneLoadArgs e)` | Loads the scene specified in e.scene. |
| `IEnumerator UnloadDefault(SceneUnloadArgs e)` | Unloads scene using default ASM loaders. |
| `abstract virtual IEnumerator UnloadScene(Scene scene, SceneUnloadArgs e)` | Unloads the scene specified in e.scene. |

---
# SceneLoaderArgsBase
<!--
source: API\3.2.0\Core\SceneLoaderArgsBase.md
-->

## SceneLoaderArgsBase

`abstract class` in `AdvancedSceneManager.Core`### Description
Base class for `SceneLoadArgs` and `SceneUnloadArgs`.

### Properties

| Member | Description |
|--------|-------------|
| `SceneCollection collection { get; }` | The collection that the scene belongs to, if any. |
| `string errorMessage { get; }` | The error message if `isError` is `true`. |
| `boolean isError { get; }` | Indicates whether this operation resulted in an error. |
| `boolean isLoadingScreen` | Gets whether the associated scene is a loading screen. |
| `boolean isSplashScreen` | Gets whether the associated scene is a splash screen. |
| `SceneOperation operation { get; }` | The `SceneOperation` representing the current load or unload operation. |
| `boolean reportProgress { get; }` | Determines whether progress should be reported during this operation. |
| `Scene scene { get; }` | The scene associated with this loading or unloading operation. |

### Methods

| Member | Description |
|--------|-------------|
| `void SetError(string message)` | Marks this operation as failed with the specified error message. |

---
# SceneLoaderExtensions
<!--
source: API\3.2.0\Core\SceneLoaderExtensions.md
-->

## SceneLoaderExtensions

`static class` in `AdvancedSceneManager.Core`### Description
Provides extensions for scene loading.

<b> Remarks:</b>
This provides access to direct scene loading / unloading, which bypasses many checks that .Open() / .Close() has. Make sure to test thoroughly.

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerator Load(Scene scene, SceneLoadArgs e)` | _No documentation available._ |
| `IEnumerator Load(Scene scene, boolean isPreload, SceneOperation operation, SceneCollection collection, boolean reportsProgress, Nullable<ThreadPriority> loadPriority, Action onLoaded, Action<string> onError, boolean useOnlyGlobal)` | Loads the scene using a scene loader. |
| `IEnumerator Unload(Scene scene, SceneUnloadArgs e)` | _No documentation available._ |
| `IEnumerator Unload(Scene scene, SceneOperation operation, SceneCollection collection, boolean reportsProgress, Nullable<ThreadPriority> loadPriority, Action onUnloaded, Action<string> onError, boolean useOnlyGlobal)` | Unloads the scene using a scene loader. |

---
# SceneOperation
<!--
source: API\3.2.0\Core\SceneOperation.md
-->

## SceneOperation

`class` in `AdvancedSceneManager.Core`  /  Inherits from: `CustomYieldInstruction`### Description
A scene operation is a queueable operation that can open or close scenes..

### Static Properties

| Member | Description |
|--------|-------------|
| `SceneOperation done` | Gets a `SceneOperation` that has already completed. |

### Properties

| Member | Description |
|--------|-------------|
| `boolean acceptsSubOperations { get; }` | Gets if this operation is currently executing open callbacks. If so, sub operations is temporarily accepted. |
| `IEnumerable<Scene> close { get; }` | Gets the scenes specified to close. |
| `IEnumerable<Scene> closedScenes` | Gets the scenes that was closed during this operation. |
| `SceneCollection collection { get; }` | Specifies the collection that is being opened or closed. |
| `string description { get; }` | Specifies description for coroutine. |
| `EventCallbackManager<SceneOperationEventBase> events { get; }` | Gets the event manager for this operation. |
| `SceneOperationFlags flags { get; }` | Gets the operation flags this operation will use. |
| `Scene focus { get; }` | Sets focus to the specified scene. Overrides selected scene in collections. |
| `boolean focusSingleScene { get; }` | Sets the first opened scene as active. |
| `boolean hasStarted { get; }` | Gets whether this operation has started. |
| `IEnumerable<Scene> ignoreForActivation { get; }` | Gets the scenes that should not be activated. |
| `boolean isCollectionCloseOperation { get; }` | Gets whatever this operation is about to close `collection`. |
| `boolean isDefaultASMScene { get; }` | Gets if this scene was opened from the default ASM scene collection. |
| `boolean isFrozen { get; }` | Gets if this operation is frozen, as in, can its properties be changed? |
| `boolean isStandaloneScene { get; }` | Gets if this scene was opened from the standalone collection. |
| `boolean keepWaiting` | Inherited from `CustomYieldInstruction`. Tells unity whatever the operation is done or not. |
| `LoadingScreenReference loadingScreen { get; }` | Gets the specified loading screen. |
| `Action<LoadingScreenReference> loadingScreenCallback { get; }` | Gets the specified loading screen callback. |
| `LoadPriority loadPriority { get; }` | Gets the `LoadPriority` this operation will use. |
| `IEnumerable<Scene> open { get; }` | Gets the scenes specified to open. |
| `LoadingScreenReference openedLoadingScreen { get; }` | Gets the loading screen that was opened by this operation. |
| `IEnumerable<Scene> openedScenes` | Gets the scenes that was opened during this operation. |
| `IEnumerable<Scene> preload { get; }` | Gets the scenes specified to preload. |
| `single progress` | Gets the total progress of this operation. |
| `ProgressScope progressScope { get; }` | Gets the progress scope associated with this operation. |
| `boolean reportsProgress { get; }` | Gets if this scene operation reports progress. |
| `boolean runSceneCallbacksOutsideOfPlayMode { get; }` | Gets whatever scene callbacks should run outside of play mode. |
| `boolean setActiveCollectionScene { get; }` | Specifies whatever active scene should be set when possible. |
| `Nullable<boolean> unloadUnusedAssets { get; }` | Gets whatever `UnloadUnusedAssets` should be called at the end (before loading screen). |
| `boolean useLoadingScene { get; }` | Gets whatever a loading screen should be used. |
| `boolean wasCancelled { get; }` | Gets if this scene operation is cancelled. |

### Static Methods

| Member | Description |
|--------|-------------|
| `SceneOperation Queue()` | _No documentation available._ |
| `SceneOperation Queue(SceneOperation operation)` | Queues a new scene operation. |
| `SceneOperation Start()` | _No documentation available._ |
| `SceneOperation Start(SceneOperation operation)` | Starts a new scene operation, ignoring queue. |

### Methods

| Member | Description |
|--------|-------------|
| `SceneOperation Activate(Scene scene)` | Sets focus to the specified scene. Overrides selected scene in collections. If `null`, then the first scene opened will be set as active. |
| `void Cancel()` | Cancel this operation. |
| `SceneOperation Close(SceneCollection collection)` | _No documentation available._ |
| `SceneOperation Close(Scene scene, boolean removeFromOpen)` | Specifies the scenes to close. |
| `SceneOperation Close(Scene[] scenes)` | Specifies the scenes to close. |
| `SceneOperation Close(IEnumerable<Scene> scenes, boolean removeFromOpen)` | _No documentation available._ |
| `SceneOperation CloseAll(Scene[] except)` | _No documentation available._ |
| `SceneOperation CloseAll(IEnumerable<Scene> except, boolean removeFromOpen)` | Closes all scenes, regardless if they are persistent or splash/loading screens. |
| `SceneOperation CloseOtherScenes(Scene[] except)` | Closes all non-persistent scenes prior to opening any scenes. |
| `SceneOperation CloseOtherScenes(boolean persistent, IEnumerable<Scene> except, boolean loadingScreen, boolean splashScreen, boolean removeFromOpen)` | Closes all open scenes prior to opening any scenes, with options. |
| `SceneOperation DisableProgressReporting()` | Disables progress reporting for this operation. |
| `SceneOperation Focus(Scene scene)` | Sets focus to the specified scene. Overrides selected scene in collections. |
| `CoroutineAwaiter GetAwaiter()` | Allows this operation to be awaited. |
| `SceneOperation IgnoreForActivation(IEnumerable<Scene> scenes)` | Specifies scenes that should not be activated. |
| `SceneOperation OnProgressChanged(Action<single> callback)` | Adds a callback when progress changed. |
| `SceneOperation Open(SceneCollection collection, boolean openAll)` | _No documentation available._ |
| `SceneOperation Open(Scene[] scenes)` | Specifies the scenes to open. |
| `SceneOperation Open(Scene scene, boolean removeFromClose)` | Specifies the scenes to open. |
| `SceneOperation Open(IEnumerable<Scene> scenes, boolean removeFromClose)` | _No documentation available._ |
| `SceneOperation OpenAndActivate(Scene scene)` | Opens the scene, and makes sure it is activated afterwards. |
| `SceneOperation Preload(Scene[] scenes)` | Specifies scenes to preload. |
| `SceneOperation Preload(IEnumerable<Scene> scenes)` | Specifies scenes to preload. |
| `SceneOperation PrependOpen(Scene[] scenes)` | Specifies the scenes to prepend to the current open operation. |
| `SceneOperation PrependOpen(IEnumerable<Scene> scenes, boolean ignoreForActivation)` | _No documentation available._ |
| `SceneOperation RegisterCallback<TEventType>(EventCallback<TEventType> callback, When when, string key)` | _No documentation available._ |
| `SceneOperation RemoveOnProgressChangedCallback(Action<single> callback)` | Removes a callback when progress changed. |
| `SceneOperation RunSceneCallbacksOutsidePlayMode(boolean value)` | Specifies whatever scene callbacks should run outside of play mode. |
| `SceneOperation UnloadUsedAssets()` | Specifies whatever `UnloadUnusedAssets` should be called at the end (before loading screen). |
| `SceneOperation UnregisterCallback<TEventType>(EventCallback<TEventType> callback, When when, string key)` | _No documentation available._ |
| `void UnregisterCallback<TEventType>(string key)` | _No documentation available._ |
| `void WaitFor(SceneOperation operation)` | Waits for the specified scene operation to complete before continuing. |
| `SceneOperation With(SceneCollection collection, boolean setActiveScene, boolean isCloseOperation)` | Specifies an associated collection. |
| `SceneOperation With(LoadingScreenReference loadingScreen, boolean useLoadingScene)` | Specifies loading screen to use. |
| `SceneOperation With(boolean useLoadingScene)` | Specifies loading screen to use. |
| `SceneOperation With(Action<LoadingScreenReference> loadingScreenCallback)` | Specifies a callback when loading screen is opened, before `OnOpen` is called. |
| `SceneOperation With(LoadPriority loadPriority)` | Sets the `LoadPriority` this operation will use. |
| `SceneOperation With(SceneOperationFlags flags)` | Sets the operation flags this operation will use. |
| `SceneOperation WithFriendlyText(string text)` | Specifies description for operation coroutine. |
| `SceneOperation WithLoadingScreen(LoadingScreenReference loadingScreen, boolean useLoadingScene)` | Specifies loading screen to use. |
| `SceneOperation WithLoadingScreen(boolean useLoadingScene)` | Specifies whatever loading screen should be used. |
| `SceneOperation WithoutLoadingScreen(boolean useLoadingScene)` | Specifies whatever loading screen should be used. |

---
# SceneOperationFlags
<!--
source: API\3.2.0\Core\SceneOperationFlags.md
-->

## SceneOperationFlags

`enum` in `AdvancedSceneManager.Core`  /  Inherits from: `Enum`### Description
Defines flags that control the behavior of a `SceneOperation`.

### Static Fields

| Member | Description |
|--------|-------------|
| `SceneOperationFlags All` | Enables all available operation flags. |
| `SceneOperationFlags CollectionCallbacks` | Invokes callbacks defined on the associated `SceneCollection`. |
| `SceneOperationFlags EventCallbacks` | Triggers global event callbacks related to the operation. |
| `SceneOperationFlags LoadingScreen` | Includes loading screen scenes in the operation. |
| `SceneOperationFlags None` | No flags are set. |
| `SceneOperationFlags SceneCallbacks` | Invokes callbacks defined on the involved `Scene` objects. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# SceneOperationKind
<!--
source: API\3.2.0\Core\SceneOperationKind.md
-->

## SceneOperationKind

`enum` in `AdvancedSceneManager.Core`  /  Inherits from: `Enum`### Description
Gets the kind of operation that a `SceneLoadProgressData` represents.

### Static Fields

| Member | Description |
|--------|-------------|
| `SceneOperationKind Load` | A scene is currently being loaded. |
| `SceneOperationKind Unload` | A scene is currently being unloaded |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# SceneUnloadArgs
<!--
source: API\3.2.0\Core\SceneUnloadArgs.md
-->

## SceneUnloadArgs

`class` in `AdvancedSceneManager.Core`  /  Inherits from: `SceneLoaderArgsBase`### Description
Specifies arguments for [SceneUnloadArgs)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.core.sceneloader.unloadscene(advancedscenemanager.models.scene,advancedscenemanager.core.sceneunloadargs)).

### Methods

| Member | Description |
|--------|-------------|
| `void SetCompleted()` | Notifies ASM that the unload is done. |

---
# StartupProps
<!--
source: API\3.2.0\Core\StartupProps.md
-->

## StartupProps

`class` in `AdvancedSceneManager.Core`### Description

### Properties

| Member | Description |
|--------|-------------|
| `Color effectiveFadeColor` | _No documentation available._ |
| `boolean runStartupProcess` | _No documentation available._ |
| `boolean runStartupProcessWhenPlayingCollection` | _No documentation available._ |

### Fields

| Member | Description |
|--------|-------------|
| `Nullable<Color> fadeColor` | _No documentation available._ |
| `boolean forceOpenAllScenesOnCollection` | _No documentation available._ |
| `SceneCollection openCollection` | _No documentation available._ |
| `boolean softSkipSplashScreen` | _No documentation available._ |

---
# DependencyInjectionUtility
<!--
source: API\3.2.0\DependencyInjection\DependencyInjectionUtility.md
-->

## DependencyInjectionUtility

`static class` in `AdvancedSceneManager.DependencyInjection`### Description
Provides utility methods and accessors for dependency injection within ASM.

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerable<ValueTuple<Type, IInjectable>> EnumerateServices()` | Enumerates all currently registered injectable services. |
| `T GetService<T>()` | _No documentation available._ |
| `IInjectable GetService(Type type)` | Gets a service matching the specified type. |
| `IEnumerable<T> GetServices<T>()` | _No documentation available._ |
| `void Remove<T>(Type type, T service)` | _No documentation available._ |

---
# IBuildManager
<!--
source: API\3.2.0\DependencyInjection\Editor\IBuildManager.md
-->

## IBuildManager

`interface` in `AdvancedSceneManager.DependencyInjection.Editor`### Description
Provides functions for building, and build events.

<b> Remarks:</b>
Only available in editor.

### Events

| Member | Description |
|--------|-------------|
| `event Action<PostBuildEventArgs> postBuild` | Occurs after build. |
| `event Action<BuildReport> preBuild` | Occurs before build. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual BuildReport DoBuild(string path, boolean attachProfiler, boolean runGameWhenBuilt, boolean dev, BuildOptions customOptions)` | _No documentation available._ |
| `abstract virtual BuildReport DoBuild(BuildPlayerOptions options)` | _No documentation available._ |
| `abstract virtual IEnumerable<ValueTuple<EditorBuildSettingsScene, Reason>> GetOrderedList()` | Gets an ordered list of all scenes that ASM would set in the build settings. |
| `abstract virtual boolean IsEnabled(string path, Reason& reason)` | _No documentation available._ |
| `abstract virtual boolean IsIncluded(Scene scene, Reason& reason)` | _No documentation available._ |
| `abstract virtual void UpdateSceneList()` | Updates the scene build settings. |
| `abstract virtual void UpdateSceneList(boolean ignorePlaymodeCheck)` | _No documentation available._ |

---
# IHierarchyGUI
<!--
source: API\3.2.0\DependencyInjection\Editor\IHierarchyGUI.md
-->

## IHierarchyGUI

`interface` in `AdvancedSceneManager.DependencyInjection.Editor`### Description
An utility for adding extra icons to scene fields in the hierarchy window.

<b> Remarks:</b>
Only available in editor.

### Properties

| Member | Description |
|--------|-------------|
| `GUIStyle defaultStyle` | The default style for text in hierarchy. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void AddGameObjectGUI(HierarchyGameObjectGUI onGUI, int32 index)` | _No documentation available._ |
| `abstract virtual void AddSceneGUI(HierarchySceneGUI onGUI, int32 index)` | _No documentation available._ |
| `abstract virtual void RemoveGameObjectGUI(HierarchyGameObjectGUI onGUI)` | _No documentation available._ |
| `abstract virtual void RemoveSceneGUI(HierarchySceneGUI onGUI)` | _No documentation available._ |
| `abstract virtual void Repaint()` | Can be used to ensure repaint of the HierarchyWindow. |

---
# IPackage
<!--
source: API\3.2.0\DependencyInjection\Editor\IPackage.md
-->

## IPackage

`interface` in `AdvancedSceneManager.DependencyInjection.Editor`### Description
Contains info about the ASM package.

<b> Remarks:</b>
Only available in editor.

### Properties

| Member | Description |
|--------|-------------|
| `string folder` | The folder that ASM is contained within. |
| `string version` | The version of ASM. |

---
# ISceneManagerWindow
<!--
source: API\3.2.0\DependencyInjection\Editor\ISceneManagerWindow.md
-->

## ISceneManagerWindow

`interface` in `AdvancedSceneManager.DependencyInjection.Editor`### Description
Provides methods for working with the scene manager window.

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void CloseWindow()` | Close the window. |
| `abstract virtual void OpenWindow()` | Open the window. |

---
# IUserSettings
<!--
source: API\3.2.0\DependencyInjection\Editor\IUserSettings.md
-->

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
| `boolean logImport` | Specifies whatever ASM should log when a `ASMModelBase` is imported. |
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
| `abstract virtual void Save()` | Saves the singleton to disk, with a debounce. See also `SaveNow`. |
| `abstract virtual void SaveNow()` | Saves the singleton to disk. |
| `abstract virtual void ToolbarAction(int32 i, SceneCollection& collection, Boolean& runStartupProcess)` | _No documentation available._ |
| `abstract virtual void ToolbarAction(int32 i, SceneCollection collection, boolean runStartupProcess)` | _No documentation available._ |
| `abstract virtual void UnpinCollectionFromOverlay(SceneCollection collection)` | _No documentation available._ |

---
# IApp
<!--
source: API\3.2.0\DependencyInjection\IApp.md
-->

## IApp

`interface` in `AdvancedSceneManager.DependencyInjection`### Description
Manages startup and quit processes.

<b> Remarks:</b>
Usage: `app`.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isASMPlay` | Gets whatever we're currently in ASM play mode. |
| `boolean isQuitting` | Gets whatever ASM is currently in the process of quitting the game. |
| `boolean isRestart` | Gets if ASM has been restarted, or is currently restarting. |
| `boolean isStartupFinished` | Gets if startup process is finished. |
| `StartupProps startupProps` | Gets the props that should be used for startup process. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void CancelQuit()` | Cancels the current quit process. |
| `abstract virtual void CancelStartup()` | Cancels startup process. |
| `abstract virtual void Exit()` | Exits the application immediately. |
| `abstract virtual Awaitable Quit(boolean fade, Nullable<Color> fadeColor, single fadeDuration)` | _No documentation available._ |
| `abstract virtual void RegisterQuitCallback(Func<IEnumerator> coroutine)` | _No documentation available._ |
| `abstract virtual void Restart(StartupProps props)` | _No documentation available._ |
| `abstract virtual Async<boolean> RestartAsync(StartupProps props)` | _No documentation available._ |
| `abstract virtual void UnregisterQuitCallback(Func<IEnumerator> coroutine)` | _No documentation available._ |

---
# IInjectable
<!--
source: API\3.2.0\DependencyInjection\IInjectable.md
-->

## IInjectable

`interface` in `AdvancedSceneManager.DependencyInjection`### Description

---
# IProfileManager
<!--
source: API\3.2.0\DependencyInjection\IProfileManager.md
-->

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

---
# IProjectSettings
<!--
source: API\3.2.0\DependencyInjection\IProjectSettings.md
-->

## IProjectSettings

`interface` in `AdvancedSceneManager.DependencyInjection`### Description
Provides access to ASM settings.

<b> Remarks:</b>
May not be available in `[InitializeOnLoad]` and similar, use [Action)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.scenemanager.oninitialized(system.action)) or `OnLoadAttribute` to ensure you're not calling too early.

### Properties

| Member | Description |
|--------|-------------|
| `boolean allowCollectionLocking` | Specifies whatever asm will allow locking collections. |
| `boolean allowSceneLocking` | Specifies whatever asm will allow locking scenes. |
| `string assetPath` | Specifies the path where profiles and imported scenes should be generated to. |
| `Profile buildProfile` | The profile to use during build. |
| `boolean checkForDuplicateSceneOperations` | By default, ASM checks for duplicate scene operations, since this is usually caused by mistake, but this will disable that. |
| `CustomData customData` | Specifies custom data. |
| `Profile defaultProfile` | The profile to use when none is set. |
| `boolean enableCrossSceneReferences` | Gets or sets whatever cross-scene references should be enabled. |
| `Profile forceProfile` | The profile to force everyone in this project to use. |
| `boolean preventSpammingEventMethods` | By default, ASM will prevent spam calling event methods (i.e. calling Scene.Open() from a button press), but this will disable that. |
| `boolean reverseUnloadOrderOnCollectionClose` | Specifies whatever collections should unload scenes in the reverse order. |
| `SceneImportOption sceneImportOption` | Gets or sets when to automatically import scenes. |
| `single spamCheckCooldown` | Sets the default cooldown for `SpamCheck`. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void Save()` | Saves the singleton to disk, with a debounce. See also `SaveNow`. |
| `abstract virtual void SaveNow()` | Saves the singleton to disk. |
| `abstract virtual void SetBuildProfile(Profile profile)` | _No documentation available._ |

---
# IRuntime
<!--
source: API\3.2.0\DependencyInjection\IRuntime.md
-->

## IRuntime

`interface` in `AdvancedSceneManager.DependencyInjection`### Description
Manages runtime functionality for Advanced Scene Manager such as open scenes and collection.

---
# ISceneManager
<!--
source: API\3.2.0\DependencyInjection\ISceneManager.md
-->

## ISceneManager

`interface` in `AdvancedSceneManager.DependencyInjection`### Description
Manages runtime functionality for Advanced Scene Manager such as open scenes and collection.

### Properties

| Member | Description |
|--------|-------------|
| `Scene activeScene` | Gets the currently active scene, assuming it has been imported into ASM. |
| `SceneOperation currentOperation` | Gets the current active operation in the queue. |
| `Scene dontDestroyOnLoad` | Gets the dontDestroyOnLoad scene. |
| `boolean isBusy` | Gets whatever ASM is busy with any scene operations. |
| `IEnumerable<SceneCollection> openAdditiveCollections` | Gets the collections that are opened as additive. |
| `SceneCollection openCollection` | Gets the collection that is currently open. |
| `IEnumerable<Scene> openScenes` | Gets the scenes that are currently open. |
| `IEnumerable<Scene> preloadedScenes` | Gets the scenes that are preloaded. |
| `IEnumerable<SceneOperation> queuedOperations` | Gets the current scene operation queue. |
| `IEnumerable<SceneOperation> runningOperations` | The currently running scene operations. |

### Events

| Member | Description |
|--------|-------------|
| `event Action<SceneCollection> collectionClosed` | Occurs when a collection is closed. |
| `event Action<SceneCollection> collectionOpened` | Occurs when a collection is opened. |
| `event Action<Scene> sceneClosed` | Occurs when a scene is closed. |
| `event Action<Scene> sceneOpened` | Occurs when a scene is opened. |
| `event Action<Scene> scenePreloaded` | Occurs when a scene is preloaded. |
| `event Action<Scene> scenePreloadFinished` | Occurs when a previously preloaded scene is opened. |
| `event Action startedWorking` | Occurs when ASM has started working and is running scene operations. |
| `event Action stoppedWorking` | Occurs when ASM has finished working and no scene operations are running. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void Activate(Scene scene)` | _No documentation available._ |
| `abstract virtual void AddSceneLoader<T>()` | _No documentation available._ |
| `abstract virtual SceneOperation CancelPreload()` | Cancels the preload. All preloaded scenes will be fully loaded (limitation by Unity), then closed. No ASM scene callbacks will be called. |
| `abstract virtual SceneOperation Close(IEnumerable<Scene> scenes)` | _No documentation available._ |
| `abstract virtual SceneOperation Close(Scene[] scenes)` | _No documentation available._ |
| `abstract virtual SceneOperation Close(Scene scene)` | _No documentation available._ |
| `abstract virtual SceneOperation Close(SceneCollection collection)` | _No documentation available._ |
| `abstract virtual SceneOperation CloseAll(boolean exceptLoadingScreens, boolean exceptUnimported, Scene[] except)` | _No documentation available._ |
| `abstract virtual SceneOperation FinishPreload()` | _No documentation available._ |
| `abstract virtual SceneLoader GetLoaderForScene(Scene scene, boolean useOnlyGlobal)` | _No documentation available._ |
| `abstract virtual SceneState GetState(Scene scene)` | _No documentation available._ |
| `abstract virtual IEnumerable<SceneLoader> GetToggleableSceneLoaders()` | Gets a list of all added scene loaders that can be toggled scene by scene. |
| `abstract virtual boolean IsTracked(Scene scene)` | _No documentation available._ |
| `abstract virtual boolean IsTracked(SceneCollection collection)` | _No documentation available._ |
| `abstract virtual SceneOperation Open(IEnumerable<Scene> scenes)` | _No documentation available._ |
| `abstract virtual SceneOperation Open(Scene[] scenes)` | _No documentation available._ |
| `abstract virtual SceneOperation Open(Scene scene)` | _No documentation available._ |
| `abstract virtual SceneOperation Open(SceneCollection collection, boolean openAll)` | _No documentation available._ |
| `abstract virtual SceneOperation OpenAdditive(IEnumerable<SceneCollection> collections, SceneCollection activeCollection, LoadingScreenReference loadingScreen)` | _No documentation available._ |
| `abstract virtual SceneOperation OpenAdditive(SceneCollection collection, boolean openAll)` | _No documentation available._ |
| `abstract virtual SceneOperation OpenAndActivate(Scene scene)` | _No documentation available._ |
| `abstract virtual SceneOperation OpenWithLoadingScreen(IEnumerable<Scene> scene, Scene loadingScreen)` | _No documentation available._ |
| `abstract virtual SceneOperation OpenWithLoadingScreen(Scene scene, Scene loadingScreen)` | _No documentation available._ |
| `abstract virtual SceneOperation Preload(Scene scene, Action onPreloaded)` | _No documentation available._ |
| `abstract virtual void RemoveSceneLoader<T>()` | _No documentation available._ |
| `abstract virtual SceneOperation ToggleOpen(Scene scene)` | _No documentation available._ |
| `abstract virtual SceneOperation ToggleOpen(SceneCollection collection, boolean openAll)` | _No documentation available._ |
| `abstract virtual void Track(Scene scene)` | _No documentation available._ |
| `abstract virtual void Track(Scene scene, Scene unityScene)` | _No documentation available._ |
| `abstract virtual void Track(SceneCollection collection, boolean isAdditive)` | _No documentation available._ |
| `abstract virtual boolean Untrack(Scene scene)` | _No documentation available._ |
| `abstract virtual void Untrack(SceneCollection collection, boolean isAdditive)` | _No documentation available._ |
| `abstract virtual void UntrackCollections()` | Untracks all collections. |
| `abstract virtual void UntrackScenes()` | Untracks all open scenes. |

---
# ASMUtilityFunction
<!--
source: API\3.2.0\Editor\UI\ASMUtilityFunction.md
-->

## ASMUtilityFunction

`abstract class` in `AdvancedSceneManager.Editor.UI`### Description
Base class for ASM utility functions available in the editor UI.

### Properties

| Member | Description |
|--------|-------------|
| `string Description` | Gets the description of the function. |
| `string Group` | Gets the group this function belongs to. |
| `string Name` | Gets the display name of the function. |
| `int32 Order` | Gets the order used for sorting within its group. |

### Methods

| Member | Description |
|--------|-------------|
| `void ClosePopup()` | Closes the popup if options were provided in [VisualElement@)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.editor.ui.asmutilityfunction.oninvoke(unityengine.uielements.visualelement@)). |
| `virtual void OnDisable()` | Called when the function is disabled. |
| `virtual void OnEnable()` | Called when the function is enabled. |
| `virtual void OnInvoke(VisualElement& optionsGUI)` | _No documentation available._ |

---
# ASMWindow
<!--
source: API\3.2.0\Editor\UI\ASMWindow.md
-->

## ASMWindow

`static class` in `AdvancedSceneManager.Editor.UI`### Description
Contains APIs relating to the ASM window.

<b> Remarks:</b>
Only available in the editor.

### Static Methods

| Member | Description |
|--------|-------------|
| `void AddNotification(Notification notification)` | Adds a notification to the ASM window, optionally with click and dismiss callbacks, dismiss behavior, visual style, and icon information. |
| `void ClosePopup()` | Closes the currently open popup, if one is open.. |
| `boolean IsPopupOpen()` | Determines whether any popup is currently open. |
| `boolean IsPopupOpen<T>()` | Determines whether any popup is currently open. |
| `void OpenPopup<T>()` | _No documentation available._ |
| `void OpenPopup<T>(Nullable<ViewModelContext> context)` | _No documentation available._ |
| `void OpenPopup(Type type, Nullable<ViewModelContext> context)` | Opens `type` as a popup. |
| `void OpenSettings()` | Opens the settings popup on the main page. |
| `void OpenSettings<T>()` | Opens the settings popup on the main page. |
| `void OpenSettings<T>(ViewModelContext context)` | _No documentation available._ |
| `void OpenSettings(Type type)` | Opens the settings popup on the page that matches the view model specified by `type`. |
| `void OpenSettings(Type type, ViewModelContext context)` | Opens the settings popup on the page that matches the view model specified by `type`. |
| `void ReloadCollections()` | Reloads collection ui. |
| `void RemoveNotification(Notification notification)` | Removes the notification with the specified id. |

---
# ASMWindowElementAttribute
<!--
source: API\3.2.0\Editor\UI\ASMWindowElementAttribute.md
-->

## ASMWindowElementAttribute

`class` in `AdvancedSceneManager.Editor.UI`  /  Inherits from: `DiscoverableAttribute`### Description
Specifies a method or view model class that should be used as a callback to insert a visual element into the ASM window.

<b> Remarks:</b>
When specified on a class it should inherit `ViewModel`.

### Properties

| Member | Description |
|--------|-------------|
| `boolean canToggleVisible` | Gets if this element can be toggled visible or hidden. |
| `int32 defaultOrder` | Specifies default order. |
| `string friendlyDescription` | Specifies the description to be shown in the diag UI tooltip. |
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
| `virtual boolean IsValidTarget(MemberInfo member)` | Gets if `member` is a valid target for this attribute callback. |

---
# DragReferenceManipulator
<!--
source: API\3.2.0\Editor\UI\DragReferenceManipulator.md
-->

## DragReferenceManipulator

`class` in `AdvancedSceneManager.Editor.UI`  /  Inherits from: `PointerManipulator`### Description
Gives user a `ScriptableObject` reference on drag.

<b> Remarks:</b>
Only available in editor.

---
# ElementLocation
<!--
source: API\3.2.0\Editor\UI\ElementLocation.md
-->

## ElementLocation

`enum` in `AdvancedSceneManager.Editor.UI`  /  Inherits from: `Enum`### Description
Specifies location for a custom element in the ASM window.

### Static Fields

| Member | Description |
|--------|-------------|
| `ElementLocation Collection` | Specifies that the custom element should be located in the collection headers the ASM window, on the right side. |
| `ElementLocation CollectionLeft` | Specifies that the custom element should be located in the collection fields of the ASM window, on the left side. |
| `ElementLocation CollectionRight` | Specifies that the custom element should be located in the collection headers the ASM window, on the right side. |
| `ElementLocation Footer` | Specifies that the custom element should be located in the footer of the ASM window. |
| `ElementLocation Header` | Specifies that the custom element should be located in the header of the ASM window. |
| `ElementLocation Scene` | Specifies that the custom element should be located in the scene fields of the ASM window, on the right side. |
| `ElementLocation SceneLeft` | Specifies that the custom element should be located in the scene fields of the ASM window, on the left side. |
| `ElementLocation SceneRight` | Specifies that the custom element should be located in the scene fields of the ASM window, on the right side. |
| `ElementLocation Settings` | Specifies that the custom element should be considered a settings page. It will be accessible as a category in the main settings page. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# Notification
<!--
source: API\3.2.0\Editor\UI\Notification.md
-->

## Notification

`class` in `AdvancedSceneManager.Editor.UI`### Description
Represents a notification to be displayed.

### Fields

| Member | Description |
|--------|-------------|
| `boolean allowTextClippingIntoMenuButton` | Whether text may overlap the menu button area. |
| `boolean canDismiss` | Whether the notification can be dismissed by the user. |
| `boolean canMute` | Whether the notification can be muted. |
| `boolean dismissOnClick` | Whether the notification is dismissed when clicked. |
| `string fontAwesomeIcon` | Specifies an optional Font Awesome icon name. |
| `string iconFont` | Specifies an optional font name for the icon. |
| `string iconInfo` | Specifies an optional icon info identifier. |
| `string id` | Unique identifier for the notification. |
| `NotificationImportance importance` | Specifies the importance level of the notification. |
| `Nullable<boolean> isExpanded` | Whether the notification is expanded, if applicable. |
| `NotificationKind kind` | Specifies the visual kind of the notification. |
| `string message` | Displayed message text. |
| `Action onClick` | Action invoked when the notification is clicked. |
| `Action onDismiss` | Action invoked when the notification is dismissed. |

---
# NotificationImportance
<!--
source: API\3.2.0\Editor\UI\NotificationImportance.md
-->

## NotificationImportance

`enum` in `AdvancedSceneManager.Editor.UI`  /  Inherits from: `Enum`### Description
Specifies the importance of a notification.

### Static Fields

| Member | Description |
|--------|-------------|
| `NotificationImportance Default` | Determines that the notification will be displayed in non-overflow view when space allows, otherwise overflow menu. |
| `NotificationImportance High` | Determines that the notification will never overflow. |
| `NotificationImportance Low` | Determines that the notification will never be displayed in non-overflow view. |
| `NotificationImportance Priority` | Determines that the notification is to be prioritized. Prioritized notifications hide all others until dismissed or removed. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# NotificationKind
<!--
source: API\3.2.0\Editor\UI\NotificationKind.md
-->

## NotificationKind

`enum` in `AdvancedSceneManager.Editor.UI`  /  Inherits from: `Enum`### Description
Specifies the kind of notification.

<b> Remarks:</b>
Only available in the editor.

### Static Fields

| Member | Description |
|--------|-------------|
| `NotificationKind Default` | Does not indicate anything in particular. Displays no icon. |
| `NotificationKind FixUp` | Indicates a warning or fixable issue. Displays a warning icon. |
| `NotificationKind Info` | Indicates informational content. Displays an info icon. |
| `NotificationKind Link` | Indicates a link to something. Displays a link icon. |
| `NotificationKind Profile` | Indicates something related to profiles. Displays a profile icon. |
| `NotificationKind Scene` | Indicates something related to scenes. Displays a scene icon. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# UIElementUtility
<!--
source: API\3.2.0\Editor\UI\UIElementUtility.md
-->

## UIElementUtility

`static class` in `AdvancedSceneManager.Editor.UI`### Description
Provides utility methods for working with `VisualElement`.

### Static Methods

| Member | Description |
|--------|-------------|
| `T UseFontAwesome<T>(T element, Nullable<boolean> solid, Nullable<boolean> regular, Nullable<boolean> brands)` | _No documentation available._ |

---
# AssetDatabaseUtility
<!--
source: API\3.2.0\Editor\Utility\AssetDatabaseUtility.md
-->

## AssetDatabaseUtility

`static class` in `AdvancedSceneManager.Editor.Utility`### Description
Contains utility functions for working with the asset database.

<b> Remarks:</b>
Only available in the editor.

### Static Methods

| Member | Description |
|--------|-------------|
| `string ConvertToUnixPath(string path)` | Converts the path separators to use forward slash. |
| `boolean CreateFolder(string folder)` | _No documentation available._ |
| `boolean CreateFolder(string path, String& createdFolder)` | _No documentation available._ |
| `IEnumerable<string> FindAssetPaths<T>(string[] searchInFolders)` | _No documentation available._ |
| `IEnumerable<T> FindAssets<T>()` | _No documentation available._ |
| `IEnumerable<T> FindAssets<T>(string[] searchInFolders)` | _No documentation available._ |
| `string MakeRelative(string path, boolean includeAssetsFolder, boolean prefixWithAssetsIfNecessary)` | Makes the path absolute. Converts path to unix style. |
| `void ShowFolder(string folderPath)` | Shows the folder and selects the asset. |
| `void ShowFolder(object obj)` | Shows the folder and selects the asset. |

---
# BuildUtility
<!--
source: API\3.2.0\Editor\Utility\BuildUtility.md
-->

## BuildUtility

`static class` in `AdvancedSceneManager.Editor.Utility`### Description
Provides functions for building, and build events.

<b> Remarks:</b>
Only available in editor.

### Static Events

| Member | Description |
|--------|-------------|
| `event Action<PostBuildEventArgs> postBuild` | Occurs after build. |
| `event Action<BuildReport> preBuild` | Occurs before build. |

### Static Methods

| Member | Description |
|--------|-------------|
| `void CleanupASMBuildAssets()` | _No documentation available._ |
| `BuildReport DoBuild(string path, boolean attachProfiler, boolean runGameWhenBuilt, boolean dev, BuildOptions customOptions)` | Performs a build of the active build profile if one exists, otherwise falls back to Unity's legacy build pipeline. |
| `BuildReport DoBuild(BuildPlayerOptions opts)` | Performs a build using the legacy `BuildPlayerOptions` API. |
| `BuildReport DoBuild(BuildPlayerWithProfileOptions options)` | _No documentation available._ |
| `IEnumerable<ValueTuple<EditorBuildSettingsScene, Reason>> GetOrderedList()` | Gets an ordered list of all scenes that ASM would set in the build settings. |
| `boolean IsEnabled(string path, Reason& reason)` | _No documentation available._ |
| `boolean IsIncluded(Scene scene, Reason& reason)` | _No documentation available._ |
| `void PrepareASMForBuild()` | _No documentation available._ |
| `void UpdateSceneList()` | Updates the scene build settings. |
| `void UpdateSceneList(boolean ignorePlayModeCheck, boolean force)` | Updates the scene build settings from the ASM profile. |

---
# CodeEditorUtility
<!--
source: API\3.2.0\Editor\Utility\CodeEditorUtility.md
-->

## CodeEditorUtility

`static class` in `AdvancedSceneManager.Editor.Utility`### Description
Provides utility methods for opening the code editor on a method.

### Static Methods

| Member | Description |
|--------|-------------|
| `void OpenInCodeEditor(Exception exception)` | Opens the code editor to the top frame of a given exception. |
| `void OpenInCodeEditor(MemberInfo member)` | Opens the code editor to a specific member (e.g., method, property, or type). |

---
# HierarchyGameObjectGUI
<!--
source: API\3.2.0\Editor\Utility\HierarchyGameObjectGUI.md
-->

## HierarchyGameObjectGUI

`sealed class` in `AdvancedSceneManager.Editor.Utility`  /  Inherits from: `MulticastDelegate`### Description

### Methods

| Member | Description |
|--------|-------------|
| `virtual IAsyncResult BeginInvoke(GameObject gameObject, AsyncCallback callback, object object)` | _No documentation available._ |
| `virtual void EndInvoke(IAsyncResult result)` | _No documentation available._ |
| `virtual void Invoke(GameObject gameObject)` | _No documentation available._ |

---
# HierarchyGUIUtility
<!--
source: API\3.2.0\Editor\Utility\HierarchyGUIUtility.md
-->

## HierarchyGUIUtility

`static class` in `AdvancedSceneManager.Editor.Utility`### Description
An utility for adding extra icons to scene fields in the hierarchy window.

<b> Remarks:</b>
Only available in editor.

### Static Properties

| Member | Description |
|--------|-------------|
| `GUIStyle defaultStyle { get; }` | The default style for text in hierarchy. |

### Static Methods

| Member | Description |
|--------|-------------|
| `void AddGameObjectGUI(HierarchyGameObjectGUI onGUI, int32 index)` | _No documentation available._ |
| `void AddSceneGUI(HierarchySceneGUI onGUI, int32 index)` | _No documentation available._ |
| `boolean GetObj(int32 instanceID, Object& obj, String& name, String& scenePath)` | _No documentation available._ |
| `void RemoveGameObjectGUI(HierarchyGameObjectGUI onGUI)` | _No documentation available._ |
| `void RemoveSceneGUI(HierarchySceneGUI onGUI)` | _No documentation available._ |
| `void Repaint()` | Can be used to ensure repaint of the HierarchyWindow. |

---
# HierarchySceneGUI
<!--
source: API\3.2.0\Editor\Utility\HierarchySceneGUI.md
-->

## HierarchySceneGUI

`sealed class` in `AdvancedSceneManager.Editor.Utility`  /  Inherits from: `MulticastDelegate`### Description

### Methods

| Member | Description |
|--------|-------------|
| `virtual IAsyncResult BeginInvoke(Scene scene, AsyncCallback callback, object object)` | _No documentation available._ |
| `virtual void EndInvoke(IAsyncResult result)` | _No documentation available._ |
| `virtual void Invoke(Scene scene)` | _No documentation available._ |

---
# LockUtility
<!--
source: API\3.2.0\Editor\Utility\LockUtility.md
-->

## LockUtility

`static class` in `AdvancedSceneManager.Editor.Utility`### Description
A utility for locking scenes and collections from modification.

<b> Remarks:</b>
Only modification from within unity is prevented.

### Static Methods

| Member | Description |
|--------|-------------|
| `void Lock(ILockable obj, string message, boolean prompt)` | Locks the object. |
| `void Toggle(ILockable obj, boolean prompt)` | Toggles lock status of the object. |
| `void Unlock(ILockable obj, boolean prompt)` | Unlocks the object. |

---
# LogEntry
<!--
source: API\3.2.0\Editor\Utility\LogEntry.md
-->

## LogEntry

`class` in `AdvancedSceneManager.Editor.Utility`### Description

### Properties

| Member | Description |
|--------|-------------|
| `string condition` | _No documentation available._ |
| `string stacktrace` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual LogEntry <Clone>$()` | _No documentation available._ |
| `void Deconstruct(String& condition, String& stacktrace)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `virtual boolean Equals(LogEntry other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# PostBuildEventArgs
<!--
source: API\3.2.0\Editor\Utility\PostBuildEventArgs.md
-->

## PostBuildEventArgs

`class` in `AdvancedSceneManager.Editor.Utility`### Description

### Properties

| Member | Description |
|--------|-------------|
| `LogEntry[] error` | _No documentation available._ |
| `BuildReport report` | _No documentation available._ |
| `LogEntry[] warning` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual PostBuildEventArgs <Clone>$()` | _No documentation available._ |
| `void Deconstruct(BuildReport& report, LogEntry[]& warning, LogEntry[]& error)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `virtual boolean Equals(PostBuildEventArgs other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# Reason
<!--
source: API\3.2.0\Editor\Utility\Reason.md
-->

## Reason

`enum` in `AdvancedSceneManager.Editor.Utility`  /  Inherits from: `Enum`### Description

### Static Fields

| Member | Description |
|--------|-------------|
| `Reason Default` | _No documentation available._ |
| `Reason IncludedInProfile` | _No documentation available._ |
| `Reason InvalidScene` | _No documentation available._ |
| `Reason NotIncludedInProfile` | _No documentation available._ |
| `Reason SceneLoaderOverride` | _No documentation available._ |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# CollectionOpen
<!--
source: API\3.2.0\ExampleScripts\CollectionOpen.md
-->

## CollectionOpen

`class` in `AdvancedSceneManager.ExampleScripts`  /  Inherits from: `MonoBehaviour`### Description
Contains examples for opening collections.

### Fields

| Member | Description |
|--------|-------------|
| `SceneCollection collectionToOpen` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void ChainingExample()` | _No documentation available._ |
| `void Open()` | _No documentation available._ |
| `void OpenWithLoadingScreen(LoadingScreenReference loadingScreen)` | _No documentation available._ |
| `void OpenWithUserData(ScriptableObject scriptableObject)` | _No documentation available._ |
| `void ToggleOpen()` | _No documentation available._ |

---
# DoActionsWithLoadingScreen
<!--
source: API\3.2.0\ExampleScripts\DoActionsWithLoadingScreen.md
-->

## DoActionsWithLoadingScreen

`class` in `AdvancedSceneManager.ExampleScripts`### Description
Contains examples for doing `Action` with loading screen.

### Fields

| Member | Description |
|--------|-------------|
| `LoadingScreenReference loadingScreen` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void DoActionWithLoadingScreen()` | _No documentation available._ |
| `void DoCoroutineWithLoadingScreen()` | _No documentation available._ |

---
# SceneLoader
<!--
source: API\3.2.0\ExampleScripts\SceneLoader.md
-->

## SceneLoader

`static class` in `AdvancedSceneManager.ExampleScripts`### Description
Contains examples of how to override scene loading.

---
# SceneOpen
<!--
source: API\3.2.0\ExampleScripts\SceneOpen.md
-->

## SceneOpen

`class` in `AdvancedSceneManager.ExampleScripts`  /  Inherits from: `MonoBehaviour`### Description
Contains examples for opening scenes.

### Fields

| Member | Description |
|--------|-------------|
| `Scene sceneToOpen` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void ChainingExample()` | _No documentation available._ |
| `void OpenSingle()` | _No documentation available._ |
| `void OpenStandalone()` | _No documentation available._ |
| `void OpenWithLoadingScreen(LoadingScreenReference loadingScreen)` | _No documentation available._ |
| `void Toggle()` | _No documentation available._ |

---
# ScenePreload
<!--
source: API\3.2.0\ExampleScripts\ScenePreload.md
-->

## ScenePreload

`class` in `AdvancedSceneManager.ExampleScripts`  /  Inherits from: `MonoBehaviour`### Description
Contains examples for preloading scenes.

### Static Properties

| Member | Description |
|--------|-------------|
| `boolean hasPreloadedScene` | _No documentation available._ |

### Fields

| Member | Description |
|--------|-------------|
| `Scene SceneToPreload` | _No documentation available._ |

### Static Methods

| Member | Description |
|--------|-------------|
| `void CancelPreloadStatically(Scene scene)` | _No documentation available._ |
| `void FinishPreloadStatically(Scene scene)` | _No documentation available._ |
| `void StartPreloadStatically(Scene scene)` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void CancelPreloadCoroutine()` | _No documentation available._ |
| `void FinishPreloadCoroutine()` | _No documentation available._ |
| `void StartPreloadCoroutine()` | _No documentation available._ |

---
# IFadeLoadingScreen
<!--
source: API\3.2.0\Loading\IFadeLoadingScreen.md
-->

## IFadeLoadingScreen

`interface` in `AdvancedSceneManager.Loading`### Description
Used to pass arguments from [Color})](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.utility.loadingscreenutility.fadein(advancedscenemanager.loading.loadingscreenreference,system.single,system.nullable{unityengine.color}))

### Properties

| Member | Description |
|--------|-------------|
| `Color color` | Specifies the color of the fade. |
| `single fadeDuration` | Specifies the fade duration. |

---
# ILoadProgressData
<!--
source: API\3.2.0\Loading\ILoadProgressData.md
-->

## ILoadProgressData

`interface` in `AdvancedSceneManager.Loading`### Description
Represents progress in ASM. Used for `ILoadProgressListener`.

### Properties

| Member | Description |
|--------|-------------|
| `single value` | The current load percent. |

---
# ILoadProgressListener
<!--
source: API\3.2.0\Loading\ILoadProgressListener.md
-->

## ILoadProgressListener

`interface` in `AdvancedSceneManager.Loading`### Description
Represents a listener for when progress changes.

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void OnProgressChanged(ILoadProgressData progress)` | Called when progress has changed. |

---
# LoadingScreen
<!--
source: API\3.2.0\Loading\LoadingScreen.md
-->

## LoadingScreen

`abstract class` in `AdvancedSceneManager.Loading`  /  Inherits from: `LoadingScreenBase`### Description
A class that contains callbacks for loading screens.

<b> Remarks:</b>
`SplashScreen` and `LoadingScreen` cannot co-exist within the same scene.

### Properties

| Member | Description |
|--------|-------------|
| `SceneOperation operation { get; }` | The current scene operation that this loading screen is associated with. May be null for the first few frames, before loading has actually begun. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual IEnumerator OnClose()` | Called when loading scene is closed. |
| `abstract virtual IEnumerator OnOpen()` | Called when loading scene is opened. |
| `virtual void OnValidate()` | _No documentation available._ |

---
# LoadingScreenAttribute
<!--
source: API\3.2.0\Loading\LoadingScreenAttribute.md
-->

## LoadingScreenAttribute

`sealed class` in `AdvancedSceneManager.Loading`  /  Inherits from: `LoadingScreenAttributeBase`### Description
Defines a loading screen.

---
# LoadingScreenAttributeBase
<!--
source: API\3.2.0\Loading\LoadingScreenAttributeBase.md
-->

## LoadingScreenAttributeBase

`abstract class` in `AdvancedSceneManager.Loading`  /  Inherits from: `DiscoverableAttribute`### Description
Defines the base for a loading screen discoverable.

### Properties

| Member | Description |
|--------|-------------|
| `string displayName` | The name to display when picking a loading screen and for the host scene when open. |
| `string displayType` | Gets a human-readable type name for this screen (for example, "Splash Screen" or "Loading Screen"). |
| `string effectiveDisplayName` | The effective display name, falls back to type name if `displayName` is empty. |
| `boolean isLoadingScreen` | Gets whether this attribute defines a loading screen. |
| `boolean isSplashScreen` | Gets whether this attribute defines a splash screen. |

---
# LoadingScreenBase
<!--
source: API\3.2.0\Loading\LoadingScreenBase.md
-->

## LoadingScreenBase

`abstract class` in `AdvancedSceneManager.Loading`  /  Inherits from: `MonoBehaviour`### Description
A generic base class for loading screens. You probably want to inherit from `LoadingScreen` though.

<b> Remarks:</b>
When multiple loading screens exist within the same scene, only the first found one will be used.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isClosing { get; }` | Gets whatever we're currently closing. |
| `boolean isOpen { get; }` | Gets whatever we're currently open. |
| `boolean isOpening { get; }` | Gets whatever we're currently opening. |

### Fields

| Member | Description |
|--------|-------------|
| `Canvas canvas` | The canvas that this loading screen uses.

This will automatically register canvas with `CanvasSortOrderUtility`, to automatically manage canvas sort order. |

### Methods

| Member | Description |
|--------|-------------|
| `boolean HasPressedAnyKey()` | Gets if any key has been pressed this frame. |
| `abstract virtual IEnumerator OnClose()` | Called when the loading screen is about to close. |
| `abstract virtual IEnumerator OnOpen()` | Called when the loading screen is opened. |
| `virtual void OnProgressChanged(ILoadProgressData progress)` | Called when progress changes for the associated scene operation. |
| `WaitUntil WaitForAnyKey()` | Returns `WaitUntil` that waits for user to press any key. |

---
# LoadingScreenConfigBag
<!--
source: API\3.2.0\Loading\LoadingScreenConfigBag.md
-->

## LoadingScreenConfigBag

`abstract class` in `AdvancedSceneManager.Loading`### Description
Base class for loading screen config bags.

### Fields

| Member | Description |
|--------|-------------|
| `boolean displayInEditor` | _No documentation available._ |
| `PanelSettings panelSettings` | _No documentation available._ |
| `int32 sortOrder` | _No documentation available._ |

---
# LoadingScreenReference
<!--
source: API\3.2.0\Loading\LoadingScreenReference.md
-->

## LoadingScreenReference

`struct` in `AdvancedSceneManager.Loading`  /  Inherits from: `ValueType`### Description
Represents a loading screen.

### Properties

| Member | Description |
|--------|-------------|
| `LoadingScreenConfigBag config` | _No documentation available._ |
| `DiscoveredMember discoverable` | _No documentation available._ |
| `LoadingScreenBase instance` | _No documentation available._ |
| `boolean isDiscoverable` | _No documentation available._ |
| `boolean isScene` | _No documentation available._ |
| `boolean isValid` | _No documentation available._ |
| `string name` | _No documentation available._ |
| `Scene scene` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `boolean Equals(LoadingScreenReference other)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |

---
# LoadingScreenViewModel
<!--
source: API\3.2.0\Loading\LoadingScreenViewModel.md
-->

## LoadingScreenViewModel

`abstract class` in `AdvancedSceneManager.Loading`  /  Inherits from: `ViewModel`### Description
The base class for loading screen view models.

### Properties

| Member | Description |
|--------|-------------|
| `boolean handleDisplayInEditorAutomatically` | Determines whether ASM should automatically handle editor-only display logic based on `displayInEditor`. |
| `UIDocument uiDocument { get; }` | Gets the `UIDocument` that is rendering the view. |

### Methods

| Member | Description |
|--------|-------------|
| `void EnsureCameraExists()` | Ensures that a camera exists for rendering this loading screen. |

---
# LoadingScreenViewModel_Of_T
<!--
source: API\3.2.0\Loading\LoadingScreenViewModel_Of_T.md
-->

## LoadingScreenViewModel`1

`abstract class` in `AdvancedSceneManager.Loading`  /  Inherits from: `LoadingScreenViewModel`### Description
The base class for loading screen view models.

### Properties

| Member | Description |
|--------|-------------|
| `T configBag` | Gets the configuration bag for this loading screen. If no configuration has been provided, a default instance is created. |

---
# MessageLoadProgressData
<!--
source: API\3.2.0\Loading\MessageLoadProgressData.md
-->

## MessageLoadProgressData

`struct` in `AdvancedSceneManager.Loading`  /  Inherits from: `ValueType`### Description
An implementation of `ILoadProgressData` that provides a string message.

### Properties

| Member | Description |
|--------|-------------|
| `string message` | The message of this report. |
| `single value` | The reported progress value. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual string ToString()` | _No documentation available._ |

---
# ProgressScope
<!--
source: API\3.2.0\Loading\ProgressScope.md
-->

## ProgressScope

`class` in `AdvancedSceneManager.Loading`### Description
Represents a listener for progress that can calculate the total progress of a scene operation.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isRegistered { get; }` | Gets if this progress scope is registered. |
| `int32 operationCount` | Gets the amount of scenes that will be either unloaded or loaded. |
| `IEnumerable<Scene> scenesExpectedToLoad` | Gets the scenes that are expected to be loaded. |
| `IEnumerable<Scene> scenesExpectedToUnload` | Gets the scenes that are expected to be unloaded. |
| `boolean stopListenerWhenDisposed` | Gets or sets whatever the listener should be unregistered in `Dispose`. Default `true` |
| `single totalProgress { get; }` | Gets the calculated total progress of this progress scope. |

### Methods

| Member | Description |
|--------|-------------|
| `void Dispose()` | Stops listening to progress reports. |
| `ProgressScope Expect(SceneOperationKind kind, SceneCollection collection, boolean openAll, boolean isAdditive)` | Expect scenes in `collection`. |
| `ProgressScope Expect(SceneOperationKind kind, Scene[] scene)` | Expect `scene`. |
| `ProgressScope Expect(SceneOperationKind kind, IEnumerable<Scene> scenes)` | Expect `scenes`. |
| `single GetSubProgress(SceneOperationKind kind, Scene scene)` | Gets the progress of a specific scene. |
| `void OnProgressChanged(Action<single> callback)` | Adds a callback when progress changed. |
| `void RemoveOnProgressChangedCallback(Action<single> callback)` | Removes a callback when progress changed. |
| `ProgressScope StartListener()` | Starts listening to progress reports. |
| `ProgressScope StopListener()` | Stops listening to progress reports. |

---
# SceneLoadProgressData
<!--
source: API\3.2.0\Loading\SceneLoadProgressData.md
-->

## SceneLoadProgressData

`struct` in `AdvancedSceneManager.Loading`  /  Inherits from: `ValueType`### Description
The default implementation of `ILoadProgressData`, used by ASM in most cases.

### Properties

| Member | Description |
|--------|-------------|
| `SceneOperation operation` | The operation that started this operation. |
| `SceneOperationKind operationKind` | The kind of operation this is. |
| `Scene scene` | The scene that is being loaded or unloaded. Can be null. |
| `single value` | The reported progress value. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual string ToString()` | _No documentation available._ |

---
# SerializableLoadingScreenReference
<!--
source: API\3.2.0\Loading\SerializableLoadingScreenReference.md
-->

## SerializableLoadingScreenReference

`class` in `AdvancedSceneManager.Loading`### Description

### Fields

| Member | Description |
|--------|-------------|
| `LoadingScreenConfigBag config` | _No documentation available._ |
| `DiscoveredMember discoverable` | _No documentation available._ |
| `Scene scene` | _No documentation available._ |

---
# SplashScreen
<!--
source: API\3.2.0\Loading\SplashScreen.md
-->

## SplashScreen

`abstract class` in `AdvancedSceneManager.Loading`  /  Inherits from: `LoadingScreenBase`### Description
A class that contains callbacks for splash screens.

<b> Remarks:</b>
`SplashScreen` and `LoadingScreen` cannot coexist within the same scene.

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual IEnumerator OnClose()` | Called when splash scene is about to close. |
| `abstract virtual IEnumerator OnOpen()` | Called when splash scene is opened. |
| `virtual void OnValidate()` | _No documentation available._ |

---
# SplashScreenAttribute
<!--
source: API\3.2.0\Loading\SplashScreenAttribute.md
-->

## SplashScreenAttribute

`sealed class` in `AdvancedSceneManager.Loading`  /  Inherits from: `LoadingScreenAttributeBase`### Description
Defines a splash screen.

---
# ASMSplashScreen
<!--
source: API\3.2.0\Loading\UI\ASMSplashScreen.md
-->

## ASMSplashScreen

`class` in `AdvancedSceneManager.Loading.UI`  /  Inherits from: `LoadingScreenViewModel<ConfigBag>`### Description
A splash screen that displays the ASM logo.

<b> Remarks:</b>
A default splash screen.

### Properties

| Member | Description |
|--------|-------------|
| `VisualTreeAsset template` | Gets the UXML template asset for this view model. |

---
# ConfigBag
<!--
source: API\3.2.0\Loading\UI\ConfigBag.md
-->

## ConfigBag

`class` in `AdvancedSceneManager.Loading.UI`  /  Inherits from: `LoadingScreenConfigBag`### Description

### Fields

| Member | Description |
|--------|-------------|
| `Color color` | _No documentation available._ |
| `single fadeInDuration` | _No documentation available._ |
| `single fadeOutDuration` | _No documentation available._ |

---
# FadeLoadingScreen
<!--
source: API\3.2.0\Loading\UI\FadeLoadingScreen.md
-->

## FadeLoadingScreen

`class` in `AdvancedSceneManager.Loading.UI`  /  Inherits from: `LoadingScreenViewModel<ConfigBag>`### Description
A loading screen that fades the screen in and out.

<b> Remarks:</b>
A default loading screen.

### Properties

| Member | Description |
|--------|-------------|
| `VisualTreeAsset template` | Gets the UXML template asset for this view model. |

---
# FadeSplashScreen
<!--
source: API\3.2.0\Loading\UI\FadeSplashScreen.md
-->

## FadeSplashScreen

`class` in `AdvancedSceneManager.Loading.UI`  /  Inherits from: `LoadingScreenViewModel<ConfigBag>`### Description
A splash screen that fades the screen in and out.

<b> Remarks:</b>
A default splash screen.

### Properties

| Member | Description |
|--------|-------------|
| `VisualTreeAsset template` | Gets the UXML template asset for this view model. |

---
# Log
<!--
source: API\3.2.0\Log.md
-->

## Log

`static class` in `AdvancedSceneManager`### Description
Provides simple logging methods with support for development-only logs.

<b> Remarks:</b>
Only available in #ASM_DEV.

### Static Methods

| Member | Description |
|--------|-------------|
| `void Assert(boolean assertion, string message)` | _No documentation available._ |
| `LogTimer Duration(string logMessage, boolean onlyLogInDev, Func<TimeSpan, string> toStringOverride, boolean logStackTrace)` | _No documentation available._ |
| `LogTimer Duration()` | _No documentation available._ |
| `void Error(string message, boolean onlyLogInDev, boolean logStackTrace)` | _No documentation available._ |
| `void Exception(Exception ex, boolean onlyLogInDev)` | _No documentation available._ |
| `void Exception(Exception ex, string message, boolean onlyLogInDev)` | _No documentation available._ |
| `void Info(string callerName)` | Logs the calling method name to console. |
| `void Info(object obj, boolean onlyLogInDev, boolean logStackTrace)` | _No documentation available._ |
| `boolean IsDev()` | _No documentation available._ |
| `void List(IEnumerable list, string header, string separator, boolean logStackTrace, boolean onlyLogInDev)` | _No documentation available._ |
| `void List(IList list, string header, string separator, boolean logStackTrace, boolean onlyLogInDev)` | _No documentation available._ |
| `void List<T>(T[] list, string header, string separator, boolean logStackTrace, boolean onlyLogInDev)` | _No documentation available._ |
| `void Warning(string message, boolean onlyLogInDev, boolean logStackTrace)` | _No documentation available._ |

---
# LogTimer
<!--
source: API\3.2.0\LogTimer.md
-->

## LogTimer

`sealed class` in `AdvancedSceneManager`### Description

### Properties

| Member | Description |
|--------|-------------|
| `TimeSpan Elapsed` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void Stop()` | _No documentation available._ |

---
# ASMModel
<!--
source: API\3.2.0\Models\ASMModel.md
-->

## ASMModel

`abstract class` in `AdvancedSceneManager.Models`  /  Inherits from: `ASMModelBase`### Description
Serves as the abstract base class for models that can be opened, closed, and preloaded.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isOpen` | _No documentation available._ |
| `boolean isPreloaded` | _No documentation available._ |
| `boolean isQueued` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual void _CancelPreload()` | Cancels all active preloads. |
| `virtual void _Close()` | Closes this asset. |
| `virtual void _FinishPreload()` | Finishes all active preloads. |
| `virtual void _Open()` | Opens this asset. |
| `virtual void _Preload()` | Preloads this asset. |
| `virtual void _Reopen()` | Reopens this asset. |
| `virtual void _ToggleOpen()` | Toggles this asset open or closed. |
| `virtual SceneOperation CancelPreload()` | Cancels all active preloads. |
| `abstract virtual SceneOperation Close()` | Closes this asset. |
| `virtual SceneOperation FinishPreload()` | Finishes all active preloads. |
| `abstract virtual SceneOperation Open()` | Opens this asset. |
| `abstract virtual SceneOperation Preload()` | Preloads this asset. |
| `abstract virtual SceneOperation Reopen()` | Reopens this asset. |
| `abstract virtual SceneOperation ToggleOpen()` | Toggles this asset open or closed. |

---
# ASMModelExtensions
<!--
source: API\3.2.0\Models\ASMModelExtensions.md
-->

## ASMModelExtensions

`static class` in `AdvancedSceneManager.Models`### Description
Provides utility methods for working with `SceneCollection`.

### Static Methods

| Member | Description |
|--------|-------------|
| `void Add<T>(T collection, Scene[] scenes)` | _No documentation available._ |
| `void AddEmptyScene<T>(T collection)` | _No documentation available._ |
| `SceneOperation CloseAll(IEnumerable<Scene> scenes)` | Closes the `scenes`. |
| `SceneOperation CloseAll(IEnumerable<Scene> scenes, LoadingScreenReference loadingScreen)` | Closes the `scenes`. |
| `int32 IndexOf<T>(T collection, Scene scene)` | _No documentation available._ |
| `void Insert<T>(T collection, int32 index, Scene scene)` | _No documentation available._ |
| `void Move<T>(T collection, int32 oldIndex, int32 newIndex)` | _No documentation available._ |
| `SceneOperation OpenAdditive(IEnumerable<SceneCollection> collections)` | Opens the `collections` as additive. |
| `SceneOperation OpenAdditive(IEnumerable<SceneCollection> collections, SceneCollection activeCollection)` | Opens the `collections` as additive. |
| `SceneOperation OpenAdditive(IEnumerable<SceneCollection> collections, SceneCollection activeCollection, Scene loadingScene)` | Opens the `collections` as additive. |
| `SceneOperation OpenAll(IEnumerable<Scene> scenes)` | Opens the `scenes`. |
| `SceneOperation OpenAll(IEnumerable<Scene> scenes, LoadingScreenReference loadingScreen)` | Opens the `scenes`. |
| `SceneOperation OpenWithAdditive(SceneCollection collection, SceneCollection[] extraAdditiveCollections)` | Opens this `collection` and then opens `extraAdditiveCollections` as additive. |
| `void Remove<T>(T collection, Scene scene)` | _No documentation available._ |
| `void RemoveAt<T>(T collection, int32 index)` | _No documentation available._ |
| `boolean Replace<T>(T collection, int32 index, Scene scene)` | _No documentation available._ |

---
# ASMSceneHelper
<!--
source: API\3.2.0\Models\ASMSceneHelper.md
-->

## ASMSceneHelper

`class` in `AdvancedSceneManager.Models`  /  Inherits from: `ScriptableObject`### Description
Provides helper methods for opening, closing, and managing scenes and collections.
            Intended for use from `UnityEvent`.

### Static Properties

| Member | Description |
|--------|-------------|
| `ASMSceneHelper instance` | Gets the global instance of `ASMSceneHelper`. |

### Properties

| Member | Description |
|--------|-------------|
| `string name` | The name of the object. |

### Methods

| Member | Description |
|--------|-------------|
| `void _Activate(Scene scene)` | _No documentation available._ |
| `void _CancelPreload()` | Cancels the preload. All preloaded scenes will be fully loaded (limitation by Unity), then closed. No ASM scene callbacks will be called. |
| `void _Close(SceneCollection collection)` | _No documentation available._ |
| `void _Close(Scene scene)` | _No documentation available._ |
| `void _FinishPreload()` | _No documentation available._ |
| `void _Open(SceneCollection collection)` | _No documentation available._ |
| `void _Open(Scene scene)` | _No documentation available._ |
| `void _OpenAdditive(SceneCollection collection)` | _No documentation available._ |
| `void _OpenAndActivate(Scene scene)` | _No documentation available._ |
| `void _Preload(SceneCollection collection)` | _No documentation available._ |
| `void _Preload(Scene scene)` | _No documentation available._ |
| `void _PreloadAdditive(SceneCollection collection)` | _No documentation available._ |
| `void _Reopen(SceneCollection collection)` | _No documentation available._ |
| `void _Reopen(Scene scene)` | _No documentation available._ |
| `void _ToggleOpen(SceneCollection collection)` | _No documentation available._ |
| `void _ToggleOpen(Scene scene)` | _No documentation available._ |
| `void Activate(Scene scene)` | _No documentation available._ |
| `SceneOperation CancelPreload()` | Cancels the preload. All preloaded scenes will be fully loaded (limitation by Unity), then closed. No ASM scene callbacks will be called. |
| `SceneOperation Close(SceneCollection collection)` | _No documentation available._ |
| `SceneOperation Close(Scene scene)` | _No documentation available._ |
| `SceneOperation CloseWithLoadingScreen(Scene scene, Scene loadingScene)` | _No documentation available._ |
| `SceneOperation FinishPreload()` | _No documentation available._ |
| `void Open(SceneCollection collection)` | _No documentation available._ |
| `SceneOperation Open(SceneCollection collection, boolean openAll)` | Opens the specified collection. |
| `SceneOperation Open(Scene scene)` | _No documentation available._ |
| `SceneOperation OpenAdditive(SceneCollection collection, boolean openAll)` | Opens the collection as additive. |
| `void OpenAdditive(SceneCollection collection)` | _No documentation available._ |
| `SceneOperation OpenAndActivate(Scene scene)` | _No documentation available._ |
| `void OpenWhereNameStartsWith(string name)` | Opens all scenes whose names start with the specified string. |
| `SceneOperation OpenWithLoadingScreen(Scene scene, Scene loadingScene)` | _No documentation available._ |
| `SceneOperation Preload(SceneCollection collection, boolean openAll)` | Preloads the specified collection. |
| `SceneOperation Preload(Scene scene, Action onPreloaded)` | Preloads the scene. |
| `SceneOperation PreloadAdditive(SceneCollection collection, boolean openAll)` | Preloads the collection as additive. |
| `void Quit()` | _No documentation available._ |
| `void Reopen(SceneCollection collection)` | _No documentation available._ |
| `SceneOperation Reopen(Scene scene)` | _No documentation available._ |
| `void Restart()` | _No documentation available._ |
| `void RestartCollection()` | Reopens the currently active `openCollection`. |
| `SceneOperation ToggleOpen(SceneCollection collection, boolean openAll)` | Toggles the collection open or closed. |
| `SceneOperation ToggleOpen(SceneCollection collection)` | _No documentation available._ |
| `SceneOperation ToggleOpen(Scene scene)` | _No documentation available._ |
| `SceneOperation ToggleOpenState(Scene scene)` | _No documentation available._ |

---
# ASMSettings
<!--
source: API\3.2.0\Models\ASMSettings.md
-->

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
| `boolean allowUpdateCheck` | Gets or sets whether ASM is allowed to check for updates. |
| `string assetPath` | Specifies the path where profiles and imported scenes should be generated to. |
| `Profile buildProfile` | The profile to use during build. |
| `boolean checkForDuplicateSceneOperations` | By default, ASM checks for duplicate scene operations, since this is usually caused by mistake, but this will disable that. |
| `CustomData customData` | Specifies custom data. |
| `Profile defaultProfile` | The profile to use when none is set. |
| `boolean enableCrossSceneReferences` | Gets or sets whatever cross-scene references should be enabled. |
| `boolean enableGUIDReferences` | Gets or sets whatever GUID references should be enabled. |
| `Profile forceProfile` | The profile to force everyone in this project to use. |
| `boolean preventSpammingEventMethods` | By default, ASM will prevent spam calling event methods (i.e. calling Scene.Open() from a button press), but this will disable that. |
| `boolean reverseUnloadOrderOnCollectionClose` | Specifies whatever collections should unload scenes in the reverse order. |
| `SceneAutoTrackOutsideASMOption sceneAutoTrackOutsideASMOption` | Specifies if ASM should auto track scenes that were loaded outside of ASM. |
| `SceneImportOption sceneImportOption` | Gets or sets when to automatically import scenes. |
| `single spamCheckCooldown` | Sets the default cooldown for `SpamCheck`. |
| `InputBinding[] toolbarBindings` | Specifies the bindings to open the ASM toolbar, if enabled. |
| `boolean toolbarButtonVisible` | Specifies whatever the ASM toolbar button should be visible. |
| `boolean toolbarEnabled` | Specifies whatever the ASM toolbar should be enabled. |

### Static Methods

| Member | Description |
|--------|-------------|
| `void OnInitialized(Action action)` | Runs the callback when ASMSettings has initialized. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual void SaveNow()` | _No documentation available._ |
| `void SetBuildProfile(Profile profile)` | Sets the build profile. |

---
# ASMUserSettings
<!--
source: API\3.2.0\Models\ASMUserSettings.md
-->

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
| `boolean displayChildProfilesButton` | Specifies the child profiles button should be displayed. |
| `boolean displayHierarchyIndicators` | Specifies whatever the hierarchy indicators should be visible. |
| `boolean displayNewCollectionButton` | Specifies the new collection button should be displayed. |
| `boolean displaySceneTooltips` | Specifies whatever SceneField will display tooltips. |
| `boolean editorOnly` | _No documentation available._ |
| `single hierarchyIndicatorsOffset` | Gets or sets the offset ASM will use for hierarchy indicators. |
| `boolean keepSceneUIInMemoryWhenCollectionCollapsed` | Whether to keep scene UI elements in memory when a collection is collapsed. |
| `string lastPatchWhenNotified` | Gets or sets the last patch version when user was notified. |
| `string lastUpdateCheck` | Gets or sets the timestamp of the last update check. |
| `boolean logBuildScenes` | Specifies whatever ASM should log when build scene list is updated. |
| `boolean logImport` | Specifies whatever ASM should log when a `ASMModelBase` is imported. |
| `boolean logLoading` | Specifies whatever ASM should log when a scene is loaded. |
| `boolean logOperation` | Specifies whatever ASM should log during scene operations. |
| `boolean logStartup` | Specifies whatever ASM should log during startup. |
| `boolean logTracking` | Specifies whatever ASM should log when a scene is tracked after loaded. |
| `boolean openCollectionOnSceneAssetOpen` | When `true`: opens the first found collection that a scene is contained in when opening an SceneAsset in editor. |
| `IEnumerable<SceneCollection> pinnedOverlayCollections` | Enumerates the pinned collections in the collection overlay. |
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

---
# AutoSceneEntry
<!--
source: API\3.2.0\Models\AutoSceneEntry.md
-->

## AutoSceneEntry

`class` in `AdvancedSceneManager.Models`### Description
Represents an auto scene entry, which is a scene that will be automatically opened or closed (depending on option), when the parent scene is.

<b> Remarks:</b>
Not meant for direct use, use the following instead:
            
```
using AdvancedSceneManager.Utility;
            
            Scene.SetAutoScene(Scene, AutoSceneOption)
```

### Fields

| Member | Description |
|--------|-------------|
| `string customOption` | The custom option for this entry. |
| `Nullable<AutoSceneOption> option` | The pre-defined option specifying how ASM will handle the scene. |
| `Scene scene` | The scene this entry refers to. |
| `string scenePath` | The path to the Unity scene asset. |

### Methods

| Member | Description |
|--------|-------------|
| `boolean IsValid()` | Gets if this entry is valid. |
| `virtual string ToString()` | _No documentation available._ |

---
# Blocklist
<!--
source: API\3.2.0\Models\Blocklist.md
-->

## Blocklist

`class` in `AdvancedSceneManager.Models`### Description
Represents a blocklist.

### Properties

| Member | Description |
|--------|-------------|
| `int32 count` | Gets how many paths are added to this blocklist. |
| `string Item` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void Add(string path)` | Adds `path` to blocklist. |
| `void Change(int32 i, string newPath)` | Changes the path at the specified index in this blocklist. |
| `boolean Contains(string path)` | Gets if this blocklist contains `path`. |
| `IEnumerable<string> Enumerate()` | Enumerates the paths are added to this blocklist. |
| `boolean Get(int32 index, String& path)` | _No documentation available._ |
| `boolean MatchesFilter(string path)` | Gets if `path` matches this blocklist. |
| `boolean MatchesFilter(string path, IEnumerable<string> list)` | Gets if `path` matches this blocklist. |
| `void Remove(string path)` | Removes `path` from this blocklist. |
| `void RemoveAt(int32 index)` | Removes the entry at `index` from this blocklist. |

---
# ButtonData
<!--
source: API\3.2.0\Models\ButtonData.md
-->

## ButtonData

`class` in `AdvancedSceneManager.Models`### Description

### Fields

| Member | Description |
|--------|-------------|
| `int32 index` | _No documentation available._ |
| `boolean isVisible` | _No documentation available._ |
| `ElementLocation location` | _No documentation available._ |
| `string name` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual string ToString()` | _No documentation available._ |

---
# CustomData
<!--
source: API\3.2.0\Models\CustomData.md
-->

## CustomData

`class` in `AdvancedSceneManager.Models`  /  Inherits from: `CustomDataDictionary<string, string>`### Description

---
# CustomDataDictionary_Of_TKey_TValue
<!--
source: API\3.2.0\Models\CustomDataDictionary_Of_TKey_TValue.md
-->

## CustomDataDictionary`2

`class` in `AdvancedSceneManager.Models`### Description

### Properties

| Member | Description |
|--------|-------------|
| `TValue Item` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void Clear(TKey key)` | _No documentation available._ |
| `boolean ContainsKey(TKey key)` | _No documentation available._ |
| `boolean Get(TKey key, TValue& value)` | _No documentation available._ |
| `TValue Get(TKey key)` | _No documentation available._ |
| `IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()` | _No documentation available._ |
| `void Set(TKey key, TValue value)` | _No documentation available._ |

---
# DynamicCollection
<!--
source: API\3.2.0\Models\DynamicCollection.md
-->

## DynamicCollection

`class` in `AdvancedSceneManager.Models`  /  Inherits from: `DynamicCollectionBase<string>`### Description
Represents a collection that can take a path and then gather all scenes within, guaranteeing that they are all added to build, including non-imported and blacklisted scenes.

### Properties

| Member | Description |
|--------|-------------|
| `int32 count` | _No documentation available._ |
| `string path` | Specifies the path that this dynamic collection will gather scenes from. |
| `IEnumerable<string> scenePaths` | Gets the paths of the scenes tracked by this dynamic collection. |
| `IEnumerable<string> scenes` | _No documentation available._ |

### Static Methods

| Member | Description |
|--------|-------------|
| `DynamicCollection Find(string id)` | Finds the dynamic collction with the specified id. |

### Methods

| Member | Description |
|--------|-------------|
| `void ImportScenes()` | Imports all scenes that are currently tracked by the collection. |
| `virtual boolean IsMatch(string q)` | Determines whether the specified query matches this model. |
| `void ReloadPaths()` | Queries all `SceneAsset` in the project that is in the defined path, and is not blacklisted. |
| `virtual string ToString()` | _No documentation available._ |

---
# DynamicCollectionBase_Of_T
<!--
source: API\3.2.0\Models\DynamicCollectionBase_Of_T.md
-->

## DynamicCollectionBase`1

`abstract class` in `AdvancedSceneManager.Models`  /  Inherits from: `ASMModelBase`### Description
Base class for dynamic collections.

### Properties

| Member | Description |
|--------|-------------|
| `int32 count` | Gets the count of scenes or scene paths contained in this collection. |
| `string description` | Gets the description of this collection. |
| `boolean hasScenes` | Gets if this collection has any scenes. |
| `T Item` | _No documentation available._ |
| `Profile profile` | Gets the profile that contains this collection. Cached. |
| `IEnumerable<string> scenePaths` | Gets the scene paths contained in this collection. |
| `IEnumerable<T> scenes` | Gets the scenes or scene paths contained in this collection. |
| `string title` | Gets the title of this collection. |

### Methods

| Member | Description |
|--------|-------------|
| `boolean Contains(T scene)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(DynamicCollectionBase<T> other)` | _No documentation available._ |
| `boolean FindProfile(Profile& profile)` | _No documentation available._ |
| `Profile FindProfile()` | Finds the profile that contains this collection. |
| `IEnumerator<T> GetEnumerator()` | Gets an enumerator for the scenes or scene paths contained in this collection. |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual boolean IsMatch(string q)` | Matches this collection against the query string. |
| `virtual string ToString()` | Returns the title of this collection. |

---
# AutoSceneOption
<!--
source: API\3.2.0\Models\Enums\AutoSceneOption.md
-->

## AutoSceneOption

`enum` in `AdvancedSceneManager.Models.Enums`  /  Inherits from: `Enum`### Description
Specifies when ASM should open or close an auto scene.

<b> Remarks:</b>
See also: ``

### Static Fields

| Member | Description |
|--------|-------------|
| `AutoSceneOption Always` | Always open the auto scene automatically in either outside or in play mode. |
| `AutoSceneOption EditModeOnly` | Only open the auto scene automatically outside of play mode. |
| `AutoSceneOption Never` | Never open the auto scene automatically. |
| `AutoSceneOption PlayModeOnly` | Only open the auto scene automatically in play mode. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# CollectionStartupOption
<!--
source: API\3.2.0\Models\Enums\CollectionStartupOption.md
-->

## CollectionStartupOption

`enum` in `AdvancedSceneManager.Models.Enums`  /  Inherits from: `Enum`### Description
Specifies what to do with a `SceneCollection` during startup.

### Static Fields

| Member | Description |
|--------|-------------|
| `CollectionStartupOption Auto` | Specifies that ASM should automatically decide if a `SceneCollection` should be opened during startup. |
| `CollectionStartupOption DoNotOpen` | Specifies that a `SceneCollection` will not open during startup. |
| `CollectionStartupOption Open` | Specifies that a `SceneCollection` will open during startup. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# EditorPersistentOption
<!--
source: API\3.2.0\Models\Enums\EditorPersistentOption.md
-->

## EditorPersistentOption

`enum` in `AdvancedSceneManager.Models.Enums`  /  Inherits from: `Enum`### Description
Specifies whatever a scene should be automatically opened outside of play-mode.

### Static Fields

| Member | Description |
|--------|-------------|
| `EditorPersistentOption AnySceneOpened` | Automatically open scene when any scene opens. |
| `EditorPersistentOption Never` | Never automatically open scene. |
| `EditorPersistentOption WhenAnyOfTheFollowingScenesAreOpened` | Automatically open scene when any specified scene is opened. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# LoadingScreenUsage
<!--
source: API\3.2.0\Models\Enums\LoadingScreenUsage.md
-->

## LoadingScreenUsage

`enum` in `AdvancedSceneManager.Models.Enums`  /  Inherits from: `Enum`### Description
Specifies what loading screen to use, if any.

### Static Fields

| Member | Description |
|--------|-------------|
| `LoadingScreenUsage DoNotUse` | Specifies no loading screen. |
| `LoadingScreenUsage Override` | Specifies overriden loading screen, defined in `SceneCollection`. |
| `LoadingScreenUsage UseDefault` | Specifies default loading screen, defined in profile settings. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# LoadPriority
<!--
source: API\3.2.0\Models\Enums\LoadPriority.md
-->

## LoadPriority

`enum` in `AdvancedSceneManager.Models.Enums`  /  Inherits from: `Enum`### Description
Priority of a thread.

### Static Fields

| Member | Description |
|--------|-------------|
| `LoadPriority Auto` | Let ASM automatically decide `ThreadPriority`. |
| `LoadPriority BelowNormal` | Below normal thread priority. |
| `LoadPriority High` | Highest thread priority. |
| `LoadPriority Low` | Lowest thread priority. |
| `LoadPriority Normal` | Normal thread priority. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# SceneAutoTrackOutsideASMOption
<!--
source: API\3.2.0\Models\Enums\SceneAutoTrackOutsideASMOption.md
-->

## SceneAutoTrackOutsideASMOption

`enum` in `AdvancedSceneManager.Models.Enums`  /  Inherits from: `Enum`### Description
Specifies if ASM should auto track scenes that were loaded outside of ASM.

### Static Fields

| Member | Description |
|--------|-------------|
| `SceneAutoTrackOutsideASMOption Collections` | Specifies ASM should auto track collection scenes when loaded outside ASM. |
| `SceneAutoTrackOutsideASMOption DynamicCollections` | Specifies ASM should auto track dynamic collection scenes when loaded outside ASM. |
| `SceneAutoTrackOutsideASMOption NoTracking` | Specifies ASM shouldn't auto track any scenes when loaded outside ASM. |
| `SceneAutoTrackOutsideASMOption Standalone` | Specifies ASM should auto track standalone collection scenes when loaded outside ASM. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# SceneImportOption
<!--
source: API\3.2.0\Models\Enums\SceneImportOption.md
-->

## SceneImportOption

`enum` in `AdvancedSceneManager.Models.Enums`  /  Inherits from: `Enum`### Description
Specifies how to scenes are imported.

### Static Fields

| Member | Description |
|--------|-------------|
| `SceneImportOption Manual` | User will manually import scenes. |
| `SceneImportOption SceneCreated` | Scenes will be automatically imported when created, otherwise manual. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# SceneState
<!--
source: API\3.2.0\Models\Enums\SceneState.md
-->

## SceneState

`enum` in `AdvancedSceneManager.Models.Enums`  /  Inherits from: `Enum`### Description
Specifies that state of a scene.

### Static Fields

| Member | Description |
|--------|-------------|
| `SceneState NotOpen` | The scene is not open. |
| `SceneState Open` | The scene is open. |
| `SceneState Opening` | The scene is currently being opened. Mutually exclusive to `Preloading`. |
| `SceneState Preloaded` | The scene is currently preloaded. |
| `SceneState Preloading` | The scene is currently being preloaded. Mutually exclusive to `Opening`. |
| `SceneState Queued` | The scene is in queue to be opened. |
| `SceneState Unknown` | The state of the scene is unknown. (An issue probably occured while checking state) |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# Events
<!--
source: API\3.2.0\Models\Events.md
-->

## Events

`struct` in `AdvancedSceneManager.Models`  /  Inherits from: `ValueType`### Description

### Fields

| Member | Description |
|--------|-------------|
| `UnityEvent<Scene> OnClose` | _No documentation available._ |
| `UnityEvent<Scene, SceneCollection> OnCollectionClosed` | _No documentation available._ |
| `UnityEvent<Scene, SceneCollection> OnCollectionOpened` | _No documentation available._ |
| `UnityEvent<Scene> OnOpen` | _No documentation available._ |
| `UnityEvent<boolean> OnOpenChanged` | _No documentation available._ |
| `UnityEvent<Scene> OnPreload` | _No documentation available._ |
| `UnityEvent<Scene> OnPreloadFinished` | _No documentation available._ |

---
# IEquality
<!--
source: API\3.2.0\Models\IEquality.md
-->

## IEquality

`interface` in `AdvancedSceneManager.Models`### Description

---
# InputBinding
<!--
source: API\3.2.0\Models\InputBinding.md
-->

## InputBinding

`class` in `AdvancedSceneManager.Models`### Description
Represents a input binding for InputSystem. Available even when InputSystem is uninstalled.

### Properties

| Member | Description |
|--------|-------------|
| `List<InputButton> buttons` | Specifies the buttons. |
| `InputBindingInteractionType interactionType` | Specifies the interaction type. |
| `boolean isValid` | Gets if this input binding is valid, if it has any buttons. |
| `boolean openCollectionAsAdditive` | Specifies whatever collection should be opened as a collection. |

### Methods

| Member | Description |
|--------|-------------|
| `void SetButtons(InputBindingInteractionType interactionType, InputButton[] binding)` | Set the buttons for this input binding. |
| `void SetButtons(InputButton[] binding)` | Set the buttons for this input binding. |

---
# InputBindingInteractionType
<!--
source: API\3.2.0\Models\InputBindingInteractionType.md
-->

## InputBindingInteractionType

`enum` in `AdvancedSceneManager.Models`  /  Inherits from: `Enum`### Description
Specifies the interaction type to use for scene bindings.

### Static Fields

| Member | Description |
|--------|-------------|
| `InputBindingInteractionType Close` | Specifies that the scene or collection will be closed on button down. |
| `InputBindingInteractionType Hold` | Specifies that the scene or collection will be opened on button down, then closed on button up. |
| `InputBindingInteractionType Open` | Specifies that the scene or collection will be opened on button down. |
| `InputBindingInteractionType Toggle` | Specifies that the scene or collection will be opened on button down, then closed on next button down. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# InputButton
<!--
source: API\3.2.0\Models\InputButton.md
-->

## InputButton

`class` in `AdvancedSceneManager.Models`### Description
Specifies a input binding for use with InputSystem.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isValid` | Gets if this input binding is valid. |

### Fields

| Member | Description |
|--------|-------------|
| `string name` | Specifies the name of this binding. |
| `string path` | Specifies the path of this binding. |

---
# IASMModel
<!--
source: API\3.2.0\Models\Interfaces\IASMModel.md
-->

## IASMModel

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Defines core members for ASM models.

### Properties

| Member | Description |
|--------|-------------|
| `string id` | Gets the id of this `IASMModel`. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void OnPropertyChanged(string propertyName)` | Raises the `PropertyChanged` event. |

---
# IAssetsAPI
<!--
source: API\3.2.0\Models\Interfaces\IAssetsAPI.md
-->

## IAssetsAPI

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Provides access to the scenes, collections and profiles managed by ASM.

<b> Remarks:</b>
May not be available in `[InitializeOnLoad]` and similar, use [Action)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.scenemanager.oninitialized(system.action)) or `OnLoadAttribute` to ensure you're not calling too early.

### Properties

| Member | Description |
|--------|-------------|
| `IEnumerable<SceneCollectionTemplate> collectionTemplates` | Enumerates all collection templates tracked by ASM. |
| `IAssetsAPIDefaultScenes defaults` | Provides access to the default ASM scenes. |
| `IEnumerable<Profile> profiles` | Enumerates all profiles tracked by ASM. |
| `ASMSceneHelper sceneHelper` | Provides access to the scene helper. |
| `IEnumerable<Scene> scenes` | Enumerates all imported scenes tracked by ASM. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual IEnumerable<T> Enumerate<T>()` | Enumerates all assets. |
| `abstract virtual IEnumerable<IASMModel> Enumerate()` | Enumerates all assets. |

---
# IAssetsAPIDefaultScenes
<!--
source: API\3.2.0\Models\Interfaces\IAssetsAPIDefaultScenes.md
-->

## IAssetsAPIDefaultScenes

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Provides access to the default ASM scenes.

<b> Remarks:</b>
May not be available in `[InitializeOnLoad]` and similar, use [Action)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.scenemanager.oninitialized(system.action)) or `OnLoadAttribute` to ensure you're not calling too early.

### Properties

| Member | Description |
|--------|-------------|
| `LoadingScreenReference asmSplashScreen` | Gets the default discoverable ASM splash screen. |
| `LoadingScreenReference fadeLoadingScreen` | Gets the default discoverable fade loading screen. |
| `Scene fadeScene` | Gets the default fade loading scene. |
| `LoadingScreenReference fadeSplashScreen` | Gets the default discoverable fade splash screen. |
| `Scene iconBounceScene` | Gets the default icon bounce loading scene. |
| `Scene inGameToolbarScene` | Gets the default in-game-toolbar scene. |
| `Scene pauseScene` | Gets the default pause scene. |
| `Scene pressAnyKeyScene` | Gets the default press any button loading scene. |
| `Scene progressBarScene` | Gets the default progress bar loading scene. |
| `Scene quoteScene` | Gets the default quote loading scene. |
| `Scene splashASMScene` | Gets the default ASM splash scene. |
| `Scene splashFadeScene` | Gets the default fade splash scene. |
| `Scene totalProgressBarScene` | Gets the default progress bar loading scene. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual IEnumerable<Scene> Enumerate()` | Enumerates all imported default scenes. |

---
# IAutoScenes
<!--
source: API\3.2.0\Models\Interfaces\IAutoScenes.md
-->

## IAutoScenes

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Provides access to members needed for the auto scene API, which is implemented using extension methods.

<b> Remarks:</b>
See also `AutoSceneUtility`.

### Properties

| Member | Description |
|--------|-------------|
| `List<AutoSceneEntry> autoScenes` | Gets the auto scenes. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void Save()` | Saves the object these auto scenes are attached to. |

---
# IAutoScenes_Of_TKey_TOption
<!--
source: API\3.2.0\Models\Interfaces\IAutoScenes_Of_TKey_TOption.md
-->

## IAutoScenes`2

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Provides access to members needed for the auto scene API, which is implemented using extension methods.

<b> Remarks:</b>
See also `AutoSceneUtility`.

---
# IEditableCollection
<!--
source: API\3.2.0\Models\Interfaces\IEditableCollection.md
-->

## IEditableCollection

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Defines properties for collections whose scene list can be modified.

<b> Remarks:</b>
Provides extension methods, see [Scene[])](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.models.asmmodelextensions.add``1(``0,advancedscenemanager.models.scene[])) for example.

### Properties

| Member | Description |
|--------|-------------|
| `List<Scene> sceneList` | The list of scenes that this collection manages. |

---
# IFindable
<!--
source: API\3.2.0\Models\Interfaces\IFindable.md
-->

## IFindable

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Defines methods for finding assets.

<b> Remarks:</b>
See also: `AssetSearchUtility`.

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual boolean IsMatch(string q)` | Matches this `IFindable` against the query string. |

---
# ILockable
<!--
source: API\3.2.0\Models\Interfaces\ILockable.md
-->

## ILockable

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Specifies a object that can be locked, using `LockUtility`.

<b> Remarks:</b>
Available, but no effect in build.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isLocked` | Gets if this `ILockable` is locked. |
| `string lockMessage` | Gets or sets the message to be displayed when unlocking this `ILockable`. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void Save()` | Saves this `ILockable`. |

---
# IOpenable
<!--
source: API\3.2.0\Models\Interfaces\IOpenable.md
-->

## IOpenable

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Defines members for openable assets.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isOpen` | Gets whether this asset is currently open. |
| `boolean isQueued` | Gets whether this asset is queued to be opened or closed. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void _Close()` | Closes this asset. |
| `abstract virtual void _Open()` | Opens this asset. |
| `abstract virtual void _Reopen()` | Reopens this asset. |
| `abstract virtual void _ToggleOpen()` | Toggles this asset open or closed. |
| `abstract virtual SceneOperation Close()` | Closes this asset. |
| `abstract virtual SceneOperation Open()` | Opens this asset. |
| `abstract virtual SceneOperation Reopen()` | Reopens this asset. |
| `abstract virtual SceneOperation ToggleOpen()` | Toggles this asset open or closed. |

---
# IOpenableCollection
<!--
source: API\3.2.0\Models\Interfaces\IOpenableCollection.md
-->

## IOpenableCollection

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Defines members for openable collections.

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void _OpenAdditive()` | _No documentation available._ |
| `abstract virtual SceneOperation OpenAdditive(boolean openAll)` | Opens the collection as additive. |

---
# IOpenableCollection_Of_T
<!--
source: API\3.2.0\Models\Interfaces\IOpenableCollection_Of_T.md
-->

## IOpenableCollection`1

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Defines members for openable collections.

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void _OpenAdditive(T model)` | _No documentation available._ |
| `abstract virtual SceneOperation OpenAdditive(T model, boolean openAll)` | _No documentation available._ |

---
# IOpenableScene
<!--
source: API\3.2.0\Models\Interfaces\IOpenableScene.md
-->

## IOpenableScene

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Defines members for openable scenes.

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void _Activate()` | Activates the scene. |
| `abstract virtual void _OpenAndActivate()` | Opens and activates the scene. |
| `abstract virtual void Activate()` | Activates the scene. |
| `abstract virtual SceneOperation CloseWithLoadingScreen(Scene loadingScene)` | Closes the scene using the specified loading screen. |
| `abstract virtual SceneOperation OpenAndActivate()` | Opens and activates the scene. |
| `abstract virtual SceneOperation OpenWithLoadingScreen(Scene loadingScene)` | Opens the scene using the specified loading screen. |

---
# IOpenableScene_Of_T
<!--
source: API\3.2.0\Models\Interfaces\IOpenableScene_Of_T.md
-->

## IOpenableScene`1

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Defines members for openable scenes.

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void _Activate(T scene)` | _No documentation available._ |
| `abstract virtual void _OpenAndActivate(T scene)` | _No documentation available._ |
| `abstract virtual void Activate(T scene)` | _No documentation available._ |
| `abstract virtual SceneOperation CloseWithLoadingScreen(T scene, Scene loadingScene)` | _No documentation available._ |
| `abstract virtual SceneOperation OpenAndActivate(T scene)` | _No documentation available._ |
| `abstract virtual SceneOperation OpenWithLoadingScreen(T scene, Scene loadingScene)` | _No documentation available._ |

---
# IOpenable_Of_T
<!--
source: API\3.2.0\Models\Interfaces\IOpenable_Of_T.md
-->

## IOpenable`1

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Defines members for openable assets.

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void _Close(T model)` | _No documentation available._ |
| `abstract virtual void _Open(T model)` | _No documentation available._ |
| `abstract virtual void _Reopen(T model)` | _No documentation available._ |
| `abstract virtual void _ToggleOpen(T model)` | _No documentation available._ |
| `abstract virtual SceneOperation Close(T model)` | _No documentation available._ |
| `abstract virtual SceneOperation Open(T model)` | _No documentation available._ |
| `abstract virtual SceneOperation Reopen(T model)` | _No documentation available._ |
| `abstract virtual SceneOperation ToggleOpen(T model)` | _No documentation available._ |

---
# IPreloadable
<!--
source: API\3.2.0\Models\Interfaces\IPreloadable.md
-->

## IPreloadable

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Defines members for assets that support preloading.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isPreloaded` | Gets whether this asset is currently preloaded. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void _CancelPreload()` | Cancels all active preloads. |
| `abstract virtual void _FinishPreload()` | Finishes all active preloads. |
| `abstract virtual void _Preload()` | Preloads this asset. |
| `abstract virtual SceneOperation CancelPreload()` | Cancels all active preloads. |
| `abstract virtual SceneOperation FinishPreload()` | Finishes all active preloads. |
| `abstract virtual SceneOperation Preload()` | Preloads this asset. |

---
# IScene
<!--
source: API\3.2.0\Models\Interfaces\IScene.md
-->

## IScene

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Defines some core properties for scenes.

### Properties

| Member | Description |
|--------|-------------|
| `boolean hasSceneAsset` | Gets if `sceneAsset` has a value. |
| `string path` | Gets the path of the associated `SceneAsset`. |
| `SceneAsset sceneAsset` | Gets the associated `SceneAsset`. |
| `string sceneAssetGUID` | Gets the asset id of the associated `sceneAsset`. |

---
# ISceneCollection
<!--
source: API\3.2.0\Models\Interfaces\ISceneCollection.md
-->

## ISceneCollection

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Defines some core properties for scene collections.

### Properties

| Member | Description |
|--------|-------------|
| `int32 count` | Gets the scene count of this collection. |
| `string description` | Gets the description of this collection. |
| `IEnumerable<string> scenePaths` | Gets the scenes of this collection. |
| `string title` | Gets the title of this collection. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual boolean Contains(object obj)` | Gets whether this collection contains the specified object. |
| `abstract virtual void Save()` | Saves this collection to disk. |

---
# ISceneCollection_Of_T
<!--
source: API\3.2.0\Models\Interfaces\ISceneCollection_Of_T.md
-->

## ISceneCollection`1

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Defines some core properties for scene collections.

### Properties

| Member | Description |
|--------|-------------|
| `T Item` | _No documentation available._ |
| `IEnumerable<T> scenes` | Gets the scenes of this collection. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual boolean Contains(T scene)` | _No documentation available._ |

---
# ISettingsAPI
<!--
source: API\3.2.0\Models\Interfaces\ISettingsAPI.md
-->

## ISettingsAPI

`interface` in `AdvancedSceneManager.Models.Interfaces`### Description
Provides access to ASM settings.

<b> Remarks:</b>
May not be available in `[InitializeOnLoad]` and similar, use [Action)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.scenemanager.oninitialized(system.action)) or `OnLoadAttribute` to ensure you're not calling too early.

### Properties

| Member | Description |
|--------|-------------|
| `Profile profile` | The current ASM profile. |
| `ASMSettings project` | The project-wide ASM settings. |
| `ASMUserSettings user` | The user specific ASM settings, not synced to source control. |

---
# ASMModelBase
<!--
source: API\3.2.0\Models\Internal\ASMModelBase.md
-->

## ASMModelBase

`abstract class` in `AdvancedSceneManager.Models.Internal`  /  Inherits from: `ScriptableObject`### Description
A base class for `Profile`, `SceneCollection` and `Scene`.

### Properties

| Member | Description |
|--------|-------------|
| `string id` | Gets the id of this `ASMModelBase`. |
| `boolean isHidden` | Specifies if this ASM asset is hidden. If it is, it won't show up in UI, and won't be enumerated when using `assets`. |
| `string name` | Gets the name of this model. |

### Events

| Member | Description |
|--------|-------------|
| `event Action onDestroy` | Called when object is destroyed. |
| `event PropertyChangedEventHandler PropertyChanged` | Called when a property changes. |

### Static Methods

| Member | Description |
|--------|-------------|
| `string GenerateID()` | Generate id. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual boolean IsMatch(string q)` | Determines whether the specified query matches this model. |
| `virtual void OnDestroy()` | Called when this object is destroyed. |
| `virtual void OnPropertyChanged(string propertyName)` | Invoke `PropertyChanged`. |
| `virtual void OnValidate()` | _No documentation available._ |
| `virtual void Save()` | Saves the singleton to disk after a delay. |
| `void SaveNow()` | Saves the singleton to disk. |
| `void SaveNow(boolean setDirty)` | Saves the singleton to disk. |

---
# Profile
<!--
source: API\3.2.0\Models\Profile.md
-->

## Profile

`class` in `AdvancedSceneManager.Models`  /  Inherits from: `ASMModelBase`### Description
A profile for ASM, contains settings and collections.

### Properties

| Member | Description |
|--------|-------------|
| `IEnumerable<ISceneCollection> allCollections` | Gets `collections`, `standaloneScenes`, `dynamicCollections`. |
| `IEnumerable<Scene> allScenes` | Gets all scenes, including child profile scenes. |
| `boolean autoSwitchBuildProfileOnBuild` | Specifies whether ASM may write the build scene list to Unity’s active build profile when no build profile is explicitly associated. |
| `boolean autoUpdateBuildScenes` | Specifies whatever build scene list should be automatically updated. |
| `IEnumerable<Profile> childProfiles` | Gets the child profiles for this profile. |
| `IEnumerable<Scene> childProfileScenes` | Gets all scenes from child profiles. |
| `IEnumerable<SceneCollection> childProfileStartupCollections` | Gets all startup collections from child profiles. |
| `IEnumerable<Scene> childProfileStartupScenes` | Gets all startup scenes from child profiles. |
| `IEnumerable<SceneCollection> collections` | Gets the collections contained within this profile. |
| `IEnumerable<DynamicCollection> dynamicCollections` | Gets the dynamic collections contained within this profile. |
| `boolean isActive` | Gets if this profile is set as active. |
| `LoadingScreenReference loadingScreen` | The default loading scene. |
| `boolean notify` | Specifies whatever this profile should trigger a notification when imported. |
| `string notifyMessage` | Specifies the notification messasge, when `notify` is `true`. |
| `IEnumerable<ISceneCollection> removedCollections` | Gets all removed collections in this profile. |
| `IEnumerable<Scene> scenes` | Gets the scenes managed by this profile. |
| `IEnumerable<Scene> specialScenes` | Gets default loading screen, splash screen and startup loading screen. |
| `LoadingScreenReference splashScreen` | The splash scene. |
| `StandaloneCollection standaloneScenes` | Gets the standalone scenes contained within this profile. |
| `IEnumerable<SceneCollection> startupCollections` | Gets the collections that will be opened on startup. |
| `Scene startupScene` | The startup scene. |
| `IEnumerable<Scene> startupScenes` | Gets the scenes flagged to open on startup. |
| `BuildProfile unityBuildProfile` | Specifies the `BuildProfile` that ASM writes its build scene list to. |
| `boolean unloadUnusedAssetsForStandalone` | Enable or disable ASM calling `UnloadUnusedAssets` after standalone scenes has been opened or closed. |

### Static Fields

| Member | Description |
|--------|-------------|
| `readonly string AssetSearchString` | Gets 't:AdvancedSceneManager.Models.Profile', the string to use in [String)](https://learn.microsoft.com/dotnet/api/m:unityeditor.assetdatabase.findassets(system.string)). |

### Static Methods

| Member | Description |
|--------|-------------|
| `Profile Create(string name)` | Creates a new profile, with default scenes and collections. |
| `Profile CreateEmpty(string name, boolean useDefaultSpecialScenes)` | Creates a new empty profile. |
| `void Delete(Profile profile)` | Deletes the specified profile. |
| `void Duplicate(Profile profile)` | Duplicate the specified profile. |
| `Profile Find(string q)` | Finds the profile with the specified name or id. |
| `boolean TryFind(string q, Profile& profile)` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void AddChildProfile(Profile profile)` | Add a child profile. |
| `void AddCollection(ISceneCollection collection)` | Adds a collection. |
| `void ClearCollections()` | Clear `collections`, `dynamicCollections`, `removedCollections`. Does not prompt undo. |
| `void ClearRemovedCollections()` | Clear removed collections. |
| `boolean Contains(ISceneCollection collection, boolean checkRemoved)` | Gets whatever this profile contains the specified collection. |
| `void CreateCollection()` | Creates a new collection with title 'New collection'. |
| `void CreateCollection(SceneCollection& collection)` | _No documentation available._ |
| `SceneCollection CreateCollection(string title)` | Create a collection and add it to this profile. |
| `SceneCollection CreateCollection(SceneCollectionTemplate template)` | Create a collection from a template. |
| `void CreateDynamicCollection()` | Creates a dynamic collection with default values. |
| `DynamicCollection CreateDynamicCollection(string path, string title)` | Creates a dynamic collection with the specified path and optional title. |
| `void Delete(ISceneCollection collection)` | Deletes a collection. Does not prompt undo. |
| `IEnumerable<ISceneCollection> FindCollections(Scene scene)` | Finds all collection that the scene is included in. Includes dynamic collections. |
| `IEnumerable<ISceneCollection> FindUntrackedCollections()` | Gets all collections saved as sub assets of this profile, that are not referenced in it. |
| `int32 IndexOf(SceneCollection collection)` | Gets the index of the specified collection. |
| `int32 IndexOf(DynamicCollection collection)` | Gets the index of the specified collection. |
| `boolean IsStartupCollection(SceneCollection collection)` | Gets if the specified collection is a startup collection. |
| `virtual void OnPropertyChanged(string propertyName)` | Invoke `PropertyChanged`. |
| `virtual void OnValidate()` | _No documentation available._ |
| `void Remove(ISceneCollection collection)` | Removes a collection. Prompts undo. |
| `void RemoveChildProfile(Profile profile)` | Remove a child profile. |
| `void Restore(ISceneCollection collection)` | Restores a collection that has been removed. |
| `virtual string ToString()` | _No documentation available._ |

---
# Scene
<!--
source: API\3.2.0\Models\Scene.md
-->

## Scene

`class` in `AdvancedSceneManager.Models`  /  Inherits from: `ASMModel`### Description
Represents a scene. This scene can be dragged dropped, and is used by ASM to perform operations on the wrapped unity scene.

<b> Remarks:</b>
A scene can be imported in the ASM window (via notification / popup), or by using `SceneImportUtility`.

### Properties

| Member | Description |
|--------|-------------|
| `string address` | Gets the addressable address for this scene. |
| `string asmPath` | Gets the path of this `Scene`. |
| `EditorPersistentOption autoOpenInEditor` | Specifies whatever this scene should be opened automatically outside of play-mode. |
| `List<Scene> autoOpenInEditorScenes` | Specifies the scenes that should trigger this scene to open when `autoOpenInEditor` is set to `WhenAnyOfTheFollowingScenesAreOpened`. |
| `IEnumerable<CrossSceneReference> crossSceneReferences { get; }` | Enumerates the cross-scene references defined on this scene. |
| `Events events` | Gets the unity events for this scene. |
| `boolean hasSceneAsset` | Gets if `m_sceneAsset` has a value. |
| `Scene[] ignoreInputBindingsForScenes` | Specifies scenes where input bindings should be ignored while open (for this scene). |
| `InputBinding[] inputBindings` | Gets or sets the input bindings for this scene. |
| `Scene inputBindingsLoadingScene` | Specifies loading screen to use when opening or closing this scene using a input binding. |
| `Nullable<Scene> internalScene { get; }` | Gets the `Scene` that this scene is associated with. |
| `boolean isActive` | Gets if this scene is currently active. |
| `boolean isAddressable` | Gets or sets if this scene is enabled for addressables. |
| `boolean isDefaultASMScene` | Gets if this is a default ASM scene. |
| `boolean isDontDestroyOnLoad` | Gets if this scene is the dontDestroyOnLoad scene. |
| `boolean isDynamic` | Gets if this scene is dynamic, it is not persisted to disk. |
| `boolean isFallbackScene` | _No documentation available._ |
| `boolean isImported` | Gets whatever the scene is tracked by ASM. |
| `boolean isIncludedInBuilds` | Gets whatever this scene is included in build. |
| `boolean isLoadingScreen { get; }` | Gets if this scene is a loading screen. |
| `boolean isLocked` | Gets if this scene is locked. |
| `boolean isNonPersistant` | Gets whatever this scene will close normally after a collection closes. |
| `boolean isOpen` | Gets whatever the scene is open. |
| `boolean isOpenInHierarchy` | Gets whatever the scene is open in the hierarchy, this is `true` if scene is currently loading, if scene is preloaded, if scene is fully open. |
| `boolean isPersistent` | Gets if this scene is opened as persistent. |
| `boolean isPreloaded` | Gets whatever the scene is preloaded. |
| `boolean isQueued` | _No documentation available._ |
| `boolean isSpecial` | Gets if this is a 'special' scene. |
| `boolean isSplashScreen { get; }` | Gets if this scene is a splash screen. |
| `boolean keepOpenWhenCollectionsClose` | Specifies whatever this scene will remain open when collections close. |
| `boolean keepOpenWhenNewCollectionWouldReopen` | Specifies whatever this will remain open when a newly opened collection would have reopened it. |
| `LoadPriority loadPriority` | Specifies the `LoadPriority` to use when opening this scene. |
| `string lockMessage` | Gets or sets the message to be displayed when unlocking this scene. |
| `ISceneCollection openedBy { get; }` | Gets the collection this scene was opened by, if it is currently open and actually was opened by a collection. |
| `boolean openOnPlayMode` | Specifies whatever this scene should be opened when entering playmode. |
| `boolean openOnStartup` | Specifies whatever this scene should be opened on startup. |
| `string path { get; }` | Gets the path of the associated `SceneAsset`. |
| `IGeneralSceneObjectCache runtimeCache` | _No documentation available._ |
| `IDiscoverablesSceneObjectCache runtimeDiscoverablesCache` | _No documentation available._ |
| `SceneAsset sceneAsset { get; }` | Gets the associated `SceneAsset`. |
| `string sceneAssetGUID` | Gets the asset id of `sceneAsset`. |
| `string sceneLoader` | Specifies what `SceneLoader` to use. |
| `SceneState state` | _No documentation available._ |

### Static Fields

| Member | Description |
|--------|-------------|
| `readonly string AssetSearchString` | Gets: 
```
t:AdvancedSceneManager.Models.Scene
```

 Used in [String)](https://learn.microsoft.com/dotnet/api/m:unityeditor.assetdatabase.findassets(system.string)). |
| `string InGameToolbarDescription` | Gets the description for the in-game toolbar scene. |
| `string PauseScreenDescription` | Gets the description for the default pause screen scene. |

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerable<Scene> Find(Func<Scene, boolean> predicate)` | _No documentation available._ |
| `Scene Find(string q)` | _No documentation available._ |
| `IEnumerable<Scene> Find<TSceneLoader>()` | _No documentation available._ |
| `IEnumerable<Scene> FindOpen(string q)` | _No documentation available._ |
| `IEnumerable<Scene> FindOpen(Func<Scene, boolean> predicate)` | _No documentation available._ |
| `boolean IsEqual(object left, object right)` | _No documentation available._ |
| `boolean TryFind(string q, Scene& scene)` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void _Activate()` | Activates this scene. |
| `void _CloseWithLoadingScreen(Scene loadingScene)` | _No documentation available._ |
| `void _OpenAndActivate()` | Opens this scene and activates it. |
| `void _OpenWithLoadingScreen(Scene loadingScene)` | _No documentation available._ |
| `void Activate()` | Activates this scene. |
| `void AddCrossSceneReference(CrossSceneReference reference)` | Adds a cross-scene reference for this scene. |
| `void ClearSceneLoader()` | Clears custom scene loader for this scene. This means normal ASM functionality will be used. |
| `virtual SceneOperation Close()` | Closes this scene. |
| `SceneOperation CloseWithLoadingScreen(Scene loadingScene)` | Closes this scene with the specified `loadingScene`. |
| `IEnumerable<AutoSceneEntry> EnumerateAutoScenes()` | Enumerates all auto scenes on this scene. |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(Scene other)` | _No documentation available._ |
| `boolean Equals(Nullable<Scene> other)` | _No documentation available._ |
| `boolean Equals(SceneAsset other)` | _No documentation available._ |
| `boolean EvalOpenAsPersistent(SceneCollection parentCollection, SceneCollection collectionToOpen)` | Evaluates whether this scene should remain open as persistent. |
| `AutoSceneEntry FindAutoScene(Scene scene, AutoSceneOption option)` | _No documentation available._ |
| `AutoSceneEntry FindAutoScene(Scene scene, string customOption)` | _No documentation available._ |
| `AutoSceneEntry FindAutoScene(string scenePath, AutoSceneOption option)` | _No documentation available._ |
| `AutoSceneEntry FindAutoScene(string scenePath, string customOption)` | _No documentation available._ |
| `AutoSceneEntry FindAutoScene(SceneAsset scene, AutoSceneOption option)` | _No documentation available._ |
| `AutoSceneEntry FindAutoScene(SceneAsset scene, string customOption)` | _No documentation available._ |
| `boolean FindAutoSceneForOption(string customOption, AutoSceneEntry& entry)` | _No documentation available._ |
| `T FindObject<T>()` | _No documentation available._ |
| `boolean FindObject<T>(T& component)` | _No documentation available._ |
| `IEnumerable<T> FindObjects<T>()` | _No documentation available._ |
| `SceneLoader GetEffectiveSceneLoader()` | Gets the effective, contextual, scene loader for this scene. `null` if none found (this means normal ASM loader will be used). |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `IEnumerable<GameObject> GetRootGameObjects()` | Gets the root game objects in this `Scene`. |
| `SceneLoader GetSceneLoader()` | Gets the scene loader specified for this scene. `null` if none set. |
| `string GetTooltip()` | Gets the SceneField tooltip. |
| `virtual boolean IsMatch(string q)` | Gets if `q` matches `name`, `id`, `path`. |
| `virtual SceneOperation Open()` | Opens this scene. |
| `SceneOperation OpenAndActivate()` | Opens this scene and activates it. |
| `SceneOperation OpenWithLoadingScreen(Scene loadingScene)` | Opens this scene with the specified `loadingScene`. |
| `virtual SceneOperation Preload()` | Preloads this scene. |
| `SceneOperation Preload(Action onPreloaded)` | Preloads this scene. |
| `void RegisterCallback<T>(EventCallback<T> callback, When when, string key)` | _No documentation available._ |
| `void RemoveCrossSceneReference(CrossSceneReference reference)` | Removes a cross-scene reference for this scene. |
| `virtual SceneOperation Reopen()` | Reopens this scene. |
| `void SetAutoOpenIn(SceneCollection collection, boolean openSceneWhenCollectionOpen)` | Toggles whatever this scene should be automatically opened when a collection is opened. No effect if scene is not already contained within collection. |
| `void SetAutoScene(Scene scene, AutoSceneOption option)` | _No documentation available._ |
| `void SetAutoScene(Scene scene, string customOption)` | _No documentation available._ |
| `void SetAutoScene(string scenePath, AutoSceneOption option)` | _No documentation available._ |
| `void SetAutoScene(string scenePath, string customOption)` | _No documentation available._ |
| `void SetAutoScene(SceneAsset scene, AutoSceneOption option)` | _No documentation available._ |
| `void SetAutoScene(SceneAsset scene, string customOption)` | _No documentation available._ |
| `void SetSceneLoader<T>()` | _No documentation available._ |
| `boolean ShouldAutoOpenIn(SceneCollection collection)` | Gets whatever the scene should automatically open, when this collection is opened. |
| `virtual SceneOperation ToggleOpen()` | Toggles this scene open or closed. |
| `virtual string ToString()` | _No documentation available._ |
| `void UnregisterCallback<T>(EventCallback<T> callback, When when, string key)` | _No documentation available._ |
| `boolean UsesSceneLoader<T>()` | _No documentation available._ |

---
# SceneCollection
<!--
source: API\3.2.0\Models\SceneCollection.md
-->

## SceneCollection

`class` in `AdvancedSceneManager.Models`  /  Inherits from: `ASMModel`### Description
Represents a collection of scenes, that should open at the same time.

<b> Remarks:</b>
Only one collection can be fully open at a time; additive collections are supported but not considered fully open.

### Properties

| Member | Description |
|--------|-------------|
| `Scene activeScene` | Specifies the scene that should be activated after collection is opened. |
| `IEnumerable<Scene> allScenes` | Gets both `scenes` and loading scenes. |
| `int32 count` | _No documentation available._ |
| `string description` | _No documentation available._ |
| `Events events` | Gets the unity events for this scene. |
| `boolean hasScenes` | Gets if this collection has any scenes. |
| `Scene[] ignoreInputBindingsForScenes` | Specifies scenes where input bindings should be ignored while open (for this collection). |
| `InputBinding[] inputBindings` | Gets or sets the input bindings for this collection. |
| `boolean isIncluded` | Gets whatever this collection should be included in build. |
| `boolean isLocked` | Gets if this collection is locked. |
| `boolean isOpen` | Gets if this collection is open. |
| `boolean isOpenAdditive` | Gets if this collection is opened additively. |
| `boolean isOpenNonAdditive` | Gets if this collection is opened additively. |
| `boolean isPreloaded` | Gets if this collection is currently preloaded. |
| `boolean isQueued` | _No documentation available._ |
| `boolean isStartupCollection` | Gets if this is a startup collection. |
| `Scene Item` | _No documentation available._ |
| `LoadingScreenReference loadingScreen` | The loading screen that is associated with this collection. |
| `LoadingScreenUsage loadingScreenUsage` | Specifies what loading screen to use. |
| `LoadPriority loadPriority` | Specifies the `LoadPriority` to use when opening this collection. |
| `string lockMessage` | Gets or sets the message to be displayed when unlocking this collection. |
| `boolean openAsPersistent` | Specifies whatever this collection should be opened as persistent. |
| `Profile profile` | The profile that this collection is associated with. |
| `IEnumerable<string> scenePaths` | _No documentation available._ |
| `IEnumerable<Scene> scenes` | _No documentation available._ |
| `List<Scene> scenesThatShouldNotAutomaticallyOpen` | Specifies scenes that should not open automatically. |
| `IEnumerable<Scene> scenesToAutomaticallyOpen` | Gets the scenes that should open automatically when collection is opened (when in openAll param is `false`). |
| `boolean setActiveSceneWhenOpenedAsAdditive` | Specifies whatever `activeScene` should be set, when collection is opened as additive. |
| `CollectionStartupOption startupOption` | Specifies startup option. |
| `string title` | _No documentation available._ |
| `boolean unloadUnusedAssets` | Calls `UnloadUnusedAssets` after collection is opened or closed. |
| `ScriptableObject userData` | The extra data that is associated with this collection. |

### Static Fields

| Member | Description |
|--------|-------------|
| `readonly string AssetSearchString` | Gets: 
```
t:AdvancedSceneManager.Models.SceneCollection
```

 Used in [String)](https://learn.microsoft.com/dotnet/api/m:unityeditor.assetdatabase.findassets(system.string)). |

### Static Methods

| Member | Description |
|--------|-------------|
| `SceneCollection Find(string q, boolean activeProfile)` | Finds a collection based on its title or id. |
| `ISceneCollection FindCollectionAll(string q, boolean activeProfile)` | Finds a `SceneCollection`, `StandaloneCollection`, [DefaultASMScenesCollection](https://learn.microsoft.com/dotnet/api/!:defaultasmscenescollection), or `DynamicCollection` based on its title or id. Supports removed collections. |
| `boolean TryFind(string q, SceneCollection& collection, boolean activeProfile)` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void _OpenAdditive()` | _No documentation available._ |
| `void _PreloadAdditive()` | _No documentation available._ |
| `virtual SceneOperation Close()` | Closes this collection. |
| `boolean Contains(Scene scene)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(SceneCollection other)` | _No documentation available._ |
| `boolean FindProfile(Profile& profile)` | _No documentation available._ |
| `Profile FindProfile()` | Find the `Profile` that this collection is associated with. |
| `IEnumerator<Scene> GetEnumerator()` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual boolean IsMatch(string q)` | Matches this collection against the query string. |
| `virtual void OnPropertyChanged(string propertyName)` | Invoke `PropertyChanged`. |
| `virtual void OnValidate()` | _No documentation available._ |
| `virtual SceneOperation Open()` | Opens this collection. |
| `SceneOperation Open(boolean openAll)` | Opens this collection. |
| `SceneOperation OpenAdditive(boolean openAll)` | Opens this collection as additive. |
| `virtual SceneOperation Preload()` | Preloads this collection. |
| `SceneOperation Preload(boolean openAll)` | Preloads this collection. |
| `SceneOperation PreloadAdditive(boolean openAll)` | Preloads this collection as additive. |
| `void RegisterCallback<T>(EventCallback<T> callback, When when, string key)` | _No documentation available._ |
| `virtual SceneOperation Reopen()` | Reopens this collection. |
| `SceneOperation Reopen(boolean openAll)` | Reopens this collection. |
| `void SetAutoOpen(Scene scene, boolean openSceneWhenCollectionOpen)` | Sets whatever the scene should automatically open, when this collection is opened. |
| `boolean ShouldAutoOpen(Scene scene)` | Gets whatever the scene should automatically open, when this collection is opened. |
| `virtual SceneOperation ToggleOpen()` | Toggles this collection open or closed. |
| `SceneOperation ToggleOpen(boolean openAll)` | Toggles this collection open and closed. |
| `virtual string ToString()` | _No documentation available._ |
| `void UnregisterCallback<T>(EventCallback<T> callback, When when, string key)` | _No documentation available._ |
| `T UserData<T>()` | _No documentation available._ |

---
# SceneCollectionTemplate
<!--
source: API\3.2.0\Models\SceneCollectionTemplate.md
-->

## SceneCollectionTemplate

`class` in `AdvancedSceneManager.Models`  /  Inherits from: `SceneCollection`### Description
Represents a template for a `SceneCollection`.

### Properties

| Member | Description |
|--------|-------------|
| `string name` | The name of the object. |

### Static Methods

| Member | Description |
|--------|-------------|
| `SceneCollectionTemplate CreateTemplate(SceneCollection collection)` | Creates `SceneCollectionTemplate` from the specified `SceneCollection`. |
| `SceneCollectionTemplate CreateTemplate(string title)` | Creates `SceneCollectionTemplate` using default properties. |

### Methods

| Member | Description |
|--------|-------------|
| `void Apply(SceneCollection collection)` | Applies a `SceneCollectionTemplate` on this `SceneCollection`. |
| `SceneCollection CreateCollection(Profile profile)` | Creates a `SceneCollection` from this `SceneCollectionTemplate`. |

---
# SceneData
<!--
source: API\3.2.0\Models\SceneData.md
-->

## SceneData

`class` in `AdvancedSceneManager.Models`  /  Inherits from: `CustomDataDictionary<string, CustomData>`### Description

---
# StandaloneCollection
<!--
source: API\3.2.0\Models\StandaloneCollection.md
-->

## StandaloneCollection

`sealed class` in `AdvancedSceneManager.Models`  /  Inherits from: `DynamicCollectionBase<Scene>`### Description
Represents a collection of standalone scenes. These scenes are guaranteed to be included in build (if the associated `Profile` is active).

<b> Remarks:</b>
Usage: `standaloneScenes`.

### Properties

| Member | Description |
|--------|-------------|
| `IEnumerable<string> scenePaths` | _No documentation available._ |
| `IEnumerable<Scene> scenes` | _No documentation available._ |
| `IEnumerable<Scene> startupScenes` | Gets all scenes that will be opened on startup. |

---
# UpdateInterval
<!--
source: API\3.2.0\Models\UpdateInterval.md
-->

## UpdateInterval

`enum` in `AdvancedSceneManager.Models`  /  Inherits from: `Enum`### Description
Specifies an interval for how often to check for ASM updates.

### Static Fields

| Member | Description |
|--------|-------------|
| `UpdateInterval Auto` | Automatically determine update interval. |
| `UpdateInterval Every12Hours` | Check for updates every 12 hours. |
| `UpdateInterval Every24Hours` | Check for updates every 24 hours. |
| `UpdateInterval Every3Hours` | Check for updates every 3 hours. |
| `UpdateInterval Every48Hours` | Check for updates every 48 hours. |
| `UpdateInterval Every6Hours` | Check for updates every 6 hours. |
| `UpdateInterval EveryHour` | Check for updates every hour. |
| `UpdateInterval EveryWeek` | Check for updates every week. |
| `UpdateInterval Never` | Never check for updates. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# BuildOption
<!--
source: API\3.2.0\Models\Utility\BuildOption.md
-->

## BuildOption

`class` in `AdvancedSceneManager.Models.Utility`### Description
Represents an enabled state depending on build context (editor, dev build, non-dev build).

### Properties

| Member | Description |
|--------|-------------|
| `boolean enableInDevBuild` | Gets whatever we should be enabled in dev build. |
| `boolean enableInEditor` | Gets whatever we should be enabled in editor. |
| `boolean enableInNonDevBuild` | Gets whatever we should be enabled in non-dev build. |

### Events

| Member | Description |
|--------|-------------|
| `event PropertyChangedEventHandler PropertyChanged` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `boolean GetIsEnabledInCurrentContext()` | Get whatever we should be enabled in the current context. |

---
# Dict_Of_T
<!--
source: API\3.2.0\Models\Utility\Dict_Of_T.md
-->

## Dict

`class` in `AdvancedSceneManager.Models.Utility`  /  Inherits from: `SerializableDictionary<Profile, T>`### Description

---
# ProfileDependentCollection
<!--
source: API\3.2.0\Models\Utility\ProfileDependentCollection.md
-->

## ProfileDependentCollection

`class` in `AdvancedSceneManager.Models.Utility`  /  Inherits from: `ProfileDependent<SceneCollection>`### Description
Represents a `SceneCollection` that changes depending on the active `Profile`.

### Properties

| Member | Description |
|--------|-------------|
| `SceneCollection collection` | Gets the `SceneCollection` associated with the currently active `Profile`. |
| `boolean isOpen` | Gets whether the collection is currently open. |
| `boolean isQueued` | Gets whether the collection is queued to be opened or closed. |

### Methods

| Member | Description |
|--------|-------------|
| `void _Close()` | Closes the collection. |
| `void _Open()` | Opens the collection. |
| `void _OpenAdditive()` | Opens the collection as additive. |
| `void _Preload()` | Preloads the collection. |
| `void _PreloadAdditive()` | Preloads the collection as additive. |
| `void _Reopen()` | Reopens the collection. |
| `void _ToggleOpen()` | Toggles the open state of the collection. |
| `SceneOperation Close()` | Closes the collection. |
| `SceneOperation Open()` | Opens the collection. |
| `SceneOperation Open(boolean openAll)` | Opens the collection. |
| `SceneOperation OpenAdditive()` | Opens the collection as additive. |
| `SceneOperation OpenAdditive(boolean openAll)` | Opens the collection as additive. |
| `SceneOperation Preload()` | Preloads the collection. |
| `SceneOperation Preload(boolean openAll)` | Preloads the collection. |
| `SceneOperation PreloadAdditive()` | Preloads the collection as additive. |
| `SceneOperation PreloadAdditive(boolean openAll)` | Preloads the collection as additive. |
| `SceneOperation Reopen()` | Reopens the collection. |
| `SceneOperation Reopen(boolean openAll)` | Reopens the collection. |
| `SceneOperation ToggleOpen()` | Toggles the open state of the collection. |
| `SceneOperation ToggleOpen(boolean openAll)` | Toggles the open state of the collection. |

---
# ProfileDependentScene
<!--
source: API\3.2.0\Models\Utility\ProfileDependentScene.md
-->

## ProfileDependentScene

`class` in `AdvancedSceneManager.Models.Utility`  /  Inherits from: `ProfileDependent<Scene>`### Description
Represents a `Scene` that changes depending on the active `Profile`.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isOpen` | Gets whether the scene is currently open. |
| `boolean isQueued` | Gets whether the scene is queued to be opened or closed. |
| `Scene scene` | Gets the `Scene` associated with the currently active `Profile`. |

### Methods

| Member | Description |
|--------|-------------|
| `void _Activate()` | Activates the scene. |
| `void _CancelPreload()` | Cancels a pending preload operation. |
| `void _Close()` | Closes the scene. |
| `void _CloseWithLoadingScreen(Scene loadingScene)` | _No documentation available._ |
| `void _FinishPreload()` | Finishes preloading the scene. |
| `void _Open()` | Opens the scene. |
| `void _OpenAndActivate()` | Opens and activates the scene. |
| `void _OpenWithLoadingScreen(Scene loadingScene)` | _No documentation available._ |
| `void _Preload()` | _No documentation available._ |
| `void _Reopen()` | Reopens the scene. |
| `void _ToggleOpen()` | Toggles the open state of the scene. |
| `void _ToggleOpenState()` | Toggles the open state of the scene. |
| `void Activate()` | Activates the scene. |
| `SceneOperation CancelPreload()` | Cancels a pending preload operation. |
| `SceneOperation Close()` | Closes the scene. |
| `SceneOperation CloseWithLoadingScreen(Scene loadingScreen)` | Closes the scene using a specified loading screen. |
| `SceneOperation FinishPreload()` | Finishes preloading the scene. |
| `SceneOperation Open()` | Opens the scene. |
| `SceneOperation OpenAndActivate()` | Opens and activates the scene. |
| `SceneOperation OpenWithLoadingScreen(Scene loadingScreen)` | Opens the scene using a specified loading screen. |
| `SceneOperation Preload(Action onPreloaded)` | Preloads the scene. |
| `SceneOperation Reopen()` | Reopens the scene. |
| `SceneOperation ToggleOpen()` | Toggles the open state of the scene. |

---
# ProfileDependent_Of_T
<!--
source: API\3.2.0\Models\Utility\ProfileDependent_Of_T.md
-->

## ProfileDependent`1

`class` in `AdvancedSceneManager.Models.Utility`  /  Inherits from: `ScriptableObject`### Description
Specifies a `T` that changes depending on active `Profile`.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isValid` | Gets if the current state of this `T` is valid. |

### Fields

| Member | Description |
|--------|-------------|
| `Dict<T> list` | The list of proxies for this `T`. |

### Methods

| Member | Description |
|--------|-------------|
| `T2 DoAction<T2>(Func<T, T2> action)` | _No documentation available._ |
| `void DoAction(Action<T> action)` | _No documentation available._ |
| `boolean GetModel(T& scene)` | _No documentation available._ |
| `T GetModel()` | Gets the selected scene. |

---
# BlacklistAttribute
<!--
source: API\3.2.0\SceneImport\BlacklistAttribute.md
-->

## BlacklistAttribute

`class` in `AdvancedSceneManager.SceneImport`  /  Inherits from: `BlocklistAttribute`### Description
Specifies a path that should be blacklisted in ASM. Scenes matching path will not be available for import.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isWhitelist` | Gets whatever `path` should be added to whitelist. |

---
# BlocklistAttribute
<!--
source: API\3.2.0\SceneImport\BlocklistAttribute.md
-->

## BlocklistAttribute

`abstract class` in `AdvancedSceneManager.SceneImport`  /  Inherits from: `DiscoverableAttribute`### Description
Specifies a path that should be blocklisted in ASM.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isWhitelist` | Gets whatever `path` should be added to whitelist. |
| `string path` | The path to add to the blocklist. |

---
# BlocklistUtility
<!--
source: API\3.2.0\SceneImport\BlocklistUtility.md
-->

## BlocklistUtility

`static class` in `AdvancedSceneManager.SceneImport`### Description
Provides utility functions for managing blocklists.

### Static Properties

| Member | Description |
|--------|-------------|
| `Blocklist blacklist` | Gets the blacklist that ASM uses to determine scenes available for import. |
| `Blocklist whitelist` | Gets the whitelist that ASM uses to determine scenes available for import. |

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerable<string> EnumerateDiscoverableBlacklistPaths()` | Enumerates all discoverable blacklist paths. |
| `void EnumerateDiscoverableBlocklist(IEnumerable`1& blacklist, IEnumerable`1& whitelist)` | _No documentation available._ |
| `IEnumerable<string> EnumerateDiscoverableWhitelistPaths()` | Enumerates all discoverable whitelist paths. |
| `boolean IsBlacklisted(string path)` | Gets whatever the path is blacklisted. |
| `boolean IsWhitelisted(string path)` | Gets whatever the path is whitelisted. |

---
# SceneImportUtility
<!--
source: API\3.2.0\SceneImport\SceneImportUtility.md
-->

## SceneImportUtility

`class` in `AdvancedSceneManager.SceneImport`  /  Inherits from: `AssetPostprocessor`### Description
Contains utility functions for importing / un-importing scenes.

<b> Remarks:</b>
Only available in editor.

### Static Properties

| Member | Description |
|--------|-------------|
| `IEnumerable<IGrouping<string, Scene>> duplicateScenes` | Gets the duplicate imported scenes. |
| `IEnumerable<string> dynamicScenes` | Gets the list of dynamic scenes in the current profile. |
| `IEnumerable<Scene> importedBlacklistedScenes` | Gets the list of imported scenes that are blacklisted. |
| `IEnumerable<string> importedScenes` | Gets the list of imported scenes in the project. |
| `IEnumerable<Scene> invalidScenes` | Gets the list of imported scenes that do not have an associated scene asset. |
| `IEnumerable<Scene> scenesWithBadPath` | Gets the list of imported scenes that do not match their asset path. |
| `IEnumerable<string> unimportedScenes` | Gets the list of unimported scenes in the project, that are available for import. |
| `IEnumerable<Scene> untrackedScenes` | Gets the list of scenes that are imported, but are, for whatever reason, not tracked by AssetRef. |

### Static Methods

| Member | Description |
|--------|-------------|
| `boolean GetImportedScene(string sceneAssetPath, Scene& scene)` | _No documentation available._ |
| `Scene GetImportedSceneByItsOwnPath(string path)` | Gets the imported scene asset by its own asset path. |
| `IEnumerable<Scene> GetImportedScenes(IEnumerable<string> sceneAssetPaths)` | Gets imported scenes matching the specified scene asset paths. |
| `IEnumerable<Scene> Import(IEnumerable<string> sceneAssetPaths, boolean notify)` | Imports the specified scenes. |
| `IEnumerable<Scene> Import(IEnumerable<string> sceneAssetPaths, string importFolder, boolean notify)` | Imports the specified scenes into the given folder. |
| `Scene Import(string sceneAssetPath, boolean notify, boolean track)` | Imports a single scene asset. |
| `Scene Import(string sceneAssetPath, string importFolder, boolean notify, boolean track, boolean skipImportedCheck, boolean skipValidCheck)` | Imports a single scene asset into the given folder. |
| `void Unimport(IEnumerable<string> scenes, boolean notify)` | Unimports the specified scenes. |
| `void Unimport(IEnumerable<Scene> scenes, boolean notify)` | Unimports the specified scenes. |
| `void Unimport(Scene scene, boolean notify)` | Unimports the specified scene. |

---
# StringExtensions
<!--
source: API\3.2.0\SceneImport\StringExtensions.md
-->

## StringExtensions

`static class` in `AdvancedSceneManager.SceneImport`### Description

### Static Methods

| Member | Description |
|--------|-------------|
| `boolean HasScene(string path)` | _No documentation available._ |
| `boolean IsASMScene(string path)` | _No documentation available._ |
| `boolean IsBlacklisted(string path)` | _No documentation available._ |
| `boolean IsDynamicScene(string path)` | _No documentation available._ |
| `boolean IsImported(string path)` | _No documentation available._ |
| `boolean IsPackageScene(string path)` | _No documentation available._ |
| `boolean IsScene(string path)` | _No documentation available._ |
| `boolean IsTestScene(string path)` | _No documentation available._ |
| `boolean IsValidSceneToImport(string path)` | _No documentation available._ |

---
# WhitelistAttribute
<!--
source: API\3.2.0\SceneImport\WhitelistAttribute.md
-->

## WhitelistAttribute

`class` in `AdvancedSceneManager.SceneImport`  /  Inherits from: `BlocklistAttribute`### Description
Specifies a path that should be whitelisted in ASM. Only scenes matching path (or other whitelisted paths) will be available for import.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isWhitelist` | Gets whatever `path` should be added to whitelist. |

---
# SceneManager
<!--
source: API\3.2.0\SceneManager.md
-->

## SceneManager

`static class` in `AdvancedSceneManager`### Description
The central Advanced Scene Manager API. Provides access to the most important things in ASM.

### Static Properties

| Member | Description |
|--------|-------------|
| `App app` | Manages startup and quit processes. |
| `IAssetsAPI assets` | Provides access to the scenes, collections and profiles managed by ASM. |
| `IDiscoverablesService discoverables` | Provides access to the ASM discoverables service. |
| `Scene dontDestroyOnLoadScene` | Gets the dontDestroyOnLoad scene. |
| `EventCallbackManager<EventCallbackBase> events` | Provides access to global ASM event callbacks. |
| `Scene fallbackScene` | Gets the fallback scene. |
| `boolean isInitialized` | Gets whatever ASM is initialized. Calling ASM methods may fail if `false`, this is due to `ASMSettings` singleton not being loaded yet. |
| `SceneCollection openCollection` | Gets the collection that is currently open. |
| `IEnumerable<Scene> openScenes` | Gets the scenes that are currently open. |
| `Package package` | Contains info about the ASM package. |
| `IEnumerable<Scene> preloadedScenes` | Gets the scenes that are preloaded. |
| `Profile profile` | Gets the currently active profile. |
| `Runtime runtime` | Manages runtime functionality for Advanced Scene Manager such as open scenes and collection. |
| `IServiceContainer services` | Provides access to the ASM service container. |
| `ISettingsAPI settings` | Provides access to ASM settings. |
| `Scene startupScene` | Gets the startup scene. |

### Static Methods

| Member | Description |
|--------|-------------|
| `void OnInitialized(Action action)` | Call `action` when ASM has initialized. |

---
# IDiscoverablesService
<!--
source: API\3.2.0\Services\IDiscoverablesService.md
-->

## IDiscoverablesService

`interface` in `AdvancedSceneManager.Services`### Description
A service that manages discoverables, types or members decorated with a subclass of `[]`, like `[]`.

<b> Remarks:</b>
Allows for centralized management, optimized discovery, and caching.

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual boolean Find(string identifier, Nullable`1& discoverable)` | _No documentation available._ |
| `abstract virtual boolean GetDiscoverable<T>(Nullable`1& discoverable)` | _No documentation available._ |
| `abstract virtual boolean GetDiscoverable<T, TAttribute>(Nullable`1& discoverable)` | _No documentation available._ |
| `abstract virtual boolean GetDiscoverable(Expression<Func<object>> expression, Nullable`1& discoverable)` | _No documentation available._ |
| `abstract virtual boolean GetDiscoverable<TAttribute>(Expression<Func<object>> expression, Nullable`1& discoverable)` | _No documentation available._ |
| `abstract virtual IEnumerable<DiscoveredMember> GetInstanceMembersOn<TDiscoverable>(Type type)` | _No documentation available._ |
| `abstract virtual IEnumerable<DiscoveredMember> GetMembers()` | Get members decorated with the specified attribute. |
| `abstract virtual IEnumerable<DiscoveredMember> GetMembers<T>()` | Get members decorated with the specified attribute. |
| `abstract virtual IEnumerable<DiscoveredMember> GetStaticMembersOn<TDiscoverable>(Type type)` | _No documentation available._ |
| `abstract virtual void InvalidateCache()` | Invalidates the discoverable cache. |

---
# IServiceContainer
<!--
source: API\3.2.0\Services\IServiceContainer.md
-->

## IServiceContainer

`interface` in `AdvancedSceneManager.Services`### Description
A container for managing services and DI.

<b> Remarks:</b>
Accessible via:

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual IEnumerable<TService> Find<TService>()` | _No documentation available._ |
| `abstract virtual TService Get<TService>()` | _No documentation available._ |
| `abstract virtual IReadOnlyDictionary<Type, object> GetAll()` | Gets all registered services. |
| `abstract virtual void Register<TService>(TService service)` | _No documentation available._ |
| `abstract virtual void Register<TService>()` | _No documentation available._ |
| `abstract virtual void Register<TService, TImplementation>()` | _No documentation available._ |
| `abstract virtual void Register<TService, TImplementation>(TImplementation service)` | _No documentation available._ |
| `abstract virtual void Resolve(object obj)` | Resolves dependencies for the specified object. |
| `abstract virtual void Unregister<T>()` | _No documentation available._ |
| `abstract virtual void Unregister(Type type)` | Unregisters a service by type. |

---
# RegisterServiceAttribute
<!--
source: API\3.2.0\Services\RegisterServiceAttribute.md
-->

## RegisterServiceAttribute

`class` in `AdvancedSceneManager.Services`  /  Inherits from: `DiscoverableAttribute`### Description
Registers a service with the service container.

### Properties

| Member | Description |
|--------|-------------|
| `Type associatedType` | Gets the associated type for this service registration. |
| `string friendlyDescription` | Gets a friendly description of this service registration. |

---
# Service_Of_T
<!--
source: API\3.2.0\Services\Service_Of_T.md
-->

## Service`1

`sealed class` in `AdvancedSceneManager.Services`### Description
Resolves a service lazily.

### Properties

| Member | Description |
|--------|-------------|
| `T instance` | _No documentation available._ |

---
# Service_ViewModelBase
<!--
source: API\3.2.0\Services\Service_ViewModelBase.md
-->

## Service_ViewModelBase

`abstract class` in `AdvancedSceneManager.Services`### Description
Shared base class for services and view models.

### Methods

| Member | Description |
|--------|-------------|
| `void RegisterEvent<T>(EventCallback<T> callback)` | _No documentation available._ |
| `void UnregisterEvent<T>(EventCallback<T> callback)` | _No documentation available._ |

---
# SessionStateHelper
<!--
source: API\3.2.0\Services\SessionStateHelper.md
-->

## SessionStateHelper

`class` in `AdvancedSceneManager.Services`### Description
A helper wrapper for `SessionState`, uses type name + property name for naming.

### Methods

| Member | Description |
|--------|-------------|
| `T GetProperty<T>(T defaultValue, string propertyName)` | _No documentation available._ |
| `T GetValue<T>(T defaultValue, string propertyName)` | _No documentation available._ |
| `void SetProperty<T>(T value, string propertyName)` | _No documentation available._ |
| `void SetValue<T>(T value, string propertyName)` | _No documentation available._ |

---
# IPopup
<!--
source: API\3.2.0\UI\IPopup.md
-->

## IPopup

`interface` in `AdvancedSceneManager.UI`### Description
Identifies a view model as a popup in the ASM window.

---
# ISettingsPage
<!--
source: API\3.2.0\UI\ISettingsPage.md
-->

## ISettingsPage

`interface` in `AdvancedSceneManager.UI`### Description
Identifies a view model as a settings page in the ASM window.

---
# SerializableViewModelData
<!--
source: API\3.2.0\UI\SerializableViewModelData.md
-->

## SerializableViewModelData

`struct` in `AdvancedSceneManager.UI`  /  Inherits from: `ValueType`### Description
Serializable data for view model state persistence.

### Fields

| Member | Description |
|--------|-------------|
| `string collectionID` | The ID of the associated collection. |
| `string sceneID` | The ID of the associated scene. |
| `Nullable<int32> sceneIndex` | The index of the scene within its collection. |
| `single scrollPos` | The scroll position of the view. |
| `string typeName` | The type name of the view model. |

---
# ViewModel
<!--
source: API\3.2.0\UI\ViewModel.md
-->

## ViewModel

`abstract class` in `AdvancedSceneManager.UI`  /  Inherits from: `Service_ViewModelBase`### Description
Defines a view model for the ASM window.

<b> Remarks:</b>
Only available in the editor.

### Properties

| Member | Description |
|--------|-------------|
| `boolean cacheAsSingleton` | Gets whatever we should cache this view model. `true` by default, disable if you're having issues. |
| `ViewModelContext context { get; }` | Gets or sets the context for this view model. |
| `VisualElement headerView { get; }` | Gets the header element for this view model, assuming `CreateHeaderGUI` is overriden. |
| `boolean isAdded { get; }` | Gets whether this view model has been added to the UI. |
| `boolean remainOpenAsPopupAfterDomainReload` | When hosted as a popup, should this view be re-opened after a domain reload? |
| `VisualElement rootVisualElement` | Gets the root visual element of the ASM window. |
| `string settingsCategoryIcon { get; }` | Specifies icon to use for settings category button. |
| `VisualTreeAsset template` | Gets the UXML template asset for this view model. |
| `string templatePath { get; }` | Gets or sets the path to the UXML template for this view model. |
| `string title` | Specifies title when hosted as a popup, or button text for settings category. |
| `boolean useScrollView` | When hosted in a PageStackView (settings page layout), should this view be wrapped in a scroll view? |
| `boolean useTemplateContainer` | If being wrapped in a `TemplateContainer` is an issue, set this to false to disable it. |
| `VisualElement view { get; }` | Gets the visual element for this view model. |
| `EditorWindow window` | Gets the ASM window. |

### Static Methods

| Member | Description |
|--------|-------------|
| `ViewModel Deserialize(SerializableViewModelData data)` | Deserializes a view model from data. |
| `T Instantiate<T>()` | _No documentation available._ |
| `T Instantiate<T>(boolean useSingletonCache)` | _No documentation available._ |
| `boolean Instantiate<T>(T& viewModel, boolean useSingletonCache)` | _No documentation available._ |
| `boolean Instantiate<T>(T& viewModel, VisualElement& view, boolean useSingletonCache)` | _No documentation available._ |
| `boolean Instantiate(Type type, ViewModel& viewModel, VisualElement& view, boolean useSingletonCache)` | _No documentation available._ |
| `boolean Instantiate(Type type, ViewModel& viewModel, boolean useSingletonCache)` | _No documentation available._ |
| `ViewModel Instantiate(Type type)` | Instantiates a view model by type. |
| `ViewModel Instantiate(Type type, boolean useSingletonCache)` | Instantiates a view model by type. |
| `SerializableViewModelData Serialize(ViewModel viewModel)` | Serializes a view model to data for persistence. |
| `boolean TryDeserialize(SerializableViewModelData data, ViewModel& viewModel)` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual VisualElement CreateGUI()` | Can be used to create gui. |
| `virtual VisualElement CreateHeaderGUI()` | When hosted in a PageStackView, this callback can be used to put content in the header. |
| `void DisableTemplateContainer()` | Disables the template container wrapper for this view model. |
| `virtual void OnAddAnimationComplete()` | Callback for when animation finished, if hosted in a container that does animate it, like popups. |

---
# ViewModelContext
<!--
source: API\3.2.0\UI\ViewModelContext.md
-->

## ViewModelContext

`struct` in `AdvancedSceneManager.UI`  /  Inherits from: `ValueType`### Description
Provides info about where a view model is hosted at in the ASM window.

### Properties

| Member | Description |
|--------|-------------|
| `ISceneCollection baseCollection` | Gets the associated collection as `ISceneCollection`, if hosted by a collection element. |
| `SceneCollection collection` | Gets the associated collection as `SceneCollection`, if hosted by a collection element. |
| `object customParam` | Gets the custom parameter that as passed from host. |
| `DynamicCollection dynamicCollection` | Gets the associated collection as `DynamicCollection`, if hosted by a collection element. |
| `Scene scene` | Gets the associated scene, if hosted by a scene element. |
| `Nullable<int32> sceneIndex` | Gets the associated scene index, if hosted by a scene element, inside a collection element. |
| `StandaloneCollection standaloneCollection` | Gets the associated collection as `StandaloneCollection`, if hosted by a collection element. |

### Methods

| Member | Description |
|--------|-------------|
| `T OfType<T>()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ASMFilePathAttribute
<!--
source: API\3.2.0\Utility\ASMFilePathAttribute.md
-->

## ASMFilePathAttribute

`class` in `AdvancedSceneManager.Utility`  /  Inherits from: `FilePathAttribute`### Description
A `FilePathAttribute` that supports build.

### Properties

| Member | Description |
|--------|-------------|
| `string path` | The path to the associated `ScriptableSingleton`1`. |

---
# ASMScriptableSingleton_Of_T
<!--
source: API\3.2.0\Utility\ASMScriptableSingleton_Of_T.md
-->

## ASMScriptableSingleton`1

`abstract class` in `AdvancedSceneManager.Utility`  /  Inherits from: `ScriptableSingleton<T>`### Description
A `ScriptableSingleton`1` that supports build.

### Properties

| Member | Description |
|--------|-------------|
| `boolean editorOnly` | Specifies that build support will not be applied to this `ScriptableSingleton`1`. |
| `SerializedObject serializedObject` | Gets a cached `SerializedObject` for this `ScriptableSingleton`1`. |

### Events

| Member | Description |
|--------|-------------|
| `event PropertyChangedEventHandler PropertyChanged` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void OnPropertyChanged(string propertyName)` | _No documentation available._ |
| `virtual void OnValidate()` | _No documentation available._ |
| `virtual void Save()` | Saves the singleton to disk, with a debounce. See also `SaveNow`. |
| `virtual void SaveNow()` | Saves the singleton to disk. |

---
# AssetSearchUtility
<!--
source: API\3.2.0\Utility\AssetSearchUtility.md
-->

## AssetSearchUtility

`static class` in `AdvancedSceneManager.Utility`### Description
Provides utility functions for searching ASM assets.

### Static Methods

| Member | Description |
|--------|-------------|
| `T Find<T>(string q)` | _No documentation available._ |
| `T Find<T>(T[] list, string q)` | _No documentation available._ |
| `T Find<T>(IEnumerable<T> list, string q)` | _No documentation available._ |
| `boolean TryFind<T>(string q, T& result)` | _No documentation available._ |
| `boolean TryFind<T>(T[] list, string q, T& result)` | _No documentation available._ |
| `boolean TryFind<T>(IEnumerable<T> list, string q, T& result)` | _No documentation available._ |

---
# Async_Of_T
<!--
source: API\3.2.0\Utility\Async_Of_T.md
-->

## Async`1

`class` in `AdvancedSceneManager.Utility`  /  Inherits from: `CustomYieldInstruction`### Description
Represents a async operation that returns a value.

### Static Properties

| Member | Description |
|--------|-------------|
| `Async<T> complete` | Gets a `Async`1` that is already completed. |

### Properties

| Member | Description |
|--------|-------------|
| `boolean keepWaiting` | Indicates if coroutine should be kept suspended. |
| `T value` | Gets the value that was produced by the async operation. |

### Static Methods

| Member | Description |
|--------|-------------|
| `Async<T> FromResult(T result)` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void OnComplete(Action<T> callback)` | _No documentation available._ |

---
# AutoSceneEventArgs
<!--
source: API\3.2.0\Utility\AutoSceneEventArgs.md
-->

## AutoSceneEventArgs

`class` in `AdvancedSceneManager.Utility`### Description
Represents event args for `AutoSceneHandlerAttribute`.

<b> Remarks:</b>
Usage:
            
```
[AutoSceneHandler]
            static void OnHandleAutoScene(AutoSceneEventArgs e)
            { }
```

### Properties

| Member | Description |
|--------|-------------|
| `Scene autoScene` | The auto scene to handle. |
| `string autoSceneKey` | The key of the auto scene. |
| `Scene parentScene` | The scene that the auto scene belongs to. |
| `SceneEvent sceneEvent` | Gets the event type. |
| `string scenePath` | The path of the auto scene to handle. |

---
# AutoSceneHandlerAttribute
<!--
source: API\3.2.0\Utility\AutoSceneHandlerAttribute.md
-->

## AutoSceneHandlerAttribute

`class` in `AdvancedSceneManager.Utility`  /  Inherits from: `DiscoverableAttribute`### Description
Registers the method to handle the auto scene with the specified auto scene key.

<b> Remarks:</b>
Usage:
            
```
[AutoSceneHandler]
            static void OnHandleAutoScene(AutoSceneEventArgs e)
            { }
```

### Properties

| Member | Description |
|--------|-------------|
| `string AutoSceneKey` | The auto scene key to handle. |
| `string friendlyDescription` | Specifies the description to be shown in the diag UI tooltip. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual boolean IsValidTarget(MemberInfo member)` | Gets if `member` is a valid target for this attribute callback. |

---
# AutoSceneUtility
<!--
source: API\3.2.0\Utility\AutoSceneUtility.md
-->

## AutoSceneUtility

`static class` in `AdvancedSceneManager.Utility`### Description
Contains utility methods related to auto scenes.

### Static Methods

| Member | Description |
|--------|-------------|
| `AutoSceneEntry FindAutoScene<TKey, TOption>(IAutoScenes<TKey, TOption> obj, TKey scene, TOption option)` | _No documentation available._ |
| `void RemoveAutoScene<TKey, TOption>(IAutoScenes<TKey, TOption> obj, TKey scene, TOption option)` | _No documentation available._ |
| `void SetAutoScene<TKey, TOption>(IAutoScenes<TKey, TOption> obj, TKey scene, TOption option)` | _No documentation available._ |

---
# CanvasSortOrderUtility
<!--
source: API\3.2.0\Utility\CanvasSortOrderUtility.md
-->

## CanvasSortOrderUtility

`static class` in `AdvancedSceneManager.Utility`### Description
An utility class to manage sort order on canvases.

### Static Properties

| Member | Description |
|--------|-------------|
| `Canvas GetBottomCanvas` | Gets the bottommost canvas. |
| `Canvas GetTopCanvas` | Gets the topmost canvas. |

### Static Methods

| Member | Description |
|--------|-------------|
| `void PutAbove(Canvas canvas, Canvas target)` | Inserts this canvas above target. |
| `void PutAtBottom(Canvas canvas)` | Sets the sort order on this canvas to be on bottom of all other canvases managed by `CanvasSortOrderUtility`. |
| `void PutBelow(Canvas canvas, Canvas target)` | Inserts this canvas below target. |
| `void PutOnTop(Canvas canvas)` | Sets the sort order on this canvas to be on top of all other canvases managed by `CanvasSortOrderUtility`. |
| `void Remove(Canvas canvas)` | Removes a canvas. |

---
# CoroutineAwaiter
<!--
source: API\3.2.0\Utility\CoroutineAwaiter.md
-->

## CoroutineAwaiter

`class` in `AdvancedSceneManager.Utility`### Description
Provides an awaiter for coroutines, allowing them to be awaited like tasks.

<b> Remarks:</b>
See also [IEnumerator)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.utility.taskutility.getawaiter(system.collections.ienumerator)).

### Properties

| Member | Description |
|--------|-------------|
| `boolean IsCompleted` | Gets whether the coroutine has completed. |

### Methods

| Member | Description |
|--------|-------------|
| `void GetResult()` | Retrieves the result of the coroutine. |
| `void OnCompleted(Action continuation)` | Registers a continuation to be invoked when the coroutine completes. |

---
# CoroutineUtility
<!--
source: API\3.2.0\Utility\CoroutineUtility.md
-->

## CoroutineUtility

`static class` in `AdvancedSceneManager.Utility`### Description
An utility class that helps with running coroutines detached from `MonoBehaviour`.

### Static Properties

| Member | Description |
|--------|-------------|
| `IEnumerable<GlobalCoroutine> coroutines` | Gets all currently active coroutines. |

### Static Methods

| Member | Description |
|--------|-------------|
| `GlobalCoroutine Chain(Func<IEnumerator>[] coroutines)` | Runs the coroutines in sequence, wrapped in a single `GlobalCoroutine`. |
| `GlobalCoroutine Chain(Func<IEnumerator>[] coroutines, string description)` | Runs the coroutines in sequence, wrapped in a single `GlobalCoroutine`. |
| `GlobalCoroutine Chain(IEnumerable<Func<IEnumerator>> coroutines, string description)` | Runs the coroutines in sequence, wrapped in a single `GlobalCoroutine`. |
| `void Run(Action action, TimeSpan after, string description, string callerFile, int32 callerLine, string callerName)` | Runs the action after the specified time. |
| `void Run(Action action, Nullable<single> after, boolean nextFrame, Func<boolean> when, string description, string callerFile, int32 callerLine, string callerName)` | Runs the action after the specified time. |
| `GlobalCoroutine StartCoroutine(IEnumerator coroutine, Action onComplete, string description, string callerFile, int32 callerLine)` | _No documentation available._ |
| `GlobalCoroutine StartCoroutineGlobal(MonoBehaviour _, IEnumerator coroutine, Action onComplete, string description, string callerFile, int32 callerLine)` | Runs the coroutine using `CoroutineUtility`, which means it won't be tied to a `MonoBehaviour` and will persist through scene close. |
| `void StopAllCoroutines()` | Stops all global coroutines. |
| `void StopCoroutine(GlobalCoroutine coroutine)` | Stops the coroutine. |
| `GlobalCoroutine Timer(Action action, TimeSpan interval, string description, string callerFile, int32 callerLine, string callerName)` | Runs the action every interval. |
| `GlobalCoroutine TimerRealtime(Action action, TimeSpan interval, string callerFile, int32 callerLine, string callerName)` | Runs the action every interval. Using unscaled time. |
| `IEnumerator WaitAll(Func<IEnumerator>[] coroutines)` | Wait for all coroutines to complete. |
| `IEnumerator WaitAll(string description, Func<IEnumerator>[] coroutines)` | Wait for all coroutines to complete. |
| `IEnumerator WaitAll(IEnumerable<Func<IEnumerator>> coroutines, Func<boolean> isCancelled, string description)` | Wait for all coroutines to complete. |
| `IEnumerator WaitAll(GlobalCoroutine[] coroutines)` | Wait for all coroutines to complete. |
| `IEnumerator WaitAll(GlobalCoroutine[] coroutines, Func<boolean> isCancelled)` | Wait for all coroutines to complete. |

---
# CrossSceneDebugger
<!--
source: API\3.2.0\Utility\CrossSceneReferences\CrossSceneDebugger.md
-->

## CrossSceneDebugger

`class` in `AdvancedSceneManager.Utility.CrossSceneReferences`  /  Inherits from: `EditorWindow`### Description
A window for debugging cross-scene references.

### Static Methods

| Member | Description |
|--------|-------------|
| `void Open()` | Opens the cross-scene reference debugger. |

---
# CrossSceneReference
<!--
source: API\3.2.0\Utility\CrossSceneReferences\CrossSceneReference.md
-->

## CrossSceneReference

`class` in `AdvancedSceneManager.Utility.CrossSceneReferences`### Description
Represents a reference between two objects in different scenes.

### Fields

| Member | Description |
|--------|-------------|
| `string id` | The unique identifier for this reference. |
| `ObjectReference value` | The value assigned to the referenced variable. |
| `ObjectReference variable` | The variable being referenced in another scene. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |

---
# CrossSceneReferenceUtility
<!--
source: API\3.2.0\Utility\CrossSceneReferences\CrossSceneReferenceUtility.md
-->

## CrossSceneReferenceUtility

`static class` in `AdvancedSceneManager.Utility.CrossSceneReferences`### Description
An utility for saving and restoring cross-scene references.

### Static Methods

| Member | Description |
|--------|-------------|
| `boolean CanSceneBeSaved(Scene scene)` | Gets if the cross-scene references can be saved. |
| `IEnumerable<CrossSceneReference> FindCrossSceneReferences(Scene[] scenes)` | Finds all cross-scene references in the scenes. |
| `boolean GetResolved(CrossSceneReference reference, Nullable`1& resolved)` | _No documentation available._ |
| `ResolvedCrossReference GetResolved(CrossSceneReference reference)` | Get the resolve result for a cross scene reference, if it has been resolved. |
| `IEnumerable<ResolvedCrossReference> GetResolvedReferences()` | Gets all references for all scenes. |
| `IEnumerable<ResolvedCrossReference> GetResolvedReferences(Scene scene)` | Gets all references for this scene. |
| `IEnumerable<ResolvedCrossReference> GetResolvedReferences(GameObject obj)` | Gets all references for this game object. |
| `IEnumerable<ResolvedCrossReference> GetResolvedReferencesValue(GameObject obj)` | Gets all references for this game object. |
| `SceneStatus GetSceneStatus(Scene scene)` | Gets the resolve status of `scene`. |
| `void Initialize()` | Initializes cross-scene references, if it is enabled in settings. |
| `void Initialize(Nullable<boolean> enabled)` | Initializes cross-scene references, if it is enabled in settings. |
| `void ResetAllScenes()` | Resets all cross-scene references in all scenes. |
| `void ResetScene(Scene scene)` | Resets all cross-scene references in scene. |
| `void ResolveAllScenes()` | Resolves all scenes. |
| `IEnumerable<ResolvedCrossReference> ResolveScene(Scene scene)` | Resolves cross-scene references in the scene. |

---
# ObjectReference
<!--
source: API\3.2.0\Utility\CrossSceneReferences\ObjectReference.md
-->

## ObjectReference

`class` in `AdvancedSceneManager.Utility.CrossSceneReferences`### Description
Represents a reference to an object within a scene.

### Properties

| Member | Description |
|--------|-------------|
| `Scene asmScene` | Gets the corresponding ASM scene, if found. |
| `boolean isTargetingComponent` | Returns whether this reference targets a component. |
| `boolean isTargetingField` | Returns whether this reference targets a field. |

### Fields

| Member | Description |
|--------|-------------|
| `string componentType` | The assembly-qualified name of the referenced component type. |
| `int32 componentTypeIndex` | The index of the component within its GameObject. |
| `string field` | The name of the referenced field, if applicable. |
| `string fieldType` | The assembly-qualified type name of the referenced field. |
| `int32 index` | The element index if targeting an array or UnityEvent. |
| `boolean isTargetingArray` | Whether this reference targets an array element. |
| `boolean isTargetingUnityEvent` | Whether this reference targets a UnityEvent entry. |
| `string objectID` | The unique object identifier of the referenced object. |
| `string scene` | The path of the scene this reference belongs to. |

### Static Methods

| Member | Description |
|--------|-------------|
| `void ResetValue(ResolvedReference variable)` | Resets the referenced value. |
| `ResolveStatus SetValue(ResolvedReference variable, ResolvedReference value)` | Sets the referenced value to another resolved reference. |

### Methods

| Member | Description |
|--------|-------------|
| `ValueTuple<string, string, string, int32, string, int32, boolean, ValueTuple<boolean>> AsTuple()` | Returns a tuple representation of this reference. |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(ObjectReference x, ObjectReference y)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `int32 GetHashCode(ObjectReference obj)` | _No documentation available._ |
| `boolean IsValid(boolean returnTrueWhenSceneIsUnloaded)` | Returns whether this reference is still valid. |
| `ResolvedReference Resolve()` | Resolves this reference to its target. |
| `virtual string ToString()` | _No documentation available._ |
| `string ToString(boolean includeScene, boolean includeGameObject)` | Returns a string representation of this reference. |
| `ObjectReference With(Component component)` | Adds data about a component to this reference. |
| `ObjectReference With(Nullable<int32> unityEventIndex, Nullable<int32> arrayIndex)` | Adds array or UnityEvent index data to this reference. |

---
# ResolvedCrossReference
<!--
source: API\3.2.0\Utility\CrossSceneReferences\ResolvedCrossReference.md
-->

## ResolvedCrossReference

`struct` in `AdvancedSceneManager.Utility.CrossSceneReferences`  /  Inherits from: `ValueType`### Description
Represents a resolved reference.

### Fields

| Member | Description |
|--------|-------------|
| `CrossSceneReference reference` | The unresolved reference. |
| `ResolveStatus result` | The result when setting value. |
| `ValueTuple<ObjectReference, ResolvedReference> value` | The unresolved and resolved reference to the value. |
| `ValueTuple<ObjectReference, ResolvedReference> variable` | The unresolved and resolved reference to the variable. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual string ToString()` | _No documentation available._ |

---
# ResolvedReference
<!--
source: API\3.2.0\Utility\CrossSceneReferences\ResolvedReference.md
-->

## ResolvedReference

`struct` in `AdvancedSceneManager.Utility.CrossSceneReferences`  /  Inherits from: `ValueType`### Description
Represents a resolved `ObjectReference`.

### Fields

| Member | Description |
|--------|-------------|
| `Component component` | The resolved `Component`, if applicable. |
| `FieldInfo field` | The resolved `FieldInfo`, if applicable. |
| `GameObject gameObject` | The resolved `GameObject`, if applicable. |
| `boolean hasBeenRemoved` | Whether the reference target has been removed. |
| `int32 index` | The element index if targeting an array or event list. |
| `boolean isTargetingArray` | Whether the reference targets an array element. |
| `boolean isTargetingUnityEvent` | Whether the reference targets a UnityEvent entry. |
| `object resolvedTarget` | The resolved target object. |
| `ResolveStatus result` | The result of the resolution. |
| `Nullable<Scene> scene` | The scene containing the resolved object, if any. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual string ToString()` | _No documentation available._ |
| `string ToString(boolean includeScene, boolean includeGameObject)` | Returns a string representation of this reference. |

---
# ResolveStatus
<!--
source: API\3.2.0\Utility\CrossSceneReferences\ResolveStatus.md
-->

## ResolveStatus

`enum` in `AdvancedSceneManager.Utility.CrossSceneReferences`  /  Inherits from: `Enum`### Description
Specifies the result of a resolve.

### Static Fields

| Member | Description |
|--------|-------------|
| `ResolveStatus ComponentNotFound` | The referenced component could not be found. |
| `ResolveStatus IndexOutOfRange` | The referenced array or event index was out of range. |
| `ResolveStatus InvalidField` | The referenced field could not be found. |
| `ResolveStatus InvalidObjectPath` | The object path was invalid or could not be found. |
| `ResolveStatus SceneIsNotOpen` | The referenced scene is not currently open. |
| `ResolveStatus Succeeded` | The reference was successfully resolved. |
| `ResolveStatus TypeMismatch` | The resolved value type does not match the expected type. |
| `ResolveStatus Unknown` | An unknown error occurred during resolution. |
| `ResolveStatus Unresolved` | The reference has not been resolved yet. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# SceneStatus
<!--
source: API\3.2.0\Utility\CrossSceneReferences\SceneStatus.md
-->

## SceneStatus

`enum` in `AdvancedSceneManager.Utility.CrossSceneReferences`  /  Inherits from: `Enum`### Description
Specifies the state of a scene.

### Static Fields

| Member | Description |
|--------|-------------|
| `SceneStatus Cleared` | Cross-scene reference utility has cleared references in this scene. |
| `SceneStatus Default` | Cross-scene reference utility has not done anything to this scene. |
| `SceneStatus Restored` | Cross-scene reference utility has restored references in this scene. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# DictionaryUtility
<!--
source: API\3.2.0\Utility\DictionaryUtility.md
-->

## DictionaryUtility

`static class` in `AdvancedSceneManager.Utility`### Description
Contains utility functions for working with dictionaries.

### Static Methods

| Member | Description |
|--------|-------------|
| `void Add<TKey, TValue>(IDictionary<TKey, TValue> d, TKey key, TValue value)` | _No documentation available._ |
| `void Add<TKey, TList, TItem>(IDictionary<TKey, TList> d, TKey key, TItem item)` | _No documentation available._ |
| `void AddRange<TKey, TList, TItem>(IDictionary<TKey, TList> d, TKey key, IEnumerable<TItem> items)` | _No documentation available._ |
| `void AddRange<TKey, TList, TItem>(IDictionary<TKey, TList> d, TKey key, TItem[] items)` | _No documentation available._ |
| `TValue GetValue<TKey, TValue>(IDictionary<TKey, TValue> d, TKey key, TValue defaultValue)` | _No documentation available._ |
| `void Remove<TKey, TList, TItem>(IDictionary<TKey, TList> d, TKey key, TItem value)` | _No documentation available._ |
| `TValue Set<TKey, TValue>(IDictionary<TKey, TValue> d, TKey key, TValue value)` | _No documentation available._ |
| `void Set(Hashtable d, object key, object value)` | Adds or replaces a value in the specified `Hashtable`. |

---
# DiscoverabilityCacheInvalidatedAttribute
<!--
source: API\3.2.0\Utility\Discoverability\DiscoverabilityCacheInvalidatedAttribute.md
-->

## DiscoverabilityCacheInvalidatedAttribute

`class` in `AdvancedSceneManager.Utility.Discoverability`  /  Inherits from: `DiscoverableAttribute`### Description
Occurs when the discoverables cache has been invalidated, and re-scanned.

<b> Remarks:</b>
This is also called after discoverables has just been initialized for the first time, even if nothing was invalidated or scanned.

### Properties

| Member | Description |
|--------|-------------|
| `string friendlyDescription` | A friendly description to be shown in the diagnostics popup of the ASM window. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual boolean IsValidTarget(MemberInfo member)` | Specifies if the member is a valid target for this attribute callback. |

---
# DiscoverableAttribute
<!--
source: API\3.2.0\Utility\Discoverability\DiscoverableAttribute.md
-->

## DiscoverableAttribute

`abstract class` in `AdvancedSceneManager.Utility.Discoverability`  /  Inherits from: `Attribute`### Description
Represents the base attribute for discoverable attributes.

### Properties

| Member | Description |
|--------|-------------|
| `string friendlyDescription` | Specifies the description to be shown in the diag UI tooltip. |
| `TargetInfo target` | Specifies what the target should look like. |

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerable<DiscoveredMember> Enumerate<T>()` | _No documentation available._ |
| `IEnumerable<ValueTuple<T, T2>> Enumerate<T, T2>()` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual boolean IsValidTarget(MemberInfo member)` | Gets if `member` is a valid target for this attribute callback. |
| `virtual void LogError(MemberInfo member, string message)` | Logs an error to console. Uses a standard template. |

---
# DiscoveredMember
<!--
source: API\3.2.0\Utility\Discoverability\DiscoveredMember.md
-->

## DiscoveredMember

`struct` in `AdvancedSceneManager.Utility.Discoverability`  /  Inherits from: `ValueType`### Description
A member that was found using `IDiscoverablesService`.

### Properties

| Member | Description |
|--------|-------------|
| `DiscoverableAttribute attribute { get; }` | Gets the attribute of this discoverable. |
| `boolean isValid` | Gets if this discovered member is valid. |
| `MemberInfo member { get; }` | Gets the member of this discoverable. |

### Static Methods

| Member | Description |
|--------|-------------|
| `string GetIdentifier(MemberInfo member)` | Gets an identifier that points to the found member. |

### Methods

| Member | Description |
|--------|-------------|
| `boolean Equals(DiscoveredMember other)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `string GetIdentifier()` | Gets an identifier that points to the found member. |
| `virtual string ToString()` | Gets a formatted string of this discoverable. |

---
# DiscoveredMemberExtensions
<!--
source: API\3.2.0\Utility\Discoverability\DiscoveredMemberExtensions.md
-->

## DiscoveredMemberExtensions

`static class` in `AdvancedSceneManager.Utility.Discoverability`### Description
Provides extension methods for DiscoveredMember.

### Static Methods

| Member | Description |
|--------|-------------|
| `boolean As<TAttribute, TMember>(DiscoveredMember discoveredMember, TAttribute& attribute, TMember& member)` | _No documentation available._ |
| `IEnumerable<ValueTuple<TAttribute, TMember>> OfType<TAttribute, TMember>(IEnumerable<DiscoveredMember> discoveredMember)` | _No documentation available._ |

---
# TargetInfo
<!--
source: API\3.2.0\Utility\Discoverability\TargetInfo.md
-->

## TargetInfo

`class` in `AdvancedSceneManager.Utility.Discoverability`### Description

### Properties

| Member | Description |
|--------|-------------|
| `boolean allowOmittingParam` | _No documentation available._ |
| `Type memberType` | _No documentation available._ |
| `Type parameterType` | _No documentation available._ |
| `boolean requireStatic` | _No documentation available._ |
| `Type returnType` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual TargetInfo <Clone>$()` | _No documentation available._ |
| `void Deconstruct(Type& memberType, Type& parameterType, Type& returnType, Boolean& allowOmittingParam, Boolean& requireStatic)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `virtual boolean Equals(TargetInfo other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# Editor
<!--
source: API\3.2.0\Utility\Editor.md
-->

## Editor

`class` in `AdvancedSceneManager.Utility`  /  Inherits from: `Editor`### Description

### Methods

| Member | Description |
|--------|-------------|
| `virtual void OnInspectorGUI()` | _No documentation available._ |
| `virtual boolean UseDefaultMargins()` | _No documentation available._ |

---
# FallbackSceneUtility
<!--
source: API\3.2.0\Utility\FallbackSceneUtility.md
-->

## FallbackSceneUtility

`static class` in `AdvancedSceneManager.Utility`### Description
An utility class that manages the default scene, called 'AdvancedSceneManager'.

<b> Remarks:</b>
The default scene allows us to more easily close all scenes when we need to, since unity requires at least one scene to be open at any time.

---
# GlobalCoroutine
<!--
source: API\3.2.0\Utility\GlobalCoroutine.md
-->

## GlobalCoroutine

`class` in `AdvancedSceneManager.Utility`  /  Inherits from: `CustomYieldInstruction`### Description
Represents a `IEnumerator` coroutine started using `CoroutineUtility`.

### Properties

| Member | Description |
|--------|-------------|
| `ValueTuple<MethodBase, string, int32> caller { get; }` | Gets the caller info of this coroutine. |
| `string description` | Gets the user defined message that was associated with this coroutine. |
| `boolean isComplete { get; }` | Gets whatever this coroutine is completed. |
| `boolean isPaused { get; }` | Gets whatever this coroutine is paused. |
| `boolean isRunning { get; }` | Gets whatever this coroutine is currently running. This will still return `true` when paused. |
| `boolean keepWaiting` | `keepWaiting`, this is how unity knows if this coroutine is done or not. |
| `boolean wasCancelled { get; }` | Gets whatever this coroutine was cancelled. |

### Methods

| Member | Description |
|--------|-------------|
| `void OnComplete(Action callback)` | Adds a callback to be invoked when the coroutine completes. |
| `void Pause()` | Pauses the coroutine. Make sure to not use this from within a coroutine, unless you also make sure to unpause it from outside. No effect if already paused. |
| `void Resume()` | Resumes a paused coroutine. No effect if not paused. |
| `void Stop()` | Stops the coroutine. |
| `virtual string ToString()` | Returns the name of the object. |
| `void ViewCallerInCodeEditor()` | View caller in code editor, only accessible in editor. |

---
# GuidReference
<!--
source: API\3.2.0\Utility\GuidReference.md
-->

## GuidReference

`class` in `AdvancedSceneManager.Utility`  /  Inherits from: `MonoBehaviour`### Description
Represents a persistent reference to the `GameObject` that this is attached to, see also `GuidReferenceUtility` .

### Fields

| Member | Description |
|--------|-------------|
| `string guid` | The guid of this reference. |

---
# GuidReferenceUtility
<!--
source: API\3.2.0\Utility\GuidReferenceUtility.md
-->

## GuidReferenceUtility

`class` in `AdvancedSceneManager.Utility`### Description
An utility for referencing objects globally.

### Static Methods

| Member | Description |
|--------|-------------|
| `string Add(GameObject obj)` | Adds a persistent reference to this `GameObject`. |
| `GuidReference Find(string id)` | Finds a reference if it exists. |
| `string GenerateID()` | Generates an id. |
| `string GetOrAddPersistent(GameObject obj)` | Adds a persistent reference to this `GameObject`. |
| `boolean HasReference(string id)` | Gets if reference exists. |
| `boolean IsRegistered(GuidReference reference)` | Gets if reference exists. |
| `void Remove(GameObject obj, boolean saveScene)` | Removes a persistent reference to this `GameObject`. |
| `boolean TryFind(string id, GuidReference& obj)` | _No documentation available._ |

---
# IDiscoverablesSceneObjectCache
<!--
source: API\3.2.0\Utility\IDiscoverablesSceneObjectCache.md
-->

## IDiscoverablesSceneObjectCache

`interface` in `AdvancedSceneManager.Utility`### Description

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual IEnumerable<MonoBehaviour> GetAll<T>()` | _No documentation available._ |
| `abstract virtual void Set<T>(IEnumerable<MonoBehaviour> list)` | _No documentation available._ |

---
# IGeneralSceneObjectCache
<!--
source: API\3.2.0\Utility\IGeneralSceneObjectCache.md
-->

## IGeneralSceneObjectCache

`interface` in `AdvancedSceneManager.Utility`### Description

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual T Get<T>(string key)` | _No documentation available._ |
| `abstract virtual boolean Get<T>(string key, T& obj)` | _No documentation available._ |
| `abstract virtual IEnumerable<ValueTuple<string, T>> GetAll<T>()` | _No documentation available._ |
| `abstract virtual void Remove(string key)` | _No documentation available._ |
| `abstract virtual void Set<T>(string key, T obj)` | _No documentation available._ |

---
# IQueueable
<!--
source: API\3.2.0\Utility\IQueueable.md
-->

## IQueueable

`interface` in `AdvancedSceneManager.Utility`### Description
Represents a queueable item.

<b> Remarks:</b>
See also `QueueUtility`1`.

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual boolean CanQueue()` | Called to make sure the item can actually be queued. |
| `abstract virtual void OnCancel()` | Called when queueable is cancelled. |
| `abstract virtual void OnTurn(Action onComplete)` | Called when it is this queueables turn. |

---
# IReorderableDictionary
<!--
source: API\3.2.0\Utility\IReorderableDictionary.md
-->

## IReorderableDictionary

`interface` in `AdvancedSceneManager.Utility`### Description
Adds support for reorder in `SerializableDictionary`2`. Used by property drawer.

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void Move(int32 oldIndex, int32 newIndex)` | Move the item at `oldIndex` to `newIndex`. |

---
# LerpUtility
<!--
source: API\3.2.0\Utility\LerpUtility.md
-->

## LerpUtility

`static class` in `AdvancedSceneManager.Utility`### Description
Provides some convinience functions for lerping.

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerator Lerp(single start, single end, single duration, Action<single> callback, Action onComplete)` | Lerp from `start` to `end` over `duration` seconds. |
| `IEnumerator Lerp(Vector3 start, Vector3 end, single duration, Action<Vector3> callback, Action onComplete)` | _No documentation available._ |
| `IEnumerator Lerp(Vector2 start, Vector2 end, single duration, Action<Vector2> callback, Action onComplete)` | _No documentation available._ |

---
# LoadingScreenUtility
<!--
source: API\3.2.0\Utility\LoadingScreenUtility.md
-->

## LoadingScreenUtility

`static class` in `AdvancedSceneManager.Utility`### Description
Manager for loading screens.

### Static Properties

| Member | Description |
|--------|-------------|
| `boolean isAnyLoadingScreenOpen` | Gets if any loading screens are open. |
| `IEnumerable<ILoadProgressListener> loadProgressListeners` | The currently open loading screens. |
| `IEnumerable<LoadingScreenReference> openLoadingScreens` | The currently open loading screens. |

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerator CloseAll()` | Hide all loading screens. |
| `Awaitable<boolean> CloseLoadingScreen(LoadingScreenReference loadingScreen)` | _No documentation available._ |
| `SceneOperation DoAction(Scene scene, Action action, Action<LoadingScreenReference> loadingScreenCallback)` | _No documentation available._ |
| `SceneOperation DoAction(Scene scene, Func<IEnumerator> coroutine, Action<LoadingScreenReference> loadingScreenCallback)` | _No documentation available._ |
| `IEnumerator FadeIn(LoadingScreenReference loadingScreen, single duration, Nullable<Color> color)` | _No documentation available._ |
| `Awaitable<LoadingScreenReference> FadeOut(single duration, Nullable<Color> color)` | _No documentation available._ |
| `boolean IsLoadingScreenOpen(LoadingScreenReference loadingScreen)` | _No documentation available._ |
| `Awaitable<LoadingScreenReference> OpenLoadingScreen(SceneOperation operation, Action<LoadingScreenReference> callbackBeforeBegin)` | _No documentation available._ |
| `Awaitable<LoadingScreenReference> OpenLoadingScreen(LoadingScreenReference loadingScreen, SceneOperation operation, Action<LoadingScreenReference> callbackBeforeBegin)` | _No documentation available._ |
| `AsyncOperation Preload(AsyncOperation asyncOperation, Func`1& activateCallback)` | _No documentation available._ |
| `void RegisterLoadProgressListener(ILoadProgressListener listener)` | _No documentation available._ |
| `void ReportProgress(ILoadProgressData progress)` | _No documentation available._ |
| `GlobalCoroutine ReportProgress(AsyncOperation asyncOperation, SceneOperationKind kind, SceneOperation operation, Scene scene)` | Returns a coroutine that returns when `isDone` becomes `true`. |
| `void UnregisterLoadProgressListener(ILoadProgressListener listener)` | _No documentation available._ |

---
# MainThreadUtility
<!--
source: API\3.2.0\Utility\MainThreadUtility.md
-->

## MainThreadUtility

`static class` in `AdvancedSceneManager.Utility`### Description
An utility for running actions on the main thread.

Only usable in play mode.

### Static Properties

| Member | Description |
|--------|-------------|
| `boolean isEnabled` | Gets whatever `MainThreadUtility` is enabled, set to `false` in source code to disable. |
| `boolean isOnMainThread` | Gets if the thread we're currently on is the main thread. |
| `boolean IsRunning` | Gets if main thread utility is running. |

### Static Methods

| Member | Description |
|--------|-------------|
| `T Invoke<T>(Func<T> func)` | _No documentation available._ |
| `void Invoke(Action action)` | Queues the action to be run on the main thread, during the next frame. |
| `T Invoke<T>(Func<T> func, boolean mainThread)` | _No documentation available._ |
| `void Invoke(Action action, boolean mainThread)` | Invokes the `action`. |
| `void Start()` | Starts main thread utility coroutine. |
| `void Stop()` | Stops main thread utility coroutine. |

---
# ProfileUtility
<!--
source: API\3.2.0\Utility\ProfileUtility.md
-->

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

---
# QueueUtility_Of_T
<!--
source: API\3.2.0\Utility\QueueUtility_Of_T.md
-->

## QueueUtility`1

`static class` in `AdvancedSceneManager.Utility`### Description
A utility that provides queuing.

### Static Properties

| Member | Description |
|--------|-------------|
| `boolean isBusy` | Gets whatever any items in the queue are running. |
| `IEnumerable<T> queue` | Gets the items currently in queue. |
| `IEnumerable<T> running` | Gets the items that are currently running. |

### Static Events

| Member | Description |
|--------|-------------|
| `event Action queueEmpty` | Occurs when an queued item finishes and queue is empty. |
| `event Action queueFilled` | Occurs when an queued is added. |

### Static Methods

| Member | Description |
|--------|-------------|
| `boolean IsQueued(T queueable)` | _No documentation available._ |
| `boolean IsRunning(T queueable)` | _No documentation available._ |
| `void Stop(T queueable)` | _No documentation available._ |
| `void StopAll()` | Cancels all queued and running items. |

---
# SceneBindingUtility
<!--
source: API\3.2.0\Utility\SceneBindingUtility.md
-->

## SceneBindingUtility

`static class` in `AdvancedSceneManager.Utility`### Description
Provides utility functions relating to scene bindings.

<b> Remarks:</b>
Only available if input system is installed.

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerable<ValueTuple<SceneCollection, Scene, InputBinding>> GetBindings()` | Gets all bindings in the project. |
| `boolean IsDuplicate(InputButton binding)` | Gets if the binding is assigned to multiple scenes / collections. |
| `boolean WasOpenedByBinding(SceneCollection collection)` | Gets if `collection` was opened by a binding. |
| `boolean WasOpenedByBinding(Scene scene)` | Gets if the scene was opened by a binding. |

---
# SceneUtility
<!--
source: API\3.2.0\Utility\SceneUtility.md
-->

## SceneUtility

`static class` in `AdvancedSceneManager.Utility`### Description
An utility class to perform actions on scenes.

### Static Properties

| Member | Description |
|--------|-------------|
| `Scene dontDestroyOnLoadScene` | Gets the dontDestroyOnLoad scene. Returns null if not open. |
| `boolean hasAnyScenes` | Gets if there are any scenes open that are not dynamically created, and not yet saved to disk. |
| `boolean isStartupScene` | Gets if current, and only, scene is the startup scene. |
| `int32 unitySceneCount` | The current number of Scenes. |

### Static Methods

| Member | Description |
|--------|-------------|
| `void AddScript<T>(Scene scene, Action<T> configure)` | _No documentation available._ |
| `boolean ASMScene(Component component, Scene& scene)` | _No documentation available._ |
| `Scene ASMScene(GameObject gameObject, Scene& scene)` | _No documentation available._ |
| `Scene ASMScene(Component component)` | _No documentation available._ |
| `Scene ASMScene(GameObject gameObject)` | _No documentation available._ |
| `boolean ASMScene(Scene thisScene, Scene& scene)` | _No documentation available._ |
| `Scene ASMScene(Scene scene)` | Gets the associated ASM `Scene`. |
| `boolean ASMScene(SceneAsset thisScene, Scene& scene)` | _No documentation available._ |
| `Scene ASMScene(SceneAsset scene)` | Finds the asm representation of this `SceneAsset`. |
| `IEnumerable<SceneAsset> Create(string[] paths)` | _No documentation available._ |
| `IEnumerable<SceneAsset> Create(IEnumerable<string> paths)` | _No documentation available._ |
| `SceneAsset Create(string path)` | Creates a scene at the specified path. |
| `Scene CreateAddressableScene(string name, AssetReference assetReference)` | Creates an addressable, runtime-only, scene. |
| `Scene CreateAndImport(string path)` | Creates and imports a scene. |
| `IEnumerable<Scene> CreateAndImport(string[] paths)` | _No documentation available._ |
| `IEnumerable<Scene> CreateAndImport(IEnumerable<string> paths)` | _No documentation available._ |
| `void CreateAsset(string folder, string baseClass, string namespaceName, string name)` | Creates a scene asset and script based on the specified base class. |
| `Scene CreateDynamic(string name, LocalPhysicsMode localPhysicsMode)` | Creates a scene at runtime, that is not saved to disk. |
| `GameObject CreateHere(MonoBehaviour mono)` | Creates a game object in this scene. |
| `GameObject CreateHere(MonoBehaviour mono, string name)` | Creates a game object in this scene. |
| `GameObject CreateHere(MonoBehaviour mono, string name, Type[] components)` | Creates a game object in this scene. |
| `TComponent CreateHere<TComponent>(MonoBehaviour mono, string gameObjectName)` | Creates a game object in this scene. |
| `void CreateLoadingScreenAsset(string folder, string name, string namespaceName)` | Creates a loading screen scene and its corresponding script. |
| `void CreateSplashScreenAsset(string folder, string name, string namespaceName)` | Creates a splash screen scene and its corresponding script. |
| `void Disable(Scene scene)` | Sets all root objects as disabled. |
| `void Enable(Scene scene)` | Sets all root objects as enabled. |
| `IEnumerable<Scene> EvaluateFinalSceneList(Profile profile, StartupProps props)` | _No documentation available._ |
| `IEnumerable<Scene> EvaluateFinalSceneList(IEnumerable<SceneCollection> collections)` | Evaluate the final scene list after opening a sequence of collections. |
| `Scene Find(string q)` | Find scenes by name or path. |
| `IEnumerable<Scene> Find(Func<Scene, boolean> predicate)` | Find scenes by predicate. |
| `Scene FindAddressableScene(AssetReference assetReference)` | Finds the scene with the associated `AssetReference`. |
| `boolean FindCollection(Scene scene, SceneCollection& collection)` | _No documentation available._ |
| `SceneCollection FindCollection(Scene scene)` | Attempts to find best match for collection. |
| `IEnumerable<SceneCollection> FindCollections(Scene scene, boolean allProfiles)` | Finds which collections that this scene is a part of. |
| `IEnumerable<SceneCollection> FindCollections(Scene scene, Profile profile)` | Finds which collections that this scene is a part of. |
| `IEnumerable<Scene> FindOpen(string q)` | Find open scenes by name or path. |
| `IEnumerable<Scene> FindOpen(Func<Scene, boolean> predicate)` | Find open scenes by predicate. |
| `IEnumerable<Scene> GetAllOpenUnityScenes()` | Get all open unity scenes. |
| `Scene Import(SceneAsset scene)` | _No documentation available._ |
| `IEnumerable<Scene> Import(IEnumerable<SceneAsset> scene)` | _No documentation available._ |
| `Scene Import(string scene)` | Imports the scene into ASM and returns it. Returns already imported scene if already imported. |
| `IEnumerable<Scene> Import(string[] scene)` | Imports the scene into ASM and returns it. Returns already imported scene if already imported. |
| `boolean IsIncluded(Scene scene)` | Gets if the scene is included in build. |
| `void MergeScenes(Scene targetScene, Scene[] scenes)` | Merges the specified scenes into the target scene. |
| `void MergeScenes(string targetScenePath, string[] scenePaths)` | Merges the specified scenes into the target scene. |
| `void MergeScenesPreserveOriginal(Scene targetScene, Scene[] scenes)` | Merges the specified scenes into the target scene, preserving the originals. |
| `void MergeScenesPreserveOriginal(string targetScenePath, string[] scenePaths)` | Merges the specified scenes into the target scene, preserving the originals. |
| `void Move(GameObject obj, Scene scene)` | _No documentation available._ |
| `void Move(GameObject obj, Scene scene)` | _No documentation available._ |
| `void MoveAfter(Scene sceneToMove, Scene otherScene)` | Moves the scene after another scene. |
| `void MoveBefore(Scene sceneToMove, Scene otherScene)` | Moves the scene before another scene in the heirarchy. |
| `GameObject MoveHere(MonoBehaviour mono, GameObject obj)` | Moves `obj` to this scene. |
| `void MoveToBottom(Scene sceneToMove)` | Moves the scene to the bottom in the hierarchy. |
| `void MoveToNewScene(GameObject[] objects)` | Moves the object to a new scene. |
| `void MoveToTop(Scene sceneToMove)` | Moves the scene to the top in the hierarchy. |
| `void RemoveScript<T>(Scene scene, boolean removeGameObject)` | _No documentation available._ |
| `void SetEnabled(Scene scene, boolean isEnabled)` | Sets all root objects as enabled / disabled. |
| `void Unimport(SceneAsset scene)` | _No documentation available._ |
| `void Unimport(IEnumerable<SceneAsset> scene)` | _No documentation available._ |
| `void Unimport(string[] scene)` | Unimports the scene from ASM. No effect if scene not imported. |
| `void Unimport(Scene scene)` | _No documentation available._ |
| `void Unimport(IEnumerable<Scene> scene)` | _No documentation available._ |
| `void Unimport(Scene[] scene)` | Unimports the scene from ASM. No effect if scene not imported. |

---
# ScriptableObjectUtility
<!--
source: API\3.2.0\Utility\ScriptableObjectUtility.md
-->

## ScriptableObjectUtility

`static class` in `AdvancedSceneManager.Utility`### Description
Contains utility methods for `ScriptableObject`.

### Static Methods

| Member | Description |
|--------|-------------|
| `void Save(ScriptableObject obj)` | Saves the `ScriptableObject`. |

---
# SerializableDictionary_Of_TKey_TValue
<!--
source: API\3.2.0\Utility\SerializableDictionary_Of_TKey_TValue.md
-->

## SerializableDictionary`2

`class` in `AdvancedSceneManager.Utility`  /  Inherits from: `Dictionary<TKey, TValue>`### Description
A serializable dictionary that supports Unity serialization and implements `IDictionary`2`.

### Methods

| Member | Description |
|--------|-------------|
| `virtual void OnAfterDeserialize()` | Implement this callback to transform data back into runtime data types after an object is deserialized. |
| `virtual void OnBeforeSerialize()` | Implement this callback to transform data into serializable data types immediately before an object is serialized. |

---
# SpamCheck
<!--
source: API\3.2.0\Utility\SpamCheck.md
-->

## SpamCheck

`class` in `AdvancedSceneManager.Utility`### Description
Provides an easy way to check for spamming.

### Static Properties

| Member | Description |
|--------|-------------|
| `SpamCheck Global` | Gets the global spam check. |

### Properties

| Member | Description |
|--------|-------------|
| `single executeCooldown` | Gets or sets the cooldown. |
| `boolean isEnabled` | Gets or sets if this `SpamCheck` is enabled. |
| `single lastExecute { get; }` | Gets the time an action was executed last. |
| `single timeSinceLastExecute` | Gets the time an action was executed last. |

### Methods

| Member | Description |
|--------|-------------|
| `void Execute(Action action)` | Runs action if allowed. |
| `boolean IsSpam()` | Gets if an action was executed not long enough ago. |
| `void MarkAsExecuted()` | Marks this spam check as executed, disallowing any actions until cooldown has run out. |

---
# StopwatchUtility
<!--
source: API\3.2.0\Utility\StopwatchUtility.md
-->

## StopwatchUtility

`static class` in `AdvancedSceneManager.Utility`### Description
Provides utility functions for working with stopwatches.

### Static Methods

| Member | Description |
|--------|-------------|
| `TimeSpan GetElapsedTime(int64 startingTimestamp)` | Gets the elapsed time. |

---
# TaskUtility
<!--
source: API\3.2.0\Utility\TaskUtility.md
-->

## TaskUtility

`static class` in `AdvancedSceneManager.Utility`### Description
Provides utility methods for working with tasks.

### Static Methods

| Member | Description |
|--------|-------------|
| `CoroutineAwaiter GetAwaiter(IEnumerator coroutine)` | Gets an awaiter that allows awaiting the coroutine. |
| `Awaitable<boolean> StartCoroutineAsAwaitable(IEnumerator coroutine)` | Runs a coroutine as an `Awaitable`1`. |
| `Task StartCoroutineAsTask(IEnumerator coroutine)` | Runs a coroutine as a `Task`. |
| `Awaitable WhenAll(Awaitable[] items)` | Waits for all awaitable to finish. |

---
# TypeUtility
<!--
source: API\3.2.0\Utility\TypeUtility.md
-->

## TypeUtility

`static class` in `AdvancedSceneManager.Utility`### Description
Contains utility functions for working with types.

### Static Methods

| Member | Description |
|--------|-------------|
| `Type Deserialize(string value)` | _No documentation available._ |
| `boolean Deserialize(string value, Type& type)` | _No documentation available._ |
| `string GetFriendlyTypeName(Type type)` | Gets the friendly name of this type. |
| `string GetSignature(MemberInfo member, boolean includeAccessModifiers)` | Gets the signature of this member. |
| `boolean HasNoParameters(MemberInfo member)` | Gets if `member` is a `MethodInfo`, and has no parameters. |
| `boolean HasParameters<T1>(MemberInfo member)` | _No documentation available._ |
| `boolean HasParameters<T1, T2>(MemberInfo member)` | _No documentation available._ |
| `boolean HasParameters<T1, T2, T3>(MemberInfo member)` | _No documentation available._ |
| `boolean HasParameters<T1, T2, T3, T4>(MemberInfo member)` | _No documentation available._ |
| `boolean HasParameters(MemberInfo member, Type[] types)` | _No documentation available._ |
| `boolean IsConstructor(MemberInfo member)` | Determines whether the specified `MemberInfo` represents a constructor. |
| `boolean IsField(MemberInfo member)` | Determines whether the specified `MemberInfo` represents a field. |
| `boolean IsMethod(MemberInfo member)` | Determines whether the specified `MemberInfo` represents a method. |
| `boolean IsMethodAndReturns<T>(MemberInfo member)` | _No documentation available._ |
| `boolean IsProperty(MemberInfo member)` | Determines whether the specified `MemberInfo` represents a property. |
| `boolean IsStatic(MemberInfo member)` | Determines whether the specified `MemberInfo` represents a static member. |
| `boolean IsType(MemberInfo member)` | Determines whether the specified `MemberInfo` represents a type. |
| `boolean IsType(MemberInfo member, Type type)` | Determines whether the specified `MemberInfo` represents a type. |
| `boolean IsType<T>(MemberInfo member)` | Determines whether the specified `MemberInfo` represents a type. |
| `boolean Returns<T>(MemberInfo member)` | _No documentation available._ |
| `boolean Returns(MemberInfo member, Type type)` | Gets if `member` returns `type`. |
| `boolean ReturnsCoroutine(MemberInfo member)` | Gets if `member` returns `IEnumerator`. |
| `boolean ReturnsVoid(MemberInfo member)` | Gets if `member` returns `Void`. |
| `Type ReturnType(MemberInfo member)` | Gets the return or value type of the specified `MemberInfo`. |
| `string Serialize(Type type)` | _No documentation available._ |

---
# UIFadeExtensions
<!--
source: API\3.2.0\Utility\UIFadeExtensions.md
-->

## UIFadeExtensions

`static class` in `AdvancedSceneManager.Utility`### Description
Provides extension methods for `CanvasGroup`.

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerator Fade(CanvasGroup group, single to, single duration, boolean setBlocksRaycasts)` | Animates the alpha of a `CanvasGroup`. |
| `IEnumerator Fade(Graphic text, single to, single duration, boolean ignoreTimeScale)` | Animates the alpha of a `Graphic`. |
| `IEnumerator Fade(RectTransform element, single to, single duration, boolean ignoreTimeScale)` | Animates the alpha of all `Graphic` found on `element` and children. |
| `IEnumerator Fade(UIBehaviour element, single to, single duration, boolean ignoreTimeScale)` | Animates the alpha of all `Graphic` found on `element` and children. |

---
# UIUtility
<!--
source: API\3.2.0\Utility\UIUtility.md
-->

## UIUtility

`static class` in `AdvancedSceneManager.Utility`### Description
Provides utility methods for working with `VisualElement`.

### Static Methods

| Member | Description |
|--------|-------------|
| `Awaitable AsTask(IVisualElementScheduledItem scheduledItem)` | _No documentation available._ |
| `IVisualElementScheduledItem Fade(VisualElement view, single to, single duration, Action onComplete, Nullable<CancellationToken> cancellationToken)` | Fades the element. |
| `VisualElementScheduledItemAwaiter GetAwaiter(IVisualElementScheduledItem scheduledItem)` | _No documentation available._ |
| `void Hide(VisualElement element, boolean fade)` | Hides the element using `None`. |
| `boolean IsVisible(VisualElement element)` | Gets `DisplayStyle` is `Flex`. |
| `void SetVisible(VisualElement element, boolean visible)` | Sets `DisplayStyle` based on `visible`. |
| `void Show(VisualElement element, boolean fade)` | Shows the element using `Flex`. |

---
# UnityCompatibiltyHelper
<!--
source: API\3.2.0\Utility\UnityCompatibiltyHelper.md
-->

## UnityCompatibiltyHelper

`static class` in `AdvancedSceneManager.Utility`### Description
Contains helpers for dealing with multiple versions of unity.

---
# VisualElementScheduledItemAwaiter
<!--
source: API\3.2.0\Utility\VisualElementScheduledItemAwaiter.md
-->

## VisualElementScheduledItemAwaiter

`class` in `AdvancedSceneManager.Utility`### Description

### Properties

| Member | Description |
|--------|-------------|
| `boolean IsCompleted` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void GetResult()` | _No documentation available._ |
| `void OnCompleted(Action continuation)` | _No documentation available._ |

---
# XmlEscapeUtility
<!--
source: API\3.2.0\Utility\XmlEscapeUtility.md
-->

## XmlEscapeUtility

`static class` in `AdvancedSceneManager.Utility`### Description
Provides methods for escaping and unescaping XML strings.

### Static Methods

| Member | Description |
|--------|-------------|
| `string Escape(string value)` | Escapes special XML characters in the given string. |
| `string Escape(Type type)` | _No documentation available._ |
| `string Unescape(string value)` | Unescapes XML entities in the given string. |
| `boolean Unescape(string value, Type& type)` | _No documentation available._ |

---
# ActionUtility
<!--
source: API\Callbacks\ActionUtility.md
-->

## ActionUtility

`static class` in `AdvancedSceneManager.Callbacks`### Description
Contains utility functions for `Action`.

### Static Methods

| Member | Description |
|--------|-------------|
| `void LogInvoke(Action action)` | Tries to invoke the action, then logs error to the console if an error occurred. |
| `void TryInvoke(Action action)` | Tries to invoke the action, eats the exception. |
| `boolean TryInvoke(Action action, Exception& exception)` | _No documentation available._ |

---
# CallbackUtility
<!--
source: API\Callbacks\CallbackUtility.md
-->

## CallbackUtility

`static class` in `AdvancedSceneManager.Callbacks`### Description
Provides utilities for discovering and invoking scene and collection callbacks.
            Handles interfaces derived from `ISceneCallbacks` and their coroutine/awaitable counterparts.

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerator DoCollectionCloseCallbacks(SceneCollection collection)` | Invokes all collection close callbacks on the specified `collection`. |
| `IEnumerator DoCollectionOpenCallbacks(SceneCollection collection)` | Invokes all collection open callbacks on the specified `collection`. |
| `IEnumerator DoSceneCloseCallbacks(Scene scene)` | Invokes all scene close callbacks on the specified `scene`. |
| `IEnumerator DoSceneOpenCallbacks(Scene scene)` | Invokes all scene open callbacks on the specified `scene`. |
| `FluentInvokeAPI<T> Invoke<T>()` | _No documentation available._ |

---
# Callback_Of_T
<!--
source: API\Callbacks\Callback_Of_T.md
-->

## Callback

`sealed class` in `AdvancedSceneManager.Callbacks`  /  Inherits from: `MulticastDelegate`### Description

### Methods

| Member | Description |
|--------|-------------|
| `virtual IAsyncResult BeginInvoke(T obj, boolean isEnabled, AsyncCallback callback, object object)` | _No documentation available._ |
| `virtual IEnumerator EndInvoke(IAsyncResult result)` | _No documentation available._ |
| `virtual IEnumerator Invoke(T obj, boolean isEnabled)` | _No documentation available._ |

---
# AllScenesClosedEvent
<!--
source: API\Callbacks\Events\AllScenesClosedEvent.md
-->

## AllScenesClosedEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `EventCallbackBase`### Description
Occurs when all user scenes have been closed and only ASM fallback scene remains open.

<b> Remarks:</b>
Use this to gracefully handle the situation — for example, by returning to the main menu or similar.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(AllScenesClosedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# CalledForAttribute
<!--
source: API\Callbacks\Events\CalledForAttribute.md
-->

## CalledForAttribute

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `Attribute`### Description

### Properties

| Member | Description |
|--------|-------------|
| `When[] when` | _No documentation available._ |

---
# CollectionCloseEvent
<!--
source: API\Callbacks\Events\CollectionCloseEvent.md
-->

## CollectionCloseEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `CollectionEvent`### Description
Occurs when a collection is closed.

<b> Remarks:</b>
Called when: `Unspecified` (it will be ignored).

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(SceneCollection& collection)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(CollectionEvent other)` | _No documentation available._ |
| `virtual boolean Equals(CollectionCloseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# CollectionEvent
<!--
source: API\Callbacks\Events\CollectionEvent.md
-->

## CollectionEvent

`abstract class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `SceneOperationEventBase`### Description
The base class for collection event callbacks.

<b> Remarks:</b>
See `CollectionOpenEvent`, `CollectionCloseEvent`.

### Properties

| Member | Description |
|--------|-------------|
| `SceneCollection collection` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(SceneCollection& collection)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(SceneOperationEventBase other)` | _No documentation available._ |
| `virtual boolean Equals(CollectionEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# CollectionOpenEvent
<!--
source: API\Callbacks\Events\CollectionOpenEvent.md
-->

## CollectionOpenEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `CollectionEvent`### Description
Occurs when a collection is opened.

<b> Remarks:</b>
Called when: `Unspecified` (it will be ignored).

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(SceneCollection& collection)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(CollectionEvent other)` | _No documentation available._ |
| `virtual boolean Equals(CollectionOpenEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ASMModelRenamedEvent
<!--
source: API\Callbacks\Events\Editor\ASMModelRenamedEvent.md
-->

## ASMModelRenamedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when an ASM model is renamed.

### Properties

| Member | Description |
|--------|-------------|
| `ASMModelBase model` | The model that was renamed. |
| `string newName` | The new name of the model. |
| `string oldName` | The previous name of the model. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(ASMModelBase& model, String& oldName, String& newName)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(ASMModelRenamedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ASMSettingsChangedEvent
<!--
source: API\Callbacks\Events\Editor\ASMSettingsChangedEvent.md
-->

## ASMSettingsChangedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when a setting in ASM changes.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(ASMSettingsChangedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ASMWindowCloseEvent
<!--
source: API\Callbacks\Events\Editor\ASMWindowCloseEvent.md
-->

## ASMWindowCloseEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when the ASM editor window is closed.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(ASMWindowCloseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ASMWindowOpenEvent
<!--
source: API\Callbacks\Events\Editor\ASMWindowOpenEvent.md
-->

## ASMWindowOpenEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when the ASM editor window is opened.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(ASMWindowOpenEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# BeforeASMPlayModeEvent
<!--
source: API\Callbacks\Events\Editor\BeforeASMPlayModeEvent.md
-->

## BeforeASMPlayModeEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs before ASM enters play mode when ASM play button is used.

### Properties

| Member | Description |
|--------|-------------|
| `StartupProps props` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(StartupProps& props)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(BeforeASMPlayModeEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# CollectionAddedEvent
<!--
source: API\Callbacks\Events\Editor\CollectionAddedEvent.md
-->

## CollectionAddedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when a collection is added to a profile.

### Properties

| Member | Description |
|--------|-------------|
| `ISceneCollection collection` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(ISceneCollection& collection)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(CollectionAddedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# CollectionDeletedEvent
<!--
source: API\Callbacks\Events\Editor\CollectionDeletedEvent.md
-->

## CollectionDeletedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when a collection is deleted from a profile.

<b> Remarks:</b>
Hard delete, not recoverable. Happens after undo period.

### Properties

| Member | Description |
|--------|-------------|
| `ISceneCollection collection` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(ISceneCollection& collection)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(CollectionDeletedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# CollectionRemovedEvent
<!--
source: API\Callbacks\Events\Editor\CollectionRemovedEvent.md
-->

## CollectionRemovedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when a collection is removed from a profile.

<b> Remarks:</b>
Soft delete, still recoverable. Triggers undo period.

### Properties

| Member | Description |
|--------|-------------|
| `ISceneCollection collection` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(ISceneCollection& collection)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(CollectionRemovedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# CollectionRestoredEvent
<!--
source: API\Callbacks\Events\Editor\CollectionRestoredEvent.md
-->

## CollectionRestoredEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when a collection is restored after remove, before hard delete.

### Properties

| Member | Description |
|--------|-------------|
| `ISceneCollection collection` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(ISceneCollection& collection)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(CollectionRestoredEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ModelPropertyChangedEvent
<!--
source: API\Callbacks\Events\Editor\ModelPropertyChangedEvent.md
-->

## ModelPropertyChangedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when an ASM model property changes. This is the same as `INotifyPropertyChanged`.

<b> Remarks:</b>
`Empty` will be used when `INotifyPropertyChanged` is called from `onvalidate`.

### Properties

| Member | Description |
|--------|-------------|
| `ASMModelBase model` | The model had a property changed. |
| `string propertyName` | The name of the property that changed. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(ASMModelBase& model, String& propertyName)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(ModelPropertyChangedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# OnWindowDisableEvent
<!--
source: API\Callbacks\Events\Editor\OnWindowDisableEvent.md
-->

## OnWindowDisableEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when the ASM editor window is disabled.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(OnWindowDisableEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# OnWindowEnableEvent
<!--
source: API\Callbacks\Events\Editor\OnWindowEnableEvent.md
-->

## OnWindowEnableEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when the ASM editor window is enabled.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(OnWindowEnableEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# OnWindowFocusEvent
<!--
source: API\Callbacks\Events\Editor\OnWindowFocusEvent.md
-->

## OnWindowFocusEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when the ASM editor window gains focus.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(OnWindowFocusEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# OnWindowLostFocusEvent
<!--
source: API\Callbacks\Events\Editor\OnWindowLostFocusEvent.md
-->

## OnWindowLostFocusEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when the ASM editor window loses focus.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(OnWindowLostFocusEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# PlayModeChangedEvent
<!--
source: API\Callbacks\Events\Editor\PlayModeChangedEvent.md
-->

## PlayModeChangedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when the unity play mode state changes.

<b> Remarks:</b>
Wrapper for `playModeStateChanged`.

### Properties

| Member | Description |
|--------|-------------|
| `PlayModeStateChange state` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(PlayModeStateChange& state)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(PlayModeChangedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ProfileAddedEvent
<!--
source: API\Callbacks\Events\Editor\ProfileAddedEvent.md
-->

## ProfileAddedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when a profile is added to ASM.

<b> Remarks:</b>
Does not support [IEnumerator)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.callbacks.events.eventcallbackbase.waitfor(system.collections.ienumerator)) or any of its overloads.

### Properties

| Member | Description |
|--------|-------------|
| `Profile profile` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(Profile& profile)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(ProfileAddedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ProfileChangedEvent
<!--
source: API\Callbacks\Events\Editor\ProfileChangedEvent.md
-->

## ProfileChangedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when the active profile is changed.

### Properties

| Member | Description |
|--------|-------------|
| `Profile profile` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(Profile& profile)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(ProfileChangedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ProfileRemovedEvent
<!--
source: API\Callbacks\Events\Editor\ProfileRemovedEvent.md
-->

## ProfileRemovedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when a profile is removed from ASM.

<b> Remarks:</b>
Does not support [IEnumerator)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.callbacks.events.eventcallbackbase.waitfor(system.collections.ienumerator)) or any of its overloads.

### Properties

| Member | Description |
|--------|-------------|
| `Profile profile` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(Profile& profile)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(ProfileRemovedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# SceneImportedEvent
<!--
source: API\Callbacks\Events\Editor\SceneImportedEvent.md
-->

## SceneImportedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when a scene is imported into ASM.

### Properties

| Member | Description |
|--------|-------------|
| `Scene scene` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(Scene& scene)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(SceneImportedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# SceneLoaderToggledEvent
<!--
source: API\Callbacks\Events\Editor\SceneLoaderToggledEvent.md
-->

## SceneLoaderToggledEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when the scene loader for a given scene is changed.

### Properties

| Member | Description |
|--------|-------------|
| `Type newSceneLoader` | _No documentation available._ |
| `Type oldSceneLoader` | _No documentation available._ |
| `Scene scene` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(Scene& scene, Type& oldSceneLoader, Type& newSceneLoader)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(SceneLoaderToggledEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ScenesAvailableForImportChangedEvent
<!--
source: API\Callbacks\Events\Editor\ScenesAvailableForImportChangedEvent.md
-->

## ScenesAvailableForImportChangedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when either `unimportedScenes`, `importedScenes`, or `invalidScenes` has changed.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(ScenesAvailableForImportChangedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# SceneUnimportedEvent
<!--
source: API\Callbacks\Events\Editor\SceneUnimportedEvent.md
-->

## SceneUnimportedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs when a scene is unimported from ASM.

### Properties

| Member | Description |
|--------|-------------|
| `Scene scene` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(Scene& scene)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(SceneUnimportedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# UpdateCheckedEvent
<!--
source: API\Callbacks\Events\Editor\UpdateCheckedEvent.md
-->

## UpdateCheckedEvent

`class` in `AdvancedSceneManager.Callbacks.Events.Editor`  /  Inherits from: `EventCallbackBase`### Description
Occurs after ASM has checked for updates.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(UpdateCheckedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# EndPhaseEvent
<!--
source: API\Callbacks\Events\EndPhaseEvent.md
-->

## EndPhaseEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `SceneOperationEventBase`### Description
Occurs before operation has stopped working, but after its practically done.

<b> Remarks:</b>
Called when: `Unspecified` (it will be ignored).

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(SceneOperationEventBase other)` | _No documentation available._ |
| `virtual boolean Equals(EndPhaseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# EventCallbackBase
<!--
source: API\Callbacks\Events\EventCallbackBase.md
-->

## EventCallbackBase

`abstract class` in `AdvancedSceneManager.Callbacks.Events`### Description
The base class for all event callbacks.

### Properties

| Member | Description |
|--------|-------------|
| `List<Func<IEnumerator>> waitFor { get; }` | A list of coroutines that `SceneOperation` should wait for. It will not proceed until all coroutines are done. |
| `When when` | Specifies when this event callback was invoked, before or after the action it represents. If applicable. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `virtual boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |
| `void WaitFor(IEnumerator coroutine)` | Specifies a coroutine that the operation should wait for. |
| `void WaitFor(Func<IEnumerator> coroutine)` | Specifies a coroutine that the operation should wait for. |
| `void WaitFor(GlobalCoroutine coroutine)` | Specifies a coroutine that the operation should wait for. |
| `void WaitFor(Func<GlobalCoroutine> coroutine)` | Specifies a coroutine that the operation should wait for. |
| `void WaitFor(Awaitable awaitable)` | Specifies a coroutine that the operation should wait for. |
| `void WaitFor(Func<Awaitable> awaitable)` | Specifies a coroutine that the operation should wait for. |

---
# EventCallbackManager_Of_TEventBase
<!--
source: API\Callbacks\Events\EventCallbackManager_Of_TEventBase.md
-->

## EventCallbackManager`1

`class` in `AdvancedSceneManager.Callbacks.Events`### Description
Manages event callbacks.

<b> Remarks:</b>
You probably want to use either `events` or `events`.

### Methods

| Member | Description |
|--------|-------------|
| `IEnumerator InvokeCallback<TEventType>(When when, string callerFile, int32 callerLine)` | _No documentation available._ |
| `IEnumerator InvokeCallback<TEventType>(TEventType e, When when, string callerFile, int32 callerLine)` | _No documentation available._ |
| `void InvokeCallbackSync<TEventType>(When when)` | _No documentation available._ |
| `void InvokeCallbackSync<TEventType>(TEventType e, When when)` | _No documentation available._ |
| `void RegisterCallback<TEventType>(EventCallback<TEventType> callback, When when, string key)` | _No documentation available._ |
| `void UnregisterCallback(string key)` | Unregisters a previously registered event callback. |
| `void UnregisterCallback<TEventType>(EventCallback<TEventType> callback, When when, string key)` | _No documentation available._ |

---
# EventCallbackUtility
<!--
source: API\Callbacks\Events\EventCallbackUtility.md
-->

## EventCallbackUtility

`static class` in `AdvancedSceneManager.Callbacks.Events`### Description
Provides utility functions for working with event callbacks.

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerable<Type> GetCallbackTypes()` | Enumerates all callback types. |
| `int32 GetInvocationOrder<TEventType>()` | _No documentation available._ |
| `int32 GetInvocationOrder(Type type)` | Gets the invocation order of the event callback type. |
| `boolean IsWhenApplicable<TEventType>()` | _No documentation available._ |
| `boolean IsWhenApplicable(Type type)` | Gets if the specified callback event uses `When` enum. |
| `SceneOperation RegisterAllCallbacks(string key, SceneOperation operation, EventCallback<EventCallbackBase> callback, When when)` | Registers callback for all events. |
| `void RegisterAllCallbacksGlobal(string key, EventCallback<EventCallbackBase> callback, When when)` | Registers callback for all events. |
| `SceneOperation UnregisterCallback(string key, SceneOperation operation)` | Unregisters callback using `key`. |
| `void UnregisterCallbackGlobal(string key)` | Unregisters callback using `key`. |

---
# EventCallback_Of_TEventType
<!--
source: API\Callbacks\Events\EventCallback_Of_TEventType.md
-->

## EventCallback`1

`sealed class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `MulticastDelegate`### Description
Callback for scene operations.

### Methods

| Member | Description |
|--------|-------------|
| `virtual IAsyncResult BeginInvoke(TEventType evt, AsyncCallback callback, object object)` | _No documentation available._ |
| `virtual void EndInvoke(IAsyncResult result)` | _No documentation available._ |
| `virtual void Invoke(TEventType evt)` | _No documentation available._ |

---
# FilteredEventProxy_Of_TEventBase
<!--
source: API\Callbacks\Events\FilteredEventProxy_Of_TEventBase.md
-->

## FilteredEventProxy`1

`sealed class` in `AdvancedSceneManager.Callbacks.Events`### Description
Manages event callbacks, filtered for `TEventBase`.

<b> Remarks:</b>
You probably want to use either [String)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.models.scene.registercallback``1(advancedscenemanager.callbacks.events.eventcallback{``0},advancedscenemanager.callbacks.events.when,system.string)) or [String)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.models.scenecollection.registercallback``1(advancedscenemanager.callbacks.events.eventcallback{``0},advancedscenemanager.callbacks.events.when,system.string)).

### Methods

| Member | Description |
|--------|-------------|
| `void RegisterCallback<T>(EventCallback<T> callback, When when, string key)` | _No documentation available._ |
| `void UnregisterCallback<T>(EventCallback<T> callback, When when, string key)` | _No documentation available._ |

---
# GlobalCoroutinesChanged
<!--
source: API\Callbacks\Events\GlobalCoroutinesChanged.md
-->

## GlobalCoroutinesChanged

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `EventCallbackBase`### Description
Occurs when `CoroutineUtility` starts or ends a coroutine.

### Properties

| Member | Description |
|--------|-------------|
| `IEnumerable<GlobalCoroutine> coroutines` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(IEnumerable`1& coroutines)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(GlobalCoroutinesChanged other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# InvocationOrderAttribute
<!--
source: API\Callbacks\Events\InvocationOrderAttribute.md
-->

## InvocationOrderAttribute

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `Attribute`### Description

### Properties

| Member | Description |
|--------|-------------|
| `int32 order` | _No documentation available._ |

---
# LoadingScreenClosePhaseEvent
<!--
source: API\Callbacks\Events\LoadingScreenClosePhaseEvent.md
-->

## LoadingScreenClosePhaseEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `LoadingScreenPhaseEvent`### Description
Occurs when a loading screen is closed.

<b> Remarks:</b>
Called regardless if operation actually opens one or not.
            
            Called when: `Before`, `After`.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(LoadingScreenReference& loadingScreen)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(LoadingScreenPhaseEvent other)` | _No documentation available._ |
| `virtual boolean Equals(LoadingScreenClosePhaseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# LoadingScreenOpenPhaseEvent
<!--
source: API\Callbacks\Events\LoadingScreenOpenPhaseEvent.md
-->

## LoadingScreenOpenPhaseEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `LoadingScreenPhaseEvent`### Description
Occurs when a loading screen is opened.

<b> Remarks:</b>
Called regardless if operation actually opens one or not.
            
            Called when: `Before`, `After`.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(LoadingScreenReference& loadingScreen)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(LoadingScreenPhaseEvent other)` | _No documentation available._ |
| `virtual boolean Equals(LoadingScreenOpenPhaseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# LoadingScreenPhaseEvent
<!--
source: API\Callbacks\Events\LoadingScreenPhaseEvent.md
-->

## LoadingScreenPhaseEvent

`abstract class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `SceneOperationEventBase`### Description
The base class for loading screen phase event callbacks.

<b> Remarks:</b>
See `LoadingScreenOpenPhaseEvent`, `LoadingScreenClosePhaseEvent`.

### Properties

| Member | Description |
|--------|-------------|
| `LoadingScreenReference loadingScreen` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(LoadingScreenReference& loadingScreen)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(SceneOperationEventBase other)` | _No documentation available._ |
| `virtual boolean Equals(LoadingScreenPhaseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# QuitEvent
<!--
source: API\Callbacks\Events\QuitEvent.md
-->

## QuitEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `EventCallbackBase`### Description
Occurs when the application is quitting through `SceneManager.app.Quit()`.

This event will not be raised if the default Unity quit flow is used.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(QuitEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# SceneCloseEvent
<!--
source: API\Callbacks\Events\SceneCloseEvent.md
-->

## SceneCloseEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `SceneEvent`### Description
Occurs when a scene is closed.

<b> Remarks:</b>
Called when: `Before`, `After`.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(Scene& scene)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(SceneEvent other)` | _No documentation available._ |
| `virtual boolean Equals(SceneCloseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# SceneClosePhaseEvent
<!--
source: API\Callbacks\Events\SceneClosePhaseEvent.md
-->

## SceneClosePhaseEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `ScenePhaseEvent`### Description
Occurs when operation starts and finishes closing scenes.

<b> Remarks:</b>
Called when: `Before`, `After`.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(IEnumerable`1& scenes)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(ScenePhaseEvent other)` | _No documentation available._ |
| `virtual boolean Equals(SceneClosePhaseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# SceneEvent
<!--
source: API\Callbacks\Events\SceneEvent.md
-->

## SceneEvent

`abstract class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `SceneOperationEventBase`### Description
The base class for scene event callbacks.

<b> Remarks:</b>
See `SceneOpenEvent`, `SceneCloseEvent`, `ScenePreloadEvent`.

### Properties

| Member | Description |
|--------|-------------|
| `Scene scene` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(Scene& scene)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(SceneOperationEventBase other)` | _No documentation available._ |
| `virtual boolean Equals(SceneEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# SceneManagerBecameBusyEvent
<!--
source: API\Callbacks\Events\SceneManagerBecameBusyEvent.md
-->

## SceneManagerBecameBusyEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `EventCallbackBase`### Description
Occurs when ASM becomes busy, as in: a scene operation is queued, or started without queue, assuming it was idle beforehand.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(SceneManagerBecameBusyEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# SceneManagerBecameIdleEvent
<!--
source: API\Callbacks\Events\SceneManagerBecameIdleEvent.md
-->

## SceneManagerBecameIdleEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `EventCallbackBase`### Description
Occurs when ASM becomes idle, as in: scene operation queue is empty and no non-queued operations are running.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(SceneManagerBecameIdleEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# SceneOpenEvent
<!--
source: API\Callbacks\Events\SceneOpenEvent.md
-->

## SceneOpenEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `SceneEvent`### Description
Occurs when a scene is opened.

<b> Remarks:</b>
Called when: `Before`, `After`.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(Scene& scene)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(SceneEvent other)` | _No documentation available._ |
| `virtual boolean Equals(SceneOpenEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# SceneOpenPhaseEvent
<!--
source: API\Callbacks\Events\SceneOpenPhaseEvent.md
-->

## SceneOpenPhaseEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `ScenePhaseEvent`### Description
Occurs when operation starts and finishes opening scenes.

<b> Remarks:</b>
Called when: `Before`, `After`.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(IEnumerable`1& scenes)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(ScenePhaseEvent other)` | _No documentation available._ |
| `virtual boolean Equals(SceneOpenPhaseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# SceneOperationEventBase
<!--
source: API\Callbacks\Events\SceneOperationEventBase.md
-->

## SceneOperationEventBase

`abstract class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `EventCallbackBase`### Description
The base class for all scene operation event callbacks.

### Properties

| Member | Description |
|--------|-------------|
| `SceneOperation operation` | The operation that invoked this event callback. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(SceneOperationEventBase other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ScenePhaseEvent
<!--
source: API\Callbacks\Events\ScenePhaseEvent.md
-->

## ScenePhaseEvent

`abstract class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `SceneOperationEventBase`### Description
The base class for scene phase event callbacks.

<b> Remarks:</b>
See `SceneClosePhaseEvent`, `SceneOpenPhaseEvent`, `ScenePreloadPhaseEvent`.

### Properties

| Member | Description |
|--------|-------------|
| `IEnumerable<Scene> scenes` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(IEnumerable`1& scenes)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(SceneOperationEventBase other)` | _No documentation available._ |
| `virtual boolean Equals(ScenePhaseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ScenePreloadEvent
<!--
source: API\Callbacks\Events\ScenePreloadEvent.md
-->

## ScenePreloadEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `SceneEvent`### Description
Occurs when a scene is preloaded.

<b> Remarks:</b>
Called when: `Before`, `After`.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(Scene& scene)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(SceneEvent other)` | _No documentation available._ |
| `virtual boolean Equals(ScenePreloadEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ScenePreloadPhaseEvent
<!--
source: API\Callbacks\Events\ScenePreloadPhaseEvent.md
-->

## ScenePreloadPhaseEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `ScenePhaseEvent`### Description
Occurs when operation starts and finishes preloading scenes.

<b> Remarks:</b>
Called when: `Before`, `After`.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(IEnumerable`1& scenes)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(ScenePhaseEvent other)` | _No documentation available._ |
| `virtual boolean Equals(ScenePreloadPhaseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# StartPhaseEvent
<!--
source: API\Callbacks\Events\StartPhaseEvent.md
-->

## StartPhaseEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `SceneOperationEventBase`### Description
Occurs before operation has begun working, but after it has started.

<b> Remarks:</b>
Properties has not been frozen at this point, and can be changed.
            
            Called when: `Unspecified` (it will be ignored).

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(SceneOperationEventBase other)` | _No documentation available._ |
| `virtual boolean Equals(StartPhaseEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# StartupCancelledEvent
<!--
source: API\Callbacks\Events\StartupCancelledEvent.md
-->

## StartupCancelledEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `EventCallbackBase`### Description
Occurs when ASM startup is cancelled before completion.

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(StartupCancelledEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# StartupFinishedEvent
<!--
source: API\Callbacks\Events\StartupFinishedEvent.md
-->

## StartupFinishedEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `EventCallbackBase`### Description
Occurs when ASM startup has completed successfully.

### Properties

| Member | Description |
|--------|-------------|
| `StartupProps props` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(StartupProps& props)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(StartupFinishedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# StartupStartedEvent
<!--
source: API\Callbacks\Events\StartupStartedEvent.md
-->

## StartupStartedEvent

`class` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `EventCallbackBase`### Description
Occurs when ASM startup begins, opening any collections or scenes flagged to load during startup.

### Properties

| Member | Description |
|--------|-------------|
| `StartupProps props` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual EventCallbackBase <Clone>$()` | _No documentation available._ |
| `void Deconstruct(StartupProps& props)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(EventCallbackBase other)` | _No documentation available._ |
| `virtual boolean Equals(StartupStartedEvent other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# ASMCallbackEventPropertyDrawerFilterAttribute
<!--
source: API\Callbacks\Events\Utility\ASMCallbackEventPropertyDrawerFilterAttribute.md
-->

## ASMCallbackEventPropertyDrawerFilterAttribute

`class` in `AdvancedSceneManager.Callbacks.Events.Utility`  /  Inherits from: `Attribute`### Description
Applies a filter to the types displayed in `ASMEventCallbackPropertyDrawer`, used for `SerializableASMEventCallbackType` fields.

### Properties

| Member | Description |
|--------|-------------|
| `Type[] HiddenTypes` | Specifies the types to hide in the list. |

---
# SerializableASMEventCallbackType
<!--
source: API\Callbacks\Events\Utility\SerializableASMEventCallbackType.md
-->

## SerializableASMEventCallbackType

`class` in `AdvancedSceneManager.Callbacks.Events.Utility`### Description
Represents a serializable event callback type.

<b> Remarks:</b>
Provides [SceneOperationEventBase})](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.callbacks.events.utility.serializableasmeventcallbacktype.registercallback(system.string,advancedscenemanager.core.sceneoperation,advancedscenemanager.callbacks.events.eventcallback{advancedscenemanager.callbacks.events.sceneoperationeventbase})) for easily registering the callback.
            
Also provides a property drawer.

### Fields

| Member | Description |
|--------|-------------|
| `string typeName` | The `AssemblyQualifiedName`. |
| `When when` | Represents when this event is to be called. |

### Methods

| Member | Description |
|--------|-------------|
| `boolean IsValid()` | Gets if this event callback type is valid. |
| `void RegisterCallback(string key, SceneOperation operation, EventCallback<SceneOperationEventBase> callback)` | Register callback on `operation`. |
| `void RegisterGlobalCallback(string key, EventCallback<EventCallbackBase> callback)` | Register callback globally. |
| `virtual string ToString()` | _No documentation available._ |
| `SceneOperation UnregisterCallback(string key, SceneOperation operation)` | Unregisters the callback on `operation`. |
| `void UnregisterGlobalCallback(string key)` | Unregisters the callback globally. |

---
# When
<!--
source: API\Callbacks\Events\When.md
-->

## When

`enum` in `AdvancedSceneManager.Callbacks.Events`  /  Inherits from: `Enum`### Description
Specifies when the event callback is invoked for the action it represents.

### Static Fields

| Member | Description |
|--------|-------------|
| `When After` | Specifies that the event callback was invoked after the action it represents. |
| `When Before` | Specifies that the event callback should be invoked before the action it represents. |
| `When Unspecified` | Specifies that the event callback runs both `Before` and `After`, if applicable. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# FluentInvokeAPI_Of_T
<!--
source: API\Callbacks\FluentInvokeAPI_Of_T.md
-->

## FluentInvokeAPI`1

`sealed class` in `AdvancedSceneManager.Callbacks`### Description

### Properties

| Member | Description |
|--------|-------------|
| `boolean hasDefaultCallback` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `IEnumerator On(SceneCollection collection, Scene[] additionalScenes)` | _No documentation available._ |
| `IEnumerator On(Scene[] scenes)` | _No documentation available._ |
| `IEnumerator On(ScriptableObject[] scriptableObjects)` | _No documentation available._ |
| `IEnumerator OnAllOpenScenes()` | _No documentation available._ |
| `FluentInvokeAPI<T> WithCallback(Callback<T> callback)` | _No documentation available._ |
| `FluentInvokeAPI<T> WithParam(object param)` | _No documentation available._ |

---
# ICollectionClose
<!--
source: API\Callbacks\ICollectionClose.md
-->

## ICollectionClose

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is closed.

Called after loading screen has opened, if one is defined, or else just before collection is closed.

            See also:
            
- `ICollectionClose`
- `ICollectionCloseCoroutine`
- `ICollectionCloseAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void OnCollectionClose(SceneCollection collection)` | Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is closed.

Called after loading screen has opened, if one is defined, or else just before collection is closed.

            See also:
            
- `ICollectionClose`
- `ICollectionCloseCoroutine`
- `ICollectionCloseAwaitable` |

---
# ICollectionCloseAwaitable
<!--
source: API\Callbacks\ICollectionCloseAwaitable.md
-->

## ICollectionCloseAwaitable

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is closed.

Called after loading screen has opened, if one is defined, or else just before collection is closed.

            See also:
            
- `ICollectionClose`
- `ICollectionCloseCoroutine`
- `ICollectionCloseAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual Awaitable OnCollectionClose(SceneCollection collection)` | Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is closed.

Called after loading screen has opened, if one is defined, or else just before collection is closed.

            See also:
            
- `ICollectionClose`
- `ICollectionCloseCoroutine`
- `ICollectionCloseAwaitable` |

---
# ICollectionCloseCoroutine
<!--
source: API\Callbacks\ICollectionCloseCoroutine.md
-->

## ICollectionCloseCoroutine

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is closed.

Called after loading screen has opened, if one is defined, or else just before collection is closed.

            See also:
            
- `ICollectionClose`
- `ICollectionCloseCoroutine`
- `ICollectionCloseAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual IEnumerator OnCollectionClose(SceneCollection collection)` | Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is closed.

Called after loading screen has opened, if one is defined, or else just before collection is closed.

            See also:
            
- `ICollectionClose`
- `ICollectionCloseCoroutine`
- `ICollectionCloseAwaitable` |

---
# ICollectionExtraDataCallbacks
<!--
source: API\Callbacks\ICollectionExtraDataCallbacks.md
-->

## ICollectionExtraDataCallbacks

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callbacks for a `ScriptableObject` that has been set as extra data for a collection.
            
            See also:
            
- `ICollectionExtraDataCallbacks`
- `ICollectionExtraDataCallbacksCoroutine`
- `ICollectionExtraDataCallbacksAwaitable`

---
# ICollectionExtraDataCallbacksAwaitable
<!--
source: API\Callbacks\ICollectionExtraDataCallbacksAwaitable.md
-->

## ICollectionExtraDataCallbacksAwaitable

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callbacks for a `ScriptableObject` that has been set as extra data for a collection.
            
            See also:
            
- `ICollectionExtraDataCallbacks`
- `ICollectionExtraDataCallbacksCoroutine`
- `ICollectionExtraDataCallbacksAwaitable`

---
# ICollectionExtraDataCallbacksCoroutine
<!--
source: API\Callbacks\ICollectionExtraDataCallbacksCoroutine.md
-->

## ICollectionExtraDataCallbacksCoroutine

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callbacks for a `ScriptableObject` that has been set as extra data for a collection.
            
            See also:
            
- `ICollectionExtraDataCallbacks`
- `ICollectionExtraDataCallbacksCoroutine`
- `ICollectionExtraDataCallbacksAwaitable`

---
# ICollectionOpen
<!--
source: API\Callbacks\ICollectionOpen.md
-->

## ICollectionOpen

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is opened.

Called before loading screen is hidden, if one is defined, or else just when collection has opened.

            See also:
            
- `ICollectionOpen`
- `ICollectionOpen`
- `ICollectionOpenAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void OnCollectionOpen(SceneCollection collection)` | Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is opened.

Called before loading screen is hidden, if one is defined, or else just when collection has opened.

            See also:
            
- `ICollectionOpen`
- `ICollectionOpen`
- `ICollectionOpenAwaitable` |

---
# ICollectionOpenAwaitable
<!--
source: API\Callbacks\ICollectionOpenAwaitable.md
-->

## ICollectionOpenAwaitable

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is opened.

Called before loading screen is hidden, if one is defined, or else just when collection has opened.

            See also:
            
- `ICollectionOpen`
- `ICollectionOpen`
- `ICollectionOpenAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual Awaitable OnCollectionOpen(SceneCollection collection)` | Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is opened.

Called before loading screen is hidden, if one is defined, or else just when collection has opened.

            See also:
            
- `ICollectionOpen`
- `ICollectionOpen`
- `ICollectionOpenAwaitable` |

---
# ICollectionOpenCoroutine
<!--
source: API\Callbacks\ICollectionOpenCoroutine.md
-->

## ICollectionOpenCoroutine

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is opened.

Called before loading screen is hidden, if one is defined, or else just when collection has opened.

            See also:
            
- `ICollectionOpen`
- `ICollectionOpen`
- `ICollectionOpenAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual IEnumerator OnCollectionOpen(SceneCollection collection)` | Callback for when a scene, in a collection, that a `MonoBehaviour` is contained within is opened.

Called before loading screen is hidden, if one is defined, or else just when collection has opened.

            See also:
            
- `ICollectionOpen`
- `ICollectionOpen`
- `ICollectionOpenAwaitable` |

---
# ISceneCallbacks
<!--
source: API\Callbacks\ISceneCallbacks.md
-->

## ISceneCallbacks

`interface` in `AdvancedSceneManager.Callbacks`### Description
Base interface for `MonoBehaviour` callbacks. Just implement any of the following to have ASM call them during scene operations.
            
- `ISceneOpen`, `ISceneClose`, `ICollectionOpen`, `ICollectionClose`
- `ISceneOpenCoroutine`, `ISceneCloseCoroutine`, `ICollectionOpen`, `ICollectionCloseCoroutine`
- `ISceneOpenAwaitable`, `ISceneCloseAwaitable`, `ICollectionOpenAwaitable`, `ICollectionCloseAwaitable`
- `ICollectionExtraDataCallbacks`, `ICollectionExtraDataCallbacksCoroutine`, `ICollectionExtraDataCallbacksAwaitable`

---
# ISceneClose
<!--
source: API\Callbacks\ISceneClose.md
-->

## ISceneClose

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when the scene that a `MonoBehaviour` is contained within is closed.

<b> Remarks:</b>
See also:
            
- `ISceneClose`
- `ISceneCloseCoroutine`
- `ISceneCloseAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void OnSceneClose()` | Callback for when the scene that a `MonoBehaviour` is contained within is closed. |

---
# ISceneCloseAwaitable
<!--
source: API\Callbacks\ISceneCloseAwaitable.md
-->

## ISceneCloseAwaitable

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when the scene that a `MonoBehaviour` is contained within is closed.

<b> Remarks:</b>
See also:
            
- `ISceneClose`
- `ISceneCloseCoroutine`
- `ISceneCloseAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual Awaitable OnSceneClose()` | Callback for when the scene that a `MonoBehaviour` is contained within is closed. |

---
# ISceneCloseCoroutine
<!--
source: API\Callbacks\ISceneCloseCoroutine.md
-->

## ISceneCloseCoroutine

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when the scene that a `MonoBehaviour` is contained within is closed.

<b> Remarks:</b>
See also:
            
- `ISceneClose`
- `ISceneCloseCoroutine`
- `ISceneCloseAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual IEnumerator OnSceneClose()` | Callback for when the scene that a `MonoBehaviour` is contained within is closed. |

---
# ISceneOpen
<!--
source: API\Callbacks\ISceneOpen.md
-->

## ISceneOpen

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when the scene that a `MonoBehaviour` is contained within is opened.
            See also:
            
- `ISceneOpen`
- `ISceneOpenCoroutine`
- `ISceneOpenAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void OnSceneOpen()` | Callback for when the scene that a `MonoBehaviour` is contained within is opened.
            See also:
            
- `ISceneOpen`
- `ISceneOpenCoroutine`
- `ISceneOpenAwaitable` |

---
# ISceneOpenAwaitable
<!--
source: API\Callbacks\ISceneOpenAwaitable.md
-->

## ISceneOpenAwaitable

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when the scene that a `MonoBehaviour` is contained within is opened.
            See also:
            
- `ISceneOpen`
- `ISceneOpenCoroutine`
- `ISceneOpenAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual Awaitable OnSceneOpen()` | Callback for when the scene that a `MonoBehaviour` is contained within is opened.
            See also:
            
- `ISceneOpen`
- `ISceneOpenCoroutine`
- `ISceneOpenAwaitable` |

---
# ISceneOpenCoroutine
<!--
source: API\Callbacks\ISceneOpenCoroutine.md
-->

## ISceneOpenCoroutine

`interface` in `AdvancedSceneManager.Callbacks`### Description
Callback for when the scene that a `MonoBehaviour` is contained within is opened.
            See also:
            
- `ISceneOpen`
- `ISceneOpenCoroutine`
- `ISceneOpenAwaitable`

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual IEnumerator OnSceneOpen()` | Callback for when the scene that a `MonoBehaviour` is contained within is opened.
            See also:
            
- `ISceneOpen`
- `ISceneOpenCoroutine`
- `ISceneOpenAwaitable` |

---
# OnCollectionCloseAttribute
<!--
source: API\Callbacks\OnCollectionCloseAttribute.md
-->

## OnCollectionCloseAttribute

`class` in `AdvancedSceneManager.Callbacks`  /  Inherits from: `SceneCallbackAttribute`### Description

### Properties

| Member | Description |
|--------|-------------|
| `TargetInfo target` | _No documentation available._ |

---
# OnCollectionOpenAttribute
<!--
source: API\Callbacks\OnCollectionOpenAttribute.md
-->

## OnCollectionOpenAttribute

`class` in `AdvancedSceneManager.Callbacks`  /  Inherits from: `SceneCallbackAttribute`### Description

### Properties

| Member | Description |
|--------|-------------|
| `TargetInfo target` | _No documentation available._ |

---
# OnLoadAttribute
<!--
source: API\Callbacks\OnLoadAttribute.md
-->

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

---
# OnSceneCloseAttribute
<!--
source: API\Callbacks\OnSceneCloseAttribute.md
-->

## OnSceneCloseAttribute

`class` in `AdvancedSceneManager.Callbacks`  /  Inherits from: `SceneCallbackAttribute`### Description

### Properties

| Member | Description |
|--------|-------------|
| `TargetInfo target` | _No documentation available._ |

---
# OnSceneOpenAttribute
<!--
source: API\Callbacks\OnSceneOpenAttribute.md
-->

## OnSceneOpenAttribute

`class` in `AdvancedSceneManager.Callbacks`  /  Inherits from: `SceneCallbackAttribute`### Description

### Properties

| Member | Description |
|--------|-------------|
| `TargetInfo target` | _No documentation available._ |

---
# SceneCallbackAttribute
<!--
source: API\Callbacks\SceneCallbackAttribute.md
-->

## SceneCallbackAttribute

`abstract class` in `AdvancedSceneManager.Callbacks`  /  Inherits from: `DiscoverableAttribute`### Description

---
# App
<!--
source: API\Core\App.md
-->

## App

`class` in `AdvancedSceneManager.Core`### Description
Manages startup and quit processes.

<b> Remarks:</b>
Usage: `app`.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isASMPlay { get; }` | Gets whatever we're currently in ASM play mode. |
| `boolean isQuitting { get; }` | Gets whatever ASM is currently in the process of quitting the game. |
| `boolean isRestart { get; }` | Gets if ASM has been restarted, or is currently restarting. |
| `boolean isRunningStartupProcess { get; }` | Gets if ASM startup process is running. |
| `boolean isStartupFinished { get; }` | Gets if startup process is finished. |
| `ProgressScope startupProgressScope { get; }` | Gets the progress scope used during startup. |
| `StartupProps startupProps` | Gets the props that should be used for startup process. |

### Methods

| Member | Description |
|--------|-------------|
| `void CancelQuit()` | Cancels the current quit process. |
| `void CancelStartup()` | Cancels startup process. |
| `void Exit()` | Exits the application immediately. |
| `void Play(StartupProps props)` | _No documentation available._ |
| `Awaitable Quit(boolean fade, Nullable<Color> fadeColor, single fadeDuration)` | Quits the application with optional fade effect. |
| `void RegisterQuitCallback(Func<IEnumerator> coroutine)` | Register a callback to be called before quit. |
| `void Restart(StartupProps props)` | _No documentation available._ |
| `Async<boolean> RestartAsync(StartupProps props)` | _No documentation available._ |
| `void UnregisterQuitCallback(Func<IEnumerator> coroutine)` | Unregister a callback that was to be called before quit. |

---
# Indicator
<!--
source: API\Core\Indicator.md
-->

## Indicator

`struct` in `AdvancedSceneManager.Core`  /  Inherits from: `ValueType`### Description

### Properties

| Member | Description |
|--------|-------------|
| `Nullable<Color> color` | _No documentation available._ |
| `Func<Texture2D> icon` | _No documentation available._ |
| `Action<Scene> onClick` | _No documentation available._ |
| `string text` | _No documentation available._ |
| `string tooltip` | _No documentation available._ |
| `boolean useFontAwesome` | _No documentation available._ |
| `boolean useFontAwesomeBrands` | _No documentation available._ |

---
# Package
<!--
source: API\Core\Package.md
-->

## Package

`class` in `AdvancedSceneManager.Core`### Description
Contains info about the ASM package.

<b> Remarks:</b>
Only available in editor.

### Properties

| Member | Description |
|--------|-------------|
| `string folder` | The folder that ASM is contained within. |
| `string id` | The id of this package. |
| `string version { get; }` | The version of ASM. |

---
# Runtime
<!--
source: API\Core\Runtime.md
-->

## Runtime

`class` in `AdvancedSceneManager.Core`### Description
Manages runtime functionality for Advanced Scene Manager such as open scenes and collection.

### Properties

| Member | Description |
|--------|-------------|
| `Scene activeScene` | Gets the currently active scene, assuming it has been imported into ASM. |
| `SceneOperation currentOperation` | Gets the current active operation in the queue. |
| `Scene dontDestroyOnLoad` | Gets the dontDestroyOnLoad scene. |
| `boolean isBusy` | Gets whatever ASM is busy with any scene operations. |
| `boolean isPreloadedCollectionAdditive { get; }` | Gets if `preloadedCollection` is additive. |
| `IEnumerable<SceneCollection> openAdditiveCollections` | Gets the collections that are opened as additive. |
| `SceneCollection openCollection` | Gets the collection that is currently open. |
| `IEnumerable<Scene> openScenes` | Gets the scenes that are currently open. |
| `SceneCollection preloadedCollection { get; }` | Gets the currently preloaded collection. |
| `IEnumerable<Scene> preloadedScenes` | Gets the scenes that are preloaded. |
| `IEnumerable<SceneOperation> queuedOperations` | Gets the current scene operation queue. |
| `IEnumerable<SceneOperation> runningOperations` | The currently running scene operations. |
| `IEnumerable<Scene> unimportedScenes` | Gets all open Unity scenes that are not imported into ASM. |

### Fields

| Member | Description |
|--------|-------------|
| `Action onAllScenesClosed` | Occurs when the last user scene closes. |

### Events

| Member | Description |
|--------|-------------|
| `event Action<SceneCollection> collectionClosed` | Occurs when a collection is closed. |
| `event Action<SceneCollection> collectionOpened` | Occurs when a collection is opened. |
| `event Action<Scene> sceneClosed` | Occurs when a scene is closed. |
| `event Action sceneLoaderAdded` | Occurs when a `SceneLoader` is added. |
| `event Action sceneLoaderRemoved` | Occurs when a `SceneLoader` is removed. |
| `event Action<ValueTuple<Scene, Type, Type>> sceneLoaderToggled` | Occurs when a `SceneLoader` is toggled for a scene. |
| `event Action<Scene> sceneOpened` | Occurs when a scene is opened. |
| `event Action<Scene> scenePreloaded` | Occurs when a scene is preloaded. |
| `event Action<Scene> scenePreloadFinished` | Occurs when a previously preloaded scene is opened. |
| `event Action startedWorking` | Occurs when ASM has started working and is running scene operations. |
| `event Action stoppedWorking` | Occurs when ASM has finished working and no scene operations are running. |

### Methods

| Member | Description |
|--------|-------------|
| `void Activate(Scene scene)` | Activates this scene. |
| `void AddProgressListener(ILoadProgressListener listener)` | _No documentation available._ |
| `void AddSceneLoader<T>()` | _No documentation available._ |
| `SceneOperation CancelPreload()` | Cancels the preload. All preloaded scenes will be fully loaded (limitation by Unity), then closed. No ASM scene callbacks will be called. |
| `SceneOperation Close(SceneCollection collection)` | Closes `collection`. |
| `SceneOperation Close(SceneOperation operation, SceneCollection collection)` | _No documentation available._ |
| `SceneOperation Close(Scene scene)` | Closes this scene. |
| `SceneOperation Close(Scene[] scenes)` | _No documentation available._ |
| `SceneOperation Close(IEnumerable<Scene> scenes)` | Closes this scene. |
| `SceneOperation Close(IEnumerable<Scene> scenes, boolean skipEmptySceneCheck)` | _No documentation available._ |
| `SceneOperation CloseAll(boolean exceptLoadingScreens, boolean exceptUnimported, Scene[] except)` | Closes all scenes and collections. |
| `IEnumerator CloseUnimportedScenes()` | Closes all open Unity scenes that are not imported into ASM. |
| `SceneOperation CloseWithLoadingScreen(Scene scene, Scene loadingScreen)` | _No documentation available._ |
| `SceneOperation CloseWithLoadingScreen(IEnumerable<Scene> scene, Scene loadingScreen)` | _No documentation available._ |
| `IEnumerable<Scene> EvalScenesToClose(SceneCollection closeCollection, SceneCollection nextCollection, SceneCollection additiveCloseCollection)` | Evaluate the scenes that would close. |
| `IEnumerable<Scene> EvalScenesToOpen(SceneCollection collection, boolean openAll)` | Evaluate the scenes that would open. |
| `SceneOperation FinishPreload()` | Finish loading preloaded scenes. |
| `void ForceTrack(Scene scene)` | Tracks a scene that doesn't have a associated unity scene. |
| `SceneLoader GetLoaderForScene(Scene scene, boolean useOnlyGlobal)` | Gets the loader for `scene`. |
| `SceneLoader GetSceneLoader(string sceneLoader)` | Returns the scene loader with the specified key. |
| `Type GetSceneLoaderType(string sceneLoader)` | Returns the scene loader type with the specified key. |
| `SceneState GetState(Scene scene)` | _No documentation available._ |
| `IEnumerable<SceneLoader> GetToggleableSceneLoaders()` | Gets a list of all added scene loaders that can be toggled scene by scene. |
| `boolean IsQueued(SceneCollection collection)` | Gets if this collection is currently queued to be opened. |
| `boolean IsQueued(Scene scene)` | Gets if this scene is queued to be opened. |
| `boolean IsTracked(Scene scene)` | Gets whatever this scene is tracked as open. |
| `boolean IsTracked(SceneCollection collection)` | Gets whatever this collection is tracked as open. |
| `SceneOperation Open(SceneCollection collection, boolean openAll)` | Opens the collection. |
| `SceneOperation Open(Scene scene)` | Opens this scene. |
| `SceneOperation Open(Scene[] scenes)` | _No documentation available._ |
| `SceneOperation Open(IEnumerable<Scene> scenes)` | Opens this scene. |
| `SceneOperation OpenAdditive(SceneCollection collection, boolean openAll)` | Opens the collection without closing existing scenes. |
| `SceneOperation OpenAdditive(IEnumerable<SceneCollection> collections, SceneCollection activeCollection, LoadingScreenReference loadingScreen)` | Opens the collection without closing existing scenes. |
| `SceneOperation OpenAndActivate(Scene scene)` | Opens this scene and activates it. |
| `SceneOperation OpenWithLoadingScreen(Scene scene, Scene loadingScreen)` | _No documentation available._ |
| `SceneOperation OpenWithLoadingScreen(IEnumerable<Scene> scene, Scene loadingScreen)` | _No documentation available._ |
| `SceneOperation Preload(IEnumerable<Scene> scenes, Action<Scene> onPreloaded)` | Preloads the scenes. |
| `SceneOperation Preload(SceneCollection collection, boolean openAll)` | Preloads the collection. |
| `SceneOperation Preload(Scene scene, Action onPreloaded)` | _No documentation available._ |
| `SceneOperation Preload(Action<Scene> onPreloaded, Scene[] scenes)` | Preloads the specified scenes. |
| `SceneOperation Preload(Scene[] scenes)` | Preloads the specified scenes. |
| `SceneOperation PreloadAdditive(SceneCollection collection, boolean openAll)` | Preloads the collection as additive. |
| `void RemoveProgressListener(ILoadProgressListener listener)` | _No documentation available._ |
| `void RemoveSceneLoader<T>()` | _No documentation available._ |
| `SceneOperation Reopen(SceneCollection collection, boolean openAll)` | Reopens the collection. |
| `SceneOperation Reopen(Scene scene)` | Reopens this scene. |
| `SceneOperation Reopen(IEnumerable<Scene> scene)` | _No documentation available._ |
| `SceneOperation ToggleOpen(SceneCollection collection, boolean openAll)` | Toggles the collection open or closed. |
| `SceneOperation ToggleOpen(Scene scene)` | Toggles this scene open or closed. |
| `void Track(Scene scene, Scene unityScene)` | Tracks the specified scene as open. |
| `void Track(Scene scene)` | _No documentation available._ |
| `void Track(SceneCollection collection, boolean isAdditive)` | Tracks the collection as open. |
| `boolean Untrack(Scene scene)` | Untracks the specified scene as open. |
| `void Untrack(SceneCollection collection, boolean isAdditive)` | Untracks the collection. |
| `void UntrackCollections()` | Untracks all collections. |
| `void UntrackScenes()` | Untracks all open scenes. |

---
# RuntimeSceneLoader
<!--
source: API\Core\RuntimeSceneLoader.md
-->

## RuntimeSceneLoader

`class` in `AdvancedSceneManager.Core`  /  Inherits from: `SceneLoader`### Description
A scene loader that uses the normal play mode API. 
            
See [LoadSceneMode)](https://learn.microsoft.com/dotnet/api/m:unityengine.scenemanagement.scenemanager.loadsceneasync(system.string,unityengine.scenemanagement.loadscenemode)).

See [Scene)](https://learn.microsoft.com/dotnet/api/m:unityengine.scenemanagement.scenemanager.unloadsceneasync(unityengine.scenemanagement.scene)).

### Properties

| Member | Description |
|--------|-------------|
| `boolean activeOutsideOfPlayMode` | Specifies whatever this loader will run outside of play mode or not. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual boolean CanHandleScene(Scene scene)` | Gets whatever this scene loader can handle the scene. |
| `virtual IEnumerator LoadScene(Scene scene, SceneLoadArgs e)` | Loads the scene specified in e.scene. |
| `virtual IEnumerator UnloadScene(Scene scene, SceneUnloadArgs e)` | Unloads the scene specified in e.scene. |

---
# SceneLoadArgs
<!--
source: API\Core\SceneLoadArgs.md
-->

## SceneLoadArgs

`class` in `AdvancedSceneManager.Core`  /  Inherits from: `SceneLoaderArgsBase`### Description
Specifies arguments for [SceneLoadArgs)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.core.sceneloader.loadscene(advancedscenemanager.models.scene,advancedscenemanager.core.sceneloadargs)).

### Properties

| Member | Description |
|--------|-------------|
| `boolean isPreload { get; }` | Specifies if the scene should be preloaded. |

### Methods

| Member | Description |
|--------|-------------|
| `boolean CheckIsIncluded(boolean logError)` | Checks if the scene is actually included in build. |
| `Scene GetOpenedScene()` | Gets the `Scene` that was opened by this override. |
| `void SetCompleted(Scene scene)` | Notifies ASM that the load is done. |
| `void SetCompleted(Scene scene, Func<IEnumerator> preloadCallback)` | _No documentation available._ |
| `void SetCompletedWithoutScene()` | Sets this loader as complete even though no scene was loaded. |

---
# SceneLoader
<!--
source: API\Core\SceneLoader.md
-->

## SceneLoader

`abstract class` in `AdvancedSceneManager.Core`### Description
Specifies a scene loader.

### Properties

| Member | Description |
|--------|-------------|
| `boolean activeInPlayMode` | Specifies whatever this loader will run in play mode or not. |
| `boolean activeOutsideOfPlayMode` | Specifies whatever this loader will run outside of play mode or not. |
| `boolean addScenesToBuildSettings` | Specifies whatever scenes using this loader should be added to build settings scene list. |
| `boolean canBeActivated` | Gets whatever this loader may be activated in the current context. |
| `Indicator indicator` | Specifies the indicator on scene fields for this scene loader. |
| `boolean isGlobal` | Specifies if this scene loader will can be applied to all scenes. Otherwise scenes will have to be explicitly flagged to open with this loader. |
| `string Key` | Gets the key for this scene loader. |
| `string sceneToggleText` | Specifies the text to display on the toggle in scene popup. Only has an effect if `isGlobal` is `false`. |
| `string sceneToggleTooltip` | Specifies the tooltip to display on the toggle in scene popup. Only has an effect if `isGlobal` is `false`. |

### Static Methods

| Member | Description |
|--------|-------------|
| `string GetKey<T>()` | _No documentation available._ |
| `string GetKey<T>(T obj)` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual boolean CanHandleScene(Scene scene)` | Gets whatever this scene loader can handle the scene. |
| `IEnumerator LoadDefault(SceneLoadArgs e)` | Loads scene using default ASM loaders. |
| `abstract virtual IEnumerator LoadScene(Scene scene, SceneLoadArgs e)` | Loads the scene specified in e.scene. |
| `IEnumerator UnloadDefault(SceneUnloadArgs e)` | Unloads scene using default ASM loaders. |
| `abstract virtual IEnumerator UnloadScene(Scene scene, SceneUnloadArgs e)` | Unloads the scene specified in e.scene. |

---
# SceneLoaderArgsBase
<!--
source: API\Core\SceneLoaderArgsBase.md
-->

## SceneLoaderArgsBase

`abstract class` in `AdvancedSceneManager.Core`### Description
Base class for `SceneLoadArgs` and `SceneUnloadArgs`.

### Properties

| Member | Description |
|--------|-------------|
| `SceneCollection collection { get; }` | The collection that the scene belongs to, if any. |
| `string errorMessage { get; }` | The error message if `isError` is `true`. |
| `boolean isError { get; }` | Indicates whether this operation resulted in an error. |
| `boolean isLoadingScreen` | Gets whether the associated scene is a loading screen. |
| `boolean isSplashScreen` | Gets whether the associated scene is a splash screen. |
| `SceneOperation operation { get; }` | The `SceneOperation` representing the current load or unload operation. |
| `boolean reportProgress { get; }` | Determines whether progress should be reported during this operation. |
| `Scene scene { get; }` | The scene associated with this loading or unloading operation. |

### Methods

| Member | Description |
|--------|-------------|
| `void SetError(string message)` | Marks this operation as failed with the specified error message. |

---
# SceneLoaderExtensions
<!--
source: API\Core\SceneLoaderExtensions.md
-->

## SceneLoaderExtensions

`static class` in `AdvancedSceneManager.Core`### Description
Provides extensions for scene loading.

<b> Remarks:</b>
This provides access to direct scene loading / unloading, which bypasses many checks that .Open() / .Close() has. Make sure to test thoroughly.

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerator Load(Scene scene, SceneLoadArgs e)` | _No documentation available._ |
| `IEnumerator Load(Scene scene, boolean isPreload, SceneOperation operation, SceneCollection collection, boolean reportsProgress, Nullable<ThreadPriority> loadPriority, Action onLoaded, Action<string> onError, boolean useOnlyGlobal)` | Loads the scene using a scene loader. |
| `IEnumerator Unload(Scene scene, SceneUnloadArgs e)` | _No documentation available._ |
| `IEnumerator Unload(Scene scene, SceneOperation operation, SceneCollection collection, boolean reportsProgress, Nullable<ThreadPriority> loadPriority, Action onUnloaded, Action<string> onError, boolean useOnlyGlobal)` | Unloads the scene using a scene loader. |

---
# SceneOperation
<!--
source: API\Core\SceneOperation.md
-->

## SceneOperation

`class` in `AdvancedSceneManager.Core`  /  Inherits from: `CustomYieldInstruction`### Description
A scene operation is a queueable operation that can open or close scenes..

### Static Properties

| Member | Description |
|--------|-------------|
| `SceneOperation done` | Gets a `SceneOperation` that has already completed. |

### Properties

| Member | Description |
|--------|-------------|
| `boolean acceptsSubOperations { get; }` | Gets if this operation is currently executing open callbacks. If so, sub operations is temporarily accepted. |
| `IEnumerable<Scene> close { get; }` | Gets the scenes specified to close. |
| `IEnumerable<Scene> closedScenes` | Gets the scenes that was closed during this operation. |
| `SceneCollection collection { get; }` | Specifies the collection that is being opened or closed. |
| `string description { get; }` | Specifies description for coroutine. |
| `EventCallbackManager<SceneOperationEventBase> events { get; }` | Gets the event manager for this operation. |
| `SceneOperationFlags flags { get; }` | Gets the operation flags this operation will use. |
| `Scene focus { get; }` | Sets focus to the specified scene. Overrides selected scene in collections. |
| `boolean focusSingleScene { get; }` | Sets the first opened scene as active. |
| `boolean hasStarted { get; }` | Gets whether this operation has started. |
| `IEnumerable<Scene> ignoreForActivation { get; }` | Gets the scenes that should not be activated. |
| `boolean isCollectionCloseOperation { get; }` | Gets whatever this operation is about to close `collection`. |
| `boolean isDefaultASMScene { get; }` | Gets if this scene was opened from the default ASM scene collection. |
| `boolean isFrozen { get; }` | Gets if this operation is frozen, as in, can its properties be changed? |
| `boolean isStandaloneScene { get; }` | Gets if this scene was opened from the standalone collection. |
| `boolean keepWaiting` | Inherited from `CustomYieldInstruction`. Tells unity whatever the operation is done or not. |
| `LoadingScreenReference loadingScreen { get; }` | Gets the specified loading screen. |
| `Action<LoadingScreenReference> loadingScreenCallback { get; }` | Gets the specified loading screen callback. |
| `LoadPriority loadPriority { get; }` | Gets the `LoadPriority` this operation will use. |
| `IEnumerable<Scene> open { get; }` | Gets the scenes specified to open. |
| `LoadingScreenReference openedLoadingScreen { get; }` | Gets the loading screen that was opened by this operation. |
| `IEnumerable<Scene> openedScenes` | Gets the scenes that was opened during this operation. |
| `IEnumerable<Scene> preload { get; }` | Gets the scenes specified to preload. |
| `single progress` | Gets the total progress of this operation. |
| `ProgressScope progressScope { get; }` | Gets the progress scope associated with this operation. |
| `boolean reportsProgress { get; }` | Gets if this scene operation reports progress. |
| `boolean runSceneCallbacksOutsideOfPlayMode { get; }` | Gets whatever scene callbacks should run outside of play mode. |
| `boolean setActiveCollectionScene { get; }` | Specifies whatever active scene should be set when possible. |
| `Nullable<boolean> unloadUnusedAssets { get; }` | Gets whatever `UnloadUnusedAssets` should be called at the end (before loading screen). |
| `boolean useLoadingScene { get; }` | Gets whatever a loading screen should be used. |
| `boolean wasCancelled { get; }` | Gets if this scene operation is cancelled. |

### Static Methods

| Member | Description |
|--------|-------------|
| `SceneOperation Queue()` | _No documentation available._ |
| `SceneOperation Queue(SceneOperation operation)` | Queues a new scene operation. |
| `SceneOperation Start()` | _No documentation available._ |
| `SceneOperation Start(SceneOperation operation)` | Starts a new scene operation, ignoring queue. |

### Methods

| Member | Description |
|--------|-------------|
| `SceneOperation Activate(Scene scene)` | Sets focus to the specified scene. Overrides selected scene in collections. If `null`, then the first scene opened will be set as active. |
| `void Cancel()` | Cancel this operation. |
| `SceneOperation Close(SceneCollection collection)` | _No documentation available._ |
| `SceneOperation Close(Scene scene, boolean removeFromOpen)` | Specifies the scenes to close. |
| `SceneOperation Close(Scene[] scenes)` | Specifies the scenes to close. |
| `SceneOperation Close(IEnumerable<Scene> scenes, boolean removeFromOpen)` | _No documentation available._ |
| `SceneOperation CloseAll(Scene[] except)` | _No documentation available._ |
| `SceneOperation CloseAll(IEnumerable<Scene> except, boolean removeFromOpen)` | Closes all scenes, regardless if they are persistent or splash/loading screens. |
| `SceneOperation CloseOtherScenes(Scene[] except)` | Closes all non-persistent scenes prior to opening any scenes. |
| `SceneOperation CloseOtherScenes(boolean persistent, IEnumerable<Scene> except, boolean loadingScreen, boolean splashScreen, boolean removeFromOpen)` | Closes all open scenes prior to opening any scenes, with options. |
| `SceneOperation DisableProgressReporting()` | Disables progress reporting for this operation. |
| `SceneOperation Focus(Scene scene)` | Sets focus to the specified scene. Overrides selected scene in collections. |
| `CoroutineAwaiter GetAwaiter()` | Allows this operation to be awaited. |
| `SceneOperation IgnoreForActivation(IEnumerable<Scene> scenes)` | Specifies scenes that should not be activated. |
| `SceneOperation OnProgressChanged(Action<single> callback)` | Adds a callback when progress changed. |
| `SceneOperation Open(SceneCollection collection, boolean openAll)` | _No documentation available._ |
| `SceneOperation Open(Scene[] scenes)` | Specifies the scenes to open. |
| `SceneOperation Open(Scene scene, boolean removeFromClose)` | Specifies the scenes to open. |
| `SceneOperation Open(IEnumerable<Scene> scenes, boolean removeFromClose)` | _No documentation available._ |
| `SceneOperation OpenAndActivate(Scene scene)` | Opens the scene, and makes sure it is activated afterwards. |
| `SceneOperation Preload(Scene[] scenes)` | Specifies scenes to preload. |
| `SceneOperation Preload(IEnumerable<Scene> scenes)` | Specifies scenes to preload. |
| `SceneOperation PrependOpen(Scene[] scenes)` | Specifies the scenes to prepend to the current open operation. |
| `SceneOperation PrependOpen(IEnumerable<Scene> scenes, boolean ignoreForActivation)` | _No documentation available._ |
| `SceneOperation RegisterCallback<TEventType>(EventCallback<TEventType> callback, When when, string key)` | _No documentation available._ |
| `SceneOperation RemoveOnProgressChangedCallback(Action<single> callback)` | Removes a callback when progress changed. |
| `SceneOperation RunSceneCallbacksOutsidePlayMode(boolean value)` | Specifies whatever scene callbacks should run outside of play mode. |
| `SceneOperation UnloadUsedAssets()` | Specifies whatever `UnloadUnusedAssets` should be called at the end (before loading screen). |
| `SceneOperation UnregisterCallback<TEventType>(EventCallback<TEventType> callback, When when, string key)` | _No documentation available._ |
| `void UnregisterCallback<TEventType>(string key)` | _No documentation available._ |
| `void WaitFor(SceneOperation operation)` | Waits for the specified scene operation to complete before continuing. |
| `SceneOperation With(SceneCollection collection, boolean setActiveScene, boolean isCloseOperation)` | Specifies an associated collection. |
| `SceneOperation With(LoadingScreenReference loadingScreen, boolean useLoadingScene)` | Specifies loading screen to use. |
| `SceneOperation With(boolean useLoadingScene)` | Specifies loading screen to use. |
| `SceneOperation With(Action<LoadingScreenReference> loadingScreenCallback)` | Specifies a callback when loading screen is opened, before `OnOpen` is called. |
| `SceneOperation With(LoadPriority loadPriority)` | Sets the `LoadPriority` this operation will use. |
| `SceneOperation With(SceneOperationFlags flags)` | Sets the operation flags this operation will use. |
| `SceneOperation WithFriendlyText(string text)` | Specifies description for operation coroutine. |
| `SceneOperation WithLoadingScreen(LoadingScreenReference loadingScreen, boolean useLoadingScene)` | Specifies loading screen to use. |
| `SceneOperation WithLoadingScreen(boolean useLoadingScene)` | Specifies whatever loading screen should be used. |
| `SceneOperation WithoutLoadingScreen(boolean useLoadingScene)` | Specifies whatever loading screen should be used. |

---
# SceneOperationFlags
<!--
source: API\Core\SceneOperationFlags.md
-->

## SceneOperationFlags

`enum` in `AdvancedSceneManager.Core`  /  Inherits from: `Enum`### Description
Defines flags that control the behavior of a `SceneOperation`.

### Static Fields

| Member | Description |
|--------|-------------|
| `SceneOperationFlags All` | Enables all available operation flags. |
| `SceneOperationFlags CollectionCallbacks` | Invokes callbacks defined on the associated `SceneCollection`. |
| `SceneOperationFlags EventCallbacks` | Triggers global event callbacks related to the operation. |
| `SceneOperationFlags LoadingScreen` | Includes loading screen scenes in the operation. |
| `SceneOperationFlags None` | No flags are set. |
| `SceneOperationFlags SceneCallbacks` | Invokes callbacks defined on the involved `Scene` objects. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# SceneOperationKind
<!--
source: API\Core\SceneOperationKind.md
-->

## SceneOperationKind

`enum` in `AdvancedSceneManager.Core`  /  Inherits from: `Enum`### Description
Gets the kind of operation that a `SceneLoadProgressData` represents.

### Static Fields

| Member | Description |
|--------|-------------|
| `SceneOperationKind Load` | A scene is currently being loaded. |
| `SceneOperationKind Unload` | A scene is currently being unloaded |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# SceneUnloadArgs
<!--
source: API\Core\SceneUnloadArgs.md
-->

## SceneUnloadArgs

`class` in `AdvancedSceneManager.Core`  /  Inherits from: `SceneLoaderArgsBase`### Description
Specifies arguments for [SceneUnloadArgs)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.core.sceneloader.unloadscene(advancedscenemanager.models.scene,advancedscenemanager.core.sceneunloadargs)).

### Methods

| Member | Description |
|--------|-------------|
| `void SetCompleted()` | Notifies ASM that the unload is done. |

---
# StartupProps
<!--
source: API\Core\StartupProps.md
-->

## StartupProps

`class` in `AdvancedSceneManager.Core`### Description

### Properties

| Member | Description |
|--------|-------------|
| `Color effectiveFadeColor` | _No documentation available._ |
| `boolean runStartupProcess` | _No documentation available._ |
| `boolean runStartupProcessWhenPlayingCollection` | _No documentation available._ |

### Fields

| Member | Description |
|--------|-------------|
| `Nullable<Color> fadeColor` | _No documentation available._ |
| `boolean forceOpenAllScenesOnCollection` | _No documentation available._ |
| `SceneCollection openCollection` | _No documentation available._ |
| `boolean softSkipSplashScreen` | _No documentation available._ |

---
# DependencyInjectionUtility
<!--
source: API\DependencyInjection\DependencyInjectionUtility.md
-->

## DependencyInjectionUtility

`static class` in `AdvancedSceneManager.DependencyInjection`### Description
Provides utility methods and accessors for dependency injection within ASM.

### Static Methods

| Member | Description |
|--------|-------------|
| `IEnumerable<ValueTuple<Type, IInjectable>> EnumerateServices()` | Enumerates all currently registered injectable services. |
| `T GetService<T>()` | _No documentation available._ |
| `IInjectable GetService(Type type)` | Gets a service matching the specified type. |
| `IEnumerable<T> GetServices<T>()` | _No documentation available._ |
| `void Remove<T>(Type type, T service)` | _No documentation available._ |

---
# IBuildManager
<!--
source: API\DependencyInjection\Editor\IBuildManager.md
-->

## IBuildManager

`interface` in `AdvancedSceneManager.DependencyInjection.Editor`### Description
Provides functions for building, and build events.

<b> Remarks:</b>
Only available in editor.

### Events

| Member | Description |
|--------|-------------|
| `event Action<PostBuildEventArgs> postBuild` | Occurs after build. |
| `event Action<BuildReport> preBuild` | Occurs before build. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual BuildReport DoBuild(string path, boolean attachProfiler, boolean runGameWhenBuilt, boolean dev, BuildOptions customOptions)` | _No documentation available._ |
| `abstract virtual BuildReport DoBuild(BuildPlayerOptions options)` | _No documentation available._ |
| `abstract virtual IEnumerable<ValueTuple<EditorBuildSettingsScene, Reason>> GetOrderedList()` | Gets an ordered list of all scenes that ASM would set in the build settings. |
| `abstract virtual boolean IsEnabled(string path, Reason& reason)` | _No documentation available._ |
| `abstract virtual boolean IsIncluded(Scene scene, Reason& reason)` | _No documentation available._ |
| `abstract virtual void UpdateSceneList()` | Updates the scene build settings. |
| `abstract virtual void UpdateSceneList(boolean ignorePlaymodeCheck)` | _No documentation available._ |

---
# IHierarchyGUI
<!--
source: API\DependencyInjection\Editor\IHierarchyGUI.md
-->

## IHierarchyGUI

`interface` in `AdvancedSceneManager.DependencyInjection.Editor`### Description
An utility for adding extra icons to scene fields in the hierarchy window.

<b> Remarks:</b>
Only available in editor.

### Properties

| Member | Description |
|--------|-------------|
| `GUIStyle defaultStyle` | The default style for text in hierarchy. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void AddGameObjectGUI(HierarchyGameObjectGUI onGUI, int32 index)` | _No documentation available._ |
| `abstract virtual void AddSceneGUI(HierarchySceneGUI onGUI, int32 index)` | _No documentation available._ |
| `abstract virtual void RemoveGameObjectGUI(HierarchyGameObjectGUI onGUI)` | _No documentation available._ |
| `abstract virtual void RemoveSceneGUI(HierarchySceneGUI onGUI)` | _No documentation available._ |
| `abstract virtual void Repaint()` | Can be used to ensure repaint of the HierarchyWindow. |

---
# IPackage
<!--
source: API\DependencyInjection\Editor\IPackage.md
-->

## IPackage

`interface` in `AdvancedSceneManager.DependencyInjection.Editor`### Description
Contains info about the ASM package.

<b> Remarks:</b>
Only available in editor.

### Properties

| Member | Description |
|--------|-------------|
| `string folder` | The folder that ASM is contained within. |
| `string version` | The version of ASM. |

---
# ISceneManagerWindow
<!--
source: API\DependencyInjection\Editor\ISceneManagerWindow.md
-->

## ISceneManagerWindow

`interface` in `AdvancedSceneManager.DependencyInjection.Editor`### Description
Provides methods for working with the scene manager window.

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void CloseWindow()` | Close the window. |
| `abstract virtual void OpenWindow()` | Open the window. |

---
# IUserSettings
<!--
source: API\DependencyInjection\Editor\IUserSettings.md
-->

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
| `boolean logImport` | Specifies whatever ASM should log when a `ASMModelBase` is imported. |
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
| `abstract virtual void Save()` | Saves the singleton to disk, with a debounce. See also `SaveNow`. |
| `abstract virtual void SaveNow()` | Saves the singleton to disk. |
| `abstract virtual void ToolbarAction(int32 i, SceneCollection& collection, Boolean& runStartupProcess)` | _No documentation available._ |
| `abstract virtual void ToolbarAction(int32 i, SceneCollection collection, boolean runStartupProcess)` | _No documentation available._ |
| `abstract virtual void UnpinCollectionFromOverlay(SceneCollection collection)` | _No documentation available._ |

---
# IApp
<!--
source: API\DependencyInjection\IApp.md
-->

## IApp

`interface` in `AdvancedSceneManager.DependencyInjection`### Description
Manages startup and quit processes.

<b> Remarks:</b>
Usage: `app`.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isASMPlay` | Gets whatever we're currently in ASM play mode. |
| `boolean isQuitting` | Gets whatever ASM is currently in the process of quitting the game. |
| `boolean isRestart` | Gets if ASM has been restarted, or is currently restarting. |
| `boolean isStartupFinished` | Gets if startup process is finished. |
| `StartupProps startupProps` | Gets the props that should be used for startup process. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void CancelQuit()` | Cancels the current quit process. |
| `abstract virtual void CancelStartup()` | Cancels startup process. |
| `abstract virtual void Exit()` | Exits the application immediately. |
| `abstract virtual Awaitable Quit(boolean fade, Nullable<Color> fadeColor, single fadeDuration)` | _No documentation available._ |
| `abstract virtual void RegisterQuitCallback(Func<IEnumerator> coroutine)` | _No documentation available._ |
| `abstract virtual void Restart(StartupProps props)` | _No documentation available._ |
| `abstract virtual Async<boolean> RestartAsync(StartupProps props)` | _No documentation available._ |
| `abstract virtual void UnregisterQuitCallback(Func<IEnumerator> coroutine)` | _No documentation available._ |

---
# IInjectable
<!--
source: API\DependencyInjection\IInjectable.md
-->

## IInjectable

`interface` in `AdvancedSceneManager.DependencyInjection`### Description

---
# IProfileManager
<!--
source: API\DependencyInjection\IProfileManager.md
-->

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

---
# IProjectSettings
<!--
source: API\DependencyInjection\IProjectSettings.md
-->

## IProjectSettings

`interface` in `AdvancedSceneManager.DependencyInjection`### Description
Provides access to ASM settings.

<b> Remarks:</b>
May not be available in `[InitializeOnLoad]` and similar, use [Action)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.scenemanager.oninitialized(system.action)) or `OnLoadAttribute` to ensure you're not calling too early.

### Properties

| Member | Description |
|--------|-------------|
| `boolean allowCollectionLocking` | Specifies whatever asm will allow locking collections. |
| `boolean allowSceneLocking` | Specifies whatever asm will allow locking scenes. |
| `string assetPath` | Specifies the path where profiles and imported scenes should be generated to. |
| `Profile buildProfile` | The profile to use during build. |
| `boolean checkForDuplicateSceneOperations` | By default, ASM checks for duplicate scene operations, since this is usually caused by mistake, but this will disable that. |
| `CustomData customData` | Specifies custom data. |
| `Profile defaultProfile` | The profile to use when none is set. |
| `boolean enableCrossSceneReferences` | Gets or sets whatever cross-scene references should be enabled. |
| `Profile forceProfile` | The profile to force everyone in this project to use. |
| `boolean preventSpammingEventMethods` | By default, ASM will prevent spam calling event methods (i.e. calling Scene.Open() from a button press), but this will disable that. |
| `boolean reverseUnloadOrderOnCollectionClose` | Specifies whatever collections should unload scenes in the reverse order. |
| `SceneImportOption sceneImportOption` | Gets or sets when to automatically import scenes. |
| `single spamCheckCooldown` | Sets the default cooldown for `SpamCheck`. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void Save()` | Saves the singleton to disk, with a debounce. See also `SaveNow`. |
| `abstract virtual void SaveNow()` | Saves the singleton to disk. |
| `abstract virtual void SetBuildProfile(Profile profile)` | _No documentation available._ |

---
# IRuntime
<!--
source: API\DependencyInjection\IRuntime.md
-->

## IRuntime

`interface` in `AdvancedSceneManager.DependencyInjection`### Description
Manages runtime functionality for Advanced Scene Manager such as open scenes and collection.

---
# ISceneManager
<!--
source: API\DependencyInjection\ISceneManager.md
-->

## ISceneManager

`interface` in `AdvancedSceneManager.DependencyInjection`### Description
Manages runtime functionality for Advanced Scene Manager such as open scenes and collection.

### Properties

| Member | Description |
|--------|-------------|
| `Scene activeScene` | Gets the currently active scene, assuming it has been imported into ASM. |
| `SceneOperation currentOperation` | Gets the current active operation in the queue. |
| `Scene dontDestroyOnLoad` | Gets the dontDestroyOnLoad scene. |
| `boolean isBusy` | Gets whatever ASM is busy with any scene operations. |
| `IEnumerable<SceneCollection> openAdditiveCollections` | Gets the collections that are opened as additive. |
| `SceneCollection openCollection` | Gets the collection that is currently open. |
| `IEnumerable<Scene> openScenes` | Gets the scenes that are currently open. |
| `IEnumerable<Scene> preloadedScenes` | Gets the scenes that are preloaded. |
| `IEnumerable<SceneOperation> queuedOperations` | Gets the current scene operation queue. |
| `IEnumerable<SceneOperation> runningOperations` | The currently running scene operations. |

### Events

| Member | Description |
|--------|-------------|
| `event Action<SceneCollection> collectionClosed` | Occurs when a collection is closed. |
| `event Action<SceneCollection> collectionOpened` | Occurs when a collection is opened. |
| `event Action<Scene> sceneClosed` | Occurs when a scene is closed. |
| `event Action<Scene> sceneOpened` | Occurs when a scene is opened. |
| `event Action<Scene> scenePreloaded` | Occurs when a scene is preloaded. |
| `event Action<Scene> scenePreloadFinished` | Occurs when a previously preloaded scene is opened. |
| `event Action startedWorking` | Occurs when ASM has started working and is running scene operations. |
| `event Action stoppedWorking` | Occurs when ASM has finished working and no scene operations are running. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void Activate(Scene scene)` | _No documentation available._ |
| `abstract virtual void AddSceneLoader<T>()` | _No documentation available._ |
| `abstract virtual SceneOperation CancelPreload()` | Cancels the preload. All preloaded scenes will be fully loaded (limitation by Unity), then closed. No ASM scene callbacks will be called. |
| `abstract virtual SceneOperation Close(IEnumerable<Scene> scenes)` | _No documentation available._ |
| `abstract virtual SceneOperation Close(Scene[] scenes)` | _No documentation available._ |
| `abstract virtual SceneOperation Close(Scene scene)` | _No documentation available._ |
| `abstract virtual SceneOperation Close(SceneCollection collection)` | _No documentation available._ |
| `abstract virtual SceneOperation CloseAll(boolean exceptLoadingScreens, boolean exceptUnimported, Scene[] except)` | _No documentation available._ |
| `abstract virtual SceneOperation FinishPreload()` | _No documentation available._ |
| `abstract virtual SceneLoader GetLoaderForScene(Scene scene, boolean useOnlyGlobal)` | _No documentation available._ |
| `abstract virtual SceneState GetState(Scene scene)` | _No documentation available._ |
| `abstract virtual IEnumerable<SceneLoader> GetToggleableSceneLoaders()` | Gets a list of all added scene loaders that can be toggled scene by scene. |
| `abstract virtual boolean IsTracked(Scene scene)` | _No documentation available._ |
| `abstract virtual boolean IsTracked(SceneCollection collection)` | _No documentation available._ |
| `abstract virtual SceneOperation Open(IEnumerable<Scene> scenes)` | _No documentation available._ |
| `abstract virtual SceneOperation Open(Scene[] scenes)` | _No documentation available._ |
| `abstract virtual SceneOperation Open(Scene scene)` | _No documentation available._ |
| `abstract virtual SceneOperation Open(SceneCollection collection, boolean openAll)` | _No documentation available._ |
| `abstract virtual SceneOperation OpenAdditive(IEnumerable<SceneCollection> collections, SceneCollection activeCollection, LoadingScreenReference loadingScreen)` | _No documentation available._ |
| `abstract virtual SceneOperation OpenAdditive(SceneCollection collection, boolean openAll)` | _No documentation available._ |
| `abstract virtual SceneOperation OpenAndActivate(Scene scene)` | _No documentation available._ |
| `abstract virtual SceneOperation OpenWithLoadingScreen(IEnumerable<Scene> scene, Scene loadingScreen)` | _No documentation available._ |
| `abstract virtual SceneOperation OpenWithLoadingScreen(Scene scene, Scene loadingScreen)` | _No documentation available._ |
| `abstract virtual SceneOperation Preload(Scene scene, Action onPreloaded)` | _No documentation available._ |
| `abstract virtual void RemoveSceneLoader<T>()` | _No documentation available._ |
| `abstract virtual SceneOperation ToggleOpen(Scene scene)` | _No documentation available._ |
| `abstract virtual SceneOperation ToggleOpen(SceneCollection collection, boolean openAll)` | _No documentation available._ |
| `abstract virtual void Track(Scene scene)` | _No documentation available._ |
| `abstract virtual void Track(Scene scene, Scene unityScene)` | _No documentation available._ |
| `abstract virtual void Track(SceneCollection collection, boolean isAdditive)` | _No documentation available._ |
| `abstract virtual boolean Untrack(Scene scene)` | _No documentation available._ |
| `abstract virtual void Untrack(SceneCollection collection, boolean isAdditive)` | _No documentation available._ |
| `abstract virtual void UntrackCollections()` | Untracks all collections. |
| `abstract virtual void UntrackScenes()` | Untracks all open scenes. |

---
# ASMUtilityFunction
<!--
source: API\Editor\UI\ASMUtilityFunction.md
-->

## ASMUtilityFunction

`abstract class` in `AdvancedSceneManager.Editor.UI`### Description
Base class for ASM utility functions available in the editor UI.

### Properties

| Member | Description |
|--------|-------------|
| `string Description` | Gets the description of the function. |
| `string Group` | Gets the group this function belongs to. |
| `string Name` | Gets the display name of the function. |
| `int32 Order` | Gets the order used for sorting within its group. |

### Methods

| Member | Description |
|--------|-------------|
| `void ClosePopup()` | Closes the popup if options were provided in [VisualElement@)](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.editor.ui.asmutilityfunction.oninvoke(unityengine.uielements.visualelement@)). |
| `virtual void OnDisable()` | Called when the function is disabled. |
| `virtual void OnEnable()` | Called when the function is enabled. |
| `virtual void OnInvoke(VisualElement& optionsGUI)` | _No documentation available._ |

---
# ASMWindow
<!--
source: API\Editor\UI\ASMWindow.md
-->

## ASMWindow

`static class` in `AdvancedSceneManager.Editor.UI`### Description
Contains APIs relating to the ASM window.

<b> Remarks:</b>
Only available in the editor.

### Static Methods

| Member | Description |
|--------|-------------|
| `void AddNotification(Notification notification)` | Adds a notification to the ASM window, optionally with click and dismiss callbacks, dismiss behavior, visual style, and icon information. |
| `void ClosePopup()` | Closes the currently open popup, if one is open.. |
| `boolean IsPopupOpen()` | Determines whether any popup is currently open. |
| `boolean IsPopupOpen<T>()` | Determines whether any popup is currently open. |
| `void OpenPopup<T>()` | _No documentation available._ |
| `void OpenPopup<T>(Nullable<ViewModelContext> context)` | _No documentation available._ |
| `void OpenPopup(Type type, Nullable<ViewModelContext> context)` | Opens `type` as a popup. |
| `void OpenSettings()` | Opens the settings popup on the main page. |
| `void OpenSettings<T>()` | Opens the settings popup on the main page. |
| `void OpenSettings<T>(ViewModelContext context)` | _No documentation available._ |
| `void OpenSettings(Type type)` | Opens the settings popup on the page that matches the view model specified by `type`. |
| `void OpenSettings(Type type, ViewModelContext context)` | Opens the settings popup on the page that matches the view model specified by `type`. |
| `void ReloadCollections()` | Reloads collection ui. |
| `void RemoveNotification(Notification notification)` | Removes the notification with the specified id. |

---
# ASMWindowElementAttribute
<!--
source: API\Editor\UI\ASMWindowElementAttribute.md
-->

## ASMWindowElementAttribute

`class` in `AdvancedSceneManager.Editor.UI`  /  Inherits from: `DiscoverableAttribute`### Description
Specifies a method or view model class that should be used as a callback to insert a visual element into the ASM window.

<b> Remarks:</b>
When specified on a class it should inherit `ViewModel`.

### Properties

| Member | Description |
|--------|-------------|
| `boolean canToggleVisible` | Gets if this element can be toggled visible or hidden. |
| `int32 defaultOrder` | Specifies default order. |
| `string friendlyDescription` | Specifies the description to be shown in the diag UI tooltip. |
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
| `virtual boolean IsValidTarget(MemberInfo member)` | Gets if `member` is a valid target for this attribute callback. |

---
# DragReferenceManipulator
<!--
source: API\Editor\UI\DragReferenceManipulator.md
-->

## DragReferenceManipulator

`class` in `AdvancedSceneManager.Editor.UI`  /  Inherits from: `PointerManipulator`### Description
Gives user a `ScriptableObject` reference on drag.

<b> Remarks:</b>
Only available in editor.

---
# ElementLocation
<!--
source: API\Editor\UI\ElementLocation.md
-->

## ElementLocation

`enum` in `AdvancedSceneManager.Editor.UI`  /  Inherits from: `Enum`### Description
Specifies location for a custom element in the ASM window.

### Static Fields

| Member | Description |
|--------|-------------|
| `ElementLocation Collection` | Specifies that the custom element should be located in the collection headers the ASM window, on the right side. |
| `ElementLocation CollectionLeft` | Specifies that the custom element should be located in the collection fields of the ASM window, on the left side. |
| `ElementLocation CollectionRight` | Specifies that the custom element should be located in the collection headers the ASM window, on the right side. |
| `ElementLocation Footer` | Specifies that the custom element should be located in the footer of the ASM window. |
| `ElementLocation Header` | Specifies that the custom element should be located in the header of the ASM window. |
| `ElementLocation Scene` | Specifies that the custom element should be located in the scene fields of the ASM window, on the right side. |
| `ElementLocation SceneLeft` | Specifies that the custom element should be located in the scene fields of the ASM window, on the left side. |
| `ElementLocation SceneRight` | Specifies that the custom element should be located in the scene fields of the ASM window, on the right side. |
| `ElementLocation Settings` | Specifies that the custom element should be considered a settings page. It will be accessible as a category in the main settings page. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# Notification
<!--
source: API\Editor\UI\Notification.md
-->

## Notification

`class` in `AdvancedSceneManager.Editor.UI`### Description
Represents a notification to be displayed.

### Fields

| Member | Description |
|--------|-------------|
| `boolean allowTextClippingIntoMenuButton` | Whether text may overlap the menu button area. |
| `boolean canDismiss` | Whether the notification can be dismissed by the user. |
| `boolean canMute` | Whether the notification can be muted. |
| `boolean dismissOnClick` | Whether the notification is dismissed when clicked. |
| `string fontAwesomeIcon` | Specifies an optional Font Awesome icon name. |
| `string iconFont` | Specifies an optional font name for the icon. |
| `string iconInfo` | Specifies an optional icon info identifier. |
| `string id` | Unique identifier for the notification. |
| `NotificationImportance importance` | Specifies the importance level of the notification. |
| `Nullable<boolean> isExpanded` | Whether the notification is expanded, if applicable. |
| `NotificationKind kind` | Specifies the visual kind of the notification. |
| `string message` | Displayed message text. |
| `Action onClick` | Action invoked when the notification is clicked. |
| `Action onDismiss` | Action invoked when the notification is dismissed. |

---
# NotificationImportance
<!--
source: API\Editor\UI\NotificationImportance.md
-->

## NotificationImportance

`enum` in `AdvancedSceneManager.Editor.UI`  /  Inherits from: `Enum`### Description
Specifies the importance of a notification.

### Static Fields

| Member | Description |
|--------|-------------|
| `NotificationImportance Default` | Determines that the notification will be displayed in non-overflow view when space allows, otherwise overflow menu. |
| `NotificationImportance High` | Determines that the notification will never overflow. |
| `NotificationImportance Low` | Determines that the notification will never be displayed in non-overflow view. |
| `NotificationImportance Priority` | Determines that the notification is to be prioritized. Prioritized notifications hide all others until dismissed or removed. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# NotificationKind
<!--
source: API\Editor\UI\NotificationKind.md
-->

## NotificationKind

`enum` in `AdvancedSceneManager.Editor.UI`  /  Inherits from: `Enum`### Description
Specifies the kind of notification.

<b> Remarks:</b>
Only available in the editor.

### Static Fields

| Member | Description |
|--------|-------------|
| `NotificationKind Default` | Does not indicate anything in particular. Displays no icon. |
| `NotificationKind FixUp` | Indicates a warning or fixable issue. Displays a warning icon. |
| `NotificationKind Info` | Indicates informational content. Displays an info icon. |
| `NotificationKind Link` | Indicates a link to something. Displays a link icon. |
| `NotificationKind Profile` | Indicates something related to profiles. Displays a profile icon. |
| `NotificationKind Scene` | Indicates something related to scenes. Displays a scene icon. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# UIElementUtility
<!--
source: API\Editor\UI\UIElementUtility.md
-->

## UIElementUtility

`static class` in `AdvancedSceneManager.Editor.UI`### Description
Provides utility methods for working with `VisualElement`.

### Static Methods

| Member | Description |
|--------|-------------|
| `T UseFontAwesome<T>(T element, Nullable<boolean> solid, Nullable<boolean> regular, Nullable<boolean> brands)` | _No documentation available._ |

---
# AssetDatabaseUtility
<!--
source: API\Editor\Utility\AssetDatabaseUtility.md
-->

## AssetDatabaseUtility

`static class` in `AdvancedSceneManager.Editor.Utility`### Description
Contains utility functions for working with the asset database.

<b> Remarks:</b>
Only available in the editor.

### Static Methods

| Member | Description |
|--------|-------------|
| `string ConvertToUnixPath(string path)` | Converts the path separators to use forward slash. |
| `boolean CreateFolder(string folder)` | _No documentation available._ |
| `boolean CreateFolder(string path, String& createdFolder)` | _No documentation available._ |
| `IEnumerable<string> FindAssetPaths<T>(string[] searchInFolders)` | _No documentation available._ |
| `IEnumerable<T> FindAssets<T>()` | _No documentation available._ |
| `IEnumerable<T> FindAssets<T>(string[] searchInFolders)` | _No documentation available._ |
| `string MakeRelative(string path, boolean includeAssetsFolder, boolean prefixWithAssetsIfNecessary)` | Makes the path absolute. Converts path to unix style. |
| `void ShowFolder(string folderPath)` | Shows the folder and selects the asset. |
| `void ShowFolder(object obj)` | Shows the folder and selects the asset. |

---
# BuildUtility
<!--
source: API\Editor\Utility\BuildUtility.md
-->

## BuildUtility

`static class` in `AdvancedSceneManager.Editor.Utility`### Description
Provides functions for building, and build events.

<b> Remarks:</b>
Only available in editor.

### Static Events

| Member | Description |
|--------|-------------|
| `event Action<PostBuildEventArgs> postBuild` | Occurs after build. |
| `event Action<BuildReport> preBuild` | Occurs before build. |

### Static Methods

| Member | Description |
|--------|-------------|
| `void CleanupASMBuildAssets()` | _No documentation available._ |
| `BuildReport DoBuild(string path, boolean attachProfiler, boolean runGameWhenBuilt, boolean dev, BuildOptions customOptions)` | Performs a build of the active build profile if one exists, otherwise falls back to Unity's legacy build pipeline. |
| `BuildReport DoBuild(BuildPlayerOptions opts)` | Performs a build using the legacy `BuildPlayerOptions` API. |
| `BuildReport DoBuild(BuildPlayerWithProfileOptions options)` | _No documentation available._ |
| `IEnumerable<ValueTuple<EditorBuildSettingsScene, Reason>> GetOrderedList()` | Gets an ordered list of all scenes that ASM would set in the build settings. |
| `boolean IsEnabled(string path, Reason& reason)` | _No documentation available._ |
| `boolean IsIncluded(Scene scene, Reason& reason)` | _No documentation available._ |
| `void PrepareASMForBuild()` | _No documentation available._ |
| `void UpdateSceneList()` | Updates the scene build settings. |
| `void UpdateSceneList(boolean ignorePlayModeCheck, boolean force)` | Updates the scene build settings from the ASM profile. |

---
# CodeEditorUtility
<!--
source: API\Editor\Utility\CodeEditorUtility.md
-->

## CodeEditorUtility

`static class` in `AdvancedSceneManager.Editor.Utility`### Description
Provides utility methods for opening the code editor on a method.

### Static Methods

| Member | Description |
|--------|-------------|
| `void OpenInCodeEditor(Exception exception)` | Opens the code editor to the top frame of a given exception. |
| `void OpenInCodeEditor(MemberInfo member)` | Opens the code editor to a specific member (e.g., method, property, or type). |

---
# HierarchyGameObjectGUI
<!--
source: API\Editor\Utility\HierarchyGameObjectGUI.md
-->

## HierarchyGameObjectGUI

`sealed class` in `AdvancedSceneManager.Editor.Utility`  /  Inherits from: `MulticastDelegate`### Description

### Methods

| Member | Description |
|--------|-------------|
| `virtual IAsyncResult BeginInvoke(GameObject gameObject, AsyncCallback callback, object object)` | _No documentation available._ |
| `virtual void EndInvoke(IAsyncResult result)` | _No documentation available._ |
| `virtual void Invoke(GameObject gameObject)` | _No documentation available._ |

---
# HierarchyGUIUtility
<!--
source: API\Editor\Utility\HierarchyGUIUtility.md
-->

## HierarchyGUIUtility

`static class` in `AdvancedSceneManager.Editor.Utility`### Description
An utility for adding extra icons to scene fields in the hierarchy window.

<b> Remarks:</b>
Only available in editor.

### Static Properties

| Member | Description |
|--------|-------------|
| `GUIStyle defaultStyle { get; }` | The default style for text in hierarchy. |

### Static Methods

| Member | Description |
|--------|-------------|
| `void AddGameObjectGUI(HierarchyGameObjectGUI onGUI, int32 index)` | _No documentation available._ |
| `void AddSceneGUI(HierarchySceneGUI onGUI, int32 index)` | _No documentation available._ |
| `boolean GetObj(int32 instanceID, Object& obj, String& name, String& scenePath)` | _No documentation available._ |
| `void RemoveGameObjectGUI(HierarchyGameObjectGUI onGUI)` | _No documentation available._ |
| `void RemoveSceneGUI(HierarchySceneGUI onGUI)` | _No documentation available._ |
| `void Repaint()` | Can be used to ensure repaint of the HierarchyWindow. |

---
# HierarchySceneGUI
<!--
source: API\Editor\Utility\HierarchySceneGUI.md
-->

## HierarchySceneGUI

`sealed class` in `AdvancedSceneManager.Editor.Utility`  /  Inherits from: `MulticastDelegate`### Description

### Methods

| Member | Description |
|--------|-------------|
| `virtual IAsyncResult BeginInvoke(Scene scene, AsyncCallback callback, object object)` | _No documentation available._ |
| `virtual void EndInvoke(IAsyncResult result)` | _No documentation available._ |
| `virtual void Invoke(Scene scene)` | _No documentation available._ |

---
# LockUtility
<!--
source: API\Editor\Utility\LockUtility.md
-->

## LockUtility

`static class` in `AdvancedSceneManager.Editor.Utility`### Description
A utility for locking scenes and collections from modification.

<b> Remarks:</b>
Only modification from within unity is prevented.

### Static Methods

| Member | Description |
|--------|-------------|
| `void Lock(ILockable obj, string message, boolean prompt)` | Locks the object. |
| `void Toggle(ILockable obj, boolean prompt)` | Toggles lock status of the object. |
| `void Unlock(ILockable obj, boolean prompt)` | Unlocks the object. |

---
# LogEntry
<!--
source: API\Editor\Utility\LogEntry.md
-->

## LogEntry

`class` in `AdvancedSceneManager.Editor.Utility`### Description

### Properties

| Member | Description |
|--------|-------------|
| `string condition` | _No documentation available._ |
| `string stacktrace` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual LogEntry <Clone>$()` | _No documentation available._ |
| `void Deconstruct(String& condition, String& stacktrace)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `virtual boolean Equals(LogEntry other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# PostBuildEventArgs
<!--
source: API\Editor\Utility\PostBuildEventArgs.md
-->

## PostBuildEventArgs

`class` in `AdvancedSceneManager.Editor.Utility`### Description

### Properties

| Member | Description |
|--------|-------------|
| `LogEntry[] error` | _No documentation available._ |
| `BuildReport report` | _No documentation available._ |
| `LogEntry[] warning` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual PostBuildEventArgs <Clone>$()` | _No documentation available._ |
| `void Deconstruct(BuildReport& report, LogEntry[]& warning, LogEntry[]& error)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `virtual boolean Equals(PostBuildEventArgs other)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual string ToString()` | _No documentation available._ |

---
# Reason
<!--
source: API\Editor\Utility\Reason.md
-->

## Reason

`enum` in `AdvancedSceneManager.Editor.Utility`  /  Inherits from: `Enum`### Description

### Static Fields

| Member | Description |
|--------|-------------|
| `Reason Default` | _No documentation available._ |
| `Reason IncludedInProfile` | _No documentation available._ |
| `Reason InvalidScene` | _No documentation available._ |
| `Reason NotIncludedInProfile` | _No documentation available._ |
| `Reason SceneLoaderOverride` | _No documentation available._ |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# CollectionOpen
<!--
source: API\ExampleScripts\CollectionOpen.md
-->

## CollectionOpen

`class` in `AdvancedSceneManager.ExampleScripts`  /  Inherits from: `MonoBehaviour`### Description
Contains examples for opening collections.

### Fields

| Member | Description |
|--------|-------------|
| `SceneCollection collectionToOpen` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void ChainingExample()` | _No documentation available._ |
| `void Open()` | _No documentation available._ |
| `void OpenWithLoadingScreen(LoadingScreenReference loadingScreen)` | _No documentation available._ |
| `void OpenWithUserData(ScriptableObject scriptableObject)` | _No documentation available._ |
| `void ToggleOpen()` | _No documentation available._ |

---
# DoActionsWithLoadingScreen
<!--
source: API\ExampleScripts\DoActionsWithLoadingScreen.md
-->

## DoActionsWithLoadingScreen

`class` in `AdvancedSceneManager.ExampleScripts`### Description
Contains examples for doing `Action` with loading screen.

### Fields

| Member | Description |
|--------|-------------|
| `LoadingScreenReference loadingScreen` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void DoActionWithLoadingScreen()` | _No documentation available._ |
| `void DoCoroutineWithLoadingScreen()` | _No documentation available._ |

---
# SceneLoader
<!--
source: API\ExampleScripts\SceneLoader.md
-->

## SceneLoader

`static class` in `AdvancedSceneManager.ExampleScripts`### Description
Contains examples of how to override scene loading.

---
# SceneOpen
<!--
source: API\ExampleScripts\SceneOpen.md
-->

## SceneOpen

`class` in `AdvancedSceneManager.ExampleScripts`  /  Inherits from: `MonoBehaviour`### Description
Contains examples for opening scenes.

### Fields

| Member | Description |
|--------|-------------|
| `Scene sceneToOpen` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void ChainingExample()` | _No documentation available._ |
| `void OpenSingle()` | _No documentation available._ |
| `void OpenStandalone()` | _No documentation available._ |
| `void OpenWithLoadingScreen(LoadingScreenReference loadingScreen)` | _No documentation available._ |
| `void Toggle()` | _No documentation available._ |

---
# ScenePreload
<!--
source: API\ExampleScripts\ScenePreload.md
-->

## ScenePreload

`class` in `AdvancedSceneManager.ExampleScripts`  /  Inherits from: `MonoBehaviour`### Description
Contains examples for preloading scenes.

### Static Properties

| Member | Description |
|--------|-------------|
| `boolean hasPreloadedScene` | _No documentation available._ |

### Fields

| Member | Description |
|--------|-------------|
| `Scene SceneToPreload` | _No documentation available._ |

### Static Methods

| Member | Description |
|--------|-------------|
| `void CancelPreloadStatically(Scene scene)` | _No documentation available._ |
| `void FinishPreloadStatically(Scene scene)` | _No documentation available._ |
| `void StartPreloadStatically(Scene scene)` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void CancelPreloadCoroutine()` | _No documentation available._ |
| `void FinishPreloadCoroutine()` | _No documentation available._ |
| `void StartPreloadCoroutine()` | _No documentation available._ |

---
# IFadeLoadingScreen
<!--
source: API\Loading\IFadeLoadingScreen.md
-->

## IFadeLoadingScreen

`interface` in `AdvancedSceneManager.Loading`### Description
Used to pass arguments from [Color})](https://learn.microsoft.com/dotnet/api/m:advancedscenemanager.utility.loadingscreenutility.fadein(advancedscenemanager.loading.loadingscreenreference,system.single,system.nullable{unityengine.color}))

### Properties

| Member | Description |
|--------|-------------|
| `Color color` | Specifies the color of the fade. |
| `single fadeDuration` | Specifies the fade duration. |

---
# ILoadProgressData
<!--
source: API\Loading\ILoadProgressData.md
-->

## ILoadProgressData

`interface` in `AdvancedSceneManager.Loading`### Description
Represents progress in ASM. Used for `ILoadProgressListener`.

### Properties

| Member | Description |
|--------|-------------|
| `single value` | The current load percent. |

---
# ILoadProgressListener
<!--
source: API\Loading\ILoadProgressListener.md
-->

## ILoadProgressListener

`interface` in `AdvancedSceneManager.Loading`### Description
Represents a listener for when progress changes.

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual void OnProgressChanged(ILoadProgressData progress)` | Called when progress has changed. |

---
# LoadingScreen
<!--
source: API\Loading\LoadingScreen.md
-->

## LoadingScreen

`abstract class` in `AdvancedSceneManager.Loading`  /  Inherits from: `LoadingScreenBase`### Description
A class that contains callbacks for loading screens.

<b> Remarks:</b>
`SplashScreen` and `LoadingScreen` cannot co-exist within the same scene.

### Properties

| Member | Description |
|--------|-------------|
| `SceneOperation operation { get; }` | The current scene operation that this loading screen is associated with. May be null for the first few frames, before loading has actually begun. |

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual IEnumerator OnClose()` | Called when loading scene is closed. |
| `abstract virtual IEnumerator OnOpen()` | Called when loading scene is opened. |
| `virtual void OnValidate()` | _No documentation available._ |

---
# LoadingScreenAttribute
<!--
source: API\Loading\LoadingScreenAttribute.md
-->

## LoadingScreenAttribute

`sealed class` in `AdvancedSceneManager.Loading`  /  Inherits from: `LoadingScreenAttributeBase`### Description
Defines a loading screen.

---
# LoadingScreenAttributeBase
<!--
source: API\Loading\LoadingScreenAttributeBase.md
-->

## LoadingScreenAttributeBase

`abstract class` in `AdvancedSceneManager.Loading`  /  Inherits from: `DiscoverableAttribute`### Description
Defines the base for a loading screen discoverable.

### Properties

| Member | Description |
|--------|-------------|
| `string displayName` | The name to display when picking a loading screen and for the host scene when open. |
| `string displayType` | Gets a human-readable type name for this screen (for example, "Splash Screen" or "Loading Screen"). |
| `string effectiveDisplayName` | The effective display name, falls back to type name if `displayName` is empty. |
| `boolean isLoadingScreen` | Gets whether this attribute defines a loading screen. |
| `boolean isSplashScreen` | Gets whether this attribute defines a splash screen. |

---
# LoadingScreenBase
<!--
source: API\Loading\LoadingScreenBase.md
-->

## LoadingScreenBase

`abstract class` in `AdvancedSceneManager.Loading`  /  Inherits from: `MonoBehaviour`### Description
A generic base class for loading screens. You probably want to inherit from `LoadingScreen` though.

<b> Remarks:</b>
When multiple loading screens exist within the same scene, only the first found one will be used.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isClosing { get; }` | Gets whatever we're currently closing. |
| `boolean isOpen { get; }` | Gets whatever we're currently open. |
| `boolean isOpening { get; }` | Gets whatever we're currently opening. |

### Fields

| Member | Description |
|--------|-------------|
| `Canvas canvas` | The canvas that this loading screen uses.

This will automatically register canvas with `CanvasSortOrderUtility`, to automatically manage canvas sort order. |

### Methods

| Member | Description |
|--------|-------------|
| `boolean HasPressedAnyKey()` | Gets if any key has been pressed this frame. |
| `abstract virtual IEnumerator OnClose()` | Called when the loading screen is about to close. |
| `abstract virtual IEnumerator OnOpen()` | Called when the loading screen is opened. |
| `virtual void OnProgressChanged(ILoadProgressData progress)` | Called when progress changes for the associated scene operation. |
| `WaitUntil WaitForAnyKey()` | Returns `WaitUntil` that waits for user to press any key. |

---
# LoadingScreenConfigBag
<!--
source: API\Loading\LoadingScreenConfigBag.md
-->

## LoadingScreenConfigBag

`abstract class` in `AdvancedSceneManager.Loading`### Description
Base class for loading screen config bags.

### Fields

| Member | Description |
|--------|-------------|
| `boolean displayInEditor` | _No documentation available._ |
| `PanelSettings panelSettings` | _No documentation available._ |
| `int32 sortOrder` | _No documentation available._ |

---
# LoadingScreenReference
<!--
source: API\Loading\LoadingScreenReference.md
-->

## LoadingScreenReference

`struct` in `AdvancedSceneManager.Loading`  /  Inherits from: `ValueType`### Description
Represents a loading screen.

### Properties

| Member | Description |
|--------|-------------|
| `LoadingScreenConfigBag config` | _No documentation available._ |
| `DiscoveredMember discoverable` | _No documentation available._ |
| `LoadingScreenBase instance` | _No documentation available._ |
| `boolean isDiscoverable` | _No documentation available._ |
| `boolean isScene` | _No documentation available._ |
| `boolean isValid` | _No documentation available._ |
| `string name` | _No documentation available._ |
| `Scene scene` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `boolean Equals(LoadingScreenReference other)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `virtual int32 GetHashCode()` | _No documentation available._ |

---
# LoadingScreenViewModel
<!--
source: API\Loading\LoadingScreenViewModel.md
-->

## LoadingScreenViewModel

`abstract class` in `AdvancedSceneManager.Loading`  /  Inherits from: `ViewModel`### Description
The base class for loading screen view models.

### Properties

| Member | Description |
|--------|-------------|
| `boolean handleDisplayInEditorAutomatically` | Determines whether ASM should automatically handle editor-only display logic based on `displayInEditor`. |
| `UIDocument uiDocument { get; }` | Gets the `UIDocument` that is rendering the view. |

### Methods

| Member | Description |
|--------|-------------|
| `void EnsureCameraExists()` | Ensures that a camera exists for rendering this loading screen. |

---
# LoadingScreenViewModel_Of_T
<!--
source: API\Loading\LoadingScreenViewModel_Of_T.md
-->

## LoadingScreenViewModel`1

`abstract class` in `AdvancedSceneManager.Loading`  /  Inherits from: `LoadingScreenViewModel`### Description
The base class for loading screen view models.

### Properties

| Member | Description |
|--------|-------------|
| `T configBag` | Gets the configuration bag for this loading screen. If no configuration has been provided, a default instance is created. |

---
# MessageLoadProgressData
<!--
source: API\Loading\MessageLoadProgressData.md
-->

## MessageLoadProgressData

`struct` in `AdvancedSceneManager.Loading`  /  Inherits from: `ValueType`### Description
An implementation of `ILoadProgressData` that provides a string message.

### Properties

| Member | Description |
|--------|-------------|
| `string message` | The message of this report. |
| `single value` | The reported progress value. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual string ToString()` | _No documentation available._ |

---
# ProgressScope
<!--
source: API\Loading\ProgressScope.md
-->

## ProgressScope

`class` in `AdvancedSceneManager.Loading`### Description
Represents a listener for progress that can calculate the total progress of a scene operation.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isRegistered { get; }` | Gets if this progress scope is registered. |
| `int32 operationCount` | Gets the amount of scenes that will be either unloaded or loaded. |
| `IEnumerable<Scene> scenesExpectedToLoad` | Gets the scenes that are expected to be loaded. |
| `IEnumerable<Scene> scenesExpectedToUnload` | Gets the scenes that are expected to be unloaded. |
| `boolean stopListenerWhenDisposed` | Gets or sets whatever the listener should be unregistered in `Dispose`. Default `true` |
| `single totalProgress { get; }` | Gets the calculated total progress of this progress scope. |

### Methods

| Member | Description |
|--------|-------------|
| `void Dispose()` | Stops listening to progress reports. |
| `ProgressScope Expect(SceneOperationKind kind, SceneCollection collection, boolean openAll, boolean isAdditive)` | Expect scenes in `collection`. |
| `ProgressScope Expect(SceneOperationKind kind, Scene[] scene)` | Expect `scene`. |
| `ProgressScope Expect(SceneOperationKind kind, IEnumerable<Scene> scenes)` | Expect `scenes`. |
| `single GetSubProgress(SceneOperationKind kind, Scene scene)` | Gets the progress of a specific scene. |
| `void OnProgressChanged(Action<single> callback)` | Adds a callback when progress changed. |
| `void RemoveOnProgressChangedCallback(Action<single> callback)` | Removes a callback when progress changed. |
| `ProgressScope StartListener()` | Starts listening to progress reports. |
| `ProgressScope StopListener()` | Stops listening to progress reports. |

---
# SceneLoadProgressData
<!--
source: API\Loading\SceneLoadProgressData.md
-->

## SceneLoadProgressData

`struct` in `AdvancedSceneManager.Loading`  /  Inherits from: `ValueType`### Description
The default implementation of `ILoadProgressData`, used by ASM in most cases.

### Properties

| Member | Description |
|--------|-------------|
| `SceneOperation operation` | The operation that started this operation. |
| `SceneOperationKind operationKind` | The kind of operation this is. |
| `Scene scene` | The scene that is being loaded or unloaded. Can be null. |
| `single value` | The reported progress value. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual string ToString()` | _No documentation available._ |

---
# SerializableLoadingScreenReference
<!--
source: API\Loading\SerializableLoadingScreenReference.md
-->

## SerializableLoadingScreenReference

`class` in `AdvancedSceneManager.Loading`### Description

### Fields

| Member | Description |
|--------|-------------|
| `LoadingScreenConfigBag config` | _No documentation available._ |
| `DiscoveredMember discoverable` | _No documentation available._ |
| `Scene scene` | _No documentation available._ |

---
# SplashScreen
<!--
source: API\Loading\SplashScreen.md
-->

## SplashScreen

`abstract class` in `AdvancedSceneManager.Loading`  /  Inherits from: `LoadingScreenBase`### Description
A class that contains callbacks for splash screens.

<b> Remarks:</b>
`SplashScreen` and `LoadingScreen` cannot coexist within the same scene.

### Methods

| Member | Description |
|--------|-------------|
| `abstract virtual IEnumerator OnClose()` | Called when splash scene is about to close. |
| `abstract virtual IEnumerator OnOpen()` | Called when splash scene is opened. |
| `virtual void OnValidate()` | _No documentation available._ |

---
# SplashScreenAttribute
<!--
source: API\Loading\SplashScreenAttribute.md
-->

## SplashScreenAttribute

`sealed class` in `AdvancedSceneManager.Loading`  /  Inherits from: `LoadingScreenAttributeBase`### Description
Defines a splash screen.

---
# ASMSplashScreen
<!--
source: API\Loading\UI\ASMSplashScreen.md
-->

## ASMSplashScreen

`class` in `AdvancedSceneManager.Loading.UI`  /  Inherits from: `LoadingScreenViewModel<ConfigBag>`### Description
A splash screen that displays the ASM logo.

<b> Remarks:</b>
A default splash screen.

### Properties

| Member | Description |
|--------|-------------|
| `VisualTreeAsset template` | Gets the UXML template asset for this view model. |

---
# ConfigBag
<!--
source: API\Loading\UI\ConfigBag.md
-->

## ConfigBag

`class` in `AdvancedSceneManager.Loading.UI`  /  Inherits from: `LoadingScreenConfigBag`### Description

### Fields

| Member | Description |
|--------|-------------|
| `Color color` | _No documentation available._ |
| `single fadeInDuration` | _No documentation available._ |
| `single fadeOutDuration` | _No documentation available._ |

---
# FadeLoadingScreen
<!--
source: API\Loading\UI\FadeLoadingScreen.md
-->

## FadeLoadingScreen

`class` in `AdvancedSceneManager.Loading.UI`  /  Inherits from: `LoadingScreenViewModel<ConfigBag>`### Description
A loading screen that fades the screen in and out.

<b> Remarks:</b>
A default loading screen.

### Properties

| Member | Description |
|--------|-------------|
| `VisualTreeAsset template` | Gets the UXML template asset for this view model. |

---
# FadeSplashScreen
<!--
source: API\Loading\UI\FadeSplashScreen.md
-->

## FadeSplashScreen

`class` in `AdvancedSceneManager.Loading.UI`  /  Inherits from: `LoadingScreenViewModel<ConfigBag>`### Description
A splash screen that fades the screen in and out.

<b> Remarks:</b>
A default splash screen.

### Properties

| Member | Description |
|--------|-------------|
| `VisualTreeAsset template` | Gets the UXML template asset for this view model. |

---
# Log
<!--
source: API\Log.md
-->

## Log

`static class` in `AdvancedSceneManager`### Description
Provides simple logging methods with support for development-only logs.

<b> Remarks:</b>
Only available in #ASM_DEV.

### Static Methods

| Member | Description |
|--------|-------------|
| `void Assert(boolean assertion, string message)` | _No documentation available._ |
| `LogTimer Duration(string logMessage, boolean onlyLogInDev, Func<TimeSpan, string> toStringOverride, boolean logStackTrace)` | _No documentation available._ |
| `LogTimer Duration()` | _No documentation available._ |
| `void Error(string message, boolean onlyLogInDev, boolean logStackTrace)` | _No documentation available._ |
| `void Exception(Exception ex, boolean onlyLogInDev)` | _No documentation available._ |
| `void Exception(Exception ex, string message, boolean onlyLogInDev)` | _No documentation available._ |
| `void Info(string callerName)` | Logs the calling method name to console. |
| `void Info(object obj, boolean onlyLogInDev, boolean logStackTrace)` | _No documentation available._ |
| `boolean IsDev()` | _No documentation available._ |
| `void List(IEnumerable list, string header, string separator, boolean logStackTrace, boolean onlyLogInDev)` | _No documentation available._ |
| `void List(IList list, string header, string separator, boolean logStackTrace, boolean onlyLogInDev)` | _No documentation available._ |
| `void List<T>(T[] list, string header, string separator, boolean logStackTrace, boolean onlyLogInDev)` | _No documentation available._ |
| `void Warning(string message, boolean onlyLogInDev, boolean logStackTrace)` | _No documentation available._ |

---
# LogTimer
<!--
source: API\LogTimer.md
-->

## LogTimer

`sealed class` in `AdvancedSceneManager`### Description

### Properties

| Member | Description |
|--------|-------------|
| `TimeSpan Elapsed` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void Stop()` | _No documentation available._ |

---
# ASMModel
<!--
source: API\Models\ASMModel.md
-->

## ASMModel

`abstract class` in `AdvancedSceneManager.Models`  /  Inherits from: `ASMModelBase`### Description
Serves as the abstract base class for models that can be opened, closed, and preloaded.

### Properties

| Member | Description |
|--------|-------------|
| `boolean isOpen` | _No documentation available._ |
| `boolean isPreloaded` | _No documentation available._ |
| `boolean isQueued` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual void _CancelPreload()` | Cancels all active preloads. |
| `virtual void _Close()` | Closes this asset. |
| `virtual void _FinishPreload()` | Finishes all active preloads. |
| `virtual void _Open()` | Opens this asset. |
| `virtual void _Preload()` | Preloads this asset. |
| `virtual void _Reopen()` | Reopens this asset. |
| `virtual void _ToggleOpen()` | Toggles this asset open or closed. |
| `virtual SceneOperation CancelPreload()` | Cancels all active preloads. |
| `abstract virtual SceneOperation Close()` | Closes this asset. |
| `virtual SceneOperation FinishPreload()` | Finishes all active preloads. |
| `abstract virtual SceneOperation Open()` | Opens this asset. |
| `abstract virtual SceneOperation Preload()` | Preloads this asset. |
| `abstract virtual SceneOperation Reopen()` | Reopens this asset. |
| `abstract virtual SceneOperation ToggleOpen()` | Toggles this asset open or closed. |

---
# ASMModelExtensions
<!--
source: API\Models\ASMModelExtensions.md
-->

## ASMModelExtensions

`static class` in `AdvancedSceneManager.Models`### Description
Provides utility methods for working with `SceneCollection`.

### Static Methods

| Member | Description |
|--------|-------------|
| `void Add<T>(T collection, Scene[] scenes)` | _No documentation available._ |
| `void AddEmptyScene<T>(T collection)` | _No documentation available._ |
| `SceneOperation CloseAll(IEnumerable<Scene> scenes)` | Closes the `scenes`. |
| `SceneOperation CloseAll(IEnumerable<Scene> scenes, LoadingScreenReference loadingScreen)` | Closes the `scenes`. |
| `int32 IndexOf<T>(T collection, Scene scene)` | _No documentation available._ |
| `void Insert<T>(T collection, int32 index, Scene scene)` | _No documentation available._ |
| `void Move<T>(T collection, int32 oldIndex, int32 newIndex)` | _No documentation available._ |
| `SceneOperation OpenAdditive(IEnumerable<SceneCollection> collections)` | Opens the `collections` as additive. |
| `SceneOperation OpenAdditive(IEnumerable<SceneCollection> collections, SceneCollection activeCollection)` | Opens the `collections` as additive. |
| `SceneOperation OpenAdditive(IEnumerable<SceneCollection> collections, SceneCollection activeCollection, Scene loadingScene)` | Opens the `collections` as additive. |
| `SceneOperation OpenAll(IEnumerable<Scene> scenes)` | Opens the `scenes`. |
| `SceneOperation OpenAll(IEnumerable<Scene> scenes, LoadingScreenReference loadingScreen)` | Opens the `scenes`. |
| `SceneOperation OpenWithAdditive(SceneCollection collection, SceneCollection[] extraAdditiveCollections)` | Opens this `collection` and then opens `extraAdditiveCollections` as additive. |
| `void Remove<T>(T collection, Scene scene)` | _No documentation available._ |
| `void RemoveAt<T>(T collection, int32 index)` | _No documentation available._ |
| `boolean Replace<T>(T collection, int32 index, Scene scene)` | _No documentation available._ |

---
# ASMSceneHelper
<!--
source: API\Models\ASMSceneHelper.md
-->

## ASMSceneHelper

`class` in `AdvancedSceneManager.Models`  /  Inherits from: `ScriptableObject`### Description
Provides helper methods for opening, closing, and managing scenes and collections.
            Intended for use from `UnityEvent`.

### Static Properties

| Member | Description |
|--------|-------------|
| `ASMSceneHelper instance` | Gets the global instance of `ASMSceneHelper`. |

### Properties

| Member | Description |
|--------|-------------|
| `string name` | The name of the object. |

### Methods

| Member | Description |
|--------|-------------|
| `void _Activate(Scene scene)` | _No documentation available._ |
| `void _CancelPreload()` | Cancels the preload. All preloaded scenes will be fully loaded (limitation by Unity), then closed. No ASM scene callbacks will be called. |
| `void _Close(SceneCollection collection)` | _No documentation available._ |
| `void _Close(Scene scene)` | _No documentation available._ |
| `void _FinishPreload()` | _No documentation available._ |
| `void _Open(SceneCollection collection)` | _No documentation available._ |
| `void _Open(Scene scene)` | _No documentation available._ |
| `void _OpenAdditive(SceneCollection collection)` | _No documentation available._ |
| `void _OpenAndActivate(Scene scene)` | _No documentation available._ |
| `void _Preload(SceneCollection collection)` | _No documentation available._ |
| `void _Preload(Scene scene)` | _No documentation available._ |
| `void _PreloadAdditive(SceneCollection collection)` | _No documentation available._ |
| `void _Reopen(SceneCollection collection)` | _No documentation available._ |
| `void _Reopen(Scene scene)` | _No documentation available._ |
| `void _ToggleOpen(SceneCollection collection)` | _No documentation available._ |
| `void _ToggleOpen(Scene scene)` | _No documentation available._ |
| `void Activate(Scene scene)` | _No documentation available._ |
| `SceneOperation CancelPreload()` | Cancels the preload. All preloaded scenes will be fully loaded (limitation by Unity), then closed. No ASM scene callbacks will be called. |
| `SceneOperation Close(SceneCollection collection)` | _No documentation available._ |
| `SceneOperation Close(Scene scene)` | _No documentation available._ |
| `SceneOperation CloseWithLoadingScreen(Scene scene, Scene loadingScene)` | _No documentation available._ |
| `SceneOperation FinishPreload()` | _No documentation available._ |
| `void Open(SceneCollection collection)` | _No documentation available._ |
| `SceneOperation Open(SceneCollection collection, boolean openAll)` | Opens the specified collection. |
| `SceneOperation Open(Scene scene)` | _No documentation available._ |
| `SceneOperation OpenAdditive(SceneCollection collection, boolean openAll)` | Opens the collection as additive. |
| `void OpenAdditive(SceneCollection collection)` | _No documentation available._ |
| `SceneOperation OpenAndActivate(Scene scene)` | _No documentation available._ |
| `void OpenWhereNameStartsWith(string name)` | Opens all scenes whose names start with the specified string. |
| `SceneOperation OpenWithLoadingScreen(Scene scene, Scene loadingScene)` | _No documentation available._ |
| `SceneOperation Preload(SceneCollection collection, boolean openAll)` | Preloads the specified collection. |
| `SceneOperation Preload(Scene scene, Action onPreloaded)` | Preloads the scene. |
| `SceneOperation PreloadAdditive(SceneCollection collection, boolean openAll)` | Preloads the collection as additive. |
| `void Quit()` | _No documentation available._ |
| `void Reopen(SceneCollection collection)` | _No documentation available._ |
| `SceneOperation Reopen(Scene scene)` | _No documentation available._ |
| `void Restart()` | _No documentation available._ |
| `void RestartCollection()` | Reopens the currently active `openCollection`. |
| `SceneOperation ToggleOpen(SceneCollection collection, boolean openAll)` | Toggles the collection open or closed. |
| `SceneOperation ToggleOpen(SceneCollection collection)` | _No documentation available._ |
| `SceneOperation ToggleOpen(Scene scene)` | _No documentation available._ |
| `SceneOperation ToggleOpenState(Scene scene)` | _No documentation available._ |

---
# ASMSettings
<!--
source: API\Models\ASMSettings.md
-->

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
| `boolean allowUpdateCheck` | Gets or sets whether ASM is allowed to check for updates. |
| `string assetPath` | Specifies the path where profiles and imported scenes should be generated to. |
| `Profile buildProfile` | The profile to use during build. |
| `boolean checkForDuplicateSceneOperations` | By default, ASM checks for duplicate scene operations, since this is usually caused by mistake, but this will disable that. |
| `CustomData customData` | Specifies custom data. |
| `Profile defaultProfile` | The profile to use when none is set. |
| `boolean enableCrossSceneReferences` | Gets or sets whatever cross-scene references should be enabled. |
| `boolean enableGUIDReferences` | Gets or sets whatever GUID references should be enabled. |
| `Profile forceProfile` | The profile to force everyone in this project to use. |
| `boolean preventSpammingEventMethods` | By default, ASM will prevent spam calling event methods (i.e. calling Scene.Open() from a button press), but this will disable that. |
| `boolean reverseUnloadOrderOnCollectionClose` | Specifies whatever collections should unload scenes in the reverse order. |
| `SceneAutoTrackOutsideASMOption sceneAutoTrackOutsideASMOption` | Specifies if ASM should auto track scenes that were loaded outside of ASM. |
| `SceneImportOption sceneImportOption` | Gets or sets when to automatically import scenes. |
| `single spamCheckCooldown` | Sets the default cooldown for `SpamCheck`. |
| `InputBinding[] toolbarBindings` | Specifies the bindings to open the ASM toolbar, if enabled. |
| `boolean toolbarButtonVisible` | Specifies whatever the ASM toolbar button should be visible. |
| `boolean toolbarEnabled` | Specifies whatever the ASM toolbar should be enabled. |

### Static Methods

| Member | Description |
|--------|-------------|
| `void OnInitialized(Action action)` | Runs the callback when ASMSettings has initialized. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual void SaveNow()` | _No documentation available._ |
| `void SetBuildProfile(Profile profile)` | Sets the build profile. |

---
# ASMUserSettings
<!--
source: API\Models\ASMUserSettings.md
-->

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
| `boolean displayChildProfilesButton` | Specifies the child profiles button should be displayed. |
| `boolean displayHierarchyIndicators` | Specifies whatever the hierarchy indicators should be visible. |
| `boolean displayNewCollectionButton` | Specifies the new collection button should be displayed. |
| `boolean displaySceneTooltips` | Specifies whatever SceneField will display tooltips. |
| `boolean editorOnly` | _No documentation available._ |
| `single hierarchyIndicatorsOffset` | Gets or sets the offset ASM will use for hierarchy indicators. |
| `boolean keepSceneUIInMemoryWhenCollectionCollapsed` | Whether to keep scene UI elements in memory when a collection is collapsed. |
| `string lastPatchWhenNotified` | Gets or sets the last patch version when user was notified. |
| `string lastUpdateCheck` | Gets or sets the timestamp of the last update check. |
| `boolean logBuildScenes` | Specifies whatever ASM should log when build scene list is updated. |
| `boolean logImport` | Specifies whatever ASM should log when a `ASMModelBase` is imported. |
| `boolean logLoading` | Specifies whatever ASM should log when a scene is loaded. |
| `boolean logOperation` | Specifies whatever ASM should log during scene operations. |
| `boolean logStartup` | Specifies whatever ASM should log during startup. |
| `boolean logTracking` | Specifies whatever ASM should log when a scene is tracked after loaded. |
| `boolean openCollectionOnSceneAssetOpen` | When `true`: opens the first found collection that a scene is contained in when opening an SceneAsset in editor. |
| `IEnumerable<SceneCollection> pinnedOverlayCollections` | Enumerates the pinned collections in the collection overlay. |
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

---
# AutoSceneEntry
<!--
source: API\Models\AutoSceneEntry.md
-->

## AutoSceneEntry

`class` in `AdvancedSceneManager.Models`### Description
Represents an auto scene entry, which is a scene that will be automatically opened or closed (depending on option), when the parent scene is.

<b> Remarks:</b>
Not meant for direct use, use the following instead:
            
```
using AdvancedSceneManager.Utility;
            
            Scene.SetAutoScene(Scene, AutoSceneOption)
```

### Fields

| Member | Description |
|--------|-------------|
| `string customOption` | The custom option for this entry. |
| `Nullable<AutoSceneOption> option` | The pre-defined option specifying how ASM will handle the scene. |
| `Scene scene` | The scene this entry refers to. |
| `string scenePath` | The path to the Unity scene asset. |

### Methods

| Member | Description |
|--------|-------------|
| `boolean IsValid()` | Gets if this entry is valid. |
| `virtual string ToString()` | _No documentation available._ |

---
# Blocklist
<!--
source: API\Models\Blocklist.md
-->

## Blocklist

`class` in `AdvancedSceneManager.Models`### Description
Represents a blocklist.

### Properties

| Member | Description |
|--------|-------------|
| `int32 count` | Gets how many paths are added to this blocklist. |
| `string Item` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void Add(string path)` | Adds `path` to blocklist. |
| `void Change(int32 i, string newPath)` | Changes the path at the specified index in this blocklist. |
| `boolean Contains(string path)` | Gets if this blocklist contains `path`. |
| `IEnumerable<string> Enumerate()` | Enumerates the paths are added to this blocklist. |
| `boolean Get(int32 index, String& path)` | _No documentation available._ |
| `boolean MatchesFilter(string path)` | Gets if `path` matches this blocklist. |
| `boolean MatchesFilter(string path, IEnumerable<string> list)` | Gets if `path` matches this blocklist. |
| `void Remove(string path)` | Removes `path` from this blocklist. |
| `void RemoveAt(int32 index)` | Removes the entry at `index` from this blocklist. |

---
# ButtonData
<!--
source: API\Models\ButtonData.md
-->

## ButtonData

`class` in `AdvancedSceneManager.Models`### Description

### Fields

| Member | Description |
|--------|-------------|
| `int32 index` | _No documentation available._ |
| `boolean isVisible` | _No documentation available._ |
| `ElementLocation location` | _No documentation available._ |
| `string name` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `virtual string ToString()` | _No documentation available._ |

---
# CustomData
<!--
source: API\Models\CustomData.md
-->

## CustomData

`class` in `AdvancedSceneManager.Models`  /  Inherits from: `CustomDataDictionary<string, string>`### Description

---
# CustomDataDictionary_Of_TKey_TValue
<!--
source: API\Models\CustomDataDictionary_Of_TKey_TValue.md
-->

## CustomDataDictionary`2

`class` in `AdvancedSceneManager.Models`### Description

### Properties

| Member | Description |
|--------|-------------|
| `TValue Item` | _No documentation available._ |

### Methods

| Member | Description |
|--------|-------------|
| `void Clear(TKey key)` | _No documentation available._ |
| `boolean ContainsKey(TKey key)` | _No documentation available._ |
| `boolean Get(TKey key, TValue& value)` | _No documentation available._ |
| `TValue Get(TKey key)` | _No documentation available._ |
| `IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()` | _No documentation available._ |
| `void Set(TKey key, TValue value)` | _No documentation available._ |

---
# DynamicCollection
<!--
source: API\Models\DynamicCollection.md
-->

## DynamicCollection

`class` in `AdvancedSceneManager.Models`  /  Inherits from: `DynamicCollectionBase<string>`### Description
Represents a collection that can take a path and then gather all scenes within, guaranteeing that they are all added to build, including non-imported and blacklisted scenes.

### Properties

| Member | Description |
|--------|-------------|
| `int32 count` | _No documentation available._ |
| `string path` | Specifies the path that this dynamic collection will gather scenes from. |
| `IEnumerable<string> scenePaths` | Gets the paths of the scenes tracked by this dynamic collection. |
| `IEnumerable<string> scenes` | _No documentation available._ |

### Static Methods

| Member | Description |
|--------|-------------|
| `DynamicCollection Find(string id)` | Finds the dynamic collction with the specified id. |

### Methods

| Member | Description |
|--------|-------------|
| `void ImportScenes()` | Imports all scenes that are currently tracked by the collection. |
| `virtual boolean IsMatch(string q)` | Determines whether the specified query matches this model. |
| `void ReloadPaths()` | Queries all `SceneAsset` in the project that is in the defined path, and is not blacklisted. |
| `virtual string ToString()` | _No documentation available._ |

---
# DynamicCollectionBase_Of_T
<!--
source: API\Models\DynamicCollectionBase_Of_T.md
-->

## DynamicCollectionBase`1

`abstract class` in `AdvancedSceneManager.Models`  /  Inherits from: `ASMModelBase`### Description
Base class for dynamic collections.

### Properties

| Member | Description |
|--------|-------------|
| `int32 count` | Gets the count of scenes or scene paths contained in this collection. |
| `string description` | Gets the description of this collection. |
| `boolean hasScenes` | Gets if this collection has any scenes. |
| `T Item` | _No documentation available._ |
| `Profile profile` | Gets the profile that contains this collection. Cached. |
| `IEnumerable<string> scenePaths` | Gets the scene paths contained in this collection. |
| `IEnumerable<T> scenes` | Gets the scenes or scene paths contained in this collection. |
| `string title` | Gets the title of this collection. |

### Methods

| Member | Description |
|--------|-------------|
| `boolean Contains(T scene)` | _No documentation available._ |
| `virtual boolean Equals(object obj)` | _No documentation available._ |
| `boolean Equals(DynamicCollectionBase<T> other)` | _No documentation available._ |
| `boolean FindProfile(Profile& profile)` | _No documentation available._ |
| `Profile FindProfile()` | Finds the profile that contains this collection. |
| `IEnumerator<T> GetEnumerator()` | Gets an enumerator for the scenes or scene paths contained in this collection. |
| `virtual int32 GetHashCode()` | _No documentation available._ |
| `virtual boolean IsMatch(string q)` | Matches this collection against the query string. |
| `virtual string ToString()` | Returns the title of this collection. |

---
# AutoSceneOption
<!--
source: API\Models\Enums\AutoSceneOption.md
-->

## AutoSceneOption

`enum` in `AdvancedSceneManager.Models.Enums`  /  Inherits from: `Enum`### Description
Specifies when ASM should open or close an auto scene.

<b> Remarks:</b>
See also: ``

### Static Fields

| Member | Description |
|--------|-------------|
| `AutoSceneOption Always` | Always open the auto scene automatically in either outside or in play mode. |
| `AutoSceneOption EditModeOnly` | Only open the auto scene automatically outside of play mode. |
| `AutoSceneOption Never` | Never open the auto scene automatically. |
| `AutoSceneOption PlayModeOnly` | Only open the auto scene automatically in play mode. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# CollectionStartupOption
<!--
source: API\Models\Enums\CollectionStartupOption.md
-->

## CollectionStartupOption

`enum` in `AdvancedSceneManager.Models.Enums`  /  Inherits from: `Enum`### Description
Specifies what to do with a `SceneCollection` during startup.

### Static Fields

| Member | Description |
|--------|-------------|
| `CollectionStartupOption Auto` | Specifies that ASM should automatically decide if a `SceneCollection` should be opened during startup. |
| `CollectionStartupOption DoNotOpen` | Specifies that a `SceneCollection` will not open during startup. |
| `CollectionStartupOption Open` | Specifies that a `SceneCollection` will open during startup. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# EditorPersistentOption
<!--
source: API\Models\Enums\EditorPersistentOption.md
-->

## EditorPersistentOption

`enum` in `AdvancedSceneManager.Models.Enums`  /  Inherits from: `Enum`### Description
Specifies whatever a scene should be automatically opened outside of play-mode.

### Static Fields

| Member | Description |
|--------|-------------|
| `EditorPersistentOption AnySceneOpened` | Automatically open scene when any scene opens. |
| `EditorPersistentOption Never` | Never automatically open scene. |
| `EditorPersistentOption WhenAnyOfTheFollowingScenesAreOpened` | Automatically open scene when any specified scene is opened. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# LoadingScreenUsage
<!--
source: API\Models\Enums\LoadingScreenUsage.md
-->

## LoadingScreenUsage

`enum` in `AdvancedSceneManager.Models.Enums`  /  Inherits from: `Enum`### Description
Specifies what loading screen to use, if any.

### Static Fields

| Member | Description |
|--------|-------------|
| `LoadingScreenUsage DoNotUse` | Specifies no loading screen. |
| `LoadingScreenUsage Override` | Specifies overriden loading screen, defined in `SceneCollection`. |
| `LoadingScreenUsage UseDefault` | Specifies default loading screen, defined in profile settings. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# LoadPriority
<!--
source: API\Models\Enums\LoadPriority.md
-->

## LoadPriority

`enum` in `AdvancedSceneManager.Models.Enums`  /  Inherits from: `Enum`### Description
Priority of a thread.

### Static Fields

| Member | Description |
|--------|-------------|
| `LoadPriority Auto` | Let ASM automatically decide `ThreadPriority`. |
| `LoadPriority BelowNormal` | Below normal thread priority. |
| `LoadPriority High` | Highest thread priority. |
| `LoadPriority Low` | Lowest thread priority. |
| `LoadPriority Normal` | Normal thread priority. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

---
# SceneAutoTrackOutsideASMOption
<!--
source: API\Models\Enums\SceneAutoTrackOutsideASMOption.md
-->

## SceneAutoTrackOutsideASMOption

`enum` in `AdvancedSceneManager.Models.Enums`  /  Inherits from: `Enum`### Description
Specifies if ASM should auto track scenes that were loaded outside of ASM.

### Static Fields

| Member | Description |
|--------|-------------|
| `SceneAutoTrackOutsideASMOption Collections` | Specifies ASM should auto track collection scenes when loaded outside ASM. |
| `SceneAutoTrackOutsideASMOption DynamicCollections` | Specifies ASM should auto track dynamic collection scenes when loaded outside ASM. |
| `SceneAutoTrackOutsideASMOption NoTracking` | Specifies ASM shouldn't auto track any scenes when loaded outside ASM. |
| `SceneAutoTrackOutsideASMOption Standalone` | Specifies ASM should auto track standalone collection scenes when loaded outside ASM. |

### Fields

| Member | Description |
|--------|-------------|
| `int32 value__` | _No documentation available._ |

