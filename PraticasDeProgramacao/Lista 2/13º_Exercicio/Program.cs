/* Faça um programa que receba o salário de um funcionário e, usando a tabela a seguir, 
calcule e mostre o novo salário.
Até R$ 300,00                              50%
Entre R$ 300,00 e R$ 500,00                40%
Entre R$ 500,00 e R$ 700,00                30%
Entre R$ 700,00 e R$ 800,00                20%
Entre R$ 800,00 e R$ 1.000,00              10%
Acima de R$ 1.000,00                        5%
 
 */

using System;

namespace _13º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, aumento;

            Console.WriteLine("Digite o salário: ");
            salario = double.Parse(Console.ReadLine());

            if (salario <= 300)
            {
                aumento = (salario * 0.5) + salario;
                Console.WriteLine("Novo salário: " + aumento.ToString("C2"));
            }
            if (salario > 300 && salario <= 500)
            {
                aumento = (salario * 0.4) + salario;
                Console.WriteLine("Novo salário: " + aumento.ToString("C2"));
            }
            if (salario > 500 && salario <= 700)
            {
                aumento = (salario * 0.3) + salario;
                Console.WriteLine("Novo salário: " + aumento.ToString("C2"));
            }
            if (salario > 700 && salario <= 800)
            {
                aumento = (salario * 0.2) + salario;
                Console.WriteLine("Novo salário: " + aumento.ToString("C2"));
            }
            if (salario > 800 && salario <= 1000)
            {
                aumento = (salario * 0.1) + salario;
                Console.WriteLine("Novo salário: " + aumento.ToString("C2"));
            }
            if (salario > 1000)
            {
                aumento = (salario * 0.05) + salario;
                Console.WriteLine("Novo salário: " + aumento.ToString("C2"));
            }


        }
    }
}
