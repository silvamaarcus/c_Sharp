using System;

namespace L03E05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, soma=0, contador=0, maior=0, menor=0;
            string opcao;
            
            do  {
                Console.WriteLine("Digite um número: ");
                num = int.Parse(Console.ReadLine());
                if (contador > 0)
                {
                    if (num < menor)
                        menor = num;
                    else
                        if (num > maior)
                        maior = num;
                }
                else
                    menor = maior = num;

                soma += num;
                contador++;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Deseja digitar outro número? (sim/não)");
                opcao = Console.ReadLine().ToLower();
                Console.ResetColor();


            } while ((opcao == "sim") || (opcao == "s")); //Looping de repetição;

            Console.WriteLine("Maior: " + maior);
            Console.WriteLine("Menor: " + menor);
            Console.WriteLine("Média: " + (soma/contador));
        }
    }
}
