using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace MarcelDigital.Umbraco.XmlSitemap.Filters {
    /// <summary>
    ///     Filters the umbraco nodes by adding the nodes which appear
    ///     in the document type list provided by the configuration.
    /// </summary>
    public class DocumentTypeWhitelistFilter : DocumentTypeListFilter, IFilter {
        public DocumentTypeWhitelistFilter(IList<string> documentTypeList) : base(documentTypeList) {}

        public IEnumerable<IPublishedContent> Filter(IEnumerable<IPublishedContent> content) {
            return content.Where(c => _documentTypeList.Any(dta => c.IsDocumentType(dta)));
        }
    }
}