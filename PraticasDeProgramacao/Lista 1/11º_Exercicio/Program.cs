using System;

namespace _11º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Carro e Distribuidor");

			double precoFabrica, lucro, imposto, percenLucro, percenImposto, precoFinal;

			Console.WriteLine("Digite o preço de fábrica: ");
			precoFabrica = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Digite a margem de lucro: ");
			lucro = Convert.ToDouble(Console.ReadLine()) / 100;
			percenLucro = precoFabrica * lucro;

			Console.WriteLine("Digite o imposto: ");
			imposto = Convert.ToDouble(Console.ReadLine()) / 100;
			percenImposto = precoFabrica * imposto;

			precoFinal = precoFabrica + percenLucro + percenImposto;

			Console.WriteLine("Lucro: " + percenLucro.ToString("C2"));
			Console.WriteLine("Impostos: " + percenImposto.ToString("C2"));
			Console.WriteLine("Preço do veículo: " + precoFinal.ToString("C2"));

		}
	}
}
