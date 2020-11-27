/* 
Faça um programa leia um valor N inteiro e positivo. Calcule e mostre o fatorial 
de N.
 */

using System;

namespace Fundamentos_L03E02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, fatorial = 1;

            Console.WriteLine("Digite valor de 'n': ");
            n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                for (i = 1; i <= n; i++)
                {
                    fatorial *= i;
                    Console.WriteLine(n + "!" + " = " + fatorial);
                }
            }

            else if (n == 0)
            {
                Console.WriteLine(n + "!" + " = 1");
            }

            else
            {
                Console.WriteLine("Número inválido!!!");
            }
            
           

        }
    }
}
