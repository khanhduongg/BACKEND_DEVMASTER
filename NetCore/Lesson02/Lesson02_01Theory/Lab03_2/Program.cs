namespace Lab03_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tạo đối tượng contact với constructor không tham số
            Contact ct1 = new Contact();
            // gán giá trị cho ct1
            ct1.Id = 6;
            ct1.Firstname = "Nguyen Van ";
            ct1.Lastname = "ABC";
            ct1.Address = "Ha Noi";
            ct1.Phone = "0973059266";
            ct1.Email = "abc123@gmail.com";
            // tạo đối tượng contact với constructor có tham số
            Contact ct2 = new Contact(5,"Nguyen Thi","Diem Quynh","Ha Noi","0988888888","123abc@gmail.com");
            ct1.Display();
            ct2.Display();
        }
    }
}
