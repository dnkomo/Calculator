using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Classes.Operators
{
    public class ButtonOperator : Button, IButtonOperator
    {
        private decimal result;
        private decimal input;
        private char operatorCharacter;

        public decimal Result { get => result; set => result = value; }
        public decimal Input { get => input; set => input = value; }
        public char OperatorCharacter { get => operatorCharacter; set => operatorCharacter = value ; }

        public ButtonOperator()
        {
            this.Result = 0;
        }

        public ButtonOperator(char operatorInput)
        {
            this.Result = 0;
            this.operatorCharacter = operatorInput;
        }
    }
}
