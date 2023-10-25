using lab3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab3.Controllers
{
        [ApiController]
        [Route("")]
        public class TimeController : ControllerBase
        {
            private readonly TimeService time;

            public TimeController(TimeService timeservice)
            {
                time = timeservice;
            }
             public string GetTimeOfDay()
             {
                 var timeOfDay = time.GetTimeOfDay();
                 return timeOfDay;
             }
    }

    }
