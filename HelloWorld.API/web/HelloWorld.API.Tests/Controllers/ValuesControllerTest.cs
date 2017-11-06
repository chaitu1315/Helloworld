using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.API;
using HelloWorld.API.Controllers;

namespace HelloWorld.API.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void TestGetMethod()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(4, result.Count()); //change here if u made change in api method
            Assert.AreEqual("New York", result.ElementAt(0));
            Assert.AreEqual("Chicago", result.ElementAt(1));
            Assert.AreEqual("Dallas", result.ElementAt(2));
            Assert.AreEqual("Las Vegas", result.ElementAt(3));
        }
    }
}