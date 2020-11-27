using System;

namespace _20º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de Raio");

            double raio, c, a, v, r, r2;

            Console.WriteLine("Digite o raio: ");
            raio = Convert.ToDouble(Console.ReadLine());            

            c = 2 * (Math.PI) * raio;

            r = Math.Pow(raio, 2);
            r2 = Math.Pow(raio, 3);

            a = 4 * Math.PI * r;

            v = (4  * Math.PI * r2)/3;

            Console.WriteLine("O comprimento da esfera: " + c.ToString("F3") + "m");
            Console.WriteLine("A área da esfera: " + a.ToString("F3") + "m²");
            Console.WriteLine("O volume da esfera: " + v.ToString("F1") + "m³");

            Console.ReadLine();

        }
    }
}
