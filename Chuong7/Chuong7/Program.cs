//using static Chuong7.C7_Bai12;

//// Khởi tạo đối tượng Circle với bán kính kiểu double
//IDimensions hinhtron = new Circle(5.2d);

//Console.WriteLine($"Area: {hinhtron.Area()}");
//Console.WriteLine($"Circumference: {hinhtron.Circumference()}");
//Console.WriteLine($"Sides: {hinhtron.Side()}");



//using static Chuong7.C7_Bai13;


//MyPoint p = new MyPoint(2, 3);
//Console.Write("My Point: ");
//PrintPoint(p);
//IPoint p2 = new MyPoint(2, 4);
//PrintPoint(p2);

// static void PrintPoint(IPoint p)
//{
//    Console.WriteLine("x={0}, y={1}", p.x, p.y);
//}

// Khởi tạo đối tượng Dog và Cat
using static Chuong7.C7_Bai14;

IDisplay myDog = new Dog("Rex");
IDisplay myCat = new Cat("Whiskers");

// Hiển thị tên của các đối tượng
Console.WriteLine(myDog);
Console.WriteLine(myCat);