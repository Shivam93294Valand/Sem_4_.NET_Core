using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Emp_sal : Employee, gross
    {
        public double gross_salary;
        public double ta;
        public double da;
        public double hra;

        public void Gross_sal()
        {
            Console.Write("Enter ta salary = ");
            ta = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter da salary = ");
            da = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter hra salary = ");
            hra = Convert.ToDouble(Console.ReadLine());
            gross_salary = ta + da + hra;
            Console.WriteLine("Gross salary = " + gross_salary);
        }

        public void Disp_sal()
        {
            Console.WriteLine("\nBasic salary = " + basic_salary);
            Console.WriteLine("ta salary = " + ta);
            Console.WriteLine("da salary = " + da);
            Console.WriteLine("hra salary = " + hra);
            Console.WriteLine("Gross salary = " + gross_salary);
        }
    }
}
