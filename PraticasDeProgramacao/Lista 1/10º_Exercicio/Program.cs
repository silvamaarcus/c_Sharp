using System;

namespace _10º_Exercicio
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Programa de idade");

			int anoNas, anoAtual, anoFuturo;

			Console.WriteLine("Digite o ano de nascimento: ");
			anoNas = Convert.ToInt32(Console.ReadLine());

			anoAtual = 2020 - anoNas;
			Console.WriteLine("Sua idade: " + anoAtual);

			anoFuturo = 2050 - anoNas;
			Console.WriteLine("Sua idade em 2050: " + anoFuturo);
		}
	}
}