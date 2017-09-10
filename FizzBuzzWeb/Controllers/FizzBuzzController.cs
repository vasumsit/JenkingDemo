using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FizzBuzzBusinessInterfaces;
using FizzBuzzCommon.Models;
using StructureMap;
using PagedList;

namespace FizzBuzzWeb.Controllers
{
    public class FizzBuzzController : Controller
    {
        /// <summary>
        /// fizzBuzzManager holds instance of IFizzBuzzManager
        /// </summary>
        private IFizzBuzzManager _fizzBuzzManager;


        /// <summary>
        /// FizzBuzzController constructor  
        /// </summary>
        /// <param name="fizzBuzzManager"></param>
        public FizzBuzzController(IFizzBuzzManager fizzBuzzManager)
        {
            _fizzBuzzManager = fizzBuzzManager;
        }

        /// <summary>
        /// This action method is used to handle web request with model with values
        /// </summary>
        /// <param name="fizzBuzzModel"></param>
        /// <returns></returns>        
        public virtual ActionResult FizzBuzzForm(FizzBuzzModel fizzBuzzModel, int? page)
        {
            try
            {
                if (!ModelState.IsValid) return View();
                var _numberList = this._fizzBuzzManager.GetNumbers(fizzBuzzModel);

                IList<NumberModel> fizzbuzzModelList = new List<NumberModel>();
                foreach (var item in _numberList)
                {
                    fizzbuzzModelList.Add(new NumberModel() { Number = item.Number, InputNumber = item.InputNumber });
                }
                int pageNumber = (page ?? 1);
                int pageSize = 20;

                fizzBuzzModel.Numbers = fizzbuzzModelList.ToPagedList(pageNumber, pageSize);
                return View("FizzBuzzForm", fizzBuzzModel);
            }
            catch
            {

            }
            return View();
        }


    }
}

