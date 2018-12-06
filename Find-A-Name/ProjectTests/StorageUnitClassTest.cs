using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Find_A_Name;

namespace ProjectTests
{
    [TestClass]
    public class StorageUnitClassTest
    {
        StorageUnit su = new StorageUnit();

        [TestMethod]
        public void IdTest()
        {
            su.Id = 1;
            Assert.AreEqual(1, su.Id);
        }
        [TestMethod]
        public void ReferenceTest()
        {
            su.Reference = "542";
            Assert.AreEqual("542", su.Reference);
        }
        [TestMethod]
        public void TotalCapacityTest()
        {
            su.TotalCapacity = 11000;
            Assert.AreEqual(11000, su.TotalCapacity);
        }
        [TestMethod]
        public void CurrentCapacityTest()
        {
            su.CurrentCapacity = 600;
            Assert.AreEqual(600, su.CurrentCapacity);
        }
        [TestMethod]
        public void StoredCropTest()
        {
            su.StoredCrop = "Wheat";
            Assert.AreEqual("Wheat", su.StoredCrop);
        }
    }
}
