using System;

namespace _8º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Caluculo 2");

			double numero1, numero2, resultado;

			Console.WriteLine("Digite o número base: ");
			numero1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Digite o número expoente: ");
			numero2 = Convert.ToDouble(Console.ReadLine());

			resultado = Math.Pow(numero1, numero2);
			Console.WriteLine("Raiz cúbica do número: " + resultado.ToString("F2"));
		}
    }
}
