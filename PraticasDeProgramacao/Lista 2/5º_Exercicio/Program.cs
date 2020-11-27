using System;

namespace _5º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que receba três números e mostre-os em ordem crescente.");

            int num1, num2, num3;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            num3 = int.Parse(Console.ReadLine());

            if ((num1 < num2) && (num2 < num3))
                Console.WriteLine("Ordem crescente: " + num1 + " " + num2 + " " + num3);
            if ((num2 < num3) && (num3 < num1))
                Console.WriteLine("Ordem crescente: " + num2 + " " + num3 + " " + num1);
            if ((num3 < num1) && (num1 < num2))
                Console.WriteLine("Ordem crescente: " + num3 + " " + num1 + " " + num2);
        }
    }
}
