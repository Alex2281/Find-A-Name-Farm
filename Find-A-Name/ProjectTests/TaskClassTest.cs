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
        public void EmployeeIdTest()
        {
            t.EmployeeId = 1;
            Assert.AreEqual(1, t.EmployeeId);
        }
        [TestMethod]
        public void TaskTypeIdTest()
        {
            t.TaskTypeId = 1;
            Assert.AreEqual(1, t.TaskTypeId);
        }
        [TestMethod]
        public void TaskStatusIdTest()
        {
            t.TaskStatusId = 1;
            Assert.AreEqual(1, t.TaskStatusId);
        }
        [TestMethod]
        public void CropIdTest()
        {
            t.CropId = 1;
            Assert.AreEqual(1, t.CropId);
        }
        [TestMethod]
        public void FieldIdTest()
        {
            t.FieldId = 1;
            Assert.AreEqual(1, t.FieldId);
        }
        [TestMethod]
        public void VehicleIdTest()
        {
            t.VehicleId = 1;
            Assert.AreEqual(1, t.VehicleId);
        }
        [TestMethod]
        public void StorageUnitIdTest()
        {
            t.StorageUnitId = 1;
            Assert.AreEqual(1, t.StorageUnitId);
        }
    }
}
