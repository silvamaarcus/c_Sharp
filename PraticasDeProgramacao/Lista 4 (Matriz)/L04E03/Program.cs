using System;

namespace L04E03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            Console.WriteLine("Digite valores do Vetor:");
            vet[0] = int.Parse(Console.ReadLine());
            vet[1] = int.Parse(Console.ReadLine());
            vet[2] = int.Parse(Console.ReadLine());
            vet[3] = int.Parse(Console.ReadLine());
            vet[4] = int.Parse(Console.ReadLine());
            vet[5] = int.Parse(Console.ReadLine());
            vet[6] = int.Parse(Console.ReadLine());
            vet[7] = int.Parse(Console.ReadLine());
            vet[8] = int.Parse(Console.ReadLine());
            vet[9] = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                int contador = 0;
                if (vet[i] >= 50)
                {
                    if (vet[i] >= 50)
                    {
                        contador += vet[i];
                        Console.WriteLine(contador + " ");
                    }
                }                    
                else
                    Console.WriteLine("Nenhum número nessa condição");
            }

        }
    }
}
