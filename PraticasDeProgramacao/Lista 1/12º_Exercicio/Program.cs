using System;

namespace _12º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Degrau de uma escada");

			double hDegrau, hEscada, resultado;

			Console.WriteLine("Digite a altura (cm) do degrau: ");
			hDegrau = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Digite a altura (cm) desejada: ");
			hEscada = Convert.ToDouble(Console.ReadLine());

			resultado = hEscada / hDegrau;
			Console.WriteLine("Serão necessários: " + resultado.ToString("F1") + " Degraus");

		}
	}
}
