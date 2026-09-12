using Bài_tập_tự_làm.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bài_tập_tự_làm.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Dữ liệu danh mục mẫu
            var categories = new List<Category>
            {
                new Category { Id = 1, Name = "Nồi Cơm" },
                new Category { Id = 2, Name = "Nồi Lẩu" },
                new Category { Id = 3, Name = "Nồi Áp Suất" },
                new Category { Id = 4, Name = "Bếp Điện" },
                new Category { Id = 5, Name = "Nồi Cơm Điện" },
                new Category { Id = 6, Name = "Lò Vi Sóng" },
                new Category { Id = 7, Name = "Ấm Đun Nước" },
            };

            // Dữ liệu sản phẩm mẫu
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Nồi cơm điện cao cấp Nagakawa NAG0102", Description = "Nồi cơm điện cao cấp chất lượng", Price = 1290000, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRatR5ZsUd-n2BFYNlU2O46XrIMUCysOEyJXWUQ43ubnQ&s=10", CategoryId = 1, IsHot = false },
                new Product { Id = 2, Name = "Nồi cơm điện cao cấp Nagakawa NAG0102", Description = "Nồi cơm điện cao cấp chất lượng", Price = 1290000, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRatR5ZsUd-n2BFYNlU2O46XrIMUCysOEyJXWUQ43ubnQ&s=10", CategoryId = 1, IsHot = false },
                new Product { Id = 3, Name = "Nồi cơm điện cao cấp Nagakawa NAG0102", Description = "Nồi cơm điện cao cấp chất lượng", Price = 1290000, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRatR5ZsUd-n2BFYNlU2O46XrIMUCysOEyJXWUQ43ubnQ&s=10", CategoryId = 1, IsHot = false },
                new Product { Id = 4, Name = "Nồi cơm điện cao cấp Nagakawa NAG0102", Description = "Nồi cơm điện cao cấp chất lượng", Price = 1290000, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRatR5ZsUd-n2BFYNlU2O46XrIMUCysOEyJXWUQ43ubnQ&s=10", CategoryId = 1, IsHot = false },
                new Product { Id = 5, Name = "Nồi cơm điện cao cấp Nagakawa NAG0102", Description = "Nồi cơm điện cao cấp chất lượng", Price = 1290000, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRatR5ZsUd-n2BFYNlU2O46XrIMUCysOEyJXWUQ43ubnQ&s=10", CategoryId = 1, IsHot = false },
                new Product { Id = 6, Name = "Nồi cơm điện cao cấp Nagakawa NAG0102", Description = "Nồi cơm điện cao cấp chất lượng", Price = 1290000, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRatR5ZsUd-n2BFYNlU2O46XrIMUCysOEyJXWUQ43ubnQ&s=10", CategoryId = 1, IsHot = true },
                new Product { Id = 7, Name = "Nồi cơm điện cao cấp Nagakawa NAG0102", Description = "Nồi cơm điện cao cấp chất lượng", Price = 1290000, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRatR5ZsUd-n2BFYNlU2O46XrIMUCysOEyJXWUQ43ubnQ&s=10", CategoryId = 1, IsHot = true },
                new Product { Id = 8, Name = "Nồi cơm điện cao cấp Nagakawa NAG0102", Description = "Nồi cơm điện cao cấp chất lượng", Price = 1290000, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRatR5ZsUd-n2BFYNlU2O46XrIMUCysOEyJXWUQ43ubnQ&s=10", CategoryId = 1, IsHot = true },
            };

            ViewData["Categories"] = categories;
            ViewData["Products"] = products;

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
