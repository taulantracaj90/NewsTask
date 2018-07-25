using System.Collections.Generic;
using System.Linq;
using news.sitecore.Domain.Models;
using Sitecore.ContentSearch.Linq;
using news.sitecore.Application.LuceneSearch;

namespace news.sitecore.Infratstructure.Repository
{
    public class SearchResultRepository : ISearchResultRepository
    {
        public ISearchResults Create(SearchResults<NewsIndexData> results)
        {
            var searchResults = this.CreateSearchResults(results);
            return new SearchResults
            {
                Results = searchResults.Where(z => z != null),
                Total = results.TotalSearchResults,
            };
        }
        public IEnumerable<ISearchResult> CreateSearchResults(SearchResults<NewsIndexData> results)
        {
            return results.Hits.Select(h => this.CreateFormattedResult(h.Document)).ToArray();
        }
        public ISearchResult CreateFormattedResult(NewsIndexData result)
        {
            var item = result.GetItem();
            ISearchResult formattedResult = new SearchResult(item);
            return formattedResult;
        }
    }
}