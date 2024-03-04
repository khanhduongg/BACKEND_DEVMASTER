using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lesson03_Lab01.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenerId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Summary { get; set; }
        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book> {
                new Book(){Id=1,Title="Conan",AuthorId=1,GenerId=1,Image="/Image/book/b1.jpg",TotalPage=150,Price=51000},
                new Book(){Id=2,Title="Lão Hạc",AuthorId=2,GenerId=2,Image="/Image/book/b2.jpg",TotalPage=240,Price=42000},
                new Book(){Id=3,Title="Chí Phèo",AuthorId=3,GenerId=3,Image="/Image/book/b3.jpg",TotalPage=330,Price=33000},
                new Book(){Id=4,Title="Đường xưa",AuthorId=4,GenerId=4,Image="/Image/book/b4.jpg",TotalPage=420,Price=24000},
                new Book(){Id=5,Title="Thôn Quê",AuthorId=5,GenerId=5,Image="/Image/book/b5.jpg",TotalPage=510,Price=15000}
            };
            return books;
        }
        public Book GetBookById(int id)
        {
            var book = this.GetBookList().FirstOrDefault(x => x.Id == id);
            return book;
        }
        //tsac giả
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value="1",Text="Nam Cao"},
            new SelectListItem{Value="2",Text="Nam Thấp"},
            new SelectListItem{Value="3",Text="Nam Cao2"},
            new SelectListItem{Value="4",Text="Nam Cao3"},
            new SelectListItem{Value="5",Text="Nam Cao4"},
        };
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value="1",Text="Truyện ngắn"},
            new SelectListItem{Value="2",Text="Truyện dài"},
            new SelectListItem{Value="3",Text="Truyện ngôn tình"},
            new SelectListItem{Value="4",Text="Truyện văn học"},
            new SelectListItem{Value="5",Text="Truyện tranh"},
        };
    }

}
