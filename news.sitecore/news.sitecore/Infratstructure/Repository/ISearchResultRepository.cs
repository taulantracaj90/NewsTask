using news.sitecore.Application.LuceneSearch;
using news.sitecore.Domain.Models;
using Sitecore.ContentSearch.Linq;
using System.Collections.Generic;

namespace news.sitecore.Infratstructure.Repository
{
    public interface ISearchResultRepository
    {
        ISearchResults Create(SearchResults<NewsIndexData> results);
        IEnumerable<ISearchResult> CreateSearchResults(SearchResults<NewsIndexData> results);
        ISearchResult CreateFormattedResult(NewsIndexData result);
    }
}
