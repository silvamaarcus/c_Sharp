/* 
Faça um programa que verifique a validade de um senha fornecida pelo usuário. A senha é 
4531. O programa deve mostrar uma mensagem de permissão de acesso ou não.
*/

using System;

namespace _16º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha;

            do
            {
                Console.WriteLine("Digite a senha: ");
                senha = Console.ReadLine();

            } while (!senha.Equals("4231")); 
            
            if (senha == "4231")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Acesso liberado!");
                Console.ResetColor();
            }
            
        }
    }
}
