using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_BaiTap
{
     internal class C3_Bai5
    {
        public static void CaculatePiByFor()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập số c > 0 (Ví dụ c = 0.0001) :");
            double c = C3_Bai4.Nhap();
            double pi = 0.0;
            double term = 1.0;

            for (int n = 0; Math.Abs(term) > c; n++)
            {
                // Tính số hạng hiện tại của chuỗi
                term = 1.0 / (2 * n + 1) * Math.Pow(-1, n);
                // Cộng số hạng vào tổng giá trị của pi
                pi += term;
            }
            // Nhân tổng giá trị của pi với 4 để có giá trị cuối cùng
            pi *= 4;
            Console.WriteLine("Giá trị của số π tính được là: " + pi);
        }
    }
}
