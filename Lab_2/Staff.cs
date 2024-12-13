using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    //2. Write a program to create a class Staff having data members as Name,
    //Department, Designation, Experience & Salary.Accept this data for 5
    //different staffs and display only names & salary of those staff who are HOD.
    internal class Staff
    {
        string Name;
        string Department;
        string Designation;
        string Experience;
        double Salary;

        public void Get_Staff_Detail()
        {
            Console.Write("\nEnter a Name: ");
            this.Name = Console.ReadLine();
            Console.Write("Enter a Department: ");
            this.Department = Console.ReadLine();
            Department = Department.ToUpper();
            Console.Write("Enter a Designation: ");
            this.Designation = Console.ReadLine();
            Console.Write("Enter a Experience: ");
            this.Experience = Console.ReadLine();
            Console.Write("Enter a Salary: ");
            this.Salary = int.Parse(Console.ReadLine());
        }

        public void Display_Staff_Name_and_Salary()
        {
            if (Department == "HOD")
            {
                Console.WriteLine("\nStaff Details");
                Console.WriteLine("Name = " + Name + "\nSalary = " + Salary);
            }
        }
    }
}
