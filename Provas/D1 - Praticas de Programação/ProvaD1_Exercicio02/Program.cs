/* 
Faça um algoritmo que leia o um número inteiro entre 1 e 7 e escreva o dia da semana correspondente. 
Caso o usuário digite um número fora desse intervalo, deverá aparecer uma mensagem informando 
que não existe dia da semana com esse número.
Dia 1 (domingo), dia 2 (segunda-feira), ... , dia 7 (sábado)

*/

using System;

namespace ProvaD1_Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            
            Console.WriteLine("Digite um número entre 1 e 7: ");
            dia = int.Parse(Console.ReadLine());

            if (dia >= 1 && dia <= 7)
            {
                if (dia == 1)
                {
                    Console.WriteLine("Domingo");
                }
                if (dia == 2)
                {
                    Console.WriteLine("Segunda");
                }
                if (dia == 3)
                {
                    Console.WriteLine("Terça");
                }
                if (dia == 4)
                {
                    Console.WriteLine("Quarta");
                }
                if (dia == 5)
                {
                    Console.WriteLine("Quinta");
                }
                if (dia == 6)
                {
                    Console.WriteLine("Sexta");
                }
                if (dia == 7)
                {
                    Console.WriteLine("Sábado");
                }               
            }

            else
            {
                Console.WriteLine("Não existe dia da semana com esse número!");
            }

            Console.ReadKey();

        }
    }
}
