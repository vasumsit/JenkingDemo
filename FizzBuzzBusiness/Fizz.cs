using FizzBuzzBusinessInterfaces;
using FizzBuzzCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzBusiness
{

    /// <summary>
    /// method for divided by 3
    /// </summary>
    public class Fizz : IFizzBuzz
    {
        INameOfDay _NameOfDay;        

        public Fizz(INameOfDay NameOfDay)
        {
            _NameOfDay = NameOfDay;

        }

        public FizzOrBuzzValue Display()
        {
            if (_NameOfDay.isDayOfWeek(DayOfWeek.Wednesday))
            {
                return FizzOrBuzzValue.Wizz;
            }

            return FizzOrBuzzValue.Fizz;
        }

        public bool isDivisiable(int Number)
        {
            if (Number % 3 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
