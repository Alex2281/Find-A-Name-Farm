using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Find_A_Name;

namespace ProjectTests
{
    [TestClass]
    public class EmployeeClassTest
    {
        Employee e = new Employee();

        [TestMethod]
        public void IdTest()
        {
            e.Id = 1;
            Assert.AreEqual(1, e.Id);
        }
        [TestMethod]
        public void NameTest()
        {
            e.Name = "Last, First";
            Assert.AreEqual("Last, First", e.Name);
        }
        [TestMethod]
        public void AddressTest()
        {
            e.Address = "Home";
            Assert.AreEqual("Home", e.Address);
        }
        [TestMethod]
        public void PhoneTest()
        {
            e.Phone = "07968790700";
            Assert.AreEqual("07968790700", e.Phone);
        }
        [TestMethod]
        public void EmailTest()
        {
            e.Address = "Home";
            Assert.AreEqual("Home", e.Address);
        }
        [TestMethod]
        public void UsernameTest()
        {
            e.Username = "Alex";
            Assert.AreEqual("Alex", e.Username);
        }
        [TestMethod]
        public void PasswordTest()
        {
            e.Password = "12345";
            Assert.AreEqual("12345", e.Password);
        }
        [TestMethod]
        public void PrivilageTest()
        {
            e.Privilage = true;
            Assert.IsTrue(e.Privilage);
        }
    }
}
