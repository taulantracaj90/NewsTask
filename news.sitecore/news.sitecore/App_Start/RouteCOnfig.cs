[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(news.sitecore.App_Start.RouteConfig), "Initialize")]

namespace news.sitecore.App_Start
{
    using System.Web.Mvc;
    using System.Web.Routing;
    public class RouteConfig
    {
        public static void Initialize()
        {
            RegisterRoutes(RouteTable.Routes);
        }
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("SearchNews", "api/News/SearchNews/{id}", new { controller = "News", action = "SearchNews", id=UrlParameter.Optional });
        }
        
    }
}