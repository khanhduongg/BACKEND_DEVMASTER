using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_2
{
    internal class Contact
    {
        private int id;
        private string firstname;
        private string lastname;
        private string address;
        private string phone;
        private string email;
        // tạo constructor không tham số
        public Contact()
        {

        }
        // tạo constructor với tham số
        public Contact(int id, string firstname, string lastname, string address, string phone,string email)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address; 
            this.phone = phone;
            this.email = email;
        }
        // tạo thuộc tính cho các trường
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public void Display()
        {
            Console.WriteLine("Ma so: " + id);
            Console.WriteLine("Ho va Ten : {0} {1}" ,firstname,lastname);
            Console.WriteLine("Dia Chi: " + address);
            Console.WriteLine("Dien Thoai: " + phone);
            Console.WriteLine("Email: " + email);
        }
    }
}
