using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes.Buttons
{
    class ButtonZero : Button, IButtonNumber
    {
        int buttonValue;

        public int ButtonValue { get => buttonValue; set => buttonValue = ButtonValue; }
    }
}
