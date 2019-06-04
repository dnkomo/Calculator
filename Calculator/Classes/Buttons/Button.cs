namespace Calculator.Classes.Buttons
{
    using Calculator.Classes.Operators;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Button
    {
        int xCoordinate;
        int yCoordinate;
        Operator currentOperator;

        public int YCoordinate { get => yCoordinate; set => yCoordinate = value; }
        public int XCoordinate { get => xCoordinate; set => xCoordinate = value; }
        public Operator CurrentOperator { get => currentOperator; set => currentOperator = value; }

        public void Click (object sender, EventArgs e)
        {

        }
    }
}
