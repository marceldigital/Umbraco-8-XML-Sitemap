using MarcelDigital.Umbraco.XmlSitemap.Filters;
using MarcelDigital.Umbraco.XmlSitemap.Initializers;
using MarcelDigital.Umbraco.XmlSitemap.Models;
using System.Collections.Generic;
using System.Linq;

namespace MarcelDigital.Umbraco.XmlSitemap.Providers {
    public abstract class UmbracoSitemapContentProviderBase : IXmlSitemapContentProvider {
        protected abstract IInitializer Initializer { get; }

        protected abstract IList<IFilter> Filters { get; }

        public virtual IList<ISitemapContent> GetContent() {
            var content = Initializer.GetContent();

            return Filters.Aggregate(content, (current, contentFilter) => contentFilter.Filter(current))
                            .Select(c => UmbracoContent.Parse(c))
                            .ToList<ISitemapContent>();
        }
    }
}