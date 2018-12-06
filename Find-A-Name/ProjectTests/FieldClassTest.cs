using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Find_A_Name;

namespace ProjectTests
{
    [TestClass]
    public class FieldClassTest
    {
        Field f = new Field();

        [TestMethod]
        public void IdTest()
        {
            f.Id = 1;
            Assert.AreEqual(1, f.Id);
        }
        [TestMethod]
        public void ReferenceTest()
        {
            f.Reference = "12549";
            Assert.AreEqual("12549", f.Reference);
        }
        [TestMethod]
        public void SizeTest()
        {
            f.Size = 256;
            Assert.AreEqual(256, f.Size);
        }
        [TestMethod]
        public void StatusTest()
        {
            f.Status = "Available";
            Assert.AreEqual("Available", f.Status);
        }
    }
}
