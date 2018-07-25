[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(news.sitecore.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]

namespace news.sitecore.App_Start
{
    //using GRALKS.Backend.Application.IOC;
    using SimpleInjector;
    using SimpleInjector.Integration.Web.Mvc;
    using sitecore.Infratstructure.IoCRegistry;
    using System.Web.Mvc;

    /// <summary>
    /// The initializer of the Web Api.
    /// </summary>
    public static class SimpleInjectorWebApiInitializer
    {
        /// <summary>Initialize the container and register it as Web API Dependency Resolver.</summary>
        public static void Initialize()
        {
            SimpleInjector.Container container = sitecore.Infratstructure.IoCRegistry.Container.CreateContainer();

            container.Options.AllowOverridingRegistrations = true;

            // container.Options.DefaultScopedLifestyle = new SimpleInjector.Lifestyles.AsyncScopedLifestyle();

            IoCRegistry.RegisterServices(container);

          //  container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            // Set the ASP.NET dependency resolver
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
            //GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}