using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong7
{
    internal class C7_Bai14
    {
        public interface IDisplay
        {
            string Name { get; set; }
        }
        public class Dog : IDisplay
        {
            public string Name { get; set; } // Cài đặt thuộc tính Name

            public Dog(string name)
            {
                Name = name; // Khởi tạo thuộc tính Name
            }

            public override string ToString()
            {
                return $"Dog's name: {Name}";
            }
        }

        public class Cat : IDisplay
        {
            public string Name { get; set; } // Cài đặt thuộc tính Name

            public Cat(string name)
            {
                Name = name; // Khởi tạo thuộc tính Name
            }

            public override string ToString()
            {
                return $"Cat's name: {Name}";
            }
        }

    }
}
