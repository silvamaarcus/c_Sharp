// Resultado desta questão: 40

using System;

namespace ConsoleApp1
{
    struct Estrutura
    {
        public int x;
        public int y;
    }

    class Program
    {
        static void Main()
        {
            Estrutura[] estrutura = new Estrutura[1];
            estrutura[0].x = 1;
            estrutura[0].y = 2;
            metodo01 (estrutura);
            Console.WriteLine(estrutura[0].x + estrutura[0].y);
        }

        static void metodo01 (Estrutura[] estrutura)
        {
            if ((estrutura[0].x + estrutura[0].y) < 10)
            {
                estrutura[0].x *= estrutura[0].y;
                estrutura[0].y += estrutura[0].x;
                metodo02(estrutura);
            }
        }

        static void metodo02 (Estrutura[] estrutura)
        {
            estrutura[0].y -= estrutura[0].x;
            estrutura[0].x -= estrutura[0].y;
            metodo03 (estrutura);
        }

        static void metodo03(Estrutura[] estrutura)
        {
            estrutura[0].x += estrutura[0].y;
            estrutura[0].y *= estrutura[0].x;
            metodo01 (estrutura);
        }

    }
}
