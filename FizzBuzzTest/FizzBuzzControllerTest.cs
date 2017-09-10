using System;
using System.Linq;
using System.Web.Mvc;
using FizzBuzzBusinessInterfaces;
using FizzBuzzBusiness;
using FizzBuzzWeb.Controllers;
using FizzBuzzCommon.Models;
using NUnit.Framework;
using Moq;
using System.Collections.Generic;

namespace FizzBuzzTest
{
    /// <summary>
    ///This is a test class for FizzBuzzControllerTest and is intended
    ///to contain all FizzBuzzControllerTest Unit Tests
    ///</summary>
    [TestFixture]
    public class FizzBuzzControllerTest
    {
        private FizzBuzzController fizzBuzzController;
        private Mock<IFizzBuzzManager> fizzBuzzManager;
        private FizzBuzzModel fizzBuzzModel;

        private object result;

        [SetUp]
        public void LoadContext()
        {
            fizzBuzzManager = new Mock<IFizzBuzzManager>();
            fizzBuzzController = new FizzBuzzController(fizzBuzzManager.Object);
            fizzBuzzController.ControllerContext = new ControllerContext();
            this.fizzBuzzModel = new FizzBuzzModel();
        }


        /// <summary>
        /// Test Method for ViewName
        /// </summary>
        [Test]
        public void sould_return__viewName()
        {
            fizzBuzzModel = new FizzBuzzModel { InputValue = 2 };
            var stub = new List<NumberModel>();
            stub.Add(new NumberModel() { InputNumber = "1", Number = FizzOrBuzzValue.Buzz });
            stub.Add(new NumberModel() { InputNumber = "2", Number = FizzOrBuzzValue.Buzz });
            fizzBuzzManager.Setup(x => x.GetNumbers(fizzBuzzModel)).Returns(stub);

            fizzBuzzController = new FizzBuzzController(fizzBuzzManager.Object);
            result = fizzBuzzController.FizzBuzzForm(fizzBuzzModel, 1);
            var viewResult = result as ViewResult;

            Assert.IsNotNull(result);
            fizzBuzzManager.Verify(x => x.GetNumbers(fizzBuzzModel), Times.Once);
            Assert.AreEqual("FizzBuzzForm", viewResult.ViewName);
        }

    }
}
