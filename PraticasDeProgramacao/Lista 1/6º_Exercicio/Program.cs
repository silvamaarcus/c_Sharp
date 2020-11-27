using System;

namespace _6º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Área do triângulo");

			double b, h, area;

			Console.WriteLine("Digite a base: ");
			b = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Digite a altura: ");
			h = Convert.ToDouble(Console.ReadLine());

			area = ((b * h) / 2);
			Console.WriteLine("Área do triângulo: " + area.ToString("F2"));
		}
    }
}
