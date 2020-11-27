using System;

namespace _13º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Programa de Ângulo");

			double angulo, cateto, hipotenusa, resultado, conversao;

			Console.WriteLine("Digite o ângulo: ");
			angulo = Convert.ToDouble(Console.ReadLine());

			conversao = angulo * (Math.PI / 180);

			hipotenusa = Math.Cos(conversao);

			Console.WriteLine("Digite a altura da parede em metros: ");
			cateto = Convert.ToDouble(Console.ReadLine());

			resultado = cateto / hipotenusa;
			Console.WriteLine("Comprimento da escada: " + resultado.ToString("F2")+ "m");

			Console.ReadLine();
		}
    }
}
