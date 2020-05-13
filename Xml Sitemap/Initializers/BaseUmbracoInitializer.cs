using System;
using Umbraco.Web;

namespace MarcelDigital.Umbraco.XmlSitemap.Initializers {
    public abstract class BaseUmbracoInitializer {
        protected readonly UmbracoHelper _umbracoHelper;
        protected readonly UmbracoContext _umbracoContext;

        protected BaseUmbracoInitializer(UmbracoHelper umbracoHelper, UmbracoContext umbracoContext) {
            _umbracoHelper = umbracoHelper ?? throw new ArgumentNullException(nameof(umbracoHelper));
            _umbracoContext = umbracoContext ?? throw new ArgumentNullException(nameof(umbracoContext));
        }
    }
}