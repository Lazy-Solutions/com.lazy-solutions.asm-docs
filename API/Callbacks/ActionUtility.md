## ActionUtility

`static class` in `AdvancedSceneManager.Callbacks`### Description
Contains utility functions for `Action`.

### Static Methods

| Member | Description |
|--------|-------------|
| `void LogInvoke(Action action)` | Tries to invoke the action, then logs error to the console if an error occurred. |
| `void TryInvoke(Action action)` | Tries to invoke the action, eats the exception. |
| `boolean TryInvoke(Action action, Exception& exception)` | _No documentation available._ |