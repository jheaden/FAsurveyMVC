using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FAsurveyintoMVC.Models;
using FAQuizMVC.ViewModels;

namespace FAsurveyintoMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new TestViewModel();

            model.Test.Add("Test");
            model.Test.Add("Test2");

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(List<string> model)
        {
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
