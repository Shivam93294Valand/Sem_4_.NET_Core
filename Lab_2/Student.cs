using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    //4. Write a program with following specifications: Class Name: Student
    //Data Members: Enrollment_No, Student_Name, Semester, CPI and SPI
    //Get Students Details using constructor and DisplayStudentDetails() using
    //member function.
    internal class Student
    {
        int Enrollment_No;
        string Student_Name;
        int Semester;
        double CPI;
        double SPI;
        public Student()
        {
            Console.Write("Enter a Enrollment Number: ");
            this.Enrollment_No = int.Parse(Console.ReadLine());
            Console.Write("Enter a Student Name: ");
            this.Student_Name = Console.ReadLine();
            Console.Write("Enter a Semester: ");
            this.Semester = int.Parse(Console.ReadLine());
            Console.Write("Enter a CPI: ");
            this.CPI = double.Parse(Console.ReadLine());
            Console.Write("Enter a SPI: ");
            this.SPI = double.Parse(Console.ReadLine());
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("\nStudent Details");
            Console.WriteLine("Enrollment Number = " + Enrollment_No);
            Console.WriteLine("Student Name = " + Student_Name);
            Console.WriteLine("Semester = " + Semester);
            Console.WriteLine("CPI = " + CPI);
            Console.WriteLine("SPI = " +SPI);
        }
    }
}