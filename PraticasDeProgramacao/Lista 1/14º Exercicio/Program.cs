using System;

namespace _14º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Número Real");

			double numeroReal, inteiro, decimais, arredo;

			Console.WriteLine("Digite um número real(com uso de ',' para seperar as casas decimais: ");
			numeroReal = Convert.ToDouble(Console.ReadLine());

			inteiro = Convert.ToInt32(Math.Floor(numeroReal));

			decimais = numeroReal - inteiro;

			arredo = Math.Round(numeroReal);

			Console.WriteLine("A parte inteira: " + inteiro);
			Console.WriteLine("A parte fracionária: " + decimais.ToString("F2"));
			Console.WriteLine("O arredondamento: " + arredo.ToString("F2"));

		}
	}
}
