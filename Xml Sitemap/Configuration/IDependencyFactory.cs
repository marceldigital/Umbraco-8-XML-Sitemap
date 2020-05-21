using MarcelDigital.Umbraco.XmlSitemap.Engines;
using MarcelDigital.Umbraco.XmlSitemap.Generators;
using MarcelDigital.Umbraco.XmlSitemap.Optimization;
using Umbraco.Core.Logging;

namespace MarcelDigital.Umbraco.XmlSitemap.Configuration {
    /// <summary>
    ///     Creates the dependancies for the http handler
    /// </summary>
    public interface IDependencyFactory {
        /// <summary>
        ///     Creates an instance of the logger
        /// </summary>
        ILogger CreateLogger();

        /// <summary>
        ///     Creates a content gathering engine
        /// </summary>
        /// <returns></returns>
        IContentEngine CreateEngine();

        /// <summary>
        ///     Creates an instance of the sitemap cache
        /// </summary>
        /// <returns></returns>
        ISitemapCache CreateCache();

        /// <summary>
        ///     Creates an instance of the sitemap generator
        /// </summary>
        /// <returns></returns>
        IXmlSitemapGenerator CreateGenerator();
    }
}