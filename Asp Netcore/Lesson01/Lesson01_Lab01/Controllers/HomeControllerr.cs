using Microsoft.AspNetCore.Mvc;

namespace Lesson01_Lab01.Controllers
{
    public class HomeControllerr : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
