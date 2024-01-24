using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDinhKhanhDuong
{
    public interface IDstudents 
    { 
         int StuId { get; set; }
         string StuName { get; set; }
         string StuGender { get; set; }
         int StuAge { get; set;}
         string StuClass { get; set;}
         float StuAvgMark { get;}

        public void PrintInfo();
  

    }
}
