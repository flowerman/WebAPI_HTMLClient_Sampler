using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using EF6_Database.Models;
using EF6_Database.Context;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        // /api/products
        public List<Product> GetAllProducts()
        {
            using (var context = new ProductsContext())
            {
                var list = context.Products.ToList();
                return list;
            }
        }

        // /api/products/id
        public IHttpActionResult GetProduct(int id)
        {
            using (var context = new ProductsContext())
            {
                var product = context.Products.Where(x => x.ProductId == id).FirstOrDefault();
                if (product == null)
                {
                    return NotFound();
                }
                return Ok(product);
            }
        }
    } // end of
}
