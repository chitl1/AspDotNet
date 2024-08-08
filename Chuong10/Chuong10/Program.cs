//Bài 13
//có ngoại lệ phát sinh khi chưa có file "test3.txt" 
using System;
using System.IO;
public class Tester
{
    public static void Main()
    {
        Bai12();
        try
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string fname = "test3.txt";
            string buffer;
            StreamReader sReader = File.OpenText(fname);
            while ((buffer = sReader.ReadLine()) != null)
            {
                Console.WriteLine(buffer);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lỗi: Không tồn tại file trong thư mục. " + ex.Message);
        }

    }
    public static void Bai12()
    {
        try
        {
            Console.WriteLine("Bài 12");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c =  a / b;
            Console.WriteLine("c ={0}", c);

        }
        catch (DivideByZeroException ex)
        {
            // Xử lý lỗi chia cho số không
            Console.WriteLine("Lỗi: Không thể chia cho số không. " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lỗi :" +ex.Message);
        }
        finally
        {
            Console.WriteLine("-------------End Bai12 ------------------");
        }
    }
}