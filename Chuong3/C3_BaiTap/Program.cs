// See https://aka.ms/new-console-template for more information

////1) So sánh vòng lặp do và while
//vòng lặp do while sẽ thực hiện ít nhất 1 lần nếu điều kiện không hợp lệ
//còn while sẽ không thực hiện 1 lần nào nếu điều kiện không hợp lệ

using C3_BaiTap;
using System.Globalization;

// //Bài tâp2
//// Nhập số bậc của đa thức
//Console.Write("Nhap so bac cua da thuc (n): ");
//int n = int.Parse(Console.ReadLine());

//// Tạo danh sách để lưu các hệ số
//List<double> coefficients = new List<double>();

//// Nhập các hệ số của đa thức
//Console.WriteLine("Nhap cac he so tu a0 den an :");
//for (int i = 0; i <= n; i++)
//{
//    Console.Write($"a{i} = ");
//    double coef = double.Parse(Console.ReadLine());
//    coefficients.Add(coef);
//}

//// Nhập giá trị của x
//Console.Write("Nhap gia tri cua x: ");
//double x = double.Parse(Console.ReadLine());

//// Tính giá trị của đa thức P(x) bằng phương pháp Horner
//double result = C3_Bai2.EvaluatePolynomial(coefficients, x);

//// In kết quả
//Console.WriteLine($"Gia tri cua da thuc P(x) = {result}");

////Bài3
//Console.Write("Nhap 1 so nguyen duong: ");
//int number = int.Parse(Console.ReadLine());
//int[] primes = C3_Bai3.PrimeArr(number);
//if (primes.Length >=1)
//{
//    string result = string.Join(", ", primes);
//    Console.WriteLine("so nguyen to nho hon {0} là : {1}", number, result);
//}
//else
//{
//    Console.WriteLine("Khong co so nguyen to nho hon {0}",number);
//}


//C3_Bai4.CaculatePi

C3_Bai5.CaculatePiByFor();