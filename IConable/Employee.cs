using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP__3.IConable
{
    class Department:ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public object Clone()
        {
            return new Department();
            Id=this.Id;
            Name=this.Name;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
    internal class Employee:ICloneable,IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Salary { get; set; }

        public Department department { get; set; }

        public object Clone()
        {
            return new Employee()
            {
                Id = this.Id,
                Name = this.Name,
                Salary = this.Salary,
                department = (Department)this.department?.Clone()
            };
        }

        public int CompareTo(object? obj)
        {
            //return -ve if the psoition of j less than  j+1 then its right
            //return +ve if the psoition of j greaterthan j+1 is right
            //return 0 if the psoition of j = j+1 is right
            Employee passedEmp = (Employee)obj;
            if (this.Salary < passedEmp.Salary)
            {
                return -1;
            }else if(this.Salary > passedEmp.Salary) { return 1; }
            else { return 0; }
        }

        //public Employee(Employee emp)
        //{
        //    this.Id = emp.Id;
        //    this.Name = emp.Name;
        //    this.Salary = emp.Salary;
        //}

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}, Department; {department}";
        }
    }
}
