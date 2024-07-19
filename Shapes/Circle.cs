using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__3.Shapes
{
    internal class Circle : ICircle
    {
        public int Radius { get; set; }

        public Circle(int radius) { Radius = radius; }
        public double Area =>Radius * Radius*3.14;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Area of Circle{Area}");
        }
    }
}
