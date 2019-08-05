using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1Pract1
{
    public class ejer4
    {
        public static void cuarto()
        {
            int numero = 0;
            Console.WriteLine("Coloque un numero");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("Debe ser un numero mayor 0");
            }
            else
            {
                Console.WriteLine("La raiz del numero" + numero + ": " + Math.Sqrt(numero));
            }
        }
    }
}
