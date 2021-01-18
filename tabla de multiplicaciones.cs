using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jajajajajjaajjajjajjaja
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b= 0;
            int resultado = 0;
            string dato = "";
            for (a = 1; a < 10;  a=a+1)
            {
                for (b = 1; b <10; b=b+1 )
                {
                    resultado = a * b;
                    Console.WriteLine("{0} * {1} = {2}", a, b, resultado);
                }
              
            }
        dato = Console.ReadLine();
        }
    }
}
