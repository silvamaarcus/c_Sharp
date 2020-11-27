using System;

namespace L03E01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, resultado;

            Console.WriteLine("Digite o valor de n: ");
            n = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Tabuada até n:");
            for (int x = 0; x <= n; x++)
            {
                resultado = n * x;
                Console.WriteLine(x + " * " + n + " = " + resultado);
            }

            Console.WriteLine("Tabuada até 10:");
            for (int x = 0; x <= 10; x++)
            {
                resultado = n * x;
                Console.WriteLine(x + " * " + n + " = " + resultado);
            }

            Console.ReadLine();
        }
    }
}
