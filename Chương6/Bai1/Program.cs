using static Chương6.C6_Bai1;

Shape[] shapes = new Shape[6];
shapes[0] = new HinhTron(new Diem(10,5),5);
shapes[1] = new HinhChuNhat(new Diem(0,10), 10, 5);
shapes[2] = new HinhVuong(new Diem(0, 10), 5);
shapes[3] = new Triangle(new Diem(0, 10), new Diem(0, 20), new Diem(10, 0));
shapes[4] = new Parallelogram(new Diem(0, 0), new Diem(10, 0), new Diem(5, 5), new Diem(15, 5));
shapes[5] = new Rhombus(new Diem(0, 1), new Diem(2,2), new Diem(4,1), new Diem(2,0) );

foreach (Shape shape in shapes)
{
    Console.WriteLine(shape);
    Console.WriteLine($"Dientich: {shape.Dientich()}");
    Console.WriteLine($"Chuvi: {shape.Chuvi()}");
    Console.WriteLine();
}