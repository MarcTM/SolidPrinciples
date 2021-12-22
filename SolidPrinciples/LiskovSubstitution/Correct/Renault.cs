using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitution.Correct
{
    class Renault : Coche
    {
        public override int numAsientos()
        {
            return 4;
        }

        public override int precioMedioCoche()
        {
            return 18000;
        }
    }
}
