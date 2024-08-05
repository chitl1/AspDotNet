using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_BaiTap
{
    internal class C4_Bai4
    {
        public static void BoDauCachThua()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Loại bỏ dấu cách thừa trong đoạn văn");
            Console.WriteLine("Nhập đoạn văn cần sửa :");
            string ST = Console.ReadLine();
            // Xử lý chuỗi để loại bỏ dấu cách thừa
            string resultString = RemoveExtraSpaces(ST);

            // In kết quả
            Console.WriteLine("Chuỗi sau khi xử lý:");
            Console.WriteLine(resultString);
        }

        public static string RemoveExtraSpaces(string str)
        {
            if (str == null)
                return null;

            // Loại bỏ dấu cách thừa ở hai đầu chuỗi
            str = str.Trim();

            // Thay thế các dấu cách liền nhau bằng một dấu cách duy nhất
            // Sử dụng biểu thức chính quy để thay thế
            string result = System.Text.RegularExpressions.Regex.Replace(str, @"\s+", " ");

            return result;
        }
    }
}
