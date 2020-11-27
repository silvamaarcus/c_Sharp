/* 
Um funcionário de uma empresa recebe, anualmente, aumento salarial. Sabe-se 
que:
• Esse funcionário foi contratado em 2005, com salário inicial de R$ 1.000,00.
• Em 2006, ele recebeu aumento de 1,5% sobre seu salário inicial.
• A partir de 2007 (inclusive), os aumentos salariais sempre corresponderam ao 
dobro do percentual do ano anterior.
Faça um programa que determine o salário atual desse funcionário.

*/

using System;

namespace Fundamentos_L03E01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, anoAtual;
            double salario2006;

            salario2006 = (1000 * 0.015) + 1000;

            Console.WriteLine("Digite o ano atual: ");
            anoAtual = int.Parse(Console.ReadLine());
            
            for (i = 2007; i <= anoAtual; i++)
            {
                salario2006 = (salario2006 * 0.03) + salario2006;
            }

            Console.WriteLine("Salário atual: " + salario2006.ToString("C2"));
        }
    }
}
