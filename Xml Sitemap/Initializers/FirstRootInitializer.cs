using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace MarcelDigital.Umbraco.XmlSitemap.Initializers {
    /// <summary>
    /// Gets all the content under and including the first root Umbraco node
    /// </summary>
    internal class FirstRootInitializer : BaseUmbracoInitializer, IInitializer {
        public FirstRootInitializer(UmbracoHelper helper, UmbracoContext umbracoContext) : base(helper, umbracoContext) { }

        public IEnumerable<IPublishedContent> GetContent() {
            return _umbracoHelper.ContentAtRoot().First().DescendantsOrSelf();
        }
    }
}