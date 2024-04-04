using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Auth_Token_Class_Demo.Models;

namespace Auth_Token_Class_Demo.Controllers
{
    [Authorize(Roles ="Admin")]   // Check with Member too
    public class ProductController : ApiController
    {
        // GET: api/Product
        public IEnumerable<Product> GetProducts()
        { 
            var products = new ProductRepo().GetProducts();
            return products;
        }

        
    }
}
