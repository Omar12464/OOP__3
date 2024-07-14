using System;

namespace OOP__3
{
    internal class Program
    {
        #region Polymorphism
        public static int Sum(int x, int y) { return x + y; }
        public static int Sum(int x, int y, int z) { return x + y + z; }
        public static int Sum(int x, int y, int z, int xx) { return x + y + z + xx; }
        public static int Sum(int x, int y, int z, int xx, int zz) { return x + y + z + xx + zz; } 
        #endregion


        static void Main(string[] args)
        {
            //int x = 5;int y = 6; int z = 7;int xx = 8;int zz = 9;
            //Console.WriteLine(Sum(x,y));
            //Console.WriteLine(Sum(x,y,z));
            //Console.WriteLine(Sum(x, y, z,xx));
            //Console.WriteLine(Sum(x, y, z,xx,zz));


        }
    }
}
