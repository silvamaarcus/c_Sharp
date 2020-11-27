using System;

namespace _18º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de Idade 2.0");

            int anoNas, anoAtual, anos, meses, dias;
            double semanas;

            Console.WriteLine("Digite o ano de nascimento: ");
            anoNas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o ano atual: ");
            anoAtual = Convert.ToInt32(Console.ReadLine());

            anos = anoAtual - anoNas;
            meses = anos * 12;
            dias = anos * 365;
            semanas = anos * 52.143;

            Console.WriteLine("Sua idade: " + anos);
            Console.WriteLine("Sua idade em meses: " + meses);
            Console.WriteLine("Sua idade em dias: " + dias);
            Console.WriteLine("Sua idade em semanas: " + semanas.ToString("F2"));

        }
    }
}