namespace PagedList.Core.Mvc.Sample.Search.Services
{
    public interface ISearchService
    {
        SearchResult GetSearchResult(string query, int page, int pageSize);
    }
}
