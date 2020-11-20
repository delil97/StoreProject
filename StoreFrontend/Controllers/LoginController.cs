using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StoreFrontend.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("/Test", Name = "Custom")]
        public string Test()
        {
            return "This is the test page";
        } 
    }
}