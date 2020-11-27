//Resultado da questâo: 82,5

using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            double nota = 75;
            altera(in nota, out nota);
            Console.WriteLine(nota);
        }

        static void altera (in double n1, out double n2)
        {
            n2 = n1 * 1.1;
        }
    }
}
