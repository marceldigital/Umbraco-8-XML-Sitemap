using System.Configuration;
using MarcelDigital.Umbraco.XmlSitemap.Configuration.Elements;

namespace MarcelDigital.Umbraco.XmlSitemap.Configuration.Collections {
    /// <summary>
    ///     Configuration element to hold the list of filter elements
    /// </summary>
    public class FiltersCollection : ConfigurationElementCollection {
        protected override ConfigurationElement CreateNewElement() {
            return new FilterElement();
        }

        protected override object GetElementKey(ConfigurationElement element) {
            return ((FilterElement) element).Type;
        }

        /// <summary>
        ///     Created only for testing
        /// </summary>
        /// <param name="element"></param>
        internal void Add(ConfigurationElement element) {
            BaseAdd(element);
        }
    }
}