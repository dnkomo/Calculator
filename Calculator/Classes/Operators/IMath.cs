﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes.Operators
{
    public interface IMath
    {
        decimal Result { get; set; }
        decimal Input { get; set; }
    }
}
