using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Acceso permitido. Bienvenido.");
            }
            else
            {
                int faltan = Math.Abs(18 - edad);
                Console.WriteLine("Acceso denegado.");
                Console.WriteLine("Te faltan " + faltan + " año(s) para registrarte.");
            }

            Console.ReadKey();
        }
    }
}
