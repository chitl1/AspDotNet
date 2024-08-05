using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_BaiTap
{
    public class C3_Bai4
    {
        //public static double InputNumber()
        //{
        //    bool check = false;
        //    double d = 0;
        //    while (!check)
        //    {
        //        inputNumber:
        //        Console.WriteLine("Nhap so lon hon 0 :");
        //        string input =  Console.ReadLine();
        //        if (input == "")
        //        {
        //            goto inputNumber;
        //        }
        //        else
        //        {
        //            if (Convert.ToDouble(input) <= 0)
        //            {
        //                goto inputNumber;
        //            }
        //            else
        //            {
        //                d = double.Parse(input, CultureInfo.InvariantCulture);
        //                check = true;
        //            }

        //        }
        //    }
        //    return d;
        //}


        //public static void CaculatePi()
        //{
        //    Console.WriteLine("Nhap c > 0 (Vi dụ c = 0.0001) :");
        //    double c = InputNumber();
        //    double pi = 0.0;
        //    double term = 1.0;
        //    int n = 0;
        //    while (term <= c)
        //    {
        //        term = 1.0 / (2 * n + 1) * Math.Pow(-1,n);
        //        pi += term;
        //        n++;
        //    }
        //    pi *= 4;
        //    Console.WriteLine("Gia tri cua π  : {0} " , pi);
        //}


        public static double Nhap()
        {
            bool check = false;
            double d = 0;
            while (!check)
            {
                try
                {
                    // Sử dụng CultureInfo.InvariantCulture để chắc chắn rằng dấu chấm
                    // được hiểu là dấu thập phân
                    string input = Console.ReadLine();
                    d = double.Parse(input, CultureInfo.InvariantCulture);
                    if (d <= 0)
                    {
                        throw new Exception("Số phải lớn hơn 0!");
                    }
                    check = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Bạn phải nhập số lớn hơn 0! Hãy nhập lại...");
                }
            }
            return d;
        }

        public static void CaculatePi()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập số c>0  gần với số 0  (ví dụ c = 0.0001): ");
            double c = Nhap();
            double pi = 0.0;
            double term = 1.0;
            int n = 0;
            while (Math.Abs(term) > c)
            {
                // Tính số hạng hiện tại của chuỗi
                term = 1.0 / (2 * n + 1) * Math.Pow(-1, n);
                // Cộng số hạng vào tổng giá trị của pi
                pi += term;
                // Tăng giá trị của n để chuyển đến số hạng tiếp theo
                n++;
            }
            // Nhân tổng giá trị của pi với 4 để có giá trị cuối cùng
            pi *= 4;
            Console.WriteLine("Giá trị số π tính được là : " + pi);
        }
    }
}
