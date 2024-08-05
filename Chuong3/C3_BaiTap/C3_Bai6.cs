using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_BaiTap
{
     internal class C3_Bai6
    {
        public static void CaculateE()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập số c > 0 (Ví dụ c = 0.0001) :");
            double c = C3_Bai4.Nhap();
            Console.WriteLine("Nhập số thuc x :");
            double x = C3_Bai4.Nhap();
            double e = 0.0;
            double term = 1.0;

            for (int n = 0; Math.Abs(term) > c; n++)
            {
                // Tính số hạng hiện tại của chuỗi
                term = Math.Pow(x, n) / Factorial(n);
                // Cộng số hạng vào tổng giá trị của pi
                e += term;
            }
            // Nhân tổng giá trị của pi với 4 để có giá trị cuối cùng
            Console.WriteLine("Giá trị của số π tính được là: " + term);
        }

        public static long Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("N must be non-negative.");

            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
