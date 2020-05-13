using System.Collections.Generic;
using Umbraco.Core.Models.PublishedContent;

namespace MarcelDigital.Umbraco.XmlSitemap.Engines {
    /// <summary>
    ///     Gets the content for the sitemap
    /// </summary>
    public interface IContentEngine {
        IEnumerable<IPublishedContent> Run();
    }
}