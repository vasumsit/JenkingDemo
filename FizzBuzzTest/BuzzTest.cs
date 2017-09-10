using FizzBuzzBusiness;
using FizzBuzzBusinessInterfaces;
using FizzBuzzCommon.Models;
using Moq;
using NUnit.Framework;
using System;


namespace FizzBuzzTest
{
    /// <summary>
    ///This is a test class for Buzz and is intended
    ///to contain all Fizz Unit Tests
    ///</summary>
    [TestFixture]
    public class BuzzTest
    {
        IFizzBuzz buzz;
        Mock<INameOfDay> mockDay;

        [SetUp]
        public void LoadContext()
        {
            mockDay = new Mock<INameOfDay>();
            buzz = new Buzz(mockDay.Object);

        }

        /// <summary>
        /// Test Method for If divisiable
        /// </summary>
        [Test]
        public void should_get_true_if_given_inputnumber_is_divisiable()
        {
            var result = buzz.isDivisiable(5);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test Method for diplay results given input field
        /// </summary>
        [Test]
        public void should_get_buzz_if_inputnumber_is_dividedby_three()
        {
            mockDay.Setup(x => x.isDayOfWeek(DayOfWeek.Wednesday)).Returns(false);
            var result = buzz.isDivisiable(3);
            var output = buzz.Display();

            mockDay.Verify(x => x.isDayOfWeek(DayOfWeek.Wednesday), Times.Once);

            Assert.NotNull(result);
            Assert.AreEqual(output, FizzOrBuzzValue.Buzz);
        }

        /// <summary>
        /// Test Method for display results if it is wednesday.
        /// </summary>
        [Test]
        public void should_get_return_wuzz_if_day_is_wednesday()
        {
            mockDay.Setup(x => x.isDayOfWeek(DayOfWeek.Wednesday)).Returns(true);
            var result = buzz.isDivisiable(3);
            var output = buzz.Display();

            mockDay.Verify(x => x.isDayOfWeek(DayOfWeek.Wednesday), Times.Once);

            Assert.NotNull(result);
            Assert.AreEqual(output, FizzOrBuzzValue.Wuzz);
        }
    }
}
