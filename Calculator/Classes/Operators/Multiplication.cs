using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes.Operators
{
    public class Multiplication : ButtonOperator, IOperator
    {
        public decimal Calculate(decimal result, decimal input)
        {
            decimal output = result * input;

            return output;
        }
    }
}
