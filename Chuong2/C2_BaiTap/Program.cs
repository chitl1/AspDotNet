
//1.Sau khi viết xong chương trình bằng C#, nếu copy tệp tin *.exe đã viết sang máy khác để chạy,
//chương trình đó có chạy không? Giải thích.
//Có chạy

//2. Kí tự đầu tiên của tên biến có thể là kí số ?
//Không được

//3. Tên biến có thể là từ khóa ?
//Không được

//4. Lớp Console thuộc vào namespace nào ?
// Lớp Console thuộc vào namespace System

////5 Viết chương trình tính diện tích và chu vi hình chữ nhật.
//Console.Write("Nhập chiều dài của hình chữ nhật: ");
//double length = Convert.ToDouble(Console.ReadLine());
//Console.Write("Nhập chiều rộng của hình chữ nhật: ");
//double width = Convert.ToDouble(Console.ReadLine());
//double area = length * width;
//double perimeter = 2 * (length + width);
//Console.WriteLine($"Diện tích của hình chữ nhật là: {area}");
//Console.WriteLine($"Chu vi của hình chữ nhật là: {perimeter}");


////6.Viết chương trình tính thể tích của một hình trụ. 
//Console.Write("Nhập bán kính đáy của hình trụ: ");
//double radius = Convert.ToDouble(Console.ReadLine());
//Console.Write("Nhập chiều cao của hình trụ: ");
//double height = Convert.ToDouble(Console.ReadLine());
//const double pi = Math.PI;
//double volume = pi * Math.Pow(radius, 2) * height;
//Console.WriteLine($"Thể tích của hình trụ là: {volume}");


//7.Viết chương trình tính lương thực lãnh của một nhân viên
Console.WriteLine("Nhap luong co ban :");
double basicSalary = Convert.ToDouble(Console.ReadLine());
double bhyt = 0.12 * basicSalary;
int bhxh = 150;
int cd = 120;
double tax = 0.14 * basicSalary;
double salary = basicSalary - bhyt - bhxh - cd;
Console.WriteLine("salary:  " + salary);