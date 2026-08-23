using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAppDEMO.Models;

namespace WebAppDEMO.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product{ Id=1, Name="Product 1", Price=500000m, Stock=12, ImageUrl="/images/bag.svg", CreatedAt = System.DateTime.Parse("2020-12-25")},
                new Product{ Id=2, Name="Product 2", Price=700000m, Stock=5, ImageUrl="/images/bag.svg", CreatedAt = System.DateTime.Parse("2020-12-25")},
                new Product{ Id=3, Name="Product 3", Price=550000m, Stock=20, ImageUrl="/images/bag.svg", CreatedAt = System.DateTime.Parse("2020-12-25")},
                new Product{ Id=4, Name="Product 4", Price=550000m, Stock=2, ImageUrl="/images/bag.svg", CreatedAt = System.DateTime.Parse("2020-12-25")}
            };

            return View(products);
        }
    }
}
