using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__3.Override
{
    internal class TypeE:TypeD
    {
        public int E { get; set; }
        public TypeE(int _a, int _b, int _c, int _d,int _e) : base(_a, _b, _c,_d)
        {
            E = _e;
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

