using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes.Buttons
{
    public class Button
    {
        int xCoordinate;
        int yCoordinate;

        public int YCoordinate { get => yCoordinate; set => yCoordinate = value; }
        public int XCoordinate { get => xCoordinate; set => xCoordinate = value; }

        public void Click (object sender, EventArgs e)
        {

        }
    }
}
