using FizzBuzzCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace FizzBuzzWeb
{
    public static class FizzBuzzHelper
    {
        public static IHtmlString DivisibleResult(FizzOrBuzzValue content)
        {
            string htmlString = string.Empty;

            if (content == FizzOrBuzzValue.Fizz | content == FizzOrBuzzValue.Wizz)
            {
                htmlString = String.Format("<span class='FizzStyle'>{0}</span>", content);
            }
            if (content == FizzOrBuzzValue.Buzz | content == FizzOrBuzzValue.Wuzz)
            {
                htmlString += String.Format("<span class='BuzzStyle'>{0}</span>", content);
            }

            if (content == FizzOrBuzzValue.FizzBuzz)
            {
                htmlString = String.Format("<span class='FizzStyle'>{0}</span>", FizzOrBuzzValue.Fizz.ToString()) + " ";
                htmlString += String.Format("<span class='BuzzStyle'>{0 }</span>", FizzOrBuzzValue.Buzz.ToString());

            }
            if (content == FizzOrBuzzValue.WizzWuzz)
            {
                htmlString = String.Format("<span class='FizzStyle'>{0}</span> ", FizzOrBuzzValue.Wizz.ToString())+" ";
                htmlString += String.Format("<span class='BuzzStyle'>{0}</span>", FizzOrBuzzValue.Wuzz.ToString());
            }
            return new HtmlString(htmlString);
        }
    }
}