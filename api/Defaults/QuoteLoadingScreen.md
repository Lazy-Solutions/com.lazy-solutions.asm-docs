## QuoteLoadingScreen

`class` in `AdvancedSceneManager.Defaults`  /  Inherits from: `ProgressBarLoadingScreen`### Description
A default loading screen that displays random quotes while loading.

### Fields

| Member | Description |
|--------|-------------|
| `RectTransform Content` | Transform containing the entire quote content area. |
| `Text pressAnyKeyToContinueText` | UI text element for the "Press any key to continue" message. |
| `Text QuoteCountText` | UI text element showing the current quote index and total count. |
| `Quotes quotes` | Quotes to display during the loading screen. |
| `Text QuoteText` | UI text element used to display the current quote. |
| `single slideshowDelay` | Time to wait before showing the next quote in seconds. |
| `RectTransform Text` | Transform containing the text elements for fading transitions. |

### Methods

| Member | Description |
|--------|-------------|
| `virtual IEnumerator OnClose()` | Called when the loading screen is about to close. |
| `virtual IEnumerator OnOpen()` | Called when the loading screen is opened. |