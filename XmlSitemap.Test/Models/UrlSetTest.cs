﻿using System.Linq;
using MarcelDigital.Umbraco.XmlSitemap.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XmlSitemap.Test.Models {
    [TestClass]
    public class UrlSetTest {
        private const string XhtmlNamespace = "{http://www.w3.org/2000/xmlns/}xhtml";

        [TestInitialize]
        public void Setup() {}

        [TestMethod]
        public void HasXmlnsAttribute() {
            var urlSet = new UrlSet();

            var xml = urlSet.ToXml();

            Assert.IsTrue(xml.Attributes().Any(attr => attr.Name == "xmlns"), "xmlns attribute missing.");
        }

        [TestMethod]
        public void HasXmlnsDefaultValue() {
            const string expected = "http://www.sitemaps.org/schemas/sitemap/0.9";
            var urlSet = new UrlSet();

            var xml = urlSet.ToXml();

            Assert.AreEqual(xml.Attributes().First(attr => attr.Name == "xmlns").Value, expected, "xmlns default value incorrect.");
        }

        [TestMethod]
        public void CanOverrideXmlns() {
            const string expected = "http://www.somethingnew.com/sitemap";
            var urlSet = new UrlSet {
                XmlNamespace = expected
            };

            var xml = urlSet.ToXml();

            Assert.AreEqual(xml.Attributes().First(attr => attr.Name == "xmlns").Value, expected, "xmlns default value was not overriden.");
        }

        [TestMethod]
        public void HasXmlnsXhtmlAttribute() {
            var urlSet = new UrlSet();

            var xml = urlSet.ToXml();

            Assert.IsTrue(xml.Attributes().Any(attr => attr.Name == XhtmlNamespace), "xmlns:html attribute missing.");
        }

        [TestMethod]
        public void HasXmlnsXhtmlDefaultValue() {
            const string expected = "http://www.w3.org/1999/xhtml";
            var urlSet = new UrlSet();

            var xml = urlSet.ToXml();

            Assert.AreEqual(xml.Attributes().First(attr => attr.Name == XhtmlNamespace).Value, expected, "xmlns:html default value incorrect.");
        }

        [TestMethod]
        public void CanOverrideXmlnsXhtml() {
            const string expected = "http://www.somethingnew.com/2015/xhtml";
            var urlSet = new UrlSet {
                XmlNamespaceXHtml = expected
            };

            var xml = urlSet.ToXml();

            Assert.AreEqual(xml.Attributes().First(attr => attr.Name == XhtmlNamespace).Value, expected, "xmlns:html default value was not overriden.");
        }

        [TestMethod]
        public void HasChildren() {
            var urlSet = new UrlSet();

            var url1 = new UmbracoContent();
            var url2 = new UmbracoContent();

            urlSet.Urls.Add(url1);
            urlSet.Urls.Add(url2);

            var xml = urlSet.ToXml();

            Assert.IsTrue(xml.HasElements, "xml is missing child elements");
            Assert.AreEqual(xml.Elements().Count(), 2, "xml has the wrong number of elements.");
        }
    }
}