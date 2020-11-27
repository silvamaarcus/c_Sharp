using System;

namespace _11º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double a, b, c, x, bhasX1, bhasX2;

            Console.WriteLine("Equações de 2º Grau");
            Console.WriteLine("|1| Fórmula de Bhaskara");
            Console.Write("Digite 1 para começar -> ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Calculando o delta da equação completa: ");
                    Console.WriteLine("Digite o valor de 'a': ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor de 'b': ");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor de 'c': ");
                    c = double.Parse(Console.ReadLine());
                    x = ((Math.Pow(b, 2) - (4 * a * c)));
                    Console.WriteLine("x = " + x);

                    Console.WriteLine("Aplicando Bhaskara");              
                    bhasX1 = (((-b) + (Math.Sqrt(x))) / (2 * a));
                    bhasX2 = (((-b) - (Math.Sqrt(x))) / (2 * a));
                    Console.WriteLine("x' = " + bhasX1);
                    Console.WriteLine("x'' = " + bhasX2);

                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            Console.ReadKey();
        }
    }
}