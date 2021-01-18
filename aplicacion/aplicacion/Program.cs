using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacion
{
    class Program
    {
        //hacer un programa que lede pregubte su nombre, su edad,posteriormente se debe mostrar en la pantalla con el nombre del usuario y su edad
        //pista:utilice Console.Readline para leer la informacion que ingrese el usuario
        //pista 2 :utilice int.parse para convertir de tipo int

        static void Main(string[] args)
        {
            preguntanombreedad();     

            Console.Read();
        }
        static void preguntanombreedad()
        {
            string nombre;
            int edad;
        Console.WriteLine("ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese su edad");
            edad = int.Parse(Console.ReadLine());
        string output = string.Format("su nombre es {0} y su edad es{1} eres puto", nombre, edad);
            Console.WriteLine(output);

        }

        }
    }

