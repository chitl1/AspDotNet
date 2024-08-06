using static Chương6.C6_Bai2;

DrawingObject[] dObj = new DrawingObject[4];
dObj[0] = new Line();
dObj[1] = new Circle();
dObj[2] = new Square();
dObj[3] = new DrawingObject();
foreach (DrawingObject drawObj in dObj)
{
    drawObj.Draw();
}