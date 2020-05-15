using MarcelDigital.Umbraco.XmlSitemap.Providers;
using Umbraco.Core.Composing;

namespace MarcelDigital.Umbraco.XmlSitemap.Collections {
    public class XmlSitemapContentProviderCollectionBuilder
        : OrderedCollectionBuilderBase<XmlSitemapContentProviderCollectionBuilder, XmlSitemapContentProviderCollection, IXmlSitemapContentProvider> {
        protected override XmlSitemapContentProviderCollectionBuilder This => this;
    }
}