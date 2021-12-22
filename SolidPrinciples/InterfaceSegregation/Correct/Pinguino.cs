using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregation.Correct
{
    class Pinguino : IAve, IAveNadadora
    {
        public void comer()
        {
            throw new NotImplementedException();
        }

        public void nadar()
        {
            throw new NotImplementedException();
        }
    }
}
