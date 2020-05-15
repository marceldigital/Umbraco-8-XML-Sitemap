using MarcelDigital.Umbraco.XmlSitemap.Providers;
using System.Collections.Generic;
using Umbraco.Core.Composing;

namespace MarcelDigital.Umbraco.XmlSitemap.Collections {
    public class XmlSitemapContentProviderCollection : BuilderCollectionBase<IXmlSitemapContentProvider> {
        public XmlSitemapContentProviderCollection(IEnumerable<IXmlSitemapContentProvider> items) : base(items) { }
    }
}