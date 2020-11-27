using System;

namespace _7º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificação de par ou ímpar.");

            int numero;

            Console.WriteLine("Digite o número desejado: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é PAR!!");
            }
            else
            {
                Console.WriteLine("O número é ÍMPAR!!");
            }

        }
    }
}
