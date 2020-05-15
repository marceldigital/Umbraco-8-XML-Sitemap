using System.IO;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using MarcelDigital.Umbraco.XmlSitemap.Configuration;
using MarcelDigital.Umbraco.XmlSitemap.Engines;
using MarcelDigital.Umbraco.XmlSitemap.Generators;
using MarcelDigital.Umbraco.XmlSitemap.Optimization;

namespace MarcelDigital.Umbraco.XmlSitemap {
    /// <summary>
    ///     Generates the Xml sitemap for the umbraco website.
    /// </summary>
    public class XmlSitemapHandler : IHttpHandler {
        /// <summary>
        ///     Specifies whether the handler can be reused in the pool
        ///     or a new one needs to be created each time.
        /// </summary>
        public bool IsReusable => false;

        /// <summary>
        ///     Caching strategy for the XML sitemap.
        /// </summary>
        private readonly ISitemapCache _sitemapCache;

        /// <summary>
        ///     Generation strategy for the XML sitemap.
        /// </summary>
        private readonly IXmlSitemapGenerator _generator;

        /// <summary>
        ///     The engine to use to get the content.
        /// </summary>
        private readonly IContentEngine _contentEngine;

        /// <summary>
        ///     Constructor for the sitemap handler
        /// </summary>
        public XmlSitemapHandler() {
            // TODO
        }

        /// <summary>
        ///     Constructor to inject dependencies into the handler
        /// </summary>
        public XmlSitemapHandler(IDependencyFactory dependencyFactory) {
            _sitemapCache = dependencyFactory.CreateCache();
            _generator = dependencyFactory.CreateGenerator();
            _contentEngine = dependencyFactory.CreateEngine();
        }

        /// <summary>
        ///     Default method for the http request
        /// </summary>
        /// <param name="context">Current http context</param>
        public void ProcessRequest(HttpContext context) {
            HttpContextBase wrapper = new HttpContextWrapper(context);
            ProcessRequest(wrapper);
        }

        /// <summary>
        ///     Alternate method for the http request
        /// </summary>
        /// <param name="context">Current http context</param>
        public void ProcessRequest(HttpContextBase context) {
            // TODO
        }

        /// <summary>
        ///     Generates the sitemap and inserts it in the response
        /// </summary>
        private XDocument GenerateSitemapXml() {
            // TODO
            return null;
        }

        /// <summary>
        ///     Puts the sitemap into the http response
        /// </summary>
        /// <param name="context"></param>
        /// <param name="sitemap"></param>
        private static void InsertSitemapIntoResponse(HttpContextBase context, XDocument sitemap) {
            var response = context.Response;
            response.Clear();
            response.ContentType = "text/xml";

            using (var streamWriter = new StreamWriter(response.OutputStream, Encoding.UTF8)) {
                var xmlWriter = new XmlTextWriter(streamWriter);
                sitemap.WriteTo(xmlWriter);
            }
            response.Flush();
        }
    }
}