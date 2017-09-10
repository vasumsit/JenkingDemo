using FizzBuzzBusinessInterfaces;
//using FizzBuzzCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzBusiness
{
    public class FizzBuzzNumbers
    {
        static List<IFizzBuzz> _FizzorBuzz;

        static FizzBuzzNumbers()
        {
            _FizzorBuzz = new List<IFizzBuzz>();
            _FizzorBuzz.Add(new Fizz());
            _FizzorBuzz.Add(new Buzz());
        }
        /// <summary>
        /// Defines a method to get numbers
        /// </summary>
        /// <param name="getNumbers"></param>
        /// <returns></returns>
        public static string GetFizzorBuzzNumber(int i, string Name)
        {
            string fizzbuzzNumber = string.Empty;
            foreach (var r in _FizzorBuzz)
            {
                if (r.Color == Name)
                {
                    if (r.isDivisiable(i))
                    {
                        fizzbuzzNumber = r.Display();
                        break;
                    }
                }
            }

            return fizzbuzzNumber;
        }

    }
}
