using MarcelDigital.Umbraco.XmlSitemap.Filters.Enums;

namespace MarcelDigital.Umbraco.XmlSitemap.Filters {
    public class PropertyFilterOptions {
        /// <summary>
        ///     The alias of the property to filter on
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        ///     The value to check the properties value against
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        ///     The operator type to check the values against
        /// </summary>
        public FilterOperator Operator { get; set; }

        /// <summary>
        ///     If the node does not have the property, automatically remove
        /// </summary>
        public bool Required { get; set; }
    }
}