using System;

namespace _24º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversão de Moedas");

            double quantia, dolar, alemao, libra;

            Console.WriteLine("Digite sua quantia em Reais: ");
            quantia = Convert.ToDouble(Console.ReadLine());

            //Dólar: R$1,80
            dolar = quantia / 1.80;

            //Marco Alemão: R$2,00
            alemao = quantia / 2.00;

            //Libra: R$3,70
            libra = quantia / 3.70;

            Console.WriteLine("Conversão para dólar: $" + dolar.ToString("F2"));
            Console.WriteLine("Conversão para marco alemão: " + alemao.ToString("F2")+ " D-Mark");
            Console.WriteLine("Conversão para libra: £" + libra.ToString("F2"));

            Console.ReadLine();


        }
    }
}
