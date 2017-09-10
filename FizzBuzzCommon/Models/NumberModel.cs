using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace FizzBuzzCommon.Models
{
    /// <summary>
    /// Defines properties to store the fizz buzz numbers
    /// </summary>
    public class NumberModel
    {   
        public FizzOrBuzzValue Number { get; set; }
        public string InputNumber { get; set; }
       
    }

}
