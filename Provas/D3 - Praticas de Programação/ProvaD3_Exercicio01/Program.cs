using System;

namespace ProvaD3_Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("Informe o elemento ({0},{1})", i, j);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            Console.WriteLine("\nMatriz: ");
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 4; j++)

                    Console.Write("{0,5}", matriz[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("- MENU - ");
            Console.WriteLine("0. 0 (zero) para finalizar");
            Console.WriteLine("1. inverter linha 0 (zero) com a linha 4 (quatro)");
            Console.WriteLine("2. inverter coluna 0 (zero) com a coluna 4 (quatro)");
            Console.WriteLine("3. média dos elementos da matriz");
            Console.WriteLine("4. multiplicar matriz pelo seu maior elemento");
            Console.WriteLine("5. dividir a matriz pelo seu menor elemento");
            Console.WriteLine();

            Console.WriteLine("Digite a opção desejeada");
            int opcao = int.Parse(Console.ReadLine());

            while (opcao < 0 || opcao > 5)
            {
                Console.WriteLine("Entrada inválida");
                Console.WriteLine("Digite a opção desejeada");
                opcao = int.Parse(Console.ReadLine());
            }

            if (opcao == 0)
            {
                Console.WriteLine("Finalizado!!");
            }

            if (opcao == 1)
            {
                int temp = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        temp = matriz[0, j];
                        matriz[0, j] = matriz[4, j];
                        matriz[4, j] = temp;
                    }
                }
                Console.WriteLine("\nMatriz (Troca Linha 0 -> Coluna 4:");
                for (int i = 0; i <= 4; i++)
                {
                    for (int j = 0; j <= 4; j++)

                        Console.Write("{0,5}", matriz[i, j]);
                    Console.WriteLine();
                }
            }

            if (opcao == 2)
            {
                int temp = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        temp = matriz[i, 0];
                        matriz[i, 0] = matriz[i, 4];
                        matriz[i, 4] = temp;
                    }
                }
                Console.WriteLine("\nMatriz (Troca Coluna 0 -> Coluna 4:");
                for (int i = 0; i <= 4; i++)
                {
                    for (int j = 0; j <= 4; j++)

                        Console.Write("{0,5}", matriz[i, j]);
                    Console.WriteLine();
                }
            }

            if (opcao == 3)
            {
                double media = 0;
                double soma = 0;

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        soma += matriz[i, j];
                    }
                }
                media = soma / ((double)5 * (double)5);
                Console.Write("Média dos elementos da matriz: " + media.ToString("F2"));
            }

            if (opcao == 4)
            {
                int maior = 0;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if (maior < matriz[i, j])
                        {
                            maior = matriz[i, j];
                        }
                    }
                }
                Console.WriteLine("Maior elemento: " + maior);

                Console.WriteLine();

                int[,] mat2 = new int[5, 5];

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        mat2[i, j] = maior * matriz[i, j];
                    }
                }

                Console.WriteLine("\n2º Matriz: ");
                for (int i = 0; i <= 4; i++)
                {
                    for (int j = 0; j <= 4; j++)

                        Console.Write("{0,5}", mat2[i, j]);
                }
            }

            if (opcao == 5)
            {
                int menor = matriz[0, 0];
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if (menor > matriz[i, j])
                        {
                            menor = matriz[i, j];
                        }
                    }
                }
                Console.WriteLine("Maior elemento: " + menor);

                Console.WriteLine();

                int[,] mat2 = new int[5, 5];

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        mat2[i, j] = menor / matriz[i, j];
                    }
                }

                Console.WriteLine("\n2º Matriz: ");
                for (int i = 0; i <= 4; i++)
                {
                    for (int j = 0; j <= 4; j++)

                        Console.Write("{0,5}", mat2[i, j]);
                }
            }
        }
    }
}

