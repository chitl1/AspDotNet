using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C3_BaiTap
{
    public class C3_Bai3
    {
        public static int[] PrimeArr(int n)
        {
            // Danh sách để lưu các số nguyên tố
            List<int> primes = new List<int>();
            //int[] arr = new int[n];
            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i); // Thêm số nguyên tố vào danh sách
                }
            }

            return primes.ToArray();
        }
        public static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true; // 2 là số nguyên tố
            if (num % 2 == 0) return false; // Các số chẵn khác 2 không phải là số nguyên tố

            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0) return false;
            }

            return true;
        }
    }
}
