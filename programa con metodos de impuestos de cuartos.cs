using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_CON_METODOS
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = "";
            int cantidad = 0;
            double area = 0.0;
            double grantotal= 0.0;
            int n = 0;
            int opcion = 0;
            double costohab = 0.0;
            Console.WriteLine("cuantos cuartos tienes");
            dato = Console.ReadLine();
            cantidad = Convert.ToInt32(dato);
            for (n =0; n < cantidad; n=n+1)
            {
                Console.WriteLine("que tipo de cuarto tienes");
                Console.WriteLine("1 baño 2 sala 3 cocina");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);
                area = calcularArea();
                if (opcion ==1)
                {
                    costohab = calcularcostos(area, 300.0, 0.05);
                }
                if(opcion == 2)
                {
                    costohab = calcularcostos(area, 375.0, 0.12);
                }
                if (opcion ==3)
                {
                    costohab = calcularcostos(area, 120.0, 0.0);
                }

                grantotal = grantotal + costohab;
                
            }
            Console.WriteLine("el costo total de los gastos es {0}", grantotal);
            
        }
            static public  double calcularArea()
        {
            string dato = "";
            double ancho = 0.0;
            double largo = 0.0;
            double area = 0.0;
            Console.WriteLine(" dame el ancho del cuarto");
            dato = Console.ReadLine();
            ancho = Convert.ToDouble(dato);
            Console.WriteLine("dam el largo del cuarto");
            dato = Console.ReadLine();
            largo = Convert.ToDouble(dato);
            area = ancho * largo;

            return area;


        }
         public static double calcularcostos(double area, double pM2, double impuesto)
        {
            double total = 0.0;
            double imp = 0.0;
            double costo = 0.0;

            costo = area * pM2;
            imp = costo * imp;
            total =costo +imp;


            return total;
        }
        
    }
}
