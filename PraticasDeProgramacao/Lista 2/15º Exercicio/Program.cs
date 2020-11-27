/*
 Uma empresa decide aplicar descontos nos seus preços usando a tabela a seguir. Faça um 
programa que receba o preço atual de um produto e seu código, calcule e mostre o valor do 
desconto e o novo preço.

- PREÇO ATUAL -                       - % DE DESCONTO -
Até R$ 300,00                           Sem desconto
Entre R$ 30,00 e R$ 100,00                  10%
Acima de R$ 100,00                          15%

 */
using System;

namespace _15º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco1, preco2, produto;
            string cod;

            Console.WriteLine("Digite o código do produto: ");
            cod = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite o preço do produto: ");
            produto = double.Parse(Console.ReadLine());
            
            if (produto > 300)
            {
                Console.WriteLine("Valor do produto " + cod + " : " + produto.ToString("C2"));
            }
            if (produto > 30 && produto <=100)
            {
                preco1 = produto - (produto * 0.1);
                Console.WriteLine("Valor do produto " + cod + " : " + preco1.ToString("C2"));
            }
            if (produto > 100 && produto < 300)
            {
                preco2 = produto - (produto * 0.15);
                Console.WriteLine("Valor do produto " + cod + " : " + preco2.ToString("C2"));
            }

        }
    }
}
