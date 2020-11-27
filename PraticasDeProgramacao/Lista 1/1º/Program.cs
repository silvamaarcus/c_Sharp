using System;

namespace _1º
{
    class Program
    {
        static void Main(string[] args)
        {
			int numero1, numero2, numero3, numero4, soma;

			Console.WriteLine("Programa de soma para 4 números");

			Console.WriteLine("Digite o primeiro número");
			numero1 = Convert.ToInt32(Console.ReadLine());
			

			Console.WriteLine("Digite o segundo número");
			numero2 = Convert.ToInt32(Console.ReadLine());
			

			Console.WriteLine("Digite o terceiro número");
			numero3 = Convert.ToInt32(Console.ReadLine());
			

			Console.WriteLine("Digite o quarto número");
			numero4 = Convert.ToInt32(Console.ReadLine());
			

			soma = numero1 + numero2 + numero3 + numero4;

			Console.WriteLine("A soma dos números é = " + soma);
			
		}
    }
}
