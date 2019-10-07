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

        [HttpDelete]
        [Route("")]
        public bool PoistaAsiakkaat()
        {
            return false;
        }
    }
}