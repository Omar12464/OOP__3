using OOP__3.Interface;
using System;

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
            SeriesBy3 seriesby3 = new SeriesBy3();
            SeriesBy4 seriesBy4 = new SeriesBy4();
            Print10NumberFromSeries(seriesby3);
            Iseries series = new Seriesby2();
            series= new SeriesBy3();
            Print10NumberFromSeries(series);
            Print10NumberFromSeries(seriesBy4);
            
            #endregion
        }
    }
}
