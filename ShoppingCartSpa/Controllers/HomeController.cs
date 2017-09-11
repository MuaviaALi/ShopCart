using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShoppingCartSpa.Controllers
{
    public class HomeController : ApiController
    {
        [Route("api/GetProducts")]
        [HttpGet]
        public List<Product> GetProducts()
        {
            var db = new ShopCartEntities();
            db.Configuration.ProxyCreationEnabled = false;

            return db.Products.ToList();
        }
    }
}
