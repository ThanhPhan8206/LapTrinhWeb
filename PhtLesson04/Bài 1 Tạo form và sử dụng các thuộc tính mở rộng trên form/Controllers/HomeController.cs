using Bài_1_Tạo_form_và_sử_dụng_các_thuộc_tính_mở_rộng_trên_form.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bài_1_Tạo_form_và_sử_dụng_các_thuộc_tính_mở_rộng_trên_form.Controllers
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
