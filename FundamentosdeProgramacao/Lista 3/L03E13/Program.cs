/*
Construa um algoritmo que imprima a tabela de equivalência de graus Fahrenheit 
para Celsius. Os limites são de 50 a 70 graus Fahrenheit com intervalo de 1 grau.
Fórmula: °C = (°F - 32) / 1,8.
 */

using System;

namespace L03E13
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;

            Console.WriteLine("Tabela de Conversão");
            Console.WriteLine();

            for (f = 50; f <= 70; f++)
            {
                c = (f - 32) / 1.8;

                Console.WriteLine(f + " ºF " + " = " + c.ToString("F") + " ºC ");
            }        
                     

        }
    }
}
