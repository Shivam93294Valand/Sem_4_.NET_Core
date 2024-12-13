using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Employee
    {
        public string Emp_Name;
        public double basic_salary;
        public void basic_sal()
        {
            Console.Write("Enter Employee Name : ");
            Emp_Name = Console.ReadLine();
            Console.Write("Enter Basic salary of " + Emp_Name + " = ");
            basic_salary = Convert.ToDouble(Console.ReadLine());
        }
    }
}
