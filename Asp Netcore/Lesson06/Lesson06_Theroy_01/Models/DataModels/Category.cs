using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson06_Theroy_01.Models.DataModels
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [DisplayName("Mã Loại")]
        public int CategoryId { get; set; }
        [DisplayName("Tên sách")]
        public string CategoryName { get; set; }

        // tạo quan hệ
        public ICollection<Book> Categories { get; set;}

    }
}
