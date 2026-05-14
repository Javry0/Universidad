using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioejemplo2_jp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                double num, sumMa = 0, sumMe = 0;
                int contMa = 0, contMe = 0;
                
                do
                {
                    Console.Write("Ingrese un número (0 para terminar): ");
                    num = double.Parse(Console.ReadLine());

                    if (num != 0)
                    {
                        if (num > 500)
                        {
                            sumMa += num;
                            contMa++;
                        }
                        else if (num < 500)
                        {
                            sumMe += num;
                            contMe++;
                        }
                        }
                } while (num != 0);

                Console.WriteLine("\n=== RESULTADOS ===");
                if (contMa > 0)
                    Console.WriteLine($"Promedio mayores a 500: {sumMa / contMa:F2}");
                else
                    Console.WriteLine("No se ingresaron números mayores a 500.");

                if (contMe > 0)
                    Console.WriteLine($"Promedio menores a 500: {sumMe / contMe:F2}");
                else
                    Console.WriteLine("No se ingresaron números menores a 500.");
            }
        }
    }

