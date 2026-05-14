using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_jp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mayor = int.MinValue;   
            int contador = 0;           
            int numero;

            do
            {
                Console.Write("Ingrese un número entero (0 para terminar): ");
                numero = int.Parse(Console.ReadLine());

                if (numero != 0)
                {
                    if (numero > mayor)
                    {
                        mayor = numero;
                    }
                    contador++;
                }
            } while (numero != 0);

            // Resultado final
            if (contador > 0)
            {
                Console.WriteLine($"El mayor número ingresado es: {mayor}");
            }
            else
            {
                Console.WriteLine("No se ingresaron números válidos.");
            }
       }
    }
}
