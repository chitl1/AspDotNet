using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Chương6
{
    internal class C6_Bai1
    {
        public class Diem
        {
            public double x;
            public double y;
            public Diem(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public override string ToString()
            {
                return $"Point({x}, {y})";
            }
        }

        public class DoanThang
        {
            public Diem DiemDau;
            public Diem DiemCuoi;

            public DoanThang(Diem diemDau, Diem diemCuoi)
            {
                DiemDau = diemDau;
                DiemCuoi = diemCuoi;
            }
            public double Length()
            {
                //công thức tính khoảng cách 
                return Math.Sqrt(Math.Pow(DiemCuoi.x - DiemDau.x, 2) + Math.Pow(DiemCuoi.y - DiemDau.y, 2));
            }
            public override string ToString()
            {
                return $"Đoạn thẳng từ điểm ({DiemDau} tới điểm {DiemCuoi})";
            }
        }

        public abstract class Shape
        {
            public abstract double Chuvi();
            public abstract double Dientich();
            public override abstract string ToString();
        }
        public class HinhTron: Shape
        {
            public Diem TamHinhTron { get; set; }
            public double BanKinh { get; set; }

            public HinhTron(Diem tamHinhTron, double banKinh)
            {
                TamHinhTron = tamHinhTron;
                BanKinh = banKinh;
            }

            public override double Dientich()
            {
                return Math.PI * BanKinh * BanKinh;
            }

            public override double Chuvi()
            {
                return 2 * Math.PI * BanKinh;
            }

            public override string ToString()
            {
                Console.OutputEncoding = Encoding.UTF8;
                return $"Hình tròn (tâm={TamHinhTron}, bán kính={BanKinh})";
            }
        }

        public class HinhChuNhat : Shape
        {
            public Diem BottomLeft;
            public double Width;
            public double Height;
            public HinhChuNhat(Diem bottomLeft, double width, double height)
            {
                BottomLeft = bottomLeft;
                Width = width;
                Height = height;
            }
            public override double Dientich()
            {
                return Width * Height;
            }

            public override double Chuvi()
            {
                return 2 * (Width + Height);
            }

            public override string ToString()
            {
                return $"Rectangle(bottomLeft={BottomLeft}, width={Width}, height={Height})";
            }
        }
        public class HinhVuong : HinhChuNhat
        {
            public HinhVuong(Diem bottomLeft, double sideLength)
                : base(bottomLeft, sideLength, sideLength)
            {
            }

            public override string ToString()
            {
                return $"Square(bottomLeft={BottomLeft}, sideLength={Width})";
            }
        }
        public static double GetSideLength(Diem p1, Diem p2)
        {
            return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        }
        public class Triangle : Shape
        {
            public Diem d1 { get; set; }
            public Diem d2 { get; set; }
            public Diem d3 { get; set; }
            public Triangle(Diem point1, Diem point2, Diem point3)
            {
                d1 = point1;
                d2 = point2;
                d3 = point3;
            }
            public override double Dientich()
            {
                double a = GetSideLength(d1, d2);
                double b = GetSideLength(d2, d3);
                double c = GetSideLength(d3, d1);
                double s = (a + b + c) / 2;
                return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            }
            public override double Chuvi()
            {
                double a = GetSideLength(d1, d2);
                double b = GetSideLength(d2, d3);
                double c = GetSideLength(d3, d1);
                return a + b + c;
            }
            public override string ToString()
            {
                return $"Triangle(d1: {d1}, d2: {d2}, d3: {d3})";
            }
        }
        
        // Hình bình hành
        public class Parallelogram : Shape
        {
            public Diem d1 { get; set; }
            public Diem d2 { get; set; }
            public Diem d3 { get; set; }
            public Diem d4 { get; set; }

            public Parallelogram(Diem _d1, Diem _d2, Diem _d3, Diem _d4)
            {
                d1 = _d1;
                d2 = _d2;
                d3 = _d3;
                d4 = _d4;
            }

            public override double Dientich()
            {
                double baseLength = GetSideLength(d1, d2);
                double height = Math.Abs(d3.y - d1.y);
                return baseLength * height;
            }

            public override double Chuvi()
            {
                double a = GetSideLength(d1, d2);
                double b = GetSideLength(d2, d3);
                return 2 * (a + b);
            }

            public override string ToString()
            {
                return $"Parallelogram(d1: {d1}, d2: {d2}, d3: {d3}, d4: {d4})";
            }
        }

        // Hình thoi
        public class Rhombus : Shape
        {
            public Diem d1 { get; set; }
            public Diem d2 { get; set; }
            public Diem d3 { get; set; }
            public Diem d4 { get; set; }

            public Rhombus(Diem _d1, Diem _d2, Diem _d3, Diem _d4)
            {
                d1 = _d1;
                d2 = _d2;
                d3 = _d3;
                d4 = _d4;
            }

            public override double Dientich()
            {
                double diagonal1 = GetSideLength(d1, d3);
                double diagonal2 = GetSideLength(d2, d4);
                return (diagonal1 * diagonal2) / 2;
            }

            public override double Chuvi()
            {
                double sideLength = GetSideLength(d1, d2);
                return 4 * sideLength;
            }

            public override string ToString()
            {
                return $"Rhombus(d1: {d1}, d2: {d2}, d3: {d3}, d4: {d4})";
            }
        }

    }
}
