using System.Configuration;
using MarcelDigital.Umbraco.XmlSitemap.Configuration.Elements;

namespace MarcelDigital.Umbraco.XmlSitemap.Configuration.Collections {
    /// <summary>
    ///     Configuration element collection to hold the list of document type
    ///     elements
    /// </summary>
    public class DocumentTypesCollection : ConfigurationElementCollection {
        protected override ConfigurationElement CreateNewElement() {
            return new DocumentTypeElement();
        }

        protected override object GetElementKey(ConfigurationElement element) {
            return ((DocumentTypeElement) element).Alias;
        }
    }
}