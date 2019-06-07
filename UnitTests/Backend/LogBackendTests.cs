using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Backend;
using HW1c.Models;
using System.Linq;

namespace UnitTests.Backend
{
    [TestClass]
    public class LogBackendTests
    {
        [TestMethod]
        public void LogBackend_Static_Instantiate_Should_Pass()
        {
            // Arange

            // Act
            var result = LogBackend.Instance;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LogBackend_Create_Valid_Item_Should_Pass()
        {
            // Arange
            var myData = LogBackend.Instance;

            // Get the first item from the list
            var oldItem = new LogModel();
            oldItem.ID = "ID";
            oldItem.PhoneID = "PhoneID";
            oldItem.RecordedDateTime = DateTime.Parse("01/23/2019");
            oldItem.Value = "Value";


            // Act
            var newItem = myData.Create(oldItem);

            // Check each item one by one to ensure it is correctly loaded

            // Assert
            Assert.AreEqual(oldItem.ID, newItem.ID);
            Assert.AreEqual(oldItem.PhoneID, newItem.PhoneID);
            Assert.AreEqual(oldItem.RecordedDateTime, newItem.RecordedDateTime);
            Assert.AreEqual(oldItem.Value, newItem.Value);
        }

    }
}
