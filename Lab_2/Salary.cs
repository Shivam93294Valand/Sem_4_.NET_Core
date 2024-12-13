using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Salary
    {
        public double basic;
        public double ta;
        public double da;
        public double hra;

        public Salary()
        {
            Console.Write("Enter Basic Salary: ");
            basic = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter ta Salary: ");
            ta = Convert.ToDouble(Console.ReadLine());
            da = basic / 10;
            hra = ta * 0.15;
        }

        public void CalculateSalary()
        {
            Console.WriteLine("\nSalary Details:");
            Console.WriteLine("Basic salary = " + basic);   
            Console.WriteLine("Ta salary = " + ta);
            Console.WriteLine("Da salary = " + da);
            Console.WriteLine("Hra salary = " + hra);
            Console.WriteLine("Total salary = " + (basic + ta + da + hra));
        }
    }
}