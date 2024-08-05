using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_BaiTap
{
    internal class C4_Bai1
    {
        public static void DecimalToBinary(int number)
        {
            if (number != 0)
            {

                string binaryString = "";
                while (number > 0)
                {
                    binaryString = (number % 2) + binaryString;
                    number /= 2;
                }
                Console.WriteLine($"Dãy nhị phân của số {number} là: {binaryString}");
            }

        }

        public static int Nhap()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập vào một số nguyên: ");
            int decimalNumber = int.Parse(Console.ReadLine());
            return decimalNumber;
        }
        public static void convertDecimalToBinary()
        {

            DecimalToBinary(Nhap());

        }
    }
}
