using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__3.Override
{
    internal class TypeC:TypeB
    {
        public int C { get; set; }
        public TypeC(int _a,int _b, int _c) : base(_a, _b)
        {
            C = _c;
        }
        //override using new
        public new void MyFunction01()
        {
            Console.WriteLine("I am grand Child");
        }

        //override using override

        public new virtual void MyFunction02()
        {
            Console.WriteLine($"Type C: {C}");
        }
    }
}
