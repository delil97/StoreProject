using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StoreFrontend.Controllers
{
    public class AdsController : Controller
    {
        public IActionResult Index(int year = 2, int month = 2)
        {
            return Content($"Ads controller year {year}, month: {month}");
        }
    }
}
