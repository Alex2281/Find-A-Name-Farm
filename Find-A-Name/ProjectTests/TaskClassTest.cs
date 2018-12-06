using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Find_A_Name;

namespace ProjectTests
{
    [TestClass]
    public class TaskClassTest
    {
        Task t = new Task();

        [TestMethod]
        public void IdTest()
        {
            t.Id = 1;
            Assert.AreEqual(1, t.Id);
        }
        [TestMethod]
        public void EntryDateTest()
        {
            //t.EntryDate = ;
            //Assert.AreEqual(, t.EntryDate);
        }
        [TestMethod]
        public void ScheduledDateTest()
        {
            //t.ScheduledDate = ;
            //Assert.AreEqual(, t.ScheduledDate);
        }
        [TestMethod]
        public void EmployeeNameTest()
        {
            t.Employee = "Henery";
            Assert.AreEqual("Henery", t.Employee);
        }
        [TestMethod]
        public void TaskTypeTest()
        {
            t.TaskType = "Harvest";
            Assert.AreEqual("Harvest", t.TaskType);
        }
        [TestMethod]
        public void TaskStatusIdTest()
        {
            t.TaskStatus = "Pending";
            Assert.AreEqual("Pending", t.TaskStatus);
        }
        [TestMethod]
        public void CropTest()
        {
            t.Crop = "Barley";
            Assert.AreEqual("Barley", t.Crop);
        }
        [TestMethod]
        public void FieldIdTest()
        {
            t.Field = "Field 1";
            Assert.AreEqual("Field 1", t.Field);
        }
        [TestMethod]
        public void VehicleIdTest()
        {
            t.Vehicle = "Tractor";
            Assert.AreEqual("Tractor", t.Vehicle);
        }
        [TestMethod]
        public void StorageUnitIdTest()
        {
            t.StorageUnit = "Unit 2";
            Assert.AreEqual("Unit 2", t.StorageUnit);
        }
    }
}
