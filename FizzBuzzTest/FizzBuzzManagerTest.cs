using System;
using System.Linq;
using FizzBuzzBusinessInterfaces;
using FizzBuzzBusiness;
using FizzBuzzCommon.Models;
using NUnit.Framework;
using Moq;
using System.Collections.Generic;
namespace FizzBuzzTest
{
    /// <summary>
    ///This is a test class for FizzBuzzManagerTest and is intended
    ///to contain all FizzBuzzManagerTest Unit Tests
    ///</summary>
    [TestFixture]
    public class FizzBuzzManagerTest
    {
        private IFizzBuzzManager fizzBuzzManager;
        private FizzBuzzModel fizzBuzzModel;
        private Mock<IFizzBuzz> fizz;
        private Mock<IFizzBuzz> buzz;
        private Mock<IFizzBuzz> fizzbuzz;

        [SetUp]
        public void LoadContext()
        {
            fizz = new Mock<IFizzBuzz>();
            buzz = new Mock<IFizzBuzz>();
            fizzbuzz = new Mock<IFizzBuzz>();

            List<IFizzBuzz> list = new List<IFizzBuzz>();
            list.Add(fizz.Object);
            list.Add(buzz.Object);
            list.Add(fizzbuzz.Object);

            this.fizzBuzzManager = new FizzBuzzManager(list);
            this.fizzBuzzModel = new FizzBuzzModel();
        }

        /// <summary>
        /// Test Method for listofNumbers
        /// </summary>
        [Test]  
        public void should_get_listofnumbers_for_given_inputValue()
        {
            fizzBuzzModel.InputValue = 9;

            fizz.Setup(x => x.isDivisiable(fizzBuzzModel.InputValue)).Returns(true);
            fizz.Setup(x => x.Display()).Returns(FizzOrBuzzValue.FizzBuzz);
            var result = fizzBuzzManager.GetNumbers(fizzBuzzModel);

            fizz.Verify(x => x.isDivisiable(fizzBuzzModel.InputValue), Times.Once);
            Assert.NotNull(result);
            Assert.AreEqual(result.Count(), 9);
        }

        /// <summary>
        /// Test Method for divided by theree
        /// </summary>
        [Test]
        public void should_get_wizz_if_number_is_dividedby_three()
        {
            fizzBuzzModel.InputValue = 9;

            fizz.Setup(x => x.isDivisiable(fizzBuzzModel.InputValue)).Returns(true);
            fizz.Setup(x => x.Display()).Returns(FizzOrBuzzValue.Wizz);
            var result = fizzBuzzManager.GetNumbers(fizzBuzzModel);

            fizz.Verify(x => x.isDivisiable(fizzBuzzModel.InputValue), Times.Once);
            Assert.NotNull(result);
            Assert.AreEqual(result.Count(), 9);
        }
    }
}

