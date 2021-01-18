using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuras
{
    class Program
    {
        public struct empleado
            {
            public string nombre;
            public int edad;
            public int id;
            public double sueldo; 

            public override string ToString()
            {
                StringBuilder cadena = new StringBuilder();

                cadena.AppendFormat("numero de empleado{0}, \r\nnombre {1} y edad {2} , \r\n sueldo mensual del empleado{3}", id, nombre, edad, sueldo);



                return cadena.ToString();
            }

            }
        static void Main(string[] args)
        {
            empleado uno;
          uno.id = 0;
            uno.edad = 0;
            uno.nombre = "";
            uno.sueldo = 0.0;
            string dato = "";
            Console.WriteLine("cual es el codigo  empleado");
            dato = Console.ReadLine();
            uno.id = Convert.ToInt32(dato);
            Console.WriteLine("nombre del empleado que va ingresar");
            uno.nombre = Console.ReadLine();
            Console.WriteLine("cual es edad del empleado");
            dato = Console.ReadLine();
            uno.edad = Convert.ToInt32(dato);
            Console.WriteLine("el sueldo que va ganar por mes el empleado de nuevo ingreso");
            dato = Console.ReadLine();
            uno.sueldo = Convert.ToDouble(dato);
            Console.WriteLine(uno);
            dato = Console.ReadLine();

        }
    }
}
