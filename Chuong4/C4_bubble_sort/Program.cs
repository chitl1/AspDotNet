// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic.FileIO;
using System.Xml.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

static class In
{
    public static void InMAng(int[] a)
    {
        //In mang
        int n = a.Length;
        Console.WriteLine("\n Cac phan tu trong mang sau sap xep");
        for (int i = 0; i < n; i++)
        {
            Console.Write(" a[{0}] = {1} \t", i, a[i]);
        }
    }
}
class hoc
{
    static void Main( string[] args)
    {
        //Nhap mang
        Console.Write("Nhap so luong phan tu n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int [n];  
        Console.WriteLine("Nhap cac phan tu trong mang");
        for (int i = 0; i < n; i++)
        {
            Console.Write(" a[{0}] = ",i);
            
            a[i] = Convert.ToInt16(Console.ReadLine());
        }
        //In mang
        Console.WriteLine("\n Cac phan tu trong mang");
        for (int i = 0; i < n; i++)
        {
            Console.Write(" a[{0}] = {1} \t" , i, a[i]);
        }
        //Sap xep mang
        //bubbleSort.sapXep(a);
        //selectionSort.sapXep(a);
        //InsertionSort.sapXep(a);
        QuickSort.SapXep(a, 0, a.Length -1 );

        //In mang
        In.InMAng(a);
        
    }

}

//1. sắp xếp nổi bọt
public static class bubbleSort
{
    //so sánh 2 số cạnh nhau -> tìm ra số lớn nhất hoặc hoặc nhất ở cuối của mảng
    //lặp lại quá trình so sánh từ vị trí 0 -> n-1 ( vì vị trí cuối cùng là giá trị lớn nhất hoặc nhỏ nhất tìm ra trong vòng lặp đầu tiên)
    
    public static int[] sapXep(int[] a)
    {
        int step = 0;
        int n = a.Length;
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                    swapped = true;
                }
                step++;
                Console.WriteLine("So vong lap : {0}", step);
            }
            if (!swapped) break;
        }
        return a;
    }
}

//2. sắp xếp chọn
public static class selectionSort
{
    // lặp n - 2 lần
    // mảng chạy từ 0 -> n-1;

    //tìm trong mảng ra phần tử nhỏ nhất -> chuyển về vị trí đầu của mảng.
    //lặp từ vị trí i = i+ 1;
    //dừng vòng lặp khi i = n - 1

    public static int[] sapXep(int[] a)
    {
        int step = 0;
        int n = a.Length;
        for (int i = 0; i < n; i++)
        {
            // tìm giá trị nhỏ nhất trong mảng từ vị trí i -> n-1;
            int min = a[i];
            int chisoMin = i;
            int temp;
            int j ;

            for ( j = i + 1; j < n ; j++)
            {
                step += 1;
                if (a[j] < min)
                {
                    min = a[j];
                    chisoMin = j;
                }
            }
            //hoán đổi giá trị của vị a[i] với a[chisoMin]
            Console.WriteLine("\n---------------");
            Console.WriteLine("so nho nhat la a[{0}] = {1}", chisoMin, min);
            Console.WriteLine("doi chõ  a[{0}] = {1} voi a[{2}] = {3}", chisoMin, min, i, a[i]);

            temp = a[i];
            a[i] = min;
            a[chisoMin] = temp;
           
            InMAng(a);
            Console.WriteLine("\n---------------");

        }
        Console.WriteLine("So vong lap : {0}", step); // n= 5 => 10 lần lặp
        return a;
    }

    public static void InMAng(int[] a)
    {
        //In mang
        int n = a.Length;
        Console.WriteLine("\n Cac phan tu trong mang sau sap xep");
        for (int i = 0; i < n; i++)
        {
            Console.Write(" a[{0}] = {1} \t", i, a[i]);
        }
    }
    public static int timMin(int[] a)
    {
        int min = a[0];
        int chisoMin = 0;
        for (int i = 0; i< a.Length -1; i++)
        {
            if (a[i] < min)
            {
                min = a[i];
                chisoMin = i;
            }
        }
        return chisoMin;
    }
}

//3. Sắp xếp chèn
public static class InsertionSort
{
    public static int[] sapXep(int[] a)
    {
        //tìm vị trí cho phần tử thứ i trong mảng.
        int n = a.Length;
        int key; // 
        for (int i = 1; i < n; i++)
        {
            //gán key = a[i]
            key = a[i];
            //so sánh key với mảng trước đó
            int j = i - 1;
            while (j >= 0 && a[j] > key)
            {
                a[j + 1] = a[j];
                j--;
            }
            // Chèn `key` vào vị trí đúng
            a[j + 1] = key;
        }
        return a;
    }
}

//4. Sắp xếp nhanh
public static class QuickSort
{
    //phân hoạc lomuto
   public static void SapXep(int[] a, int csd, int csc )
    {
        if (csd >= csc) return;
        int p = Partition(a, csd, csc);
        SapXep(a, csd, p - 1);
        SapXep(a, p+1, csc);
    }

    public static int Partition(int[] a, int csd, int csc)
    {
        int pivot = a[csc];
        int j = csd - 1;
        int chisocuapivot = csc;
        for (int i = csd; i <= csc ; i++)
        {
            if (a[i] <= pivot)
            {
                j++;
                if (a[j] > a[i])
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;

                }
            }
        }

        return j ; // Trả về vị trí của pivot
    }

    public static int PartitionHoare()
    {

        return 0;
    }
}
