namespace news.sitecore.Infratstructure.IoCRegistry
{
    /// <summary>
    /// Class that offers access to a SimpleInjector Container instance.
    /// </summary>
    public static class Container
    {
        /// <summary>
        /// The SimpleInjector configuration instance.
        /// </summary>
        private static SimpleInjector.Container _configuration;

        /// <summary>
        /// Method for creating a SimpleInjector Container instance.
        /// </summary>
        /// <returns>SimpleInjector.Container.</returns>
        public static SimpleInjector.Container CreateContainer()
        {
            _configuration = new SimpleInjector.Container();
            return _configuration;
        }
    }
}
