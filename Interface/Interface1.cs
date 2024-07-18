using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__3.Interface
{
    internal interface Iseries
    {
        //signature for property
        public int Current { get; set; }

        //signature for method

        public void GetNext();
        public void Reset();




    }
}
