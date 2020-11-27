/* 
 Uma agência bancária possui dois tipos de investimentos, conforme o quadro a seguir. 
Faça um programa que receba o tipo de investimento e seu valor, calcule e mostre o valor 
corrigido após um mês de investimento, de acordo com o tipo de investimento.

TIPO              DESCRIÇÃO          REDIMENTO MENSAL
1                 Poupança                 3%
2            Fundos de renda fixa          4%
 
 */

using System;

namespace _14º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double poupanca, rendaFixa, invest;
            int opcao;
            
            Console.WriteLine("| ESCOLHA O TIPO DE INVESTIMENTO |");
            Console.WriteLine();
            Console.WriteLine("1. POUPANÇA");
            Console.WriteLine("2. RENDA FIXA");
            Console.Write("Digite a opção desejada! \n");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o valor de investimento: ");
                    invest = double.Parse(Console.ReadLine());
                    poupanca = (invest * 0.03) + invest;
                    Console.WriteLine("Valor corrigido após 30 dias: " + poupanca.ToString("C2"));
                    break;

                case 2:
                    Console.WriteLine("Digite o valor de investimento: ");
                    invest = double.Parse(Console.ReadLine());
                    rendaFixa = (invest * 0.04) + invest;
                    Console.WriteLine("Valor corrigido após 30 dias: " + rendaFixa.ToString("C2"));
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;

            }

        }
    }
}
