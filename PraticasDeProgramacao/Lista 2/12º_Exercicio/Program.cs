using System;

namespace _12º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;

            Console.WriteLine("Digite valor de X: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor de Y: ");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor de Z: ");
            z = double.Parse(Console.ReadLine());

            if (x == y && y == z)
            {
                Console.WriteLine("É um triângulo Equilátero.");
            }
            else if (x == y && y != z)
            {
                Console.WriteLine("É um triângulo Isósceles.");
            }
            else
            {
                Console.WriteLine("É um triângulo Escaleno.");
            }
        }
    }
}
