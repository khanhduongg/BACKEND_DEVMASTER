using Lesson05_theory.Models.DataModels;
using Lesson05_theory.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesson05_theory.Controllers
{
   public class MembersController : Controller
    {
        private static List<Member> members = new List<Member>()
        {
            new Member ()
            {
                Id =Guid.NewGuid().ToString() ,
                Name = "Duong Duong",
                FullName= " Nguyễn",
                Username = "Dev",
                Password = "1234",
                Email= "Khanhduong04.199@gmail.com",
                Phone = "0919999999",
                Brithday = DateTime.Now,
            }
        };
        // GET: MembersController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MembersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MembersController/Create
        public ActionResult Create(RegisterViewModels register)
        {
            if(ModelState.IsValid){
                Member m = new Member
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Duong Duong",
                    FullName = " Nguyễn",
                    Username = "Dev",
                    Password = "1234",
                    Email = "Khanhduong04.199@gmail.com",
                    Phone = "0919999999",
                    Brithday = DateTime.Now,
                };
                members.Add(m);
                return RedirectToAction("Index");
            }
            else
            {
            return View(register);
            }
        }

        // POST: MembersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MembersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MembersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MembersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MembersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
