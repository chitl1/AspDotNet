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
    }
}
