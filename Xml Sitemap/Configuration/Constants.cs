namespace MarcelDigital.Umbraco.XmlSitemap.Configuration {
    internal static class Constants {
        /// <summary>
        ///     The name of the configuration section of the sitemap
        /// </summary>
        public const string ConfigurationSectionName = "umbracoXmlSitemap";

        /// <summary>
        ///     The fully qualified name of the class that will be used to cache
        ///     the sitemap
        /// </summary>
        public const string DefaultCachingStrategy =
            "MarcelDigital.Umbraco.XmlSitemap.Optimization.HttpContextCache, MarcelDigital.Umbraco.XmlSitemap";

        /// <summary>
        ///     The fully qualified name of the engine that is used to gether the content
        /// </summary>
        public const string DefaultEngine =
            "MarcelDigital.Umbraco.XmlSitemap.Engines.UmbracoEngine, MarcelDigital.Umbraco.XmlSitemap";

        /// <summary>
        ///     The fully qulified name of the generator that is used to format the sitemap output
        /// </summary>
        public const string DefaultGenerator =
            "MarcelDigital.Umbraco.XmlSitemap.Generators.XmlSitemapGenerator, MarcelDigital.Umbraco.XmlSitemap";

        /// <summary>
        ///     The fully qualified name of the initializer that is used to get the first set of content
        /// </summary>
        public const string DefaultInitializer =
            "MarcelDigital.Umbraco.XmlSitemap.Initializers.FirstRootInitializer, MarcelDigital.Umbraco.XmlSitemap";
    }
}