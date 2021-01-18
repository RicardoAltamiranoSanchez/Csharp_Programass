using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Cempleado
    {
        private int edad = 0;
        private string nombre = "";
        
        public Cempleado()
        {
            string dato = "";
            Console.WriteLine("dame el nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("dame la edad");
            dato = Console.ReadLine();
            edad = Convert.ToInt32(dato);


        }

        public string Nombre
        {
            set { nombre = value; }



        }
        public int Edad
        {
            set  { edad = value; }

        }
        public void muestra()
        {
            Console.WriteLine("NOMBRE: {0}   EDAD {1}   ", nombre, edad);
        }
    }
}
