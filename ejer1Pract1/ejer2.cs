using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1Pract1
{
    public class ejer2
    {
        public static void segundo()
        {
            //nombre, cargo, correo, edad, fecha de contratación y sueldo;
            double sueldo = 0;
            int edad = 0;
            DateTime fecha;
            string cargo, nombre, correo;
            Console.WriteLine("Coloque el nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("Coloque el correo del empleado");
            correo = Console.ReadLine();
            Console.WriteLine("Coloque el cargo del empleado");
            cargo = Console.ReadLine();
            Console.WriteLine("Coloque el sueldo del empleado");
            sueldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Coloque la edad del empleado");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Coloque la fecha de contratacion");
            fecha = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("El nombre del empleado es: " + nombre + " El correo del empleado es: " + correo + " El cargo del empleado es: " + cargo + " El sueldo del empleado es: " + sueldo);
            Console.WriteLine(" La edad del empleado es: " + edad + "La fecha de contratacion es: " + fecha.ToString("ddd/MMMM/yyyy"));


          

        }
    }
}
