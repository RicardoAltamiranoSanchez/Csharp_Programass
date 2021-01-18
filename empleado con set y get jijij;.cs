using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa2898687
{
    class Program
    {
        static void Main(string[] args)
        {
            Cempleado ricardo = new Cempleado();
            string dato = "";
            int constraseña = 0;
            int cript = 1993;
            double sueldo1 = 0.0;
            int n = 0;
            int cantidad = 0;
            double sumatoria = 0.0;
            Console.WriteLine("dame la  contraseña para acceder");
            dato = Console.ReadLine();
            constraseña = Convert.ToInt32(dato);


          
             if (constraseña !=cript)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("CUANTOS USUARIOS VAS INGRESAR");
                dato = Console.ReadLine();
                cantidad = Convert.ToInt32(dato);

                for (n = 0; n < cantidad; n++)
                {



                    Console.WriteLine("dame tu el sueldo que vas ingresar");
                    dato = Console.ReadLine();
                    sueldo1 = Convert.ToDouble(dato);
                    ricardo.Sueldo = sueldo1;
                    ricardo.muestra();
                    ricardo.calculaimpuesto();
                    ricardo.muestra();

                }
                for (n =0; n < cantidad; n++)
                {
                    sumatoria = sumatoria + sueldo1;
                }
                Console.WriteLine(sumatoria);
            }
             for (n=0; n<cantidad; n++)
            {
                Console.WriteLine(sueldo1);
            }
            dato = Console.ReadLine();







        }
    }
}
