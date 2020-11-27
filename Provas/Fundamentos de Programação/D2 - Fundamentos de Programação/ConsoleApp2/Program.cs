//Resultado desta questâo: 5 5 6 5 5

using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            int num = 5;
            Console.Write(num + "  ");
            metodo(ref num);
            Console.Write( num + "  ");
        }

        static void metodo (ref int num)
        {
            Console.Write(num + "  ");
            Console.Write(num + 1 + "  ");
            Console.Write(num + "  ");
        }
    }
}
