using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson06_Theroy_01.Models.DataModels
{
    [Table("Publisher")]
    public class Publisher
    {
        [Key]
        [DisplayName("Mã nhà xuất bản")]
        [StringLength(10)]
        public int PublisherId { get; set; }

        [DisplayName("Tên nhà xuất bản")]
        [StringLength(200)]
        public string PublisherName { get; set; }

        [DisplayName("Điện Thoại")]
        [StringLength(10)]
        public string Phone {  get; set; }
        [DisplayName("Địa chỉ")]
        [StringLength(200)]
        public string Address { get; set; }

        // tạo quan hệ
        public ICollection<Book> Categories { get; set; }
    }
}
