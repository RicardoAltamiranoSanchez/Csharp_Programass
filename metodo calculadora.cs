using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos_ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = "";
            int opcion = 0;
           
            
            do
            {
                Console.WriteLine("que operacion deseas");
                Console.WriteLine("1 suma 2 resta 3 multplicacion 4 division 5 salir");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);
                if (opcion == 1)
                {
                    suma();
                }
                if (opcion == 2)
                {
                    resta();
                }
                if (opcion ==3)
                {
                    multiplicacion();
                }
                if (opcion ==4)
                {
                    division();
                }
            } while (opcion != 5);
            Console.WriteLine("adios");
        }
        static public void suma()
        {
            string dato = "";
            int num1 = 0;
            int num2 = 0;
            int resl = 0;
            Console.WriteLine("dame tu primer numero");
            dato = Console.ReadLine();
            num1 = Convert.ToInt32(dato);
            Console.WriteLine("dame tu segundo numero");
            dato = Console.ReadLine();
            num2 = Convert.ToInt32(dato);
            resl = num1 + num2;
            Console.WriteLine("tu resultado es {0}", resl);
        }
        static public void resta()
        {
            string dato = "";
            int num1 = 0;
            int num2 = 0;
            int resul = 0;
            Console.WriteLine("dame tu primer numero");
            dato = Console.ReadLine();
            num1 = Convert.ToInt32(dato);
            Console.WriteLine("dame tu segundo numero");
            dato = Console.ReadLine();
            num2 = Convert.ToInt32(dato);
            resul = num1 - num2;
            Console.WriteLine("tu resultado es {0}", resul);


        }
        static public void multiplicacion()
        {
            string dato = "";
            int num1 = 0;
            int num2 = 0;
            int resul = 0;
            Console.WriteLine("dame tu primer numero");
            dato = Console.ReadLine();
            num1 = Convert.ToInt32(dato);
            Console.WriteLine("dame tu segundo numero");
            dato = Console.ReadLine();
            num2 = Convert.ToInt32(dato);
            resul = num1 * num2;
            Console.WriteLine(" tu resultado es {0}", resul);
        }
        static public void division()
        {
            string dato = "";
            int num1 = 0;
            int num2 = 0;
            int resul = 0;
            Console.WriteLine("dame tu primer numero ");
            dato = Console.ReadLine();
            num1 = Convert.ToInt32(dato);
            Console.WriteLine("dame tu segundo numero");
            dato = Console.ReadLine();
            num2 = Convert.ToInt32(dato);
            resul = num1 / num2;
            Console.WriteLine(" tu resultado es {0}", resul);
        }
    }
}