using MarcelDigital.Umbraco.XmlSitemap.Filters.Enums;
using MarcelDigital.Umbraco.XmlSitemap.Filters;
using MarcelDigital.Umbraco.XmlSitemap.Initializers;
using System.Collections.Generic;

namespace MarcelDigital.Umbraco.XmlSitemap.Providers {
    public class DefaultUmbracoSitemapContentProvider : UmbracoSitemapContentProviderBase {
        public DefaultUmbracoSitemapContentProvider(DomainInitializer domainInitializer) {
            Initializer = domainInitializer;
            Filters = new List<IFilter> {
                new NoTemplateFilter(),
                new PropertiesFilter(new List<PropertyFilterOptions> {
                    new PropertyFilterOptions() { Alias = "metaHideFromSitemap", Operator = FilterOperator.Equals, Required = false, Value = "false" }
                })
            };
        }

        protected override IInitializer Initializer { get; }

        protected override IList<IFilter> Filters { get; }
    }
}