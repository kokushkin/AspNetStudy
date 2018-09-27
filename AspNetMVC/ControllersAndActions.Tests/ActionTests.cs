using System;
using System.Web.Mvc;
using ControllersAndActions.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ControllersAndActions.Tests
{
    [TestClass]
    public class ActionTests
    {
        [TestMethod]
        public void ControllerTest()
        {
            // Организация - создание контроллера
            ExampleController controller = new ExampleController();

            // Действие - вызов метода действия
            ViewResult result = controller.Index();

            // Утверждение - проверка результата
            Assert.AreEqual("", result.ViewName);
            Assert.AreEqual("Привет", result.ViewBag.Message);
        }

        [TestMethod]
        public void ViewSelectionTest()
        {
            // Организация - создание контроллера
            ExampleController controller = new ExampleController();

            // Действие - вызов метода действия
            ViewResult result = controller.Index();

            // Утверждение - проверка результата
            Assert.AreEqual("", result.ViewName);
            Assert.IsInstanceOfType(result.ViewData.Model, typeof(System.DateTime));
        }
    }
}
