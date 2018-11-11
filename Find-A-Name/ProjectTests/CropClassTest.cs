using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Find_A_Name;

namespace ProjectTests
{
    [TestClass]
    public class CropClassTest
    {
        Crop c = new Crop();

        [TestMethod]
        public void IdTest()
        {
            c.Id = 1;
            Assert.AreEqual(1, c.Id);
        }
        [TestMethod]
        public void NameTest()
        {
            c.Name = "Wheat";
            Assert.AreEqual("Wheat", c.Name);
        }
        [TestMethod]
        public void CultivationTimeTest()
        {
            c.CultivationTime = 90;
            Assert.AreEqual(90, c.CultivationTime);
        }
        [TestMethod]
        public void FertiliserTime()
        {
            c.FertiliserFrequency = 30;
            Assert.AreEqual(30, c.FertiliserFrequency);
        }
    }
}
