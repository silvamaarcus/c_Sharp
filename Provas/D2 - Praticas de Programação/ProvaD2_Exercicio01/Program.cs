using System;

namespace ProvaD2_Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];

            Random numAleatorio = new Random();

            for (int i = 0; i < 10; i++)
            {
                vet[i] = numAleatorio.Next(0, 10);
                Console.WriteLine($"{vet[i]} ");
            }

            Console.WriteLine();

            int soma = 0;
            int multi = 1;
            int contador = 0;

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    soma += vet[i];                    
                }
                else 
                {
                    multi *= vet[i];                    
                }                
            }

            for (int i = 0; i < 10; i++)
            {                
                if (i % 5 == 0)
                contador++;
            }

            Console.WriteLine("Soma dos números pares: " + soma);
            Console.WriteLine("Multiplicação dos números ímpares: " + multi);
            Console.WriteLine("Posições armazenam números inteiros divisíveis por 5: " + contador);

            Console.WriteLine();

            int[] vet2 = new int[10];

            Console.WriteLine("Vetor 2:");

            for (int i = 0; i < vet2.Length; i++)
            {
                vet2[i] = vet[i] * i;
                Console.Write(vet2[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
