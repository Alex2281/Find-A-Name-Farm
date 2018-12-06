using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Find_A_Name;

namespace ProjectTests
{
    [TestClass]
    public class TaskStatusUnitTest
    {
        TaskStatus ts = new TaskStatus();

        [TestMethod]
        public void IdTest()
        {
            ts.Id = 1;
            Assert.AreEqual(1, ts.Id);
        }
        [TestMethod]
        public void NameTest()
        {
            ts.Name = "Pending";
            Assert.AreEqual("Pending", ts.Name);
        }
    }
}
