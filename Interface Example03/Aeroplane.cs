using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__3.Interface_Example03
{
    internal class Aeroplane : Vhiecle, IFlyable, Imoveable
    {
        

        void Imoveable.Backward()
        {
            Console.WriteLine("BackWard explicitly");
        }

        void IFlyable.Backward()
        {
            throw new NotImplementedException();
        }

        void Imoveable.Forward()
        {
            Console.WriteLine("ForWard explicitly");
        }

        void IFlyable.Forward()
        {
            throw new NotImplementedException();
        }
    }
}
