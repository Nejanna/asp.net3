using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab3.Models
{
    public class TimeService
    {
        public string GetTimeOfDay()
        {
            var dateTime = DateTime.Now;
            if (dateTime.Hour >= 12 && dateTime.Hour < 18)
            {
                return "зараз день";
            }
            else if (dateTime.Hour >= 18 && dateTime.Hour < 24)
            {
                return "зараз вечір";
            }
            else if (dateTime.Hour >= 0 && dateTime.Hour < 6)
            {
                return "зараз ніч";
            }
            else
            {
                return "зараз ранок";
            }
        }
    }
}
