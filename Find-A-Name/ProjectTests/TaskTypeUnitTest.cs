using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Find_A_Name;

namespace ProjectTests
{
    [TestClass]
    public class TaskTypeUnitTest
    {
        TaskType tt = new TaskType();

        [TestMethod]
        public void IdTest()
        {
            tt.Id = 1;
            Assert.AreEqual(1, tt.Id);
        }
        [TestMethod]
        public void NameTest()
        {
            tt.Name = "Plough Field";
        }
        [TestMethod]
        public void DescriptionTest()
        {
            tt.Description = "This is the vehicle description.";
            Assert.AreEqual("This is the vehicle description.", tt.Description);
        }
    }
}
