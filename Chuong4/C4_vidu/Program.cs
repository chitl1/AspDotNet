// See https://aka.ms/new-console-template for more information

class Hoc
{
    static void Main(string[] args)
    {
        int n, max=0, min=0;
        Console.WriteLine("Nhap so phan tu  n=");
        n = Convert.ToInt32(Console.ReadLine());

        //
        int[] a = new int[n];
        for(int i = 0; i <n; i++)
        {
            Console.WriteLine("Nhap phan tu thu {0} :", i);
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        //
        Console.WriteLine("Mang phan tu la: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + "\t");
        }
        //
        max = a[0];
        min = a[0];
        for(int i = 0;i < n-1; i++)
        {
            for (int j = 1; j < n; j++)
            {
                if(a[i] > a[j])
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }
        Console.WriteLine("\n Mang sau khi sap xep");
        for (int i = 0; i < a.Length; i++)
            Console.Write("{0,3:D}", a[i]);
        Console.WriteLine();
    }
}