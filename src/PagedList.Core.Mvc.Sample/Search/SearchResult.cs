namespace PagedList.Core.Mvc.Sample.Search
{
    public class SearchResult
    {
        public IPagedList<SearchHit> SearchHits { get; set; }

        public string SearchQuery { get; set; }
    }
}
