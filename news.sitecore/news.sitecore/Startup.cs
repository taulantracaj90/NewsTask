using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(news.sitecore.Startup))]
namespace news.sitecore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
