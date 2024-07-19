using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__3.Shapes
{
    internal class Recatangle : IRecatangle
    {
        public int Lenght { get; set ; }
        public int Width { get; set ; }

        public Recatangle(int length, int width)
        {
            Lenght = length;
            Width = width;
        }
        public double Area => Lenght*Width;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Area of Rectangle= {Area}");
        }
    }
}
