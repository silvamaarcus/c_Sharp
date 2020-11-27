using System;

namespace L06E01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Imforme o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];

            vet = PreencherVetor(vet);
            Imprimir(vet);
            Console.Write("Menor: " + MenorValor(vet));
            Console.WriteLine();
            Console.Write("Maior: " + MaiorValor(vet));
        }
        static int[] PreencherVetor(int[] vet)
        {
            Random numAleatorio = new Random();

            for (int i = 0; i < vet.Length; i++)
                vet[i] = numAleatorio.Next(0, 100);
            return vet;
        }

        static void Imprimir(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
                Console.WriteLine(vet[i] + " ");
        }

        static int MenorValor(int[] vet)
        {
            int menor = vet[0];

            for (int i = 1; i < vet.Length; i++)
                if (vet[i] < menor)
                {
                    menor = vet[1];
                }
            return menor;
        }

        static int MaiorValor(int[] vet)
        {
            int maior = vet[0];

            for (int i = 1; i < vet.Length; i++)
                if (vet[i] > maior)
                {
                    maior = vet[1];
                }
            return maior;
        }





    }
}
