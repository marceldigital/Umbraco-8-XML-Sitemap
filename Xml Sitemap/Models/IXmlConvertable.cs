using System.Xml.Linq;

namespace MarcelDigital.Umbraco.XmlSitemap.Models {
    public interface IXmlConvertable {
        /// <summary>
        ///     Converts the object to an XML element
        /// </summary>
        /// <returns></returns>
        XElement ToXml();
    }
}