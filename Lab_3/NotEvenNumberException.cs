﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class NotEvenNumberException : Exception
    {
        public NotEvenNumberException(string message) : base(message)
        {
        }
    }
}
