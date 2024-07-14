using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__3.Override
{
    internal class TypeD:TypeC
    {
        public int D { get; set; }
        public TypeD(int _a, int _b,int _c,int _d) : base(_a,_b,_c)
        {
            D = _d;
        }
        //override using new
        public new void MyFunction01()
        {
            Console.WriteLine("I am grand Child");
        }

        //override using override

        public override void MyFunction02()
        {
            base.MyFunction02();
        }
    }
}
