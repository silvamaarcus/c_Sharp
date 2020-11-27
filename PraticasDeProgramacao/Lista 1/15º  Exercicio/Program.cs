using System;

namespace _15º__Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Hora em Minutos");

			int hora, minuto, conversao, resultado;

			Console.WriteLine("Digite as horas: ");
			hora = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Digite os minutos");
			minuto = Convert.ToInt32(Console.ReadLine());

			conversao = (hora * 60);

			resultado = conversao + minuto;

			Console.WriteLine("O horário desejado em minutos: " + resultado);
		}
    }
}
