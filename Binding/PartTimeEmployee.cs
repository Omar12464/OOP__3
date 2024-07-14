using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP__3.Binding
{
    internal class PartTimeEmployee:Employee
    {
        public decimal HourRate { get; set; }
        public new void MyFunc01()
        {
            Console.WriteLine("I am Parttime employee");
        }

        public override void MyFunc02()
        {
            Console.WriteLine($"Id : {Id}, Name: {Name}, Age: {Age},HourRate: {HourRate}");
        }
    }
}
