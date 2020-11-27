using System;

namespace L03E03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, soma=0, contador=0;

            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            while (num >= 0) //Looping infinito até digitar um número negativo;
            {
                if (num % 2 == 1) //Validando números ímpares;
                {
                    soma += num; //Somatório de números ímapres;
                    contador++; //Contagem de números ímpares;
                }
                Console.WriteLine("Digite um número: ");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Média dos números ímpares: " + (soma/contador));            

        }
    }
}
