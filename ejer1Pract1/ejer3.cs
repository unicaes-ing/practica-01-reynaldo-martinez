using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1Pract1
{
    class ejer3
    {
        public static void tercer()
        {
            double num1 = 0, num2 = 0;
            int opc=0;


            Console.WriteLine("Coloque el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Coloque el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Que operacion desea hacer?");
            Console.WriteLine("1.suma");
            Console.WriteLine("2.resta");
            Console.WriteLine("3.multiplicacion");
            Console.WriteLine("4.division");
            opc = Convert.ToInt32(Console.ReadLine());



            Console.ReadKey();


            switch (opc)
            {
                case 1:
                    Console.WriteLine(String.Format("suma: {0:N1}", num1 + num2));
                    break;
                case 2:
                    Console.WriteLine(String.Format("resta: {0:N1}", num1 - num2));
                    break;
                case 3:
                    Console.WriteLine(String.Format("multiplicacion: {0:N1}", num1 * num2));
                    break;
                case 4:
                    Console.WriteLine(String.Format("division: {0:N1}", num1 / num2));
                    break;
                default:
                    System.Environment.Exit(-1);
                    break;

                   

            }
            
        }
    }
}
