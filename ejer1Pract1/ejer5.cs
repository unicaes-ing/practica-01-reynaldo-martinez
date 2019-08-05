using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1Pract1
{
    public class ejer5
    {
        public static void quinto()
        {
            //Crear una aplicación que capture por teclado el total de ventas correspondiente a cada
            //trimestre del año pasado, calcular y mostrar el promedio de ventas de cada trimestre.
            int i=0;
            double prom, ventas=0, cont=0;

            for ( i = 1; i <= 4; i++)
            {
                Console.WriteLine("coloque la venta del trimestre " + i);
                ventas = Convert.ToDouble(Console.ReadLine());
                cont = cont + ventas;
            }

            prom = cont / 4;
            Console.WriteLine("El promedio es: "+ prom);
        }
    }
}
