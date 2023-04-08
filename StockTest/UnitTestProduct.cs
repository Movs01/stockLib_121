using Microsoft.VisualStudio.TestTools.UnitTesting;
using stockLib_121;
using StockLib_121;
using System;
using System.Security.Cryptography.X509Certificates;

namespace StockTest
{
    [TestClass]
    public class UnitTestProduct
    {
        [TestMethod]
        public void TestConstructorDefault()
        {
            Product product = new Product();
            Assert.AreNotEqual(product.Id, 0);
            Assert.AreEqual("Новый товар", product.Name);
            Assert.AreEqual("XXX-000-00", product.Article);
            Assert.AreEqual(0, product.Price);
            Assert.AreEqual(UnitMeasure.штука, product.Unit);
            Assert.AreEqual(DateTime.Today, product.DateReceipt);
            Assert.AreEqual(0, product.Margin);
            Assert.AreEqual(false, product.IsFrozen);
            Assert.AreEqual("dafault.bmp", product.ImagePath);
        }
        [TestMethod]
        public void TestConstructorWithParam()
        {
            Product product = new Product("Товар 1", "TTT-123-45", 1234, 456.78);
            Assert.AreNotEqual(product.Id, 0);
            Assert.AreEqual("Товар 1", product.Name);
            Assert.AreEqual("TTT-123-45", product.Article);
            Assert.AreEqual(1234, product.Price);
            Assert.AreEqual(UnitMeasure.штука, product.Unit);
            Assert.AreEqual(DateTime.Today, product.DateReceipt);
            Assert.AreEqual(456.78, product.Margin);
            Assert.AreEqual(false, product.IsFrozen);
            Assert.AreEqual("dafault.bmp", product.ImagePath);
        }
    }
}
