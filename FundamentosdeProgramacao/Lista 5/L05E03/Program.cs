using System;

namespace L05E03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o limite inteiro N: ");
            int n = int.Parse(Console.ReadLine());

            double somatorio1 = SomatorioOne(n);
            double somatorio2 = SomatorioTwo(n);
            double somatorio3 = SomatorioThree(n);

            Console.WriteLine($"A) {somatorio1}");
            Console.WriteLine($"B) {somatorio2}");
            Console.WriteLine($"C) {somatorio3}");
        }

        static double SomatorioOne(int limite)
        {
            double x = 0;
            for (int i = 0; i <= limite; i++)
            {
                x += Math.Pow(i, 0.5);
            }
            return x;
        }

        static double SomatorioTwo(int limite)
        {
            double x = 0;

            for (int i = 0; i <= limite; i++)
            {
                x += Math.Sin(i + 5);                               
            }
            return x;
        }

        static double SomatorioThree(int limite)
        {
            double x = 0;

            for (int i = 0; i <= limite; i++)
            {
                x += Math.Log10 (Math.Pow(2, i));
            }
            return x;
        }
    }
}
