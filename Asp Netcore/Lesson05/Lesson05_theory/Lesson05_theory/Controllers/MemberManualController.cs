using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lesson05_theory.Models.DataModels;
using System.Text.RegularExpressions;
using Lesson05_theory.Models.DataModels;
namespace Lesson05_theory.Controllers
{
    public class MemberManualController : Controller
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
        // GET: MemberManualController
        public ActionResult Index()
        {
            return View(members);
        }

        // GET: MemberManualController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MemberManualController/Create
        public ActionResult Create()
        {
            var member = new Member();
            return View(member);
        }

        // POST: MemberManualController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            //check data
            string msg = "";
            Boolean validate = true;
            if(member.Name == null)
            {
                msg = "<liv> Chưa nhập tài khoản <liv>";
                validate = false;
            }
            else 
                if(member.Name.Length <= 3 || member.Name.Length > 10)
            {
                msg = "<liv> tài khaonr phải có độ dài trong khoảng 3-10 kí tự <liv>";
                validate = false;
            }
            string patterEmail = @"[a-z0-9._]+[a-z0-9_]+@[a-z0-9-_]+\.[a-z]{2,4}$";
            if (member.Email == null)
            {
                msg = "<liv> Chưa nhập tài khoản <liv>";
                validate = false;
            }
            else
if (!Regex.IsMatch(member.Email, patterEmail))
            {
                msg += "<li>Email không đúng định dạng <li> ";
                validate |= false;
            }
            if (validate == true)
            {
                member.Id = Guid.NewGuid().ToString();
                members.Add(member);
                return RedirectToAction(nameof(Index));
            }
            msg = "<div class='alert alert-danger'> " + msg + "<div>";
            ViewBag.msg = msg;
            return View(member);
        }

        // GET: MemberManualController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MemberManualController/Edit/5
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

        // GET: MemberManualController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MemberManualController/Delete/5
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
