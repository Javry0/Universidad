using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {                      
            Console.Write("Ingrese el peso en kg: ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la estatura en metros: ");
            double estatura = double.Parse(Console.ReadLine());
            double imc = peso / Math.Pow(estatura, 2);

            double imcRed = Math.Round(imc, 2);
            Console.WriteLine($"IMC: {imcRed}");

            if (imc < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Bajo peso");
            }
            else if (imc < 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Normal");
            }
            else if (imc < 30)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sobrepeso");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Obesidad");
            }
            Console.ResetColor();
            Console.ReadKey(); 

        }
    }
}
