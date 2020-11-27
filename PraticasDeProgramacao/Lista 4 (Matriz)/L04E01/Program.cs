/*
 Faça um programa que recebe cinco notas de um aluno, armazene-as em um 
vetor e calcule a média.
*/

using System;

namespace L04E01
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vet = new double[5];
            double contador = 0;

            Console.WriteLine("Digite as notas:");
            vet[0] = double.Parse(Console.ReadLine());
            vet[1] = double.Parse(Console.ReadLine());
            vet[2] = double.Parse(Console.ReadLine());
            vet[3] = double.Parse(Console.ReadLine());
            vet[4] = double.Parse(Console.ReadLine());
            

            for (int i = 0; i < 5; i++)
            {
                contador += vet[i];
            }
            double media = contador / 5;
            Console.WriteLine(media.ToString("F2"));
        }
    }
}
