using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Challenge_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            ProductContent content = new ProductContent();

            content.ProductName = "cinnamon roll";
            string expected = "cinnamon roll";
            Assert.AreEqual(expected, content.ProductName);

            ProductContent contentTwo = new ProductContent("apple pie", "Johnny Hopkins", 4, 851.50m, ProductType.pie);
            contentTwo.ProductName = "apple pie";
            string expectedTwo = "apple pie";
            Assert.AreEqual(expectedTwo, contentTwo.ProductName);

            contentTwo.Type = ProductType.pie;
            ProductType expectedType = ProductType.pie;
            Assert.AreEqual(expectedType, contentTwo.Type);

        }
    }
}
