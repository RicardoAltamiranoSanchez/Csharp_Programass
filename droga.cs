using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //asignamos variables
            int dinero = 0;
            int opcion = 0;
            string dato = "";
            int total = 0;
            //pedimos al usuario la cantidad que tiene
            Console.WriteLine("cuanto dinero tienes");
            dato = Console.ReadLine();
            dinero = Convert.ToInt32(dato);
            while (dinero > 0 && opcion !=5)
            {
                //hacemos el menu de 
                Console.WriteLine("que deseas comprar");
                Console.WriteLine("1 papas ,2 hamburgesa, 3 hot dog, 4 pizza, 5 adios");
                dato=Console.ReadLine();
                opcion = Convert.ToInt32(dato);
                //hacemos las opciones de cada costo de la comida
                switch (opcion)
                {
                    case 1:
                        dinero = dinero - 50;
                        total = total +50;
                        break;
                    case 2:
                        dinero = dinero - 100;
                        total = total + 100;
                        break;
                    case 3:
                        dinero = dinero - 250;
                        total = total + 250;
                        break;
                    case 4:
                        dinero = dinero - 500;
                        total = total + 500;
                        break;

                }
                //resultado final
                Console.WriteLine("tienes de dinero {0}, y haz gastado {1} ", dinero, total);




            }

        }
    }
}
