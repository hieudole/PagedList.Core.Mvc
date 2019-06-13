using System.Collections.Generic;
using System.Linq;

namespace PagedList.Core.Mvc.Sample.Search.Services
{
    public class SearchService : ISearchService
    {
        private readonly IList<SearchHit> sampleSearchData = new List<SearchHit>();

        public SearchService()
        {
            for (var i = 1; i <= 500; i++)
            {
                this.sampleSearchData.Add(
                    new SearchHit()
                    {
                        Id = i,
                        Title = "PagedList Core Mvc - Search item " + i
                    });
            }
        }

        public SearchResult GetSearchResult(string query, int page, int pageSize)
        {
            var searchHits = this.sampleSearchData.Where(x => x.Title.Contains(query, System.StringComparison.CurrentCultureIgnoreCase));

            var searchResult = new SearchResult()
            {
                SearchHits = new StaticPagedList<SearchHit>(searchHits.Skip((page - 1) * pageSize).Take(pageSize), page, pageSize, searchHits.Count()),
                SearchQuery = query
            };

            return searchResult;
        }
    }
}
