using System;
using System.Globalization;

namespace L09E04_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[3, 3];
            Console.WriteLine("Digite os vetores c/ espaços: EX) 1 2 3");

            preencheMat(mat);
            imprimeMatNeg(mat);
            imprimeMatPar(mat);
            somaMat(mat);
            mediaMat(mat);
        }

        static void preencheMat(int[,] mat)
        {
            for (int i = 0; i < 3; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < 3; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }
            Console.WriteLine();
        }

        static void imprimeMatPar(int[,] mat)
        {
            Console.WriteLine("\nElementos Pares: ");
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                    if (mat[i, j] % 2 == 0 && mat[i, j] >= 0)
                    {
                        Console.Write("{0,3}", mat[i, j]);
                    }
            }
            Console.WriteLine();
        }

        static void imprimeMatNeg(int[,] mat)
        {
            Console.WriteLine("\nElementos Negativos: ");
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                    if (mat[i, j] < 0)
                    {
                        Console.Write("{0,3}", mat[i, j]);
                    }
            }
            Console.WriteLine();
        }

        static void somaMat(int[,] mat)
        {
            int soma = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    soma += mat[i, j];
                }                
            }
            Console.WriteLine("Soma: " + soma);
            Console.WriteLine();
        }

        static void mediaMat(int[,] mat)
        {
            int soma = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    soma += mat[i, j];
                }                
            }
            Console.WriteLine($"A média é {soma / 3 * 3}");
        }
    }
}
