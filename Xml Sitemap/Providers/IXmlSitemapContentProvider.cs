using MarcelDigital.Umbraco.XmlSitemap.Models;
using System.Collections.Generic;

namespace MarcelDigital.Umbraco.XmlSitemap.Providers {
    public interface IXmlSitemapContentProvider {
        /// <summary>
        ///     Gets the sitemap content. If null is returned, the next provider in the chain is tried.
        /// </summary>
        IList<ISitemapContent> GetContent();
    }
}