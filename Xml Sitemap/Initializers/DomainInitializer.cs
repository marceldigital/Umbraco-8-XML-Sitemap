using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace MarcelDigital.Umbraco.XmlSitemap.Initializers {
    public class DomainInitializer : BaseUmbracoInitializer, IInitializer {
        public DomainInitializer(UmbracoHelper helper, UmbracoContext umbracoContext) : base(helper, umbracoContext) { }

        public IEnumerable<IPublishedContent> GetContent() {
            IPublishedContent content = null;
            var urlAuthority = _umbracoContext.HttpContext.Request?.Url?.Authority;
            var domain = _umbracoContext.Domains?.GetAll(true)?.Where(d => d.Name == urlAuthority).FirstOrDefault();

            if (domain != null) {
                content = _umbracoHelper.Content(domain.ContentId);
            }

            return content?.DescendantsOrSelf() ?? new List<IPublishedContent>();
        }
    }
}