//11) Viết chương trình minh họa sử dụng ủy quyền để thực hiện việc sắp xếp các số nguyên trong
//một mảng?

public class Program
{
    public delegate int SoSanhDelegate(int x, int y);
    internal static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Bài 11");
        int[] numbers = { 5, 2, 8, 3, 1, 4 };
        Console.WriteLine("Mảng ban đầu:");
        PrintArray(numbers);
        // Sắp xếp theo thứ tự tăng dần
        SapXep(numbers, SoSanhTangDan);
        Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
        PrintArray(numbers);
        // Sắp xếp theo thứ tự tăng dần
        SapXep(numbers, SoSanhGiamDan);
        Console.WriteLine("Mảng sau khi sắp xếp giảm dần:");
        PrintArray(numbers);
    }
    // Phương thức để in mảng ra console
    public static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    // Hàm so sánh theo thứ tự tăng dần
    //x>y return 1 , x<y return -1, x=y return 0
    public static int SoSanhTangDan(int x, int y)
    {
        return x.CompareTo(y);
    }
    // Hàm so sánh theo thứ tự giảm dần
    public static int SoSanhGiamDan(int x, int y)
    {
        return y.CompareTo(x);
    }
    public static void SapXep(int[] array, SoSanhDelegate soSanh)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for(int j = i+1; j < array.Length; j++)
            {
                if (soSanh(array[i], array[j]) > 0)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
}