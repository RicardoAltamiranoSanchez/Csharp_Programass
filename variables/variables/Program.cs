using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 5;
            int numero2 = 6;
            int numero3 = 7;
            int resultado = multiplicacion(numero1, numero2, numero3);
            Console.WriteLine(resultado);
            Console.Read();
        }
        static int multiplicacion(int a, int b, int c)
        {

            return a * b * c;
        }
    }
}


            

