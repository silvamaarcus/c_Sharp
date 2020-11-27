using System;

namespace _9º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Programa de conversão");

			double pe, jarda, milha, polegada;

			Console.WriteLine("Digite o comprimento em Pés: ");
			pe = Convert.ToDouble(Console.ReadLine());

			polegada = pe * 12;
			Console.WriteLine("O comprimento em Polegadass: " + polegada.ToString());

			jarda = pe / 3;
			Console.WriteLine("O comprimento em Jardas: " + jarda.ToString());

			milha = pe / 5280;
			Console.WriteLine("O comprimento em Milhas: " + milha.ToString());

		}
	}
}
