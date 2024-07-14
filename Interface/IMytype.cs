using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__3.Interface
{
    internal interface IMytype
    {
        //Default Acces Modifier inside the interface is Public
        //private is not allowed

        public int Age { get; set; }//Signatuer for Property

        //2.Signatuer for method

        public void MuFunc();

        //3. Default implemented Method
        //You can use private in writing methods

        public void Print()
        {
            Console.WriteLine("Default impleneted method");
        }
    }
}
