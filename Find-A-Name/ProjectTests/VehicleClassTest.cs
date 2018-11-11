using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Find_A_Name;

namespace ProjectTests
{
    [TestClass]
    public class VehicleClassTest
    {
        Vehicle v = new Vehicle();

        [TestMethod]
        public void IdTest()
        {
            v.Id = 1;
            Assert.AreEqual(1, v.Id);
        }
        [TestMethod]
        public void TypeTest()
        {
            v.Type = "Tractor";
            Assert.AreEqual("Tractor", v.Type);
        }
        [TestMethod]
        public void DescriptionTest()
        {
            v.Description = "Used to manage various farm task.";
            Assert.AreEqual("Used to manage various farm task.", v.Description);
        }
        [TestMethod]
        public void VehicleStatusTest()
        {
            v.VehicleStatusId = 1;
            Assert.AreEqual(1, v.VehicleStatusId);
        }
    }
}
