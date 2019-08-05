using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1Pract1
{
    public class ejer1
    {
        public static void primero()
        {

            string nombre, especie, edad;

            Console.WriteLine("Coloque el nombre de la mascota");
            nombre = Console.ReadLine();
            Console.WriteLine("Coloque la edad de la mascota");
            edad = Console.ReadLine();
            Console.WriteLine("Coloque la especie de la mascota");
            especie = Console.ReadLine();

            Console.WriteLine("El nombre de la mascota es:" + nombre + "La edad de la mascota es: " + edad + "La especie de la mascota es: " + especie);

        }

    }
}
