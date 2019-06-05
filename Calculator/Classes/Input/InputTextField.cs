using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes.Input
{
    public class InputTextField
    {
        private string inputString;

        public string InputString { get => inputString; set => inputString = value; }

        public InputTextField()
        {
            this.InputString = string.Empty;
        }
    }
}
