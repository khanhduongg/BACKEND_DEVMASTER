using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lesson05_theory.Models.ViewModels
{
    public class RegisterViewModels
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Tên Đăng nhập")]
        [Required(ErrorMessage = "Tên đăng nhập không được trống")]
        [StringLength(20 ,MinimumLength =3 ,ErrorMessage = " Độ dài từ 3-20 ký tự")]
        public string UserName { get; set; }

        [DisplayName("Họ Tên")]
        [Required(ErrorMessage = " Họ Tên không được trống")]
        public string FullName   { get; set; }
        [DisplayName("Mật Khẩu")]
        [Required(ErrorMessage = " Hãy nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = " Hãy nhập Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DisplayName("Điện Thoại")]
        [RegularExpression(@"^0\d{9,12}$",ErrorMessage = " Họ Tên không được trống")]
        public string Phone { get; set; }


    }
}
