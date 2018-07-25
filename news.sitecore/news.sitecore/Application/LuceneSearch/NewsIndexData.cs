using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.Data;
using System;

namespace news.sitecore.Application.LuceneSearch
{
    public class NewsIndexData : SearchResultItem
    {
        [IndexField("title")]
        public string Title { get; set; }

        [IndexField("image")]
        public string Image { get; set; }

        [IndexField("articledate")]
        public DateTime ArticleDate { get; set; }

        [IndexField("newstype")]
        public Guid NewsType { get; set; }

        [IndexField("abstract")]
        public string Abstract { get; set; }

        [IndexField("content")]
        public string Content { get; set; }
    }
}