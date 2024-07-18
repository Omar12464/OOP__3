using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__3.Interface_Example03
{
    internal class Car : Vhiecle, Imoveable
    {
        void Imoveable.Backward()
        {
            throw new NotImplementedException();
        }

        void Imoveable.Forward()
        {
            throw new NotImplementedException();
        }
    }
}
