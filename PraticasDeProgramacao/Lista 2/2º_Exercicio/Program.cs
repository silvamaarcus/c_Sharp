using System;

namespace _2º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Média de 3 Notas");

            double nota1, nota2, nota3, media, final;

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());

            media = ((nota1 + nota2 + nota3) / 3);
            Console.WriteLine("Média: " + media.ToString("F2"));

            if (media>=7)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Aprovado");
                Console.ResetColor();
            }
            else if (media>=3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Exame");
                Console.ResetColor();
                final = 10 - media;
                Console.WriteLine("Pontuação necessária para aprovação: " + final.ToString("F2"));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Reprovado");
                Console.ResetColor();
            }
        }
    }
}
