using System;
using NUnit;
using NUnit.Framework;
using FizzBuzzBusinessInterfaces;
using FizzBuzzBusiness;
using FizzBuzzCommon.Models;
using Moq;

namespace FizzBuzzTest
{
    /// <summary>
    ///This is a test class for Fizz and is intended
    ///to contain all Fizz Unit Tests
    ///</summary>
    [TestFixture]
    public class FizzTest
    {
        IFizzBuzz fizz;
        Mock<INameOfDay> mockDay;

        [SetUp]
        public void LoadContext()
        {
            mockDay = new Mock<INameOfDay>();
            fizz = new Fizz(mockDay.Object);
            
        }

        /// <summary>
        /// Test Method for If divisiable
        /// </summary>
        [Test]
        public void should_get_true_if_given_inputnumber_is_divisiable()
        {
            var result = fizz.isDivisiable(3);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method for diplay results given input field
        /// </summary>
        [Test]
        public void should_get_fizz_if_inputnumber_is_dividedby_three()
        {            
            mockDay.Setup(x => x.isDayOfWeek(DayOfWeek.Wednesday)).Returns(false);
            var result = fizz.isDivisiable(3);
            var output = fizz.Display();

            mockDay.Verify(x => x.isDayOfWeek(DayOfWeek.Wednesday), Times.Once);

            Assert.NotNull(result);
            Assert.AreEqual(output, FizzOrBuzzValue.Fizz);
        }

        /// <summary>
        /// Test Method for display results if it is wednesday.
        /// </summary>
        [Test]
        public void should_get_return_wizz_if_day_is_wednesday()
        {
            mockDay.Setup(x => x.isDayOfWeek(DayOfWeek.Wednesday)).Returns(true);
            var result = fizz.isDivisiable(3);
            var output = fizz.Display();

            mockDay.Verify(x => x.isDayOfWeek(DayOfWeek.Wednesday), Times.Once);

            Assert.NotNull(result);
            Assert.AreEqual(output, FizzOrBuzzValue.Wizz);
        }
    }
}
