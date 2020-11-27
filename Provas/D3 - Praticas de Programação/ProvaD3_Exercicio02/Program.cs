using System;
using System.Globalization;

namespace ProvaD3_Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um valor POSITIVO de N: ");
            int n = int.Parse(Console.ReadLine());

            while (n < 0)
            {
                Console.WriteLine("Entrada inválida!!");
                Console.Write("Informe um valor POSITIVO de N: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            int[,] mat = new int[n, n];

            Console.WriteLine("Digite os vetores na mesma linha c/ espaços: EX) 1 2 3");

            //Leitura da matriz;
            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine();

            int soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += mat[i, i];
            }
            Console.WriteLine("Somatório da diagonal principal: " + soma);

            Console.WriteLine();

            int temp = 0;

            Console.WriteLine("Possibilidades de somátorio EM LINHAS:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    temp += mat[i, j];
                }

                if (temp < soma)
                    Console.WriteLine($"Linha [{i}] da matriz é {temp} (MENOR)");
                else
                    Console.WriteLine($"Linha [{i}] da matriz é {temp} (MAIOR)");

                temp = 0;
            }

            Console.WriteLine();

            Console.WriteLine("Possibilidades de somátorio EM COLUNAS:");
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    temp += mat[i, j];
                }

                if (temp < soma)
                    Console.WriteLine($"Coluna [{j}] da matriz é {temp} (MENOR)");
                else
                    Console.WriteLine($"Coluna [{j}] da matriz é {temp} (MAIOR)");

                temp = 0;
            }

            Console.ReadKey();
        }
    }
}

