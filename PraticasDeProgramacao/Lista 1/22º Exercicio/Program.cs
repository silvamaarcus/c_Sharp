using System;

namespace _22º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Poligno Convexo");

            int lados, nd;

            Console.WriteLine("Digite o número de lados do poligno: ");
            lados = Convert.ToInt32(Console.ReadLine());

            nd = (lados * (lados - 2)) / 2;

            Console.WriteLine("Número de diagonais: " + nd.ToString());
            Console.ReadLine();

        }
    }
}
