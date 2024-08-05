using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_BaiTap
{
    internal class C4_Bai3
    {
        public static void MergeArrAndSort()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào số lượng phần tử của mảng a là: ");
            int m = Int32.Parse(Console.ReadLine());
            int[] arr1 = new int[m];
            Console.WriteLine("Nhập các phần tử cho mảng a.");
            for (int i = 0; i < m; i++)
            {
                Console.Write("a[{0}] = ", i);
                arr1[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Nhập vào số lượng phần tử của mảng b là: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] arr2 = new int[n];
            Console.WriteLine("Nhập các phần tử cho mảng a.");
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                arr2[i] = Int32.Parse(Console.ReadLine());
            }
            int[] result = MergeArrays(arr1 , arr2);
            Console.WriteLine("Mảng gộp:");
            foreach (int num in result)
            {
                Console.Write(num + "  ");
            }
        }
        public static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;
            // Sử dụng thuật toán Merge để gộp hai mảng
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] <= arr2[j])
                {
                    result[k++] = arr1[i++];
                }
                else
                {
                    result[k++] = arr2[j++];
                }
            }

            // Sao chép phần còn lại của arr1 (nếu có)
            while (i < arr1.Length)
            {
                result[k++] = arr1[i++];
            }

            // Sao chép phần còn lại của arr2 (nếu có)
            while (j < arr2.Length)
            {
                result[k++] = arr2[j++];
            }
            return result;
        }
    }
}
