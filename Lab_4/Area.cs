using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Area
    {
        public double Find_Area(double length) 
        {
            return length * length;
        }

        public double Find_Area(double length, double width) 
        {
            return length * width; 
        }
    }
}
