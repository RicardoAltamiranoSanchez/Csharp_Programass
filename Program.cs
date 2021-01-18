using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progrmaprueba2
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato;
            int numero1;
            int numero2;
            string nombre;
            string apellido;
            int edad;
            int seleccion;
            int resultado;
            Console.WriteLine("ingrese SU NOMBRE");
            nombre = Console.ReadLine();
            Console.WriteLine("INGRESE SU APELLIDO");
            apellido = Console.ReadLine();
            Console.WriteLine("ingresa tu edad");
            dato = Console.ReadLine();
            edad = Convert.ToInt32(dato);
            Console.WriteLine("HOLA{0} {1} y tu edad es {2}", nombre, apellido, edad);
            Console.WriteLine("LISTO PARA USAR LA CALCULADORA");
            Console.WriteLine("INGRESA TU PRIMER NUMERO");
            dato = Console.ReadLine();
            numero1 = Convert.ToInt32(dato);
            Console.WriteLine("ingresa tu segundo numero");
            dato = Console.ReadLine();
            numero2 = Convert.ToInt32(dato);
            Console.WriteLine("que operacion deseas 1 multiplicacion 2 division 3 resta 4 suma");
            dato = Console.ReadLine();
            seleccion = Convert.ToInt32(dato);

                switch (seleccion)
                { 
                case 1:
                    resultado = numero1 * numero2;
                Console.WriteLine("tu resultado es {0}", resultado);
                break;
                case 2:
                    resultado = numero1 / numero2;
                Console.WriteLine("tu resultado es {0}", resultado);
                break;
                case 3:
                    resultado = numero1 - numero2;
                Console.WriteLine("TU RESULTADO ES {0}", resultado);
                break;
                case 4:
                    resultado = numero1 + numero2;
                Console.WriteLine("tu resultado es {0}", resultado);
                break;
                default:
                    Console.WriteLine(" ERROR ");
                break;







            

            }
            Console.WriteLine(" deseas otra operacion");
            dato = Console.ReadLine();

        }
    }
}
