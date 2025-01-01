using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class BankAccount
    {
        string AccountHolder_Name;
        double balance;
        public BankAccount()
        {
            Console.WriteLine("Enter AccountHolder Neme:");
            string AccountHolder_Name = Console.ReadLine();
            Console.WriteLine("Enter AccountHolder balance:");
            double balance = double.Parse(Console.ReadLine());
        }

        public void Deposit_Cash()
        {
            Console.WriteLine("Enter ruppies you want to deposit:");
            double depo = double.Parse(Console.ReadLine());
            this.balance += depo;
        }

        public void Deposit_Check()
        {
            Console.WriteLine("Enter ruppies you want to deposit:");
            double depo = double.Parse(Console.ReadLine());
            this.balance += depo;
        }

        public void Withdrw_Cash()
        {
            Console.WriteLine("Enter ruppies you want to withdrow:");
            double withdrow = double.Parse(Console.ReadLine());
            if (balance - withdrow > 0)
            {
                Console.WriteLine("Withdraw succesfully");
            }
            else
            {
                Console.WriteLine("Insufficent Balance");
            }
        }

        public void Withdrw_Check()
        {
            Console.WriteLine("Enter ruppies you want to withdrow:");
            double withdrow = double.Parse(Console.ReadLine());
            if (balance - withdrow > 0)
            {
                Console.WriteLine("Withdraw succesfully");
            }
            else
            {
                Console.WriteLine("Insufficent Balance");
            }
        }
    }
}
