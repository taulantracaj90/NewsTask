using Sitecore.Data.Items;
using System.Collections.Generic;

namespace news.sitecore.Domain.Models
{
   public interface ISearchResult
    {
        Item Item { get; }
        string Id { get; set; }
        string Title { get; set; }
        string Image { get; set; }
        string ArticleDate { get; set; }
        string NewsType { get; set; }
        string Abstract { get; set; }
        string Content { get; set; }
        IList<ISearchResult> PageSearchResults { get; set; }

    }
}
