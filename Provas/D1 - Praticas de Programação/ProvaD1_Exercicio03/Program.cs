/* Faça um algoritmo que leia um número maior ou igual a 10, deve-se validar a entrada, e informe
quantos divisores ele possui entre 1 e 9. */

using System;

namespace ProvaD1_Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, numero;

            Console.WriteLine("Digite um número maior ou igual a 10: ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 10)
            {
                for (x = 1; x <= 9; x++)
                {
                    if (numero % x == 0)
                    {
                        Console.WriteLine(x);
                    }
                }
            }
            else
            {
                Console.WriteLine("O número informado é menor que 10!");
            }

            Console.ReadKey();
        }
    }
}
