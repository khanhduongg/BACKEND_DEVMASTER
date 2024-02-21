using Microsoft.AspNetCore.Mvc;

namespace Lesson01_MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
