using System;

namespace L04E02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet1 = new int[5];
            Console.WriteLine("Digite valores do Vetor 1:");
            vet1[0] = int.Parse(Console.ReadLine());
            vet1[1] = int.Parse(Console.ReadLine());
            vet1[2] = int.Parse(Console.ReadLine());
            vet1[3] = int.Parse(Console.ReadLine());
            vet1[4] = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[] vet2 = new int[5];
            Console.WriteLine("Digite valores do Vetor 2:");
            vet2[0] = int.Parse(Console.ReadLine());
            vet2[1] = int.Parse(Console.ReadLine());
            vet2[2] = int.Parse(Console.ReadLine());
            vet2[3] = int.Parse(Console.ReadLine());
            vet2[4] = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[] vetResul = new int[10];
            int j = 0;            

            for (int i = 0; i < 5; i++)
            {
                vetResul[j] = vet1[i];
                j += 1;
                vetResul[j] = vet2[i];
                j += 1;
            }

            Console.WriteLine("Vetor Resultante:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(vetResul[i] + " ");
            }

            Console.ReadKey();

        }
    }
}
