using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using  MVCDEMO.Models;
namespace MVCDEMO.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetAllProduct()
        {
            List<Product> productlist = new List<Product>()
            {
                new Product{Id=1,Name="Laptop",Company="Dell",Price=40000},
                new Product{Id=2,Name="Laptop",Company="HP",Price=50000},
                new Product{Id=3,Name="Laptop",Company="Lenovo",Price=30000},
                new Product{Id=4,Name="Mouse",Company="Dell",Price=400},
                new Product{Id=5,Name="Keyword",Company="Dell",Price=700},
            };
            ViewBag.ProductList = productlist;
            return View();
        }
    }
}
