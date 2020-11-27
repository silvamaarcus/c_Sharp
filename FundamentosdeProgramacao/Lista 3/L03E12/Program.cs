/* 
Escreva um algoritmo que leia um número natural a partir do teclado e que 
informe na tela se esse número é primo. Um número natural primo tem apenas
dois divisores naturais distintos: o número um e ele mesmo.
*/

using System;

namespace L03E12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            
            Console.WriteLine("Digite o número: ");
            numero = int.Parse(Console.ReadLine());
         
            if (numero/numero == 1 && numero / 1 == 1 && numero != 1)
            {
                Console.WriteLine("O número é primo!!!");
            }
                     
            else
            {
                Console.WriteLine("Não é número primo!!!");
            }
        }
    }
}
