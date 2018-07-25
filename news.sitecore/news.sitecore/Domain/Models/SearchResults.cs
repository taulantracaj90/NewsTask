using System.Collections.Generic;

namespace news.sitecore.Domain.Models
{
    public class SearchResults : ISearchResults
    {
        public IEnumerable<ISearchResult> Results { get; set; }
        public int Total { get; set; }
       // public ISitecoreQuery Query { get; set; }
        public bool ShowLoadMore { get; set; }
    }
}