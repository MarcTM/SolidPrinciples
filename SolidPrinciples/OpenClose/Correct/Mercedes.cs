using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClose.Correct
{
    class Mercedes : Coche
    {
        public override int precioMedioCoche()
        {
            return 22500;
        }
    }
}
