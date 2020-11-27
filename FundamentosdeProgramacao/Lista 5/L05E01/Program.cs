using System;

namespace L05E01
{
    class Program
    {
        static void Main(string[] args)
        {
            NumerosInvertidos numero = new NumerosInvertidos();

            Console.Write("Informe uma sequência de números: ");
            numero.Numeros = Console.ReadLine();

            string invertidos = numero.Inversao();
            Console.Write("Invertidos: " + invertidos);
        }
    }
}
