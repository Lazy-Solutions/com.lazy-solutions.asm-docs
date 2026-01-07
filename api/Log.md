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