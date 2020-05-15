using Umbraco.Core.Composing;

namespace MarcelDigital.Umbraco.XmlSitemap.Collections.Extensions {
    public static class XmlSitemapContentProviderExtensions {
        public static XmlSitemapContentProviderCollectionBuilder XmlSitemapContentProviders(this Composition composition)
            => composition?.WithCollectionBuilder<XmlSitemapContentProviderCollectionBuilder>();
    }
}