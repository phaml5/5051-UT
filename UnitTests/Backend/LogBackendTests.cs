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
    }
}
