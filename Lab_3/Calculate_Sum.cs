using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Calculate_Sum : sum
    {

        public override int SumOfTwo(int num1, int num2)
        {
            return (num1 + num2);
        }

        public override int SumOfThree(int num1, int num2, int num3)
        {
            return (num1 + num2 + num3);
        }
    }
}