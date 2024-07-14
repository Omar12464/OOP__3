using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__3.Override
{
    public class TypeB:TypeA
    {
        public int B { get; set; }
        public TypeB(int _a,int _b):base(_a)
        {
            B=_b;
        }
        //override using new
        public new void MyFunction01()
        {
            Console.WriteLine("I am Child");
        }

        //override using override

        public override void MyFunction02()
        {
            Console.WriteLine($"Type B: {B}");
        }
    }

}
