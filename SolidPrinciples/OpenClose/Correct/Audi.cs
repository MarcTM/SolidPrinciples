﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClose.Correct
{
    class Audi : Coche
    {
        public override int precioMedioCoche()
        {
            return 25000;
        }
    }
}
