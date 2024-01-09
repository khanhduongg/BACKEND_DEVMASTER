using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Theory
{
    internal class OverLoadingDemo
    {
        // cài đặt tính chất đa hình tron OOP
        // - có cùng tên
        // - danh sách tham số khác nhau
        // - nếu danh sách tham số giống nhau thì phải khác nhau về kiểu dữ liệu

        public int Sum(int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong+= i;
            }
            return tong;
        }
        public int Sum(int a,int b) {
            int tong = 0;
            for (int i = a; i < b; i++)
            {
                tong += i;
            }
            return tong;
        }
        public double Sum(double a,double b)
        {
            return a+b;
        }
    }
}
