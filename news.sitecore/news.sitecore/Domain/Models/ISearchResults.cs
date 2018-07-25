using System.Collections.Generic;

namespace news.sitecore.Domain.Models
{
   public interface ISearchResults
    {
        IEnumerable<ISearchResult> Results { get; set; }
        int Total { get; set; }
        bool ShowLoadMore { get; set; }
    }
}
