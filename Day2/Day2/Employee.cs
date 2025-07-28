using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Employee
    {
        public int Id { get; set; }
        public int Salary { get; set; }
        public Employee(int sal)
        {
            if (sal>3000)
            {
                Salary = sal;
            }
            else
            {
                Salary = 3000;
            }
        }
        public Employee(int id, int sal)
        {
            Id = id;
            if (sal > 3000)
            {
                Salary = sal;
            }
            else
            {
                Salary = 3000;
            }
        }
        public void Display()
        {
            Console.WriteLine($"Id: {Id} \t Salary: {Salary}");
        }

    }
}
