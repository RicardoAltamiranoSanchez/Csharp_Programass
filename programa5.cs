using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class   Program
    {
        /* BUENAS TARDES HOY HAREMOS EL PROYECTO DE PROGRAMACION LO HARE EN C# POR QUE MI LAPTOP ESTA LENTA HARE UN
         * PROGRAMA DE UNA EMPRESA QUE INGRESA USUARIO USARE LOS METODOS QUE NOS ENSEÑARON Y OTROS ESPERO QUE NO
         * SE MOLESTE BUENO Y NO PUDE PONER MI CARA EN LA PANTALLA POR QUE SE TRABA MI LAPTOP BUENO SOY RICARDO
         * ALTAMIRANO SANCHEZ 3-A GRACIAS*/
         
        


        
        //creamos las variables en una estructura para que no se vea tan feo el programa y simple
        public struct produccion
        {
            public string nombre;
            public int edad;
            public int id;
            public double sueldo;
            
            //hacemos override que solo de pertenece a ese metodo y una cadena de mensaje para no hacer muchas impresiones
            public override string ToString ()
            {
                StringBuilder cadena = new StringBuilder();
                cadena.AppendFormat("tu numero de empleado{0}, \r\nel nombre es {1} y su edad {2}, \r\n y su sueldo {3}", id, nombre, edad, sueldo);

                return cadena.ToString();


            }
        }
        static void Main(string[] args)
        {
            //empezamos a crear las variables que vamos a utilizar parar el for
            string dato = "";
            int cantidad = 0;
            int n = 0;
            //pedimos la cantidad que vamos a ingresar 
            Console.WriteLine(" cuantas personas vas a ingresar");
            dato = Console.ReadLine();
            cantidad = Convert.ToInt32(dato);
            //utilizamos el uso los array o metodos no recuerdo muy bien, para ser mas sencillo el programa
            empleado[] personas = new empleado[cantidad];
            //utilizamos el ciclo for para ingresar los datos ala cantidad que vamos a ingresar
            for ( n =0; n < cantidad; n=n+1)
            {
                Console.WriteLine("ingresa el nombre del empleado");
                personas[n].nombre= Console.ReadLine();
                Console.WriteLine("ingrese la edad del empleado");
                dato = Console.ReadLine();
                personas[n].edad = Convert.ToInt32(dato);
                Console.WriteLine("ingrese su id del empleado");
                dato = Console.ReadLine();
                personas[n].id = Convert.ToInt32(dato);
                Console.WriteLine("ingrese el sueldo del empleado");
                dato = Console.ReadLine();
                personas[n].sueldo = Convert.ToDouble(dato);
               
            }
            //utilizamos otro for para imprimir ordenadamente los datos
         for (n =0; n< cantidad; n=n+1)
          {
                Console.WriteLine(personas[n]);
                Console.WriteLine("-------------------------");
          }
         //otro for y con if para detectar los que van a produccion
         for (n =0; n< cantidad; n=n+1)
            {
                if(personas[n].sueldo < 5000)
                {
                    Console.WriteLine("produccion {0}", personas[n].nombre);
                }
            }
         dato=Console.ReadLine();
            



        }
               
                }
    
                
            }
        
    

