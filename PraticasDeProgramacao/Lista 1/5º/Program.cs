using System;

namespace _5º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Salário base de um funcionário");

			double salarioBase, grati, imposto, salario1, salario2, salarioFinal;

			Console.WriteLine("Digite o salário base: ");
			salarioBase = Convert.ToDouble(Console.ReadLine());

			grati = 0.05;
			imposto = 0.07;

			salario1 = (salarioBase * grati);
			salario2 = (salarioBase * imposto);

			salarioFinal = ((salarioBase + salario1) - salario2);
			Console.WriteLine("Salário a receber: " + salarioFinal.ToString("F2"));
		}
    }
}
