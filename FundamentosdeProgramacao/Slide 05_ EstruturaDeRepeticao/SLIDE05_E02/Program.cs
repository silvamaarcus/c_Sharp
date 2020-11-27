using System;
using System.Linq;
using System.Reflection.Metadata;

namespace SLIDE05_E02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, contador=0, soma=0, menor=0, maior=0;           
            string opcao;

            do
            {
                Console.WriteLine("Digite um número: ");
                num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    contador++;
                    soma += num;
                }
                if (contador == 1)
                    menor = maior = num;
                else
                    if (num < menor)
                    menor = num;
                else
                    if (num > maior)
                    maior = num;

                Console.WriteLine("Deseja informar outro? (sim/não) ");
                opcao = Console.ReadLine().ToLower();
            } while ((opcao == "sim") || (opcao == "s"));

            Console.WriteLine("Menor número: " + menor);
            Console.WriteLine("Maior número: " + maior);

            if (contador > 0)
            {
                Console.WriteLine("Média dos números: " + (soma/contador));
            }

            Console.ReadKey();
        }
    }
}

