// Resultado: 82

using System;
using System.Xml.Schema;

namespace ConsoleApp5
{
    struct Conta
    {
        public int numero;
        public double saldo;
    }

    class Program
    {
        static void Main()
        {
            Conta[] contas = new Conta[5];
            preencher(contas);
            total(contas);
        }

        static void preencher (Conta[] contas)
        {
            for (int i = 0; i < contas.Length; i++)
            {
                contas[i].numero = i;
                if (i % 2 != 0)
                    contas[i].saldo = Math.Pow(i, 2);
                else
                    contas[i].saldo = Math.Pow(i, 3);
            }
        }

        static void total (Conta [] contas)
        {
            double total = 0;
            for (int i = 0; i < contas.Length; i++)
                total += contas[i].saldo;
            Console.WriteLine("Total: " + total);
        }
    }
}
