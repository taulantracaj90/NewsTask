using news.sitecore.Application.ViewModels;
using news.sitecore.Domain.Models;

namespace news.sitecore.Application.Services
{
    public interface INewsService
    {
        NewsContentTemplateViewModel GetNewsViewModel();
        ISearchResults SearchNews(string id);
    }
}
