using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsability.Correct
{
    // Una clase o método debe tener una única responsabilidad
    class Coche
    {
        String marca;

        Coche(String marca)
        {
            this.marca = marca;
        }

        string getMarcaCoche()
        {
            return marca;
        }
    }
}
