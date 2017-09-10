using PagedList;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace FizzBuzzCommon.Models
{
    /// <summary>
    /// Defines properties to store the user entered data and generated fizz buzz numbers
    /// </summary>
    public class FizzBuzzModel
    {
        /// <summary>
        /// Holds the user entered integer value
        /// </summary>
        [Required]
        [RegularExpression(@"\d+")]
        [Range(1, 1000)]
        public int InputValue { get; set; }

        /// <summary>
        /// Hold the list of generated list of  fizz buzz numbers 
        /// </summary>
        public virtual IPagedList<NumberModel> Numbers { get; set; }
    }

}
