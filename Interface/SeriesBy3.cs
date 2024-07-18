using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__3.Interface
{
    internal class SeriesBy3 : Iseries
    {
        public int Current { 
            get; 
            set;
        }

        public void GetNext()
        {
            Current += 3;
        }

        public void Reset()
        {
            Current = 0;
        }
    }
}
