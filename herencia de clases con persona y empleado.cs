using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = "";
            Cpersona ricardo = new Cpersona();
            ricardo.Nombre = "ricardo";
            ricardo.Edad = 25;
            ricardo.muestra();

            Cempleado miguel = new Cempleado();
            miguel.Nombre = "miguel";
            miguel.Edad = 18;
            miguel.Puesto = "gerente";
            miguel.Sueldo = 15000;
            miguel.Empleadomuestra();
         

            Cempleado juan = new Cempleado();
            juan.ponerdatos("juan", 29, "programador", 30000);
            juan.Empleadomuestra();
            dato = Console.ReadLine();






















        }
    }
}
