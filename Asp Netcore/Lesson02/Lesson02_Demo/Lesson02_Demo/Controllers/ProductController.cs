using Lesson02_Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson02_Demo.Controllers
{
    //[Route("danh-sach-san-pham")]
    public class ProductController : Controller
    {
        //[Route("index")]
        public IActionResult Index()
        {
            // dữ liệu từ controller ra view
            ViewBag.product = " Dữ liệu trong view Bag";
            ViewData["ProductVD"] = "Dữ liệu trong ViewData -> ProductID";
            TempData["MessageVD"] = "Thông báo dữ liệu trong TempData"; 
            // trả về view trong thư mục views/Product/index.cshtml

            return View();

        }
        public IActionResult GetProduct()
        {
            // dữ liệu object
            Product p = new Product()
            {
                Id = 1,
                Name = "Test Product"
            };
            ViewBag.product = p;
            return View();
        }
        //[Route("tat-ca")]
        public IActionResult GetAllProduct() {
            List<Product> products = new List<Product>();
            {
                new Product() { Id = 1, Name = "Item 1" };
                new Product() { Id = 2, Name = "Item 2" };
                new Product() { Id = 3, Name = "Item 3" };
                new Product() { Id = 4, Name = "Item 4" };
                new Product() { Id = 5, Name = "Item 5" };
            }
            ViewData["list"] = products;
            return View("Products");
        }
    }
}
