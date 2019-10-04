using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetWebApplication.Models;

namespace AspNetWebApplication.Controllers
{
    /// <summary>
    /// Tämä on oma kontrolleri-luokkani....
    /// </summary>
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            NorthwindContext context = new NorthwindContext();
            int lkm = context.Customers.Count();

            ViewBag.AsiakkaidenLkm = lkm;

            return View();
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
