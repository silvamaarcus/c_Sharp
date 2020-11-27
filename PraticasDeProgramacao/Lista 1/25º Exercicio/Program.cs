using System;

namespace _25º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Conversão de Tempo");

			int hora, minuto, conversao, resultado2, resultado3;

			Console.WriteLine("Digite as horas: ");
			hora = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Digite os minutos");
			minuto = Convert.ToInt32(Console.ReadLine());

			conversao = (hora * 60);
			Console.WriteLine("A hora em minutos: " + conversao);

			resultado2 = conversao + minuto;
			Console.WriteLine("O horário desejado em minutos: " + resultado2);

			resultado3 = (resultado2 * 60);
			Console.WriteLine("O horário desejado em segundos: " + resultado3);

			Console.ReadLine();
		}
    }
}
