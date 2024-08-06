using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong7
{
    internal class C7_Bai12
    {
        public interface IDimensions
        {
            //trong interface không chứa field chỉ chứa property và abstract method
             long width { get; set; }
             long height { get; set; }
             double Area();
             double Circumference();
             int Side();
        }
        public class Circle: IDimensions
        {
            double radius;
            public long width { get; set; }
            public long height { get; set; }

            public Circle(double _radius)
            {
                radius = _radius;
            }

            public double Area()
            {
                return Math.PI * radius * radius;
            }
            public  double Circumference()
            {
                return 2 * Math.PI * radius; 
            }
            public int Side()
            {
                return 0;
            }
        }
    }
}
