# PagedList.Core.Mvc
PagedList tag helper for ASP.NET Core

## Installation

1. Install `PagedList.Core.Mvc` package from Nuget.

2. Edit `_ViewImports.cshtml`

```diff
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
+ @addTagHelper *, PagedList.Core.Mvc
```

## Usage
```html
<pager class="pager-container" list="@Model.SearchResult.SearchHits" options="@PagedListRenderOptions.Bootstrap4FullPagination" asp-action="Index" asp-controller="Search" asp-route-query="@Model.SearchResult.SearchQuery" />
```
## Sample
![Sample](../assets/SearchResult.jpg?raw=true)
