using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

using FizzBuzzWeb.Controllers;
using FizzBuzzBusinessInterfaces;

using FizzBuzzBusiness;

namespace FizzBuzzWeb
{
    /// <summary>
    /// Defines methods to create instance for controllers and register custom controller factory
    /// </summary>
    public class CustomControllerFactory : DefaultControllerFactory
    {
        /// <summary>
        /// Register CustomControllerFactory class
        /// </summary>
        public static void RegisterCustomControllerFactory()
        {
            ControllerBuilder.Current.SetControllerFactory(new CustomControllerFactory());
        }

        /// <summary>
        /// Generates instance for controller for given type
        /// </summary>
        /// <param name="requestContext"></param>
        /// <param name="controllerType"></param>
        /// <returns></returns>
        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            try
            {
                if (controllerType == null)
                {
                    controllerType = typeof(FizzBuzzController);
                }

                // Creating instance for FizzBuzzManager
                IFizzBuzzManager fizzBuzzManager = new FizzBuzzManager();

                // Creating instance for controller;
                var controller = Activator.CreateInstance(controllerType, new object[] { fizzBuzzManager });

                return controller as Controller;
            }
            catch (Exception ex)
            {
            }
            return null;
        }
    }
}

