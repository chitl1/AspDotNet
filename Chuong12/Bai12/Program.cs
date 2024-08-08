//12) Viết chương trình minh họa sử dụng ủy quyền để thực hiện việc chuyển các ký tự thường thành
//ký tự hoa trong một chuỗi?

public class Program
{
    // Khai báo delegate cho phương thức chuyển đổi ký tự
    public delegate char CharacterTransform(char c);
    internal static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Bài 12");
        string input = "đây là một ví dụ chữ thường chuyển thành chữ hoa";
        // Chuyển đổi chuỗi sử dụng delegate
        string transformed = TransformString(input, ToUpperCase);

        Console.WriteLine("Chuỗi gốc: " + input);
        Console.WriteLine("Chuỗi sau khi chuyển đổi: " + transformed);
    }
    // Phương thức chuyển đổi ký tự thường thành ký tự hoa
    public static char ToUpperCase(char c)
    {
        return char.ToUpper(c);
    }
    // Phương thức chuyển đổi chuỗi sử dụng delegate
    public static string TransformString(string input, CharacterTransform transform)
    {
        char[] result = new char[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            result[i] = transform(input[i]);
        }
        return new string(result);
    }
}