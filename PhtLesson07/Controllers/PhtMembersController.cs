using PhtLesson07.Models.DataModels;
using PhtLesson07.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;

namespace PhtLesson07.Controllers
{
    public class PhtMembersController : Controller
    {
        private static List<PhtMember> members = new List<PhtMember>();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(RegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
                PhtMember m = new PhtMember
                {
                    MemberId = Guid.NewGuid().ToString(),
                    UserName = register.UserName,
                    FullName = register.FullName,
                    Email = register.Email,
                    Password = register.Password,
                    Phone = register.Phone,
                    Birthday = register.Birthday,
                };

                members.Add(m);
                return RedirectToAction("Index");
            }
            else
            {
                return View(register);
            }
        }
    }
}
