using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyStore.Core.Models;

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
            ViewBag.Name = $"You are logged in: {userName}";

            var user = new User();

            return View();

            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("http://localhost:64189/api/");
            //    //HTTP GET
            //    var responseTask = client.GetAsync("student");
            //    responseTask.Wait();

            //    var result = responseTask.Result;
            //    if (result.IsSuccessStatusCode)
            //    {
            //        var readTask = result.Content.ReadAsAsync<IList<StudentViewModel>>();
            //        readTask.Wait();

            //        students = readTask.Result;
            //    }
            //    else //web api sent error response 
            //    {
            //        //log response status here..

            //        students = Enumerable.Empty<StudentViewModel>();

            //        ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
            //    }
            }

            //https://localhost:44335/

            //Todo find username of logged in user. in Store Backend.
            //return View();
        }
    }
