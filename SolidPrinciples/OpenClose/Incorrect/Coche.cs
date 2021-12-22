using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClose.Incorrect
{
    public class Coche
    {
        private String marca;

        public String Marca;

        public Coche (String marca) {
            this.marca = marca;
        }

        String getMarcaCoche() { return marca; }
    }
}
