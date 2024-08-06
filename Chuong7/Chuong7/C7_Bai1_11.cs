using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chuong7
{
    internal class C7_Bai1_11
    {
        public interface IEmployee
        {
            public string Id { get; set; }
        }
        public class Employee: IEmployee
        {
            public string Id { get; set; }
            public Employee(string id)
            {
                Id = id;
            }
        }

    }
}
