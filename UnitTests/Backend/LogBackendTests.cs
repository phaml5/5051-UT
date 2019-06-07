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
        public void LogBackend_Index_Default_Should_Pass()
        {
            // Should load the dataset with 4 rows

            // Arange
            var myData = LogBackend.Instance;

            // Act
            var result = myData.Index().LogList;

            // Assert
            Assert.AreEqual(4, result.Count);
        }

        [TestMethod]
        public void LogBackend_Update_First_Item_Should_Pass()
        {
            // Delete the first item from the list, and then check the list to verify it is gone

            // Arange
            var myData = LogBackend.Instance;

            // Get the first item from the list
            var oldItem = myData.Index().LogList.First();
            var oldPhoneID = oldItem.PhoneID;

            // Change the ID
            oldItem.PhoneID = "UpdatedPhone";


            // Act
            var result = myData.Update(oldItem);
            var newItem = myData.Read(oldItem.ID);

            // Assert
            Assert.AreNotEqual(oldPhoneID, newItem.PhoneID);
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

        [TestMethod]
        public void LogBackend_Create_InValid_Null_Should_Fail()
        {
            // Arange
            var myData = LogBackend.Instance;

            // Act
            var newItem = myData.Create(null);

            // Check each item one by one to ensure it is correctly loaded

            // Assert
            Assert.AreEqual(null, newItem);
        }

        [TestMethod]
        public void LogBackend_Read_Valid_Item_Should_Pass()
        {
            // Delete the first item from the list, and then check the list to verify it is gone

            // Arange
            var myData = LogBackend.Instance;

            // Get the first item from the list
            var oldItem = myData.Index().LogList.First();

            // Act
            var newItem = myData.Read(oldItem.ID);

            // Check each item one by one to ensure it is correctly loaded

            // Assert
            Assert.AreEqual(oldItem.ID, newItem.ID);
            Assert.AreEqual(oldItem.PhoneID, newItem.PhoneID);
            Assert.AreEqual(oldItem.RecordedDateTime, newItem.RecordedDateTime);
            Assert.AreEqual(oldItem.Value, newItem.Value);
        }

        [TestMethod]
        public void LogBackend_Read_InValid_Bogus_Item_Should_Pass()
        {
            // Arange
            var myData = LogBackend.Instance;

            // Act
            var newItem = myData.Read("bogus");

            // Assert
            Assert.AreEqual(null, newItem);
        }
    }
}
