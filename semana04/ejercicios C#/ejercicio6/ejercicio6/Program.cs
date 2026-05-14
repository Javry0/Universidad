using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa el promedio del estudiante (0-20): ");
            if (int.TryParse(Console.ReadLine(), out int promedio))
            {
                if (promedio < 0 || promedio > 20)
                {
                    Console.WriteLine("Valor inválido");
                }
                else if (promedio >= 0 && promedio <= 5)
                {
                    Console.WriteLine("Deficiente");
                }
                else if (promedio >= 6 && promedio <= 10)
                {
                    Console.WriteLine("Regular");
                }
                else if (promedio >= 11 && promedio <= 14)
                {
                    Console.WriteLine("Bueno");
                }
                else if (promedio >= 15 && promedio <= 20)
                {
                    Console.WriteLine("Excelente");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
            }
        }
    }
}
