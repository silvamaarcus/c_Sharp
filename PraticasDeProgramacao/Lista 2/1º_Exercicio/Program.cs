using System;

namespace _1º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Média Ponderada");

            double lab, prova, provaFinal, result;
            
            Console.WriteLine("Digite a nota de laboratório: ");
            lab = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da prova semestral: ");
            prova = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do exame final: ");
            provaFinal = double.Parse(Console.ReadLine());

            result = (((lab * 2) + (prova * 3) + (provaFinal * 5)) / 10);
            Console.WriteLine("Média Ponderada: " + result);

            if (result >= 8)
            {
                Console.WriteLine("Conceito: A");
            }
            else if (result >=7)
            {
                Console.WriteLine("Conceito: B");
            }
            else if (result >= 6)
            {
                Console.WriteLine("Conceito: C");
            }
            else if (result >= 5)
            {
                Console.WriteLine("Conceito: D");
            }
            else
            {
                Console.WriteLine("Conceito: E");
            }
        }
    }
}
