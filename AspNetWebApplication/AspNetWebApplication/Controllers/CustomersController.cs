using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetWebApplication.Controllers
{
    public class Auto
    {
        public string Väri { get; set; }
        public int Huippunopeus { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [Route("testi1")]
        public int Luku()
        {
            return 12345;
        }

        [Route("testi2")]
        public int[] Luvut()
        {
            int[] luvut = { 1, 2, 3, 4, 5 };
            return luvut;
        }

        [Route("testi3")]
        public bool Boolean()
        {
            return true;
        }

        [Route("testi4")]
        public Auto Luokka()
        {
            Auto a = new Auto();
            a.Väri = "Keltainen";
            a.Huippunopeus = 245;
            return a;
        }

        [Route("moi")]
        public string SanoMoi()
        {
            return "Moikka!";
        }

        [Route("hei")]
        public string SanoHei()
        {
            return "Heippa!";
        }
    }
}