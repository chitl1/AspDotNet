using System;

public class Calculator
{
    // Khai báo một delegate
    public delegate int Operation(int x, int y);

    // Thuộc tính để lưu delegate
    public Operation OnCalculate { get; set; }

    // Phương thức để thực hiện phép toán sử dụng delegate
    public void PerformCalculation(int a, int b)
    {
        if (OnCalculate != null)
        {
            int result = OnCalculate(a, b);
            Console.WriteLine("Kết quả: " + result);
        }
        else
        {
            Console.WriteLine("Không có phương thức nào được gán.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Calculator calc = new Calculator();

        // Gán delegate vào thuộc tính
        calc.OnCalculate = (x, y) => x + y; // Delegate thực hiện phép cộng

        // Thực hiện phép toán
        calc.PerformCalculation(5, 3); // Kết quả: 8

        // Gán delegate khác vào thuộc tính
        calc.OnCalculate = (x, y) => x * y; // Delegate thực hiện phép nhân

        // Thực hiện phép toán
        calc.PerformCalculation(5, 3); // Kết quả: 15
    }
}
