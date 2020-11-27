using System;

namespace L02E03
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("Digite a abcissa (x): ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a ordenada (y): ");
            y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("1º Quadrante");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("2º Quadrante");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("3º Quadrante");
            }
            else
            {
                Console.WriteLine("4º Quadrante");
            }
        }
    }
}
