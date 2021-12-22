using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitution.Correct
{
    public class Principal
    {
        public static void main(String[] args)
        {
            Coche[] arrayCoches = {
                new Renault(),
                new Audi(),
                new Mercedes()
            };
            imprimirNumAsientos(arrayCoches);
            imprimirPrecioMedioCoche(arrayCoches);
        }

        public static void imprimirNumAsientos(Coche[] arrayCoches)
        {
            foreach (Coche coche in arrayCoches)
            {
                Console.WriteLine(coche.numAsientos());
            }
        }

        public static void imprimirPrecioMedioCoche(Coche[] arrayCoches)
        {
            foreach (Coche coche in arrayCoches)
            {
                Console.WriteLine(coche.precioMedioCoche());
            }
        }
    }
}
