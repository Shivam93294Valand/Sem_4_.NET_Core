using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    //1. Write a program to create a class named Candidate with ID, Name, Age,
    //Weight and Height as data members & also create a member functions like
    //GetCandidateDetails() and DisplayCandidateDetails().
    internal class Candidate
    {
        int Id;
        string Name;
        int Age;
        int Weight;
        int Height;

        public void GetCandidateDetails()
        {
            Console.Write("Enter a Id: ");
            this.Id = int.Parse(Console.ReadLine());
            Console.Write("Enter a Name: ");
            this.Name = Console.ReadLine();
            Console.Write("Enter a Age: ");
            this.Age = int.Parse(Console.ReadLine());
            Console.Write("Enter a Weight: ");
            this.Weight = int.Parse(Console.ReadLine());
            Console.Write("Enter a Height: ");
            this.Height = int.Parse(Console.ReadLine());
        }

        public void DisplayCandidateDetails()
        {
            Console.WriteLine("\nThe Details of Candidate");
            Console.WriteLine("Id = " + Id);
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("Age = " + Age);
            Console.WriteLine("Weight = " + Weight);
            Console.WriteLine("Height = " + Height);
        }
    }
}