using System;

namespace _4º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que receba três números e mostre o menor.");

            int num1, num2, num3;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            num3 = int.Parse(Console.ReadLine());

            if ((num1 < num2) && (num1 < num3))
                Console.WriteLine("O menor número é: " + num1);
            if ((num2 < num3) && (num2 < num1))
                Console.WriteLine("O menor número é: " + num2);
            if ((num3 < num1) && (num3 < num2))
                Console.WriteLine("O menor número é: " + num3);
        }
    }
}
