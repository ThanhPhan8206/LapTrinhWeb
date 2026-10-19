using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using YTB1.Models;

namespace YTB1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult ThongTinSinhVien()
        {
            var sv = new SinhVien();
            sv.HoTen = "Phan Huu Thanh";
            sv.Truong = " Giao thong Van tai";

            return View(sv);
            
        }

        public IActionResult DanhSachSinhVien()
        {
            // 1. Khởi tạo một List chứa nhiều đối tượng SinhVien
            var danhSach = new List<SinhVien>()
        {
            new SinhVien { Truong = "UTC01", HoTen = "Phan Hữu Thành" },
            new SinhVien { Truong = "UTC02", HoTen = "Nguyễn Văn A" },
            new SinhVien { Truong = "UTC03", HoTen = "Trần Thị B" }
        };

            // 2. Truyền toàn bộ danh sách này sang giao diện
            return View(danhSach);
        }



    }
}
