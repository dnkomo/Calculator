using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Classes.Operators
{
    public class Math : IMath
    {
        private decimal result;
        private decimal input;
        private int inputToggle;

        public decimal Result { get => result; set => result = value; }
        public decimal Input { get => input; set => input = value; }
        public int InputToggle { get => inputToggle; set => inputToggle = value; }

        public Math()
        {
            this.result = 0;
            this.inputToggle = 0;
        }

        public decimal Evaluate(decimal result, decimal input, Label inputField, Label outputField)
        {
            decimal output = 0;

            if (inputField.Text[0] == '+')
            {
                Addition add = new Addition();
                output = add.Calculate(result, input);
            }
            if (inputField.Text[0] == '-')
            {
                Subtraction minus = new Subtraction();
                output = minus.Calculate(result, input);
            }
            if (inputField.Text[0] == '*')
            {
                Multiplication multiply = new Multiplication();
                output = multiply.Calculate(result, input);
            }
            if (inputField.Text[0] == '/')
            {
                Division divide = new Division();
                output = divide.Calculate(result, input);
            }

            return output;
        }

        public void InputToggleMethod()
        {
            if (this.inputToggle == 1)
            {
                this.inputToggle = 0;
            }
            else
            {
                this.inputToggle = 1;
            }
        }
    }
}
