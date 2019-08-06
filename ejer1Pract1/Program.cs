using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1Pract1
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            string respuesta;
            do
            {

                Console.WriteLine("1.Ejercicio1");
                Console.WriteLine("2.Ejercicio2");
                Console.WriteLine("3.Ejercicio3");
                Console.WriteLine("4.Ejercicio4");
                Console.WriteLine("5.Ejercicio5");
                Console.WriteLine("6.Ejercicio6");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (menu)
                {
                    case 1:
                        ejer1.primero();
                        break;
                    case 2:
                        ejer2.segundo();
                        break;
                    case 3:
                        ejer3.tercer();
                        break;
                    case 4:
                        ejer4.cuarto();
                        break;
                    case 5:
                        ejer5.quinto();
                        break;
                    case 6:
                        ejer6.sexto();
                        break;

                    default:
                        break;
                }
               
                Console.WriteLine(" desea hacer otrto ejercicio?");
                respuesta = Console.ReadLine();
                Console.Clear();
                
            } while (respuesta == "si" ||respuesta == "s");
            
         
            
            Console.ReadKey();

        }
    }
}
