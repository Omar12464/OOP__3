using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__3.Interface
{
    internal class Seriesby2 : Iseries
    {
        int current;
        public int Current 
        {
            get { return current; }
            set { current = value; }
        }

        public void GetNext()
        {
            Current+=2;
        }

        public void Reset()
        {
            Current = 0;
        }
    }
}
