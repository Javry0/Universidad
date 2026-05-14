using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_jp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, contador = 0, numero = 1;
            do
            {
                suma = suma + numero;
                contador = contador + 1;
                numero = numero + 2;
            } while (contador < 100 && numero < 500);

            Console.WriteLine($"Cantidad de impares sumados: {contador}");
            Console.WriteLine($"El siguiente impar despues del ciclo: {numero}");
            Console.WriteLine($"La suma de los primeros 100 " + $"Número de impares < a 500 es : {suma}" );
        }
    }
}
