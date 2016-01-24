using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Władca Pierścieni Trylogia", Category = "Książka", Price = 99.99M },
            new Product { Id = 2, Name = "Harry Potter", Category = "Książka", Price =150M },
            new Product { Id = 3, Name = "Saga Zmierzch", Category = "Książka", Price = 170M },
            new Product { Id = 4, Name = "Mata do Jogi", Category = "Akcesoria", Price = 120M },
            new Product { Id = 5, Name = "Hantelki", Category = "Akcesoria", Price = 24.99M },
            new Product { Id = 6, Name = "Piłka do ćwiczeń", Category = "Akcesoria", Price = 65.80M }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
