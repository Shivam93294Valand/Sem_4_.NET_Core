using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Interest : Account_Details
    {
        public int interest;
        public int Cal_interest;

        public void Calcute_Interest()
        {
            Console.Write("\nEnter interest in persentage: ");
            interest = Convert.ToInt32(Console.ReadLine());
            Cal_interest = (Balance * interest) / 100;
        }
        public void DisplayDetail()
        {
            Console.WriteLine("\nAccount Details:");
            Console.WriteLine("Account Holder name: " + AccountHolder_Name);
            Console.WriteLine("Account Number: " + Account_No);
            Console.WriteLine("Balance : " + Balance);
            Console.WriteLine("Calculated Interest : " + Cal_interest);
            Console.WriteLine("Total Balance : " + (Balance + Cal_interest));
        }
    }
}