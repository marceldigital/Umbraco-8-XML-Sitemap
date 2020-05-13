using System.Collections.Generic;
using Umbraco.Core.Models.PublishedContent;

namespace MarcelDigital.Umbraco.XmlSitemap.Filters {
    public interface IFilter {
        /// <summary>
        ///     Filters the content and returns the result
        /// </summary>
        /// <param name="content">The content to filter</param>
        /// <returns></returns>
        IEnumerable<IPublishedContent> Filter(IEnumerable<IPublishedContent> content);
    }
}