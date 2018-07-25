using news.sitecore.Extensions;
using Newtonsoft.Json;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;

namespace news.sitecore.Domain.Models
{
    public class SearchResult : ISearchResult
    {
        private Uri _url;

        public SearchResult()
        {
        }
        public SearchResult(Item item)
        {
            this.Item = item;
            Title = Item.Fields[Sitecore.Templates.StandardContent.Fields.Title] != null ? Item.Fields[Sitecore.Templates.StandardContent.Fields.Title].Value : null;
            Image = FieldExtensions.GetImageUrl(item);
            ArticleDate = Item.Fields[Sitecore.Templates.NewsContent.Fields.ArticleDate] != null ? Item.Fields[Sitecore.Templates.NewsContent.Fields.ArticleDate].Value : null;
            NewsType = Item.Fields[Sitecore.Templates.NewsContent.Fields.NewsType] != null ? Item.Fields[Sitecore.Templates.NewsContent.Fields.NewsType].Value : null;//RenderingContext.Current.Rendering.Item.Fields[Sitecore.Templates.NewsContent.Fields.NewsType] 
            Abstract = Item.Fields[Sitecore.Templates.NewsContent.Fields.Abstract] != null ? Item.Fields[Sitecore.Templates.NewsContent.Fields.Abstract].Value : null ;
            Content = Item.Fields[Sitecore.Templates.NewsContent.Fields.Content] != null ? Item.Fields[Sitecore.Templates.NewsContent.Fields.Content].Value : null;
            Id = Item.ID.ToString();
        }

        [JsonIgnore]
        public Item Item { get; }
        public Uri Url 
        {
            get { return this._url ?? new Uri(this.Item.Url(), UriKind.Relative); }
            set { this._url = value; }
        }
        IList<ISearchResult> ISearchResult.PageSearchResults { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }   
        public string Image { get; set; }
        public string ArticleDate { get; set; } 
        public string NewsType { get; set; }
        public string Abstract { get; set; }
        public string Content { get; set; }
    }
}