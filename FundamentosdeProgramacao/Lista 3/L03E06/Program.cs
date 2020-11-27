using System;

namespace L03E06
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial=1, num;
            
            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            if ( num > 0)
            {
                for (int x = 1; x <= num; x++)
                {
                    fatorial *= x;
                    Console.WriteLine(x + "!" + " = " + fatorial);
                }
            }
            else if (num == 0)
            {
                Console.WriteLine("O fatorial de 0 é igual a 1.");
            }
            else
            {
                Console.WriteLine("Número informado é inválido!!");
            }
        }
    }
}
