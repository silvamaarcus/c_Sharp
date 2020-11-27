using System;

namespace _2º
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de Média");

            double nota1, nota2, nota3, media;

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            media = ((nota1 + nota2 + nota3) / 3);

            Console.WriteLine("A média é: " + media.ToString("F2"));
        }
    }
}
