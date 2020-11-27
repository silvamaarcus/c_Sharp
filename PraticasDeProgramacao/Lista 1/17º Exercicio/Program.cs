using System;

namespace Praticas_de_Programação___Lista_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada");

            int numero, resultado;

            Console.WriteLine("Digite o número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.Clear(); //Limpar a tela

            for (int x = 0; x <= 10; x++)
            {
                resultado = numero * x;
                Console.WriteLine(x + " * " + numero + " = " + resultado);
            }

            

        }
    }
}

