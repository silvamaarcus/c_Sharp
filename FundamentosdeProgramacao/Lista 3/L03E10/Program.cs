/* 
Escreva um algoritmo que leia um número natural a partir do teclado e que 
informe se esse número equivale ao resultado do produto de três números
naturais consecutivos.
Exemplo: 
 
0 = 0 x 1 x 2    6 = 1 x 2 x 3      24 = 2 x 3 x 4   
60 = 3 x 4 x 5   120 = 4 x 5 x 6    210 = 5 x 6 x 7
336 = 6 x 7 x 8  504 = 7 x 8 x 9    720 = 8 x 9 x 10

 */


using System;

namespace L03E10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, i; //Declarando variáveis;
            bool condicao; //Expressão booleana, para declarar se a condição é verdadeira ou falsa;

            Console.Write("Digite o número: ");
            numero = int.Parse(Console.ReadLine());

            condicao = false; //'verificar' é FALSO;
            i = 1; //'i' é igual 1, pois é o primeiro termo na multiplicação de três números;

            while (i < numero && !condicao) //ENQUANTO, 'i' ser menor que 'numero' a expressão é FALSA;
            {
                if ((i * (i + 1) * (i + 2)) == numero) //SE, 1 * 2 * 3 = 6;
                    condicao = true; //Condição será VERDADEIRA;
                else  //SENÃO, incrementar + 1 em 'i';
                    i++;
            }

            if (condicao) //SE 'condicao' for VERDADEIRO, imprima isso;
            {                
                Console.WriteLine(numero + " = " + i + " * " + (i + 1) + " * " + (i + 2));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("O número equivale ao produto de três números consecutivos!");
                Console.ResetColor();
            }
            else //Caso contrário, imprima isso;
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O número " + numero + " NÃO equivale ao produto de três números consecutivos!");
                Console.ResetColor();
            }

            Console.ReadKey();           
        }
    }
}
