using Lesson04.Models.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Lesson04.Controllers
{
    public class Member1Controlle : Controller
    {
        private static List<Member> list = new List<Member>
        {

                new Member() { MemberId = Guid.NewGuid().ToString(), FullName = "Member 1", UserName = "Mem1", Password = "123", Email = "Member1@gmail.com" },
                new Member() { MemberId = Guid.NewGuid().ToString(), FullName = "Member 2", UserName = "Mem2", Password = "123", Email = "Member1@gmail.com" },
                new Member() { MemberId = Guid.NewGuid().ToString(), FullName = "Member 3", UserName = "Mem3", Password = "123", Email = "Member1@gmail.com" },
                new Member() { MemberId = Guid.NewGuid().ToString(), FullName = "Member 4", UserName = "Mem4", Password = "123", Email = "Member1@gmail.com" },
                new Member() { MemberId = Guid.NewGuid().ToString(), FullName = "Member 5", UserName = "Mem5", Password = "123", Email = "Member1@gmail.com" },

         };
        // GET: Member1Controlle1
        public ActionResult Index()
        {
            // truyền dữ liệu ra view
            return View(list);
        }

        // GET: Member1Controlle1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Member1Controlle1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Member1Controlle1/Create
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

        // GET: Member1Controlle1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Member1Controlle1/Edit/5
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

        // GET: Member1Controlle1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Member1Controlle1/Delete/5
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
