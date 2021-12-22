using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitution.Correct
{
    class Mercedes : Coche
    {
        public override int numAsientos()
        {
            return 5;
        }

        public override int precioMedioCoche()
        {
            return 27500;
        }
    }
}
