using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDinhKhanhDuong
{
    public class Student :IDstudents 
    {
        public int StuId { get; set; }
        public string StuName { get; set; }
        public string StuGender { get; set; }
        public int StuAge { get; set;}
        public string StuClass { get; set;}
        public float StuAvgMark { get;  private set;}

        private int[] MarkList = new int[3];
        public void PrintInfo()
        {

            Console.WriteLine($"Student ID: {StuId}");
            Console.WriteLine($"Student Name: {StuName}");
            Console.WriteLine($"Student Gender: {StuGender}");
            Console.WriteLine($"Student Age: {StuAge}");
            Console.WriteLine($"Student Class: {StuClass}");
            Console.WriteLine($"Student Average Mark: {StuAvgMark}");

        }
        // Phương thức để nhập chỉ mục mảng MarkList
        public void SetMarkList()
        {
            Console.WriteLine("Nhap diem sinh vien:");
            for (int i = 0; i < MarkList.Length; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                MarkList[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Phương thức tính trung bình và đặt giá trị cho StudAvgMark
        public float CalculateAverage()
        {
            int total = 0;

            // Tính tổng điểm
            foreach (int mark in MarkList)
            {
                total += mark;
            }

            // Tính điểm trung bình
            float average = (float)total / MarkList.Length;

            return StuAvgMark = (float)total / MarkList.Length ;
        }

    }

}
