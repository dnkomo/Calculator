using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes.Operators
{
    public class Subtraction : Operator,IOperator
    {
        public decimal Calculate()
        {
            decimal output = base.Result - base.Input;

            return output;
        }
    }
}
