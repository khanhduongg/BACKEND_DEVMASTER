using System.ComponentModel.DataAnnotations;

namespace Lesson05_Lab01.Models.AccountsView
{
    public class AccountView
    {
        [Key]
        public int AccoutId { get; set; }
        [
        Display (Name = " Họ và Tên"),
        Required(ErrorMessage ="Họ tên không đươc để trống"),
        MinLength(6 , ErrorMessage =" Họ tên ít nhất 6 ký tự"),
        MaxLength(6, ErrorMessage = " Họ tên nhiều nhất 20 ký tự")
         ]
        public string FullName { get; set; }
        [
         Display(Name = " Hòm Thư"),
         Required(ErrorMessage = "Hòm thư không được để trống"),
         EmailAddress(ErrorMessage ="Địa chỉ Email không đúng định dạng"),
         DataType(DataType.EmailAddress)
         ]
        public string Email { get; set; }   
         [
         Display(Name = " Số Điện Thoại"),
         RegularExpression(@"[a-z0-9._]+[a-z0-9_]+@[a-z0-9-_]+\.[a-z]{2,4}$",ErrorMessage ="Số điện thoại không đúng định dạng"),
         Required(ErrorMessage ="Số điện thoại không được để trống"),
         DataType(DataType.PhoneNumber)
         ]
        public string Phone { get; set; }


        [
        Display(Name ="Địa Chỉ Thường Trú"),
        Required(ErrorMessage ="Địa chỉ thường chú khống được để trống"),
        StringLength(35,ErrorMessage ="Địa chỉ không được vượt quá 35 kí tự"),
        ]

        public string Address { get; set; }

        [Display(Name ="Ảnh đại diện")]
        public string Avatar { get; set; }

        [Display(Name = "Link  Facebook cá nhân"),
         Required(ErrorMessage ="Link Facebook cá nhân không được để trống"),
         Url(ErrorMessage ="Link phải đúng định dạng")
        ]
        public string Facebook { get; set; }

        [Display(Name ="Giới Tính")]
        public string Gender { get; set; }
        [
            Display(Name ="Mật Khẩu"),
            DataType(DataType.Password)
            ]
       public string Password { get; set; }
    }
}
