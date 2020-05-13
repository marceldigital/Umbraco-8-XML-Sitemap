﻿using System.Collections.Generic;
using System.Linq;
using MarcelDigital.Umbraco.XmlSitemap.Filters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Umbraco.Core.Models.PublishedContent;

namespace XmlSitemap.Test.Filters
{
    [TestClass]
    public class DocumentTypeBlacklistFilterTest
    {
        private DocumentTypeBlacklistFilter _sut;
        private IList<IPublishedContent> _testContent;
        private const string GoodDocumentTypeAlias = "GoodDocType";
        private const string BadDocumentTypeAlias = "BadDocType";

        [TestInitialize]
        public void Setup() {
            _sut = new DocumentTypeBlacklistFilter(new List<string> { BadDocumentTypeAlias });
            _testContent = new List<IPublishedContent>();

            var content1 = new Mock<IPublishedContent>();
            content1.Setup(c => c.ContentType.Alias).Returns(GoodDocumentTypeAlias);
            var content2 = new Mock<IPublishedContent>();
            content2.Setup(c => c.ContentType.Alias).Returns(BadDocumentTypeAlias);
            var content3 = new Mock<IPublishedContent>();
            content3.Setup(c => c.ContentType.Alias).Returns(GoodDocumentTypeAlias);

            _testContent.Add(content1.Object);
            _testContent.Add(content2.Object);
            _testContent.Add(content3.Object);
        }

        [TestCleanup]
        public void Cleanup() {
            _sut = null;
        }

        [TestMethod]
        public void FilterTest() {
            var filteredContent = _sut.Filter(_testContent);

            Assert.AreEqual(2, filteredContent.Count());
        }
    }
}