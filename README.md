# PagedList.Core.Mvc
PagedList tag helper for ASP.NET Core

## Installtion

1. Install `PagedList.Core.Mvc` package from Nuget.

2. Add the following code in `Startup.cs`

```cs
  public void ConfigureServices(IServiceCollection services)
  {
    // Add framework services.
    services.AddMvc();
    
    services.AddSingleton<IActionContextAccessor, ActionContextAccessor>(); // <=
  }
```

3. Add the following code in `_ViewImports.cshtml`

```html
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
@addTagHelper *, PagedList.Core.Mvc
```

## Usage
```html
<pager class="pager-container" list="@Model.Tests" options="@PagedListRenderOptions.TwitterBootstrapPager" asp-action="Index" asp-controller="Test" />
```

