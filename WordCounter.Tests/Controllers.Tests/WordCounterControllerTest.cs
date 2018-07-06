using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class NewCounterControllerTest
    {
      [TestMethod]
      public void Index_ReturnsCorrectView_True()
      {
          //Arrange
          NewCounterController controller = new NewCounterController();

          //Act
          ActionResult indexView = controller.ReturnForm();

          //Assert
          Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }
      [TestMethod]
      public void Index2_ReturnsCorrectView_True()
      {
          //Arrange
          NewCounterController controller = new NewCounterController();

          //Act
          ActionResult indexView = controller.CreateForm();

          //Assert
          Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }
    }
}
