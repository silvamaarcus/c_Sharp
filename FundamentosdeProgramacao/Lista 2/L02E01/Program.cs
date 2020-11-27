using System;

namespace L02E01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, media;

            Console.WriteLine("|Digite números distintos|");
            Console.WriteLine();

            Console.WriteLine("Digite o 1º número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 3º número: ");
            num3 = int.Parse(Console.ReadLine());

            //Maior número
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("O maior número é " + num1);
            }
            if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine("O maior número é " + num2);
            }
            if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("O maior número é " + num3);
            }


            //Menor número
            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine("O menor número é " + num1);
            }
            if (num2 < num3 && num2 < num1)
            {
                Console.WriteLine("O menor número é " + num2);
            }
            if (num3 < num1 && num3 < num2)
            {
                Console.WriteLine("O menor número é " + num3);
            }

            //Média
            media = num1 + num2 + num3 / 3;
            Console.WriteLine("Média aritimetica: " + media);

        }
    }
}
