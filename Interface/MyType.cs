using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__3.Interface
{
    class MyType : IMytype//implentation of Interface
    {
        int age;
        public int Age//Automatic Property
        {
            get { return age; }
            set { age = value; }
        }

        public void MuFunc()
        {
            Console.WriteLine("Hello Rpute");
        }
    }
}
