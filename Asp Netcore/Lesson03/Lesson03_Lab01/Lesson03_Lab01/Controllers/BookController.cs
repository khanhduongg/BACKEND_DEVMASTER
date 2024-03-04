using Lesson03_Lab01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson03_Lab01.Controllers
{
    public class BookController : Controller
    {
        protected Book book = new Book();
        public IActionResult Index()
        {
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;
            var books = book.GetBookList();
            return View(books);
        }
        public IActionResult Create()
        {
            ViewBag.authors = book.Authors;
            ViewBag.genrnes = book.Genres;
            Book model = new Book();
            return View(model);

        }
    }
}
