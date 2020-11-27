using System;

namespace L05E02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = Modulo(num1, num2);
            if (num2 != 0)
                Console.WriteLine($"mod ({num1}, {num2}): {result}");
            else
                Console.WriteLine("O segundo número não pode ser igual a 0!");

            Console.ReadKey();
        }

        static int Modulo(int n1, int n2)
        {
            int result = 0;

            if (n2 != 0)
            {
                result = n1 % n2;
            }
            return result;
        }
    }
}
