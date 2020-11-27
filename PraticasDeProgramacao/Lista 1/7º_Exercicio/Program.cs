using System;

namespace _7º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Calculos 1");

			double numero, quadrado, cubico, raizQuadrada, raizCubica, potencia;

			Console.WriteLine("Digite um número maior do que 0: ");
			numero = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Número: " + numero.ToString("F2"));

			quadrado = Math.Pow(numero, 2);
			Console.WriteLine("Número ao quadrado: " + quadrado.ToString("F2"));

			cubico = Math.Pow(numero, 3);
			Console.WriteLine("Número ao cubo: " + cubico.ToString("F2"));

			raizQuadrada = Math.Sqrt(numero);
			Console.WriteLine("Raiz quadrada do número: " + raizQuadrada.ToString("F2"));

			potencia = 1.0 / 3.0;
			raizCubica = Math.Pow(numero, potencia);
			Console.WriteLine("Raiz cúbica do número: " + raizCubica.ToString("F2"));

		}
	}
}
