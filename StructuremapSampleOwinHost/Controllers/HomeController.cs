using StructuremapSampleOwinHost.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StructuremapSampleOwinHost.Controllers
{
    public class HomeController : ApiController
    {
        private ILoggerService _loggerService;


        public HomeController(ILoggerService loggerService)
        {

            _loggerService = loggerService;
        }

        [HttpGet]
        public string Get()
        {
            _loggerService.Log("welcome again");
            return "Welcome back";
         
        }
    }
}
