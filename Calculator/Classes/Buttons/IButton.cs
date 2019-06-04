using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes.Buttons
{
    interface IButton
    {
        int XTableCoordinate { get; set; }
        int YTableCoordinate { get; set; }
        int XWindowPosition { get; set; }
        int YWindowPosition { get; set; }

        void Click(object sender, EventArgs e);
    }
}
