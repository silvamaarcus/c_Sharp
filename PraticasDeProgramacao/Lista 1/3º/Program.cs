using System;

namespace _3º
{
    class Program
    {
        static void Main(string[] args)
        {
			double nota1, nota2, nota3, peso1, peso2, peso3, mediaPonderada; //double é igual 'float' -> casa decimais

			Console.WriteLine("Programa de média ponderada");

			Console.Write("Digite a primeira nota: ");
			nota1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Digite a segunda nota: ");
			nota2 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Digite a terceira nota: ");
			nota3 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Digite o peso1: ");
			peso1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Digite o peso2: ");
			peso2 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Digite o peso3: ");
			peso3 = Convert.ToDouble(Console.ReadLine());

			mediaPonderada = ((nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3) / (peso1 + peso2 + peso3));
			Console.WriteLine("Média ponderada: " + mediaPonderada.ToString("F2"));
		}
    }
}
