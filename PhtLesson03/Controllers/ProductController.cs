using Microsoft.AspNetCore.Mvc;
using PhtLesson03.Models;

namespace PhtLesson03.Controllers
{
    public class ProductController : Controller
    {
        private List<Category> GetCategories() => new List<Category>
        {
            new Category { Id = 1, Name = "Quần Áo" },
            new Category { Id = 2, Name = "Túi xách" }
        };

        private List<Product> GetProducts() => new List<Product>
        {
            new Product {
                Id = 1,
                Name = "Bộ đồ bơi cho bé trai nam",
                Price = 500000,
                SalePrice = 350000,
                CategoryId = 1,
                Image = "doboi01.webp",
                Description = "Bộ đồ bơi chất liệu co giãn tốt, an toàn cho da bé, màu sắc tươi sáng.",
                Status = true,
                CreatedAt = DateTime.Now
            },
            new Product {
                Id = 2,
                Name = "Bộ đồ bơi cho bé trai nữ",
                Price = 800000,
                SalePrice = 550000,
                CategoryId = 1,
                Image = "doboi02.webp",
                Description = "Bộ đồ bơi nữ tính, thiết kế dễ thương, chất liệu bền bỉ.",
                Status = true,
                CreatedAt = DateTime.Now
            },
            new Product {
                Id = 3,
                Name = "Bộ đồ bơi cho bé em lứa 3-5 tuổi",
                Price = 700000,
                SalePrice = 450000,
                CategoryId = 1,
                Image = "doboi03.jpg",
                Description = "Bộ đồ bơi cho bé nhỏ, an toàn, kháng nước tốt, màu sắc bắt mắt.",
                Status = true,
                CreatedAt = DateTime.Now
            },
            new Product {
                Id = 4,
                Name = "Bộ đồ bơi cho bé trẻ thời trang",
                Price = 50000,
                SalePrice = 45000,
                CategoryId = 1,
                Image = "doboi04.jpg",
                Description = "Bộ đồ bơi thời trang, thiết kế hiện đại, thoải mái khi mặc.",
                Status = true,
                CreatedAt = DateTime.Now
            },
            new Product {
                Id = 5,
                Name = "Túi thời trang màu mới 2021",
                Price = 6000000,
                SalePrice = 3500000,
                CategoryId = 2,
                Image = "tuixach01.webp",
                Description = "Túi xách màu mới hiện đại, thiết kế nhỏ gọn, dễ dàng phối đồ.",
                Status = true,
                CreatedAt = DateTime.Now
            },
            new Product {
                Id = 6,
                Name = "Túi thời trang da đã cải tiến",
                Price = 8600000,
                SalePrice = 7200000,
                CategoryId = 2,
                Image = "tuixach02.jpg",
                Description = "Túi da cao cấp, thiết kế sang trọng, bền bỉ và đẹp mắt.",
                Status = true,
                CreatedAt = DateTime.Now
            }
        };

        public IActionResult Index(int? categoryId)
        {
            var products = GetProducts();
            if (categoryId.HasValue)
            {
                products = products.Where(p => p.CategoryId == categoryId.Value).ToList();
            }

            ViewBag.Categories = GetCategories();

            return View(products);
        }

        public IActionResult Detail(int id)
        {
            var product = GetProducts().FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            return View(product);
        }
    }
}
