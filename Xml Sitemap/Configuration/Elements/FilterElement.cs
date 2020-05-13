﻿using System;
using System.ComponentModel;
using System.Configuration;
using MarcelDigital.Umbraco.XmlSitemap.Configuration.Collections;

namespace MarcelDigital.Umbraco.XmlSitemap.Configuration.Elements {
    public class FilterElement : ConfigurationElement {
        private const string TypeKey = "type";
        private const string DocumentTypesKey = "documentTypes";
        private const string PropertiesKey = "properties";

        /// <summary>
        ///     Type of the Filter
        /// </summary>
        [TypeConverter(typeof(TypeNameConverter))]
        [ConfigurationProperty(TypeKey, IsRequired = true, IsKey = true)]
        public Type Type {
            get { return this[TypeKey] as Type; }
            set { this[TypeKey] = value; }
        }

        /// <summary>
        ///     List of document types for filters that take a list
        /// </summary>
        [ConfigurationProperty(DocumentTypesKey, IsDefaultCollection = false, IsRequired = false)]
        [ConfigurationCollection(typeof(DocumentTypesCollection),
            AddItemName = "add",
            ClearItemsName = "clear",
            RemoveItemName = "remove")]
        public DocumentTypesCollection DocumentTypes {
            get { return this[DocumentTypesKey] as DocumentTypesCollection; }
            set { this[DocumentTypesKey] = value; }
        }

        /// <summary>
        ///     List of document types for filters that take a list
        /// </summary>
        [ConfigurationProperty(PropertiesKey, IsDefaultCollection = false, IsRequired = false)]
        [ConfigurationCollection(typeof(PropertiesCollection),
            AddItemName = "property",
            ClearItemsName = "clear",
            RemoveItemName = "remove")]
        public PropertiesCollection PropertiesList {
            get { return this[PropertiesKey] as PropertiesCollection; }
            set { this[PropertiesKey] = value; }
        }
    }
}