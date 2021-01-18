using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {

            var nombre = " ricardo";
            var edad = "25";
            var direccion = "nezahualcoyot";
        }

        class persona
        {
            public string nombre;
            public int edad;
            public string direccion;

            public void informaciondelapersona()
            {
                string output = "tu nombre{0}, ed ad {1}, direccion{2}";
                output = string.Format(output, nombre, edad, direccion);
                Console.WriteLine(output);

            }

        }
    }
}