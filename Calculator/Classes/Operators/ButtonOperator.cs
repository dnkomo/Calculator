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
        private char operatorCharacter;
        
        public char OperatorCharacter { get => operatorCharacter; set => operatorCharacter = value ; }

        public ButtonOperator()
        {

        }

        public ButtonOperator(char operatorInput)
        {
            this.operatorCharacter = operatorInput;
        }
    }
}
