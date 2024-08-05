using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_BaiTap
{
    internal class C5_Bai2
    {
        static public void Bai2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student[] students = new Student[5];
            //Nhập thông tin cho từng sinh viên
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();

                Console.Write($"Nhập tên sinh viên thứ {i + 1}: ");
                students[i].Name = Console.ReadLine();

                Console.Write($"Nhập điểm của sinh viên thứ {i + 1}: ");
                students[i].Score = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("---------------------------------");
            }
            //Danh sách sinh viên
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("{0} : Tên sinh viên : {1,15:s} ; Điểm : {2,5:f2}",i, students[i].Name, students[i].Score);
            }

            //Sắp xếp
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (students[i].Score < students[j].Score)
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }

            Console.WriteLine("3 sinh viên có điểm số cao nhất là :");
            for (int i = 0; i < 3 && i < students.Length; i++)
            {
                Console.WriteLine($"Tên : {students[i].Name}, Điểm số : {students[i].Score}");
            }
        }
        public class Student
        {
            public string Name { get; set; }
            public double Score { get; set; }
        }
    }
}
