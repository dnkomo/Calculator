using Calculator.Classes.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Classes.Buttons
{
    public class ButtonNumber : Button, IButton, IButtonNumber
    {
        private int buttonValue;

        public int XTableCoordinate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int YTableCoordinate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int XWindowPosition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int YWindowPosition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ButtonValue { get => buttonValue; set => buttonValue = value; }

        public ButtonNumber(int value)
        {
            this.ButtonValue = value;
        }

        //public void ButtonClick(object sender, EventArgs e)
        //{
            
        //}
    }
}
