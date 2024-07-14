using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__3.Binding
{
    internal class FullTimeEmployee: Employee
    {
        public Decimal Salary { get; set; }
        public new void MyFunc01()
        {
            Console.WriteLine("I am fulltimeemployee");
        }

        public override void MyFunc02()
        {
            Console.WriteLine($"Id : {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}");
        }
    }
}
