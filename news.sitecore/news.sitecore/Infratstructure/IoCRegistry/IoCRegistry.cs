using news.sitecore.Infratstructure.Repository;
using news.sitecore.Application.Services;

namespace news.sitecore.Infratstructure.IoCRegistry
{
    public class IoCRegistry
    {
        public static void RegisterServices(SimpleInjector.Container container)
        {
            //Repo
            container.Register<INewsRepository, NewsRepository>();
            container.Register<ISearchResultRepository, SearchResultRepository>();
            //Services
            container.Register<INewsService, NewsService>();
        }
    }
}