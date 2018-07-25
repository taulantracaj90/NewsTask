using System;
using news.sitecore.Application.LuceneSearch;
using news.sitecore.Application.ViewModels;
using news.sitecore.Domain.Models;
using news.sitecore.Domain.Sitecore;
using news.sitecore.Infratstructure.Repository;
using Sitecore;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq;
using Sitecore.Data.Fields;
using Sitecore.Mvc.Presentation;
using System.Linq.Expressions;
using Sitecore.ContentSearch.Utilities;
using System.Linq;
using Sitecore.ContentSearch.Linq.Utilities;

namespace news.sitecore.Application.Services
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _newsRepository;
        private readonly ISearchResultRepository _searchResuktRepository;
        public NewsService( INewsRepository newsRepository, ISearchResultRepository searchResuktRepository)
        {
            _newsRepository = newsRepository;
            _searchResuktRepository = searchResuktRepository;
        }
        public NewsContentTemplateViewModel GetNewsViewModel()
        {          
            var articleItem = Context.Item;

            var rc = Sitecore.Mvc.Presentation.RenderingContext.CurrentOrNull;

            var newsTypeValuest = (((GroupedDroplinkField)articleItem.Fields[Templates.NewsContent.Fields.NewsType]));

            if (articleItem != null)
            {
                var articleViewModel = new NewsContentTemplateViewModel
                {
                    Item = articleItem,
                    newsTypeValue = newsTypeValuest
                };
                return articleViewModel;
            }
            else
            {
                return null;
            }
        }
        public ISearchResults SearchNews(string id) 
        {
            var index = ContentSearchManager.GetIndex("news_index_master");

            using (var context = index.CreateSearchContext())
            {
               // Guid Nid = Guid.Parse(id);

                var predicate = PredicateBuilder.True<NewsIndexData>();
                if(!string.IsNullOrWhiteSpace(id))
                {
                    Guid Nid = Guid.Parse(id);
                    predicate = predicate.And(i => i.NewsType == Nid);
                }


             //   Expression<Func<NewsIndexData, bool>> luceneItemsFilters = ((x => x.NewsType == Nid));  

                var newsArticleEventsQueryable = context.GetQueryable<NewsIndexData>().Where(predicate);
             //   var newsArticleEventsQueryablete = context.GetQueryable<NewsIndexData>().Where(luceneItemsFilters).ToList();
                //var rendering = RenderingContext.Current.Rendering;
                //string id = rendering.Parameters["News Type"];
                //vart resultTEST = newsArticleEventsQueryable
                var result = newsArticleEventsQueryable.GetResults();

                return _searchResuktRepository.Create(result);
            }
        }
    }
}