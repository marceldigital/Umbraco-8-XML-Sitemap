using MarcelDigital.Umbraco.XmlSitemap.Collections.Extensions;
using MarcelDigital.Umbraco.XmlSitemap.Providers;
using Umbraco.Core.Composing;

namespace MarcelDigital.Umbraco.XmlSitemap.Composers {
    public class DefaultXmlSitemapComposer : IComposer {
        public void Compose(Composition composition) {
            composition.XmlSitemapContentProviders().Insert<DefaultUmbracoSitemapContentProvider>();
        }
    }
}