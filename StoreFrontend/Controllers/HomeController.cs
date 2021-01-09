using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StoreFrontend.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ListAdsBoard(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (string.IsNullOrEmpty(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format($"pageIndex={pageIndex}&sortBy{sortBy}"));
        }
    }
}