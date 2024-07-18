using OOP__3.Interface;
using OOP__3.Interface_Example03;
using System;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;

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
            //Aeroplane aeroplane = new Aeroplane();
            // for access any method you want that has the sae name and parameters but from different interface 
            //use binding from Interface reference to the class that you want
            //Imoveable imoveable = new Aeroplane();
            //IFlyable flyable = new Aeroplane();
            //flyable.Backward();
            //imoveable.Forward();

            //Implicitly vs Explicitly




            #endregion
            #region Shallow Copy vs DeepCopy
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };
            //int[] Arr03 = { 7,8,9 };
            //Console.WriteLine($"HasCode arr1: {Arr01.GetHashCode()}");
            //Console.WriteLine($"HasCode arr1: {Arr02.GetHashCode()}");
            #region Shallow Copy
            //Shallow Copy
            //Arr02= Arr01;
            ////opbject of arr01 has 2 references []
            ////and arr02 [4,5,6] is unreachable object but not deleted
            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine($"HasCode arr1: {Arr01.GetHashCode()}");
            //Console.WriteLine($"HasCode arr1: {Arr02.GetHashCode()}");
            //Arr02[0] = 100;
            //Console.WriteLine(Arr01[0]); 
            #region Array of RefType

            //string[] name01 = new string[] { "omar" };//carry referenece of Omar
            //string[] name02 = new string[1];//carry referenece of Null
            //Console.WriteLine($"String 1: {name01.GetHashCode()}");
            //Console.WriteLine($"String 2: {name02.GetHashCode()}");
            //name01 = name02;
            //Console.WriteLine($"String 1: {name01.GetHashCode()}");
            //Console.WriteLine($"String 2: {name02.GetHashCode()}");
            //name02[0] = "Mona";
            //Console.WriteLine(name02[0]);


            #endregion
            #region Array of RefType_mmutable
            StringBuilder[] name01=new StringBuilder[1];
            //name01[0].Append("Omar");//null ref exception
            name01[0] = new StringBuilder("Omar");
            StringBuilder[] name02 = new StringBuilder[1];

            //Console.WriteLine($"Hascode anem01:{name01.GetHashCode()}");
            //Console.WriteLine($"Hascode anem02:{name02.GetHashCode()}");
            //name02 = name01;
            //Console.WriteLine($"After Shallow copy");
            //Console.WriteLine($"Hascode anem01:{name01.GetHashCode()}");
            //Console.WriteLine($"Hascode anem02:{name02.GetHashCode()}");
            //name02[0].Append("Ahmed");
            //Console.WriteLine("After change");
            //Console.WriteLine(name02[0]);
            //Console.WriteLine(name01[0]);




            #endregion
            #endregion
            #region DeppCopy
            #region ArrValue Type
            //Arr02 = (int[])Arr01.Clone();//Deep Copy
            ////clone method generate new object
            ////with new and different identity
            ////this object will have the same object state[data]
            ////pf the caller object
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"HasCode arr1: {Arr01.GetHashCode()}");
            //Console.WriteLine($"HasCode arr1: {Arr02.GetHashCode()}");
            //Arr02[0] = 102;
            //Console.WriteLine(Arr01[0]); 

            //in brief shallow copy make object of arr01 has 2 reference it referece and arr02 also and the data in arr02 comes unreachable and any change happen in both 
            // deep copy make copy from arr01 ro arr02 but any change happen in any one of them will not affect or change the other one
            #endregion

            #region Array of RefType_mmutable
            //name02 = (StringBuilder[])name01.Clone();
            //Console.WriteLine("after deep copy");
            //Console.WriteLine($"HasCode name1: {name02.GetHashCode()}");
            //Console.WriteLine($"HasCode name2: {name01.GetHashCode()}");
            //name02[0].Append("Ahmed");
            //Console.WriteLine("After change");
            //Console.WriteLine(name01[0]);
            //Console.WriteLine(name02[0]);




            #endregion

            #region Array of RefType
            //name02 = (String[])name01.Clone();
            //Console.WriteLine("After Deppcopy");
            //Console.WriteLine($"String 1: {name01.GetHashCode()}");
            //Console.WriteLine($"String 2: {name02.GetHashCode()}");
            //name02[0] = "Mona";
            //Console.WriteLine(name02[0]);
            //Console.WriteLine($"String 1: {name01[0]}");
            //Console.WriteLine($"String 2: {name02[0]}");

            #endregion
            #endregion


            #endregion

            #endregion
        }
    }
}
