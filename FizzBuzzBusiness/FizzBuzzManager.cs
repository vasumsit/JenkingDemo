using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FizzBuzzCommon.Models;
using FizzBuzzBusinessInterfaces;


namespace FizzBuzzBusiness
{
    /// <summary>
    /// Defines a method to get numbers 
    /// </summary>
    public class FizzBuzzManager : IFizzBuzzManager
    {
        List<IFizzBuzz> _list;
        public FizzBuzzManager(List<IFizzBuzz> list)
        {
            _list = list;

        }
        /// <summary>
        /// Fill the Numbers property of fizzBuzzModel with fizz and buzz numbers for InputValue
        /// </summary>
        /// <param name="fizzBuzzModel"></param>
        /// <returns></returns>
        public virtual List<NumberModel> GetNumbers(FizzBuzzModel fizzBuzzModel)
        {
            List<NumberModel> NumbersList = new List<NumberModel>();

            if (fizzBuzzModel == null) return null;
            if (fizzBuzzModel.InputValue < 0 || fizzBuzzModel.InputValue > 1000) return null;

            try
            {
                for (int i = 1; i <= fizzBuzzModel.InputValue; i++)
                {
                    var numberModel = new NumberModel();

                    if (i < 1) return null;

                    var result = _list.Find(x => x.isDivisiable(i));

                    if (result != null)
                    {
                        numberModel.Number = result.Display();
                    }
                    else
                    {
                        numberModel.InputNumber = i.ToString();
                    }

                    NumbersList.Add(numberModel);
                }

            }
            catch (Exception ex)
            {
                // TODO: Exception handling code
            }
            return NumbersList;

        }

    }
}
