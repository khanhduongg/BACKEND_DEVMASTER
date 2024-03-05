using Microsoft.AspNetCore.Mvc;
using Lesson04.Models.DataModels;
namespace Lesson04.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            var member = new Member();
            member.MemberId = Guid.NewGuid().ToString();
            member.UserName = "DuongDuong";
            member.FullName = "Duong Duong";
            member.Password = "password";
            member.Email = "khanhduong04.199@gmail.com";

            return View(member);
        }
        public IActionResult GetListMember()
        {
            var list = new List<Member>()
            {
                new Member() { MemberId = Guid.NewGuid().ToString(), FullName = "Member 1", UserName = "Mem1", Password = "123", Email = "Member1@gmail.com" },
                new Member() { MemberId = Guid.NewGuid().ToString(), FullName = "Member 2", UserName = "Mem2", Password = "123", Email = "Member1@gmail.com" },
                new Member() { MemberId = Guid.NewGuid().ToString(), FullName = "Member 3", UserName = "Mem3", Password = "123", Email = "Member1@gmail.com" },
                new Member() { MemberId = Guid.NewGuid().ToString(), FullName = "Member 4", UserName = "Mem4", Password = "123", Email = "Member1@gmail.com" },
                new Member() { MemberId = Guid.NewGuid().ToString(), FullName = "Member 5", UserName = "Mem5", Password = "123", Email = "Member1@gmail.com" },
            };
            ViewBag.ListMember = list;

            return View();
         }
        public IActionResult ListModel()
        {
            var list = new List<Member>()
            {
                new Member() { MemberId = Guid.NewGuid().ToString(), FullName = "Member 1", UserName = "Mem1", Password = "123", Email = "Member1@gmail.com" },
                new Member() { MemberId = Guid.NewGuid().ToString(), FullName = "Member 2", UserName = "Mem2", Password = "123", Email = "Member1@gmail.com" },
                new Member() { MemberId = Guid.NewGuid().ToString(), FullName = "Member 3", UserName = "Mem3", Password = "123", Email = "Member1@gmail.com" },
                new Member() { MemberId = Guid.NewGuid().ToString(), FullName = "Member 4", UserName = "Mem4", Password = "123", Email = "Member1@gmail.com" },
                new Member() { MemberId = Guid.NewGuid().ToString(), FullName = "Member 5", UserName = "Mem5", Password = "123", Email = "Member1@gmail.com" },
            };
            //ViewBag.ListMember = list;

            return View(list);
        }
        //create
        public IActionResult Create()
        {
            var model = new Member();
            return View(model);
        }
    }
}
