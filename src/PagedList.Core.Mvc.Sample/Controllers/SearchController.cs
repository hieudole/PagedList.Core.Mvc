using Microsoft.AspNetCore.Mvc;
using PagedList.Core.Mvc.Sample.Models;
using PagedList.Core.Mvc.Sample.Search;
using PagedList.Core.Mvc.Sample.Search.Services;

namespace PagedList.Core.Mvc.Sample.Controllers
{
    public class SearchController : Controller
    {
        private readonly ISearchService searchService;

        public SearchController(ISearchService searchService)
        {
            this.searchService = searchService;
        }

        public IActionResult Index(string query, int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 5;
            var model = new SearchViewModel();

            if (string.IsNullOrWhiteSpace(query))
            {
                model.SearchResult = new SearchResult();
            }
            else
            {
                model.SearchResult = this.searchService.GetSearchResult(query, pageNumber, pageSize);
            }

            model.SearchResult.SearchQuery = query;

            return View(model);
        }
    }
}
