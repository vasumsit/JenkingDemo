using System.Web.Mvc;
using FizzBuzzWeb;
using NUnit.Framework;

namespace FizzBuzzTest
{
    /// <summary>
    ///This is a test class for CustomControllerFactoryTest and is intended
    ///to contain all CustomControllerFactoryTest Unit Tests
    ///</summary>
    [TestFixture]
    public class CustomControllerFactoryTest
    {
        /// <summary>
        ///A test for RegisterCustomControllerFactory
        ///</summary>
        [Test]
        public void RegisterCustomControllerFactoryTest()
        {
            CustomControllerFactory.RegisterCustomControllerFactory();

            var controllerFactory = ControllerBuilder.Current.GetControllerFactory();
            Assert.IsNotNull(controllerFactory);
        }

        

    }
}

