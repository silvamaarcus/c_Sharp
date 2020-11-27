using System;

namespace ProvaD1_Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Custo do Espetáculo");

			double espetaculo, ingresso, resultado, lucro30;

			Console.WriteLine("Digite o custo do espetáculo: ");
			espetaculo = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Digite o preço do ingresso: ");
			ingresso = Convert.ToDouble(Console.ReadLine());

			resultado = espetaculo / ingresso;

			lucro30 = (espetaculo * 1.3) / ingresso;

			Console.WriteLine();

			Console.WriteLine("Para suprir o custo, serão necessários que vendam " + resultado + " ingressos.");
			Console.WriteLine("Para se ter lucro de 30%, serão necessários que vendam " + lucro30 + " ingressos.");

			Console.ReadKey();
		}
    }
}