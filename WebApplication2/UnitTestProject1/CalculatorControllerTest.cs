using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication2.Controllers;
using System.Web.Mvc;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculatorControllerTest
    {
        [TestMethod]
        public void TestIndex()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestAuthor()
        {
            var controller = new CalculatorController();
            var result = controller.showAuthor();
            Assert.AreEqual("iiii",result);
        }
    }
}
