using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Lab04_4
{
    interface IPreson
    {
        // phương thức insert
        void Insert(object obj);
        // phương thức xóa
        void Delete(object obj);
        // phương thưc cập nhật
        void Update(object obj);
        //phương thức hiển thị
        void Display(object obj);
    }
}
