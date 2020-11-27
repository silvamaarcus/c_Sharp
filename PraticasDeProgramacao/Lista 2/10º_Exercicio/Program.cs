using System;

namespace _10º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double sal, aum, result;

            Console.WriteLine("Menu de Opções");
            Console.WriteLine("1. Escriturário");
            Console.WriteLine("2. Secretário");
            Console.WriteLine("3. Caixa");
            Console.WriteLine("4. Gerente");
            Console.WriteLine("5. Diretor");
            Console.Write("Digite a opção desejada: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Digite o salário atual: ");
                    sal = double.Parse(Console.ReadLine());
                    aum = (sal * 0.50);
                    result = aum + sal;
                    Console.WriteLine("Cargo: Escriturário \n" + "Aumento: " + aum.ToString("C2") + "\nNovo salário: " + result.ToString("C2"));
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Digite o salário atual: ");
                    sal = double.Parse(Console.ReadLine());
                    aum = (sal * 0.35);
                    result = aum + sal;
                    Console.WriteLine("Cargo: Secretário \n" + "Aumento: " + aum.ToString("C2") + "\nNovo salário: " + result.ToString("C2"));
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Digite o salário atual: ");
                    sal = double.Parse(Console.ReadLine());
                    aum = (sal * 0.20);
                    result = aum + sal;
                    Console.WriteLine("Cargo: Caixa \n" + "Aumento: " + aum.ToString("C2") + "\nNovo salário: " + result.ToString("C2"));
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Digite o salário atual: ");
                    sal = double.Parse(Console.ReadLine());
                    aum = (sal * 0.10);
                    result = aum + sal;
                    Console.WriteLine("Cargo: Gerente \n" + "Aumento: " + aum.ToString("C2") + "\nNovo salário: " + result.ToString("C2"));
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("Digite o salário atual: ");
                    sal = double.Parse(Console.ReadLine());
                    Console.WriteLine("Cargo: Diretor \n" + "Salário: " + sal.ToString("C2"));
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;                   
            }

            Console.ReadKey();
        }
    }
}
