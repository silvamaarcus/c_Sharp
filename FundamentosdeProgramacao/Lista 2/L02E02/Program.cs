using System;

namespace L02E02
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota50, nota20, nota10, nota5, nota2, nota1, valorCp, valorPg, troco;

            Console.WriteLine("Informe o valor pago: ");
            valorPg = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da compra: ");
            valorCp = int.Parse(Console.ReadLine());

            if (valorPg >= valorCp)
            {
                troco = valorPg - valorCp;
                
                nota50 = troco / 50;
                troco %= 50; //troco = troco % 50
                
                nota20 = troco / 20;
                troco %= 20; 

                nota10 = troco / 10;
                troco %= 10;

                nota5 = troco / 5;
                troco %= 5;

                nota2 = troco / 2;
                troco %= 2;

                nota1 = troco / 1;
                troco %= 1;

                Console.Clear();
                Console.WriteLine("Valor pago: " + valorPg);
                Console.WriteLine("Valor de compra: " + valorCp);
                Console.WriteLine("Valor do troco: " + (valorPg-valorCp));
                Console.WriteLine("Notas de R$ 50,00: " + nota50);
                Console.WriteLine("Notas de R$ 20,00: " + nota20);
                Console.WriteLine("Notas de R$ 10,00: " + nota10);
                Console.WriteLine("Notas de R$ 5,00: " + nota5);
                Console.WriteLine("Notas de R$ 2,00: " + nota2);
                Console.WriteLine("Moedas de R$ 1,00: " + nota1);
            }
            else
            {
                Console.WriteLine("Quantia paga é insuficiente para realizar a compra!!");
            }

            Console.ReadKey();
           
        }
    }
}
