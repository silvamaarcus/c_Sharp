using System;

namespace _6º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador, contador2 = 0;
            int[] vetor = new int[4];

            for (contador = 0; contador < 4; contador++)
            {
                Console.Write("Informe o numero: ");
                vetor[contador] = int.Parse(Console.ReadLine());
            }

            Array.Sort(vetor);

            for (contador = 3; contador >= 0; contador--)
            {
                Console.Write("\nO " + (contador + 1) + "º número é: ");
                Console.Write(vetor[contador2]);
                contador2++;
            }
            Console.ReadKey();
        }
    }
}
