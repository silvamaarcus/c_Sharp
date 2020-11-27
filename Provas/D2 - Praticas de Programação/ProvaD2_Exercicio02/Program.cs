using System;

namespace ProvaD2_Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o primeiro número inteiro: (Tamanho do 1º vetor) ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Insira o segundo número inteiro: (Tamanho do 2º vetor) ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if ((numero1 > 0 && numero1 < 10) && (numero2 > 0 && numero2 < 10))
            {
                int[] vetor1 = new int[numero1];

                Random numAleatorio = new Random();

                for (int i = 0; i < numero1; i++)
                {
                    vetor1[i] = numAleatorio.Next(0, 10);
                    Console.WriteLine($"{vetor1[i]} ");
                }

                Console.WriteLine();

                int[] vetor2 = new int[numero2];

                Console.WriteLine();

                for (int i = 0; i < numero2; i++)
                {
                    vetor2[i] = numAleatorio.Next(0, 10);
                    Console.WriteLine($"{vetor2[i]} ");
                }

                Console.WriteLine();

                if (vetor1 == vetor2 && numero1 == numero2)
                    Console.WriteLine("Vetores iguais");
                else
                {
                    Console.WriteLine("Vetores diferentes");
                    Console.WriteLine();

                    Console.WriteLine("O Vetor 2 dá última posição até a primeira posição:");
                    for (int i = vetor2.Length - 1; i > -1; i--)
                        Console.Write(vetor2[i] + " ");
                }
            }
            else
                Console.WriteLine("Execute o programa novamente!!!");

            Console.ReadKey();
        }
    }
}
