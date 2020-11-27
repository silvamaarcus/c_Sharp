using System;

namespace L03E02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, inferior, superior;

            Console.WriteLine("Digite o limite inferior natural: ");
            inferior = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o limite superior natural: ");
            superior = int.Parse(Console.ReadLine());

            Console.WriteLine("Pares:");
            for (x = inferior; x <= superior; x++)
                if (x % 2 == 0)
                    Console.WriteLine(x);                                      
        }
    }
}
