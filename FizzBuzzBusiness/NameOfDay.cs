using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzBusiness
{
    public class NameOfDay : INameOfDay
    {
        bool isToday;
        DayOfWeek _dayOfweek;

        public NameOfDay()
        {
            _dayOfweek = DateTime.Today.DayOfWeek;
        }

        public NameOfDay(DayOfWeek nameOfDay)
        {
            _dayOfweek = nameOfDay;
        }

        public virtual bool isDayOfWeek(DayOfWeek dtDay)
        {
            isToday = (_dayOfweek == dtDay);
            return isToday;
        }
    }
}
