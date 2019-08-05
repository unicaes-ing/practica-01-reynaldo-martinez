using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1Pract1
{
    public class ejer6
    {
        public static void sexto()
        {
            //. Crear una aplicación que capture por teclado el nombre del empleado y el sueldo, luego
             //que muestre el nombre del empleado, sueldo, los descuento de: ISSS, Renta y AFP,
             //calcular y mostrar el sueldo a pagar. (investigar cómo formatear las cantidades
           // numéricas y monetarias)

            string nombre;
            double sueldo, iss, renta, afp, nSueldo, suma;

            Console.WriteLine("Coloque el nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("Coloque el sueldo del empleado");
            sueldo = Convert.ToDouble(Console.ReadLine());

            iss = sueldo * 0.0725;
            afp = sueldo * 0.13;
            renta = sueldo * 0.13;
            suma = iss - afp - renta;
            Console.WriteLine("Nombre empleado: " + nombre);
            Console.WriteLine("descuentos:");
            Console.WriteLine("iss:" + iss);
            Console.WriteLine("afp:" + afp);
            Console.WriteLine("renta:" + renta);
            nSueldo = sueldo - suma;
            Console.WriteLine("Nuevo sueldo:" + nSueldo);
            
            
        }
    }
}
