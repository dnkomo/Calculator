﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes.Operators
{
    interface IOperator
    {
        decimal Calculate(decimal result, decimal input);
    }
}
