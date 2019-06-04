using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes.Operators
{
    public class Multiplication : Operator, IOperator
    {
        public decimal Calculate()
        {
            decimal output = base.Result * base.Input;

            return output;
        }
    }
}
