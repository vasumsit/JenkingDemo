using FizzBuzzCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzBusinessInterfaces
{
    /// <summary>
    /// Interface for to implement Fizz Buzz rules
    /// </summary>
    public interface IFizzBuzz
    {
        bool isDivisiable(int Number);
        FizzOrBuzzValue Display();
    }
}
