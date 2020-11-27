using System;

namespace L05E04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o limite inteiro N: ");
            int n = int.Parse(Console.ReadLine());

            double produtorio1 = ProdutorioUm(n);
            double produtorio2 = ProdutorioDois(n);
            double produtorio3 = ProdutorioTres(n);

            Console.WriteLine($"A) {produtorio1}");
            Console.WriteLine($"B) {produtorio2}");
            Console.WriteLine($"C) {produtorio3}");
        }

        static double ProdutorioUm(int limite)
        {
            double x = 1;
            for (int i = 1; i <= limite; i++)
            {
                x *= (i / (Math.Pow(i, 2)));
            }
            return x;
        }

        static double ProdutorioDois(int limite)
        {
            double x = 1;
            for (int i = 0; i <= limite; i++)
            {
                x *= Math.Exp(Math.Log(i + 12));
            }
            return x;
        }

        static double ProdutorioTres(int limite)
        {
            double x = 1;
            for (int i = 3; i <= limite; i++)
            {
                x *= Math.Pow(Math.Cos(i/3), 4);
            }
            return x;
        }
    }
}
