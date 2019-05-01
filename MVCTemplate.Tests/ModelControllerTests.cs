using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MVCTemplate.Tests
{
    [TestClass]
    public class ModelControllerTests
    {
        [TestMethod]
        public void IndexViewModelNotNull()
        {
            // Arrange
            var mock = new Mock<IRepository>();
            mock.Setup(a => a.GetComputerList()).Returns(new List<Computer>());
            ModelController controller = new ModelController(mock.Object);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result.Model);
        }
        public ActionResult Index()
        {
            var model = repo.GetComputerList();
            return View(model);
        }
        [TestMethod]
        public void IndexViewBagMessage()
        {
            // Arrange
            var mock = new Mock<IRepository>();
            mock.Setup(a => a.GetComputerList()).Returns(new List<Computer>() { new Computer() });
            HomeController controller = new HomeController(mock.Object);
            string expected = "В базе данных 1 объект";

            // Act
            ViewResult result = controller.Index() as ViewResult;
            string actual = result.ViewBag.Message as string;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
