using Lesson02_Lab01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson02_Lab01.Controllers
{
    public class AcountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>();
            {
                new Account()
                {
                    Id = 1,
                    Name = "Nguyễn Chí Hưởng",
                    Phone = "12345678",
                    Address = " Hà Nội",
                    Avatar = Url.Content("~/Avatar/1.jfit"),
                    Gender = 1,
                    Bio = "My Name is Duong",
                    Birthday = new DateTime(2002, 08, 02)
                };
                new Account()
                {
                    Id = 1,
                    Name = "Nguyễn Chí Hướng",
                    Phone = "12345678",
                    Address = " Hà Nội",
                    Avatar = Url.Content("~/Avatar/2.jfit"),
                    Gender = 1,
                    Bio = "My Name is Duong",
                    Birthday = new DateTime(2002, 08, 02)
                };
                new Account()
                {
                    Id = 1,
                    Name = "Nguyễn Chí Hương",
                    Phone = "12345678",
                    Address = " Hà Nội",
                    Avatar = Url.Content("~/Avatar/3.jfit"),
                    Gender = 1,
                    Bio = "My Name is Duong",
                    Birthday = new DateTime(2002, 08, 02)
                };
            };
            ViewBag.Account = accounts;
            return View();
        }
        public IActionResult Profile ()
        {
            return View();

        }
    }
}
