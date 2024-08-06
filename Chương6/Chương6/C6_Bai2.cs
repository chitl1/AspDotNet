using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chương6
{
    internal class C6_Bai2
    {
        public class DrawingObject
        {
            public virtual void Draw()
            {
                Console.WriteLine("I'm just a generic drawing object.");
            }
        }
        public class Line : DrawingObject
        {
            public override void Draw()
            {
                Console.WriteLine("I'm a Line.");
            }
        }
        public class Circle : DrawingObject
        {
            public override void Draw()
            {
                Console.WriteLine("I'm a Circle.");
            }
        }
        public class Square : DrawingObject
        {
            public override void Draw()
            {
                Console.WriteLine("I'm a Square.");
            }
        }
    }
}
