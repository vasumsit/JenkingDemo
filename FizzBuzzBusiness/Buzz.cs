using FizzBuzzBusinessInterfaces;
using FizzBuzzCommon.Models;
//using FizzBuzzCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzBusiness
{
    /// <summary>
    /// method for divided by 5
    /// </summary>
    public class Buzz : IFizzBuzz
    {
        INameOfDay _NameOfDay;

        public Buzz(INameOfDay NameOfDay)
        {
            _NameOfDay = NameOfDay;

        }

        public FizzOrBuzzValue Display()
        {
            if (this._NameOfDay.isDayOfWeek(DayOfWeek.Wednesday))
            {
                return FizzOrBuzzValue.Wuzz;
            }

            return FizzOrBuzzValue.Buzz;

        }

        public bool isDivisiable(int Number)
        {
            if (Number % 5 == 0)
            {
                return true;
            }
            return false;

        }
                
    }


}
