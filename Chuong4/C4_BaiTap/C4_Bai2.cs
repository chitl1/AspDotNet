using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_BaiTap
{
    internal class C4_Bai2
    {
        public static int Nhap()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập vào số điện tiêu thụ : ");
            int sodien = int.Parse(Console.ReadLine());
            return sodien;
        }

        public static void TinhTienDien()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập vào số điện tiêu thụ : ");
            int sodien = int.Parse(Console.ReadLine());

            int tiendien = 0;
            if (sodien <= 100)
                tiendien = sodien * 500;
            else if(sodien <= 150)
            {
                tiendien = 100 * 500 + (sodien - 100) * 550;
            }
            else if (sodien <= 200)
            {
                tiendien = 100 * 500 + 50 * 550 + (sodien -200) *600;
            }
            else
            {
                tiendien = 100 * 500 + 50 * 550 + 50 * 600 + (sodien - 200) * 650;
            }
            Console.WriteLine("Số tiền điện phải đóng là : {0:n}", tiendien);
        }
    }
}
