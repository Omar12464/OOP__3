using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__3.Override
{
    public class TypeA
    {
        public int A { get; set; }
        public TypeA(int _a)
        {
            A= _a;
        }

        public void MyFunction01()
        {
            Console.WriteLine("I am Base");
        }
        public virtual void MyFunction02()
        {
            Console.WriteLine($"Type A: {A}");
        }
    }
}
