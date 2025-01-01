using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class RBI
    {
        public virtual double calculateInterest(double princple, double rate, double time) 
        { 
            return (princple * rate * time) / 100;
        }
    }
}
