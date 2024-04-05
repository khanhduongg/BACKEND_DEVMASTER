using Lesson09_lab02.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
namespace Lesson09_lab02.Controllers
{
    public class CartController : Controller ,IActionFilter
    {
        private readonly DevxuongmocContext _context;
        private List<Cart> carts = new List<Cart>();
        public CartController (DevxuongmocContext context)
        {
            _context = context;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var cartInSession = HttpContext.Session.GetString("My-Cart");
            if (cartInSession != null)
            {
                // nếu cartInSession không null thì gán dữ liệu cho biến carts
                // Chuyển san dữ liệu json
                carts = JsonConvert.DeserializeObject<List<Cart>>(cartInSession);
            }
            base.OnActionExecuting(context);
        }
        public IActionResult Index()
        {

            float total = 0;
            foreach (var item in carts)
            {
                total += item.Quantity * item.Price;

            }
            ViewBag.total=total;
            return View(carts);
        }

        public IActionResult Add(int id)
        {
            if (carts.Any(c => c.Id == id)) // nếu sản phẩm này đã có trong giỏ hàng
            {
            }

            else // Nếu sản phẩm chưa có trong giỏ hàng, thêm sản phẩm vào giỏ hàng
            {
                var p = _context.Products.Find(id); // tìm sản phẩm cần mua trong bảng sản
                                                    // tạo mới một sản phẩm để thêm vào giỏ hàng
                var item = new Cart()
                {
                    Id = p.Id,
                    Name = p.Title,
                    Price = (float)p.PriceNew.Value,
                    Quantity = 1,
                    Image = p.Image,
                    Total = (float)p.PriceNew.Value * 1
                };
                // thêm sản phẩm vào giỏ hàng
                carts.Add(item);
            }
            // lưu carts vào session, cần phải chuyển sang dữ liệu json
            HttpContext.Session.SetString("My-Cart", JsonConvert.SerializeObject(carts)); return RedirectToAction("Index");
        }

    }

}
