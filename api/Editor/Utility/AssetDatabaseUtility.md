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
| `void ShowFolder(string path)` | Shows the folder and selects the asset. |
| `void ShowFolder(object obj)` | Shows the folder and selects the asset. |