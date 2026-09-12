using Bài_2_Tạo_và_sử_dụng_PartialView.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bài_2_Tạo_và_sử_dụng_PartialView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
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
