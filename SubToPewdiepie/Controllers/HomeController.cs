using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SubToPewdiepie.Models;

namespace SubToPewdiepie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult MainPage()
        {
            return View();
        }

<<<<<<< HEAD
=======
        public IActionResult About()
        {
            return View();
        }

>>>>>>> f47adea8325637fbe419e111ad9e79b3f5c86026
        public IActionResult Contact()
        {
            return View();
        }

<<<<<<< HEAD
=======
        public IActionResult Merch()
        {
            return View();
        }

>>>>>>> f47adea8325637fbe419e111ad9e79b3f5c86026
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
