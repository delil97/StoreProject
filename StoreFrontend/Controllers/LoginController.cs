using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyStore.Core.Models;
using RestSharp;
using Newtonsoft;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace StoreFrontend.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult LogInUser(string userName, string password)
        {
            return Content($"You are logged in {userName}, welcome!");
        }
    }
}