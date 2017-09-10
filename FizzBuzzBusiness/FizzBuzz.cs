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
    /// method for divided by 5 and 3
    /// </summary>
    public class FizzBuzz :  IFizzBuzz
    {
        INameOfDay _NameOfDay;

        public FizzBuzz(INameOfDay NameOfDay)
        {
            _NameOfDay = NameOfDay;

        }
        public bool isDivisiable(int Number)
        {
            if (Number % 3 == 0 & Number % 5 == 0)
            {
                return true;
            }
            return false;
        }

        public FizzOrBuzzValue Display()
        {
            if (this._NameOfDay.isDayOfWeek(DayOfWeek.Wednesday))
            {
                return FizzOrBuzzValue.WizzWuzz;
            }
            return FizzOrBuzzValue.FizzBuzz;
        }
    }
}
