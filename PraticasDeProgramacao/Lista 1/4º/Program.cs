using System;

namespace _4º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Programa Salário");

			double salario, percentual, aumento, salarioFinal;

			Console.WriteLine("Salário atual do funcionário: ");
			salario = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Percentual de aumento: ");
			percentual = Convert.ToDouble(Console.ReadLine());

			aumento = (salario * (percentual / 100));

			salarioFinal = (aumento + salario);

			Console.WriteLine("Salário atual: R$ " + salario.ToString("F2"));
			Console.WriteLine("Aumento de: R$ " + aumento.ToString("F2"));
			Console.WriteLine("Novo salário: R$ " + salarioFinal.ToString("F2"));
		}
    }
}
