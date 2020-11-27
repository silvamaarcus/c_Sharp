using System;

namespace L02E06
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            char opcao;
            
            Console.WriteLine("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("|*|");
            Console.WriteLine("|/|");
            Console.WriteLine("|+|");
            Console.WriteLine("|-|");
            Console.WriteLine("|^|");
            Console.Write("Digite a opção desejada!");

            opcao = Convert.ToChar(Console.ReadLine());

            switch (opcao)
            {
                case '*':
                    Console.WriteLine(num1 + "*" + num2 + "=" + (num1 * num2));
                break;

                case '/':
                    Console.WriteLine(num1 + "/" + num2 + "=" + (num1 / num2));
                break;

                case '+':
                    Console.WriteLine(num1 + "+" + num2 + "=" + (num1 + num2));
                break;

                case '-':
                    Console.WriteLine(num1 + "-" + num2 + "=" + (num1 - num2));
                break;

                case '^':
                    Console.WriteLine(num1 + "^" + num2 + "=" + (Math.Pow(num1,num2)));
                break;

                default:
                    Console.WriteLine("O símbolo da operação é inválido.");
                break;

            }
        }
    }
}
