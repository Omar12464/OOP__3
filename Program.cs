using OOP__3.Interface;
using OOP__3.Interface_Example03;
using System;
using System.Reflection.Metadata;

namespace OOP__3
{
    internal class Program
    {
        public static void Print10NumberFromSeries(Iseries series)
        {
            if (series == null)
            {
                return;
            }
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{series.Current}");
                series.GetNext();
            }
            series.Reset();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            #region Part01
            #region Example02
            //SeriesBy3 seriesby3 = new SeriesBy3();
            //SeriesBy4 seriesBy4 = new SeriesBy4();
            //Print10NumberFromSeries(seriesby3);
            //Iseries series = new Seriesby2();
            //series = new SeriesBy3();
            //Print10NumberFromSeries(series);
            //Print10NumberFromSeries(seriesBy4);
            #endregion
            #region Example03
            Aeroplane aeroplane = new Aeroplane();
            // for access any method you want that has the sae name and parameters but from different interface 
            //use binding from Interface reference to the class that you want
            Imoveable imoveable = new Aeroplane();
            IFlyable flyable = new Aeroplane();
            flyable.Backward();
            imoveable.Forward();

            //Implicitly vs Explicitly




            #endregion

            #endregion
        }
    }
}
