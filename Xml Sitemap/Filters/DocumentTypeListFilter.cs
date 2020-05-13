using System.Collections.Generic;

namespace MarcelDigital.Umbraco.XmlSitemap.Filters {
    /// <summary>
    ///     Abstract class to retireve the list configuration from the configuration
    ///     and make it available to sub types.
    /// </summary>
    public abstract class DocumentTypeListFilter {
        protected readonly IList<string> _documentTypeList;

        protected DocumentTypeListFilter(IList<string> documentTypeList) {
            _documentTypeList = documentTypeList;
        }
    }
}