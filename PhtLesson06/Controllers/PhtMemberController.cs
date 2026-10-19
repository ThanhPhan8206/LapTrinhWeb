using Microsoft.AspNetCore.Mvc;
using Lesson06.Models;

namespace Lesson06.Controllers
{
    public class PhtMemberController : Controller
    {
        // mock data
        private static readonly List<PhtMember> _phtMembers = new List<PhtMember>()
        {
            new PhtMember
            {
                PhtMemberId = Guid.NewGuid().ToString(),
                PhtMemberUserName = "ThanhPhan",
                PhtMemberPassword = "123456a@",
                PhtMemberEmail = "phanhuuthanh8206@gmail.com",
                PhtMemberFullName = "Phan Hữu Thành"
            },

            new PhtMember
            {
                PhtMemberId = Guid.NewGuid().ToString(),
                PhtMemberUserName = "tranthib",
                PhtMemberPassword = "123456",
                PhtMemberEmail = "tranthib@gmail.com",
                PhtMemberFullName = "Trần Thị B"
            },

            new PhtMember
            {
                PhtMemberId = Guid.NewGuid().ToString(),
                PhtMemberUserName = "levanc",
                PhtMemberPassword = "123456",
                PhtMemberEmail = "levanc@gmail.com",
                PhtMemberFullName = "Lê Văn C"
            },

            new PhtMember
            {
                PhtMemberId = Guid.NewGuid().ToString(),
                PhtMemberUserName = "levand",
                PhtMemberPassword = "123456",
                PhtMemberEmail = "levand@gmail.com",
                PhtMemberFullName = "Lê Văn D"
            },

           new PhtMember
            {
                PhtMemberId = Guid.NewGuid().ToString(),
                PhtMemberUserName = "levane",
                PhtMemberPassword = "123456",
                PhtMemberEmail = "levane@gmail.com",
                PhtMemberFullName = "Lê Văn E"
            },
        };

        // GET: LIST
        public IActionResult PhtIndex()
        {
            return View(_phtMembers);
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <returns></returns>
        public IActionResult PhtCreate()
        {
            return View();
        }

        /// <summary>
        /// Create - submit form
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult PhtCreate(PhtMember phtMember)
        {
            phtMember.PhtMemberId = Guid.NewGuid().ToString();
            _phtMembers.Add(phtMember);
            return RedirectToAction("PhtIndex");
        }

        /// <summary>
        /// TvcEdit
        /// </summary>
        /// <returns></returns>

        public IActionResult PhtEdit(string id)
        {
            var  phtMember = _phtMembers.FirstOrDefault(x=>x.PhtMemberId.Equals(id));
            return View(phtMember);
        }

        /// <summary>
        /// TvcEdit - submit form
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult PhtEdit(string id, PhtMember phtMember)
        {

            for (int i = 0; i < _phtMembers.Count; i++)
            {
                if(_phtMembers[i].PhtMemberId == id)
                {
                    _phtMembers[i].PhtMemberId=phtMember.PhtMemberId;
                    _phtMembers[i].PhtMemberUserName = phtMember.PhtMemberUserName;
                    _phtMembers[i].PhtMemberPassword = phtMember.PhtMemberPassword;
                    _phtMembers[i].PhtMemberFullName = phtMember.PhtMemberFullName;
                    _phtMembers[i].PhtMemberEmail = phtMember.PhtMemberEmail;

                    break;
                }
               
            }
            
            return RedirectToAction("PhtIndex");
        }
        public IActionResult PhtGetDetails() 
        {
            var phtMember = new PhtMember()
            {
                PhtMemberId = Guid.NewGuid().ToString(),
                PhtMemberUserName = "ThanhPhan",
                PhtMemberPassword = "Thanh123@",
                PhtMemberFullName = "Phan Hữu Thành",
                PhtMemberEmail = "phanhuuthanh8206@gmail.com"
            };
            return View(phtMember);
        }

    }
}
