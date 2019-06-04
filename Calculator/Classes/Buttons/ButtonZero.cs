using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes.Buttons
{
    public class ButtonZero : IButtonNumber, IButton
    {
        private int buttonValue;
        private int xTableCoordinate;
        private int yTableCoordinate;
        private int xWindowPosition;
        private int yWindowPosition;

        public int ButtonValue { get => buttonValue; set => buttonValue = value; }
        public int XTableCoordinate { get => xTableCoordinate; set => xTableCoordinate = value; }
        public int YTableCoordinate { get => yTableCoordinate; set => yTableCoordinate = value; }
        public int XWindowPosition { get => xWindowPosition; set => xWindowPosition = value; }
        public int YWindowPosition { get => yWindowPosition; set => yWindowPosition = value; }

        public ButtonZero()
        {
            this.ButtonValue = 0;
            this.XTableCoordinate = 1;
            this.YTableCoordinate = 4;
            this.XWindowPosition = 47;
            this.YWindowPosition = 137;
        }

        public void Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
