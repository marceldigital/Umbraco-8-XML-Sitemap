using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace MarcelDigital.Umbraco.XmlSitemap.Initializers {
    /// <summary>
    /// Gets all the content in Umbraco
    /// </summary>
    internal class AllRootInitializer : BaseUmbracoInitializer, IInitializer {
        public AllRootInitializer(UmbracoHelper helper, UmbracoContext umbracoContext) : base(helper, umbracoContext) { }

        public IEnumerable<IPublishedContent> GetContent() {
            return _umbracoHelper.ContentAtRoot().SelectMany(c => c.DescendantsOrSelf());
        }
    }
}