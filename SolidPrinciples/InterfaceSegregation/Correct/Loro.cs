using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregation.Correct
{
    class Loro : IAve, IAveVoladora
    {
        public void comer()
        {
            throw new NotImplementedException();
        }

        public void volar()
        {
            throw new NotImplementedException();
        }
    }
}
