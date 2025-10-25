## SerializableDictionary`2

`class` in `AdvancedSceneManager.Utility`  /  Inherits from: `Dictionary<TKey, TValue>`### Description
A serializable dictionary that supports Unity serialization and implements `IDictionary`2`.

### Methods

| Member | Description |
|--------|-------------|
| `virtual void OnAfterDeserialize()` | Implement this callback to transform data back into runtime data types after an object is deserialized. |
| `virtual void OnBeforeSerialize()` | Implement this callback to transform data into serializable data types immediately before an object is serialized. |