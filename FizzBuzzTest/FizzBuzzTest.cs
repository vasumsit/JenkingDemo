using FizzBuzzBusiness;
using FizzBuzzBusinessInterfaces;
using FizzBuzzCommon.Models;
using System;
using Moq;
using NUnit.Framework;


namespace FizzBuzzTest
{
    /// <summary>
    ///This is a test class for FizzBuzz and is intended
    ///to contain all Fizz Unit Tests
    ///</summary>
    [TestFixture]
    public class FizzBuzzTest
    {
        IFizzBuzz fizzbuzz;
        Mock<INameOfDay> mockDay;

        [SetUp]
        public void LoadContext()
        {
            mockDay = new Mock<INameOfDay>();
            fizzbuzz = new FizzBuzz(mockDay.Object);

        }

        /// <summary>
        /// Test Method for If divisiable
        /// </summary>
        [Test]
        public void should_get_true_if_given_inputnumber_is_divisiable()
        {
            var result = fizzbuzz.isDivisiable(15);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method for diplay results given input field
        /// </summary>
        [Test]
        public void should_get_fizzbuzz_if_inputnumber_is_dividedby_three()
        {
            mockDay.Setup(x => x.isDayOfWeek(DayOfWeek.Wednesday)).Returns(false);
            var result = fizzbuzz.isDivisiable(3);
            var output = fizzbuzz.Display();

            mockDay.Verify(x => x.isDayOfWeek(DayOfWeek.Wednesday), Times.Once);

            Assert.NotNull(result);
            Assert.AreEqual(output, FizzOrBuzzValue.FizzBuzz);
        }

        /// <summary>
        /// Test Method for display results if it is wednesday.
        /// </summary>
        [Test]
        public void should_get_return_wizzwuzz_if_day_is_wednesday()
        {
            mockDay.Setup(x => x.isDayOfWeek(DayOfWeek.Wednesday)).Returns(true);
            var result = fizzbuzz.isDivisiable(3);
            var output = fizzbuzz.Display();

            mockDay.Verify(x => x.isDayOfWeek(DayOfWeek.Wednesday), Times.Once);

            Assert.NotNull(result);
            Assert.AreEqual(output, FizzOrBuzzValue.WizzWuzz);
        }
    }
}
