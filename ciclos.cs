using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double promedio = 0;
            int n = 0;
            int m = 0;
            double sumatoria = 0;
            string dato = "";
            int[,] datos = new int[4, 7];
            Random rnd = new Random();
            for (n = 0; n < 4; n = n + 1)
            {
                for (m = 0; m < 7; m = m + 1)
                {
                    datos[n, m] = rnd.Next(30);

                }
            }
                for (n=0; n<4; n=n+1)
                {
                    Console.WriteLine("semana{0}", n);
                    for (m=0; m<7; m=m+1)
                    {
                        Console.WriteLine("{0}", datos[n, m]);
                    }
                }
     
            Console.WriteLine();
            for (n=0; n<4; n=n+1)
            {
                promedio = 0;
                sumatoria = 0;

                for (m=0; m<7; m=m+1)
                {
                    sumatoria = sumatoria + datos[n,m];
                    promedio = sumatoria / 7.0;
                    Console.WriteLine("el promedio de la semana es {0} del dia {1}", n, promedio);


                }
                dato = Console.ReadLine();
            }
        }
    }
}
