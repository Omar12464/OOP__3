using OOP__3.Binding;
using OOP__3.Override;
using System;

namespace OOP__3
{
    internal class Program
    {
        #region Polymorphism_Overloading
        public static int Sum(int x, int y) { return x + y; }
        public static int Sum(int x, int y, int z) { return x + y + z; }
        public static int Sum(int x, int y, int z, int xx) { return x + y + z + xx; }
        public static int Sum(int x, int y, int z, int xx, int zz) { return x + y + z + xx + zz; }
        #endregion

        public static void ProcessEmp(Employee employee)
        {
            if (employee != null)
            {
                employee.MyFunc01();
                employee.MyFunc02();
            }
        }
            static void Main(string[] args)
        {
            #region Overloading
            //int x = 5;int y = 6; int z = 7;int xx = 8;int zz = 9;
            //Console.WriteLine(Sum(x,y));
            //Console.WriteLine(Sum(x,y,z));
            //Console.WriteLine(Sum(x, y, z,xx));
            //Console.WriteLine(Sum(x, y, z,xx,zz));

            #endregion
            #region Override
            //TypeA typeA = new TypeA(1);
            //typeA.A = 2;
            //TypeB typeb = new TypeB(3, 4);
            //typeb.B = 5;
            //typeb.MyFunction01();
            //typeb.MyFunction02();
            #endregion
            #region Binding
            //TypeA RefBase = new TypeB(1,2);
            //RefBase.A = 3;
            //RefBase.MyFunction01();// Static Binding
            //RefBase.MyFunction02();// Dynamic Binding
            #endregion
            #region NotBinding
            //TypeA typeA = new TypeB(1, 2);//Binding
            //typeA = new TypeA(1);
            //TypeB typeB = (TypeB)typeA;// casting
            #endregion

            #region When U Need Binding
            //Employee
            //employee = new Employee();
            //FullTimeEmployee employee1= new FullTimeEmployee();
            //FullTimeEmployee employee2=new FullTimeEmployee();
            //PartTimeEmployee employee3= new PartTimeEmployee();
            //Employee employee4 = new FullTimeEmployee();
            //Employee employee5 = new PartTimeEmployee();
            //ProcessEmp(employee);



            ////Employee fulltimeemployee = new FullTimeEmployee();
            ////fulltimeemployee.Id = 1;
            ////fulltimeemployee.Name = "Omar";
            ////fulltimeemployee.Age = 25;
            ////fulltimeemployee.Salary = 2500;
            ////ProcessEmp(fulltimeemployee);

            ////Employee partTimeEmployee = new PartTimeEmployee();
            ////{
            ////partTimeEmployee.Id = 2;
            ////partTimeEmployee.Name = "Mido";
            ////partTimeEmployee.Age = 25;
            ////partTimeEmployee.HourRate = 30;
            ////}
            ////ProcessEmp(partTimeEmployee); 
            #endregion


            #region More Practice on Binding
            //TypeA typeA = new TypeE(1, 2, 3, 4, 5);
            //TypeB typeB = new TypeE(1, 2, 3, 4, 5);
            //TypeC typeC = new TypeE(1, 2, 3, 4, 5);

            ////indirect Parent

            //typeA.MyFunction01();
            //typeA.MyFunction02();//Dynamic Binding
            //typeB.MyFunction01();
            //typeC.MyFunction02();

            //TypeD typeD = new TypeE(1, 2, 3, 4, 5);
            //typeD.MyFunction02();//last override on the function




            #endregion





        }
    }
    }
