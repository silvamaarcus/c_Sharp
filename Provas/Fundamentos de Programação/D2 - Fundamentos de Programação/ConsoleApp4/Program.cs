//Resultado da questão: 10 10 10 11 10

using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            int num = 10;
            Console.WriteLine(num + "  ");
            metodo(num);
            Console.WriteLine(num + "  ");
        }

        static void metodo (int num)
        {
            Console.WriteLine(num + "  ");
            Console.WriteLine(num++ + "  ");
            Console.WriteLine(num + "  ");
        }
    }
}
