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
    internal class Employee:ICloneable
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
        public Employee(Employee emp)
        {
            this.Id = emp.Id;
            this.Name = emp.Name;
            this.Salary = emp.Salary;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}, Department; {department}";
        }
    }
}
