using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FizzBuzzCommon.Models;


namespace FizzBuzzBusinessInterfaces
{
    /// <summary>
    /// Defines a method to get numbers 
    /// </summary>
    public interface IFizzBuzzManager
    {
        /// <summary>
        /// Fill the NumberModel property of fizzBuzzModel with fizz and buzz for InputValue
        /// </summary>
        /// <param name="fizzBuzzModel"></param>
        /// <returns></returns>
        List<NumberModel> GetNumbers(FizzBuzzModel fizzBuzzModel);
    }
}
