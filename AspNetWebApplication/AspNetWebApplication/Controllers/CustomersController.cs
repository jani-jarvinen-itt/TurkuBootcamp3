using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetWebApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public List<Customers> ListaaKaikki()
        {
            NorthwindContext context = new NorthwindContext();
            List<Customers> kaikki = context.Customers.ToList();
            return kaikki;
        }

        [HttpGet]
        [Route("{id}")]
        public Customers ListaaYksi(string id)
        {
            NorthwindContext konteksti = new NorthwindContext();
            Customers asiakas = (from c in konteksti.Customers
                                 where c.CustomerId == id
                                 select c).FirstOrDefault();

            //Customers asiakas2 = konteksti.Customers.Find(id);

            return asiakas;
        }

        [HttpPost]
        [Route("")]
        public bool LisääUusi(Customers uusi)
        {
            NorthwindContext konteksti = new NorthwindContext();
            konteksti.Customers.Add(uusi);

            konteksti.SaveChanges();
            return true;
        }

        [HttpDelete]
        [Route("")]
        public bool PoistaAsiakkaat()
        {
            return false;
        }
    }
}