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
        private void LinqTesti()
        {
            int[] luvut = { 7, 4, 11, 5, 2, 10, 8, 3, 9, 6, 1, 12 };

            // viittä suuremmat, numerojärjestyksessä
            List<int> suuret = (from l in luvut
                                where l > 5
                                orderby l
                                select l).ToList();
            foreach (int suuri in suuret)
            {
                Console.WriteLine(suuri);
            }



            //for (int laskuri = 0; laskuri < luvut.Length; laskuri++)
            //{
            //    if (luvut[laskuri] > 5)
            //    {
            //        Console.WriteLine(luvut[laskuri]);
            //    }
            //}
        }

        public IActionResult Testi123()
        {
            return View();
        }
               
        public IActionResult Index()
        {
            NorthwindContext context = new NorthwindContext();
            List<Customers> suomalaiset = (from c in context.Customers
                                           where c.Country == "Finland"
                                           select c).ToList();

            foreach (Customers asiakas in suomalaiset)
            {
                int lkm = asiakas.Orders.Count();
                foreach (Orders tilaus in asiakas.Orders)
                {

                }
            }








            /*

            // asiakkaiden lukumäärä
            NorthwindContext context = new NorthwindContext();
            int lkm = context.Customers.Count();
            ViewBag.AsiakkaidenLkm = lkm;

            // listaus asiakkaista (generic type)
            List<Customers> asiakkaat = context.Customers.ToList();
            ViewBag.KaikkiAsiakkaat = asiakkaat;

            // haetaan suomalaiset asiakkaat
            List<Customers> suomalaiset = (from c in context.Customers
                                           where c.Country == "Finland"
                                           select c).ToList();
            ViewBag.KaikkiAsiakkaat = suomalaiset;

            List<Customers> suomalaiset2 =
                context.Customers.Where(c => c.Country == "Finland").ToList();

    */
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
