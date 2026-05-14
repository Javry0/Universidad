using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese examen parcial: ");
            double parcial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese examen final: ");
            double final = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese práctica 1: ");
            double p1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese práctica 2: ");
            double p2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese práctica 3: ");
            double p3 = Convert.ToDouble(Console.ReadLine());

            double menorPractica = Math.Min(p1, Math.Min(p2, p3));
            double prom_prac = (p1 + p2 + p3 - menorPractica) / 2.0;
            double prom_final = (parcial + final + prom_prac) / 3.0;

            string clasificacion;

            if (prom_final >= 18)
                clasificacion = "Excelente";
            else if (prom_final >= 14)
                clasificacion = "Bueno";
            else if (prom_final >= 10)
                clasificacion = "Regular";
            else
                clasificacion = "Deficiente";

            Console.WriteLine($"Promedio de prácticas: {prom_prac:F2}");
            Console.WriteLine($"Promedio final: {prom_final:F2}");
            Console.WriteLine($"Clasificación: {clasificacion}");
        }
    }
}
