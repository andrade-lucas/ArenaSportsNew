using Arena.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arena.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTests
    {
        [TestMethod]
        public void ShouldReturnValidWhenDocumentIsValid()
        {
            var document = new Document("06828764374");
            Assert.AreEqual(true, document.IsValid);
        }

        [TestMethod]
        public void ShouldReturnInvalidWhenDocumentIsInvalid()
        {
            var document = new Document("12573753453453");
            Assert.AreEqual(true, document.IsValid);
        }
    }
}