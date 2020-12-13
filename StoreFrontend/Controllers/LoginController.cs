using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyStore.Core.Models;
using RestSharp;
using Newtonsoft;

namespace StoreFrontend.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string userName, string password)
        {
            
            var user = new User();

            var client = new RestClient("https://localhost:5000/api/user/");
            client.AddDefaultQueryParameter("username", userName);
            client.AddDefaultQueryParameter("password", password);
            
            var request = new RestRequest("",Method.GET, DataFormat.Json);

            var response = client.Execute(request);

            ViewBag.Name = $"You are logged in: {response.Content}";

            return View();
        }
    }
}