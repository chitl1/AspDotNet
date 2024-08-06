using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong7
{
    internal class C7_Bai13
    {
        public interface IPoint
        {
            // Property signatures:
            int x {get;set;}
            int y {get;set;}
        }
        public class MyPoint : IPoint
        {
            // Fields:
            private int myX;
            private int myY;
            // Constructor:
            public MyPoint(int x, int y)
            {
                myX = x;
                myY = y;
            }
            // Property implementation:
            public int x
            {
                get
                {
                    return myX;
                }
                set
                {
                    myX = value;
                }
            }
            public int y
            {
                get
                {
                    return myY;
                }
                set
                {
                    myY = value;
                }
            }
        }
        //class MainClass
        //{
        //    private static void PrintPoint(IPoint p)
        //    {
        //        Console.WriteLine("x={0}, y={1}", p.x, p.y);
        //    }
        //    public static void Main()
        //    {
        //        MyPoint p = new MyPoint(2, 3);
        //        Console.Write("My Point: ");
        //        PrintPoint(p);
        //        IPoint p2 = new MyPoint(2,4);
        //        PrintPoint(p2);
        //    }
        //}
    }
}
