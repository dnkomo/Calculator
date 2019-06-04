using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes.Operators
{
    public class Operator
    {
        private decimal result;
        private decimal input;

        public decimal Result { get => result; set => result = value; }
        public decimal Input { get => input; set => input = value; }

        public Operator()
        {
            this.Result = 0;
        }
    }
}
