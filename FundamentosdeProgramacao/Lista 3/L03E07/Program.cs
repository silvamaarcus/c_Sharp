/* 
 
Escreva um algoritmo que solicite um limite inteiro como entrada e que apresente 
na tela os termos das séries abaixo menores ou iguais ao limite informado. O 
algoritmo deve apresentar também a soma de todos os termos apresentados em 
cada série.
a) 3, 6, 9, 12, 15, 18, 21...
b) 5, 10, 15, 20, 25, 30...
c) 1, 2, 4, 8, 16, 32, 64... (2^0, 2^1, 2^2, 2^3, 2^4, 2^5, 2^6, ...)
d) 1, 8, 27, 64, 125, 216... (1^3, 2^3, 3^3, 4^3, 5^3, 6^3, ...)

*/

using System;

namespace L03E07
{
    class Program
    {
        static void Main(string[] args)
        {
            int condicao, limite, soma;

            Console.WriteLine("Digite um número limite: ");
            limite = int.Parse(Console.ReadLine());

            //De 3 em 3;
            Console.Write("\na)");
            soma = 0;

            for (condicao = 3; condicao <= limite; condicao += 3)
            {
                Console.Write(condicao + ";");
                soma += condicao;
            }
            Console.WriteLine(" Soma: " + soma);

            //De 5 em 5;
            Console.Write("\nb)");
            soma = 0; //Resetar o somatório;

            for (condicao = 5; condicao <= limite; condicao += 5)
            {
                Console.Write(condicao + ";");
                soma += condicao;
            }
            Console.WriteLine(" Soma: " + soma);

            //Potência de 2;
            Console.Write("\nc)");
            soma = 0; //Resetar o somatório;

            for (condicao = 1; condicao <= limite; condicao *= 2)
            {
                Console.Write(condicao + ";");
                soma += condicao;
            }
            Console.WriteLine(" Soma: " + soma);

            //Potência de 3;
            Console.Write("\nd)");
            soma = 0; //Resetar o somatório;

            for (condicao = 1; condicao <= limite; condicao *= 3)
            {
                Console.Write(condicao + ";");
                soma += condicao;
            }
            Console.WriteLine(" Soma: " + soma);
        }
    }
}
