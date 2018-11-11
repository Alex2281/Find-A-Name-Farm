using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Find_A_Name;

namespace ProjectTests
{
    [TestClass]
    public class FertiliserClassTest
    {
        Fertiliser f = new Fertiliser();

        [TestMethod]
        public void IdTest()
        {
            f.Id = 1;
            Assert.AreEqual(1, f.Id);
        }
        [TestMethod]
        public void NameTest()
        {
            f.Name = "Futterxl";
            Assert.AreEqual("Futterxl", f.Name);
        }
        [TestMethod]
        public void StockQuantityTest()
        {
            f.StockQuantity = 59;
            Assert.AreEqual(59, f.StockQuantity);
        }
    }
}
