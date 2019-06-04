using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes.Buttons
{
    public class ButtonSeven : IButtonNumber, IButton
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

        public ButtonSeven()
        {
            this.ButtonValue = 7;
            this.XTableCoordinate = 0;
            this.YTableCoordinate = 1;
            this.XWindowPosition = 3;
            this.YWindowPosition = 36;
        }

        public void Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
