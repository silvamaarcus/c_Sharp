/* 
Série de Fibonacci:
0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...

A série de Fibonacci começa com os termos 0 e 1 e tem a propriedade de que cada
termo subsequente equivale à soma dos dois termos anteriores. 

Escreva um algoritmo que leia um limite a partir do teclado e que apresente na tela os termos 
da série de Fibonacci menores ou iguais ao limite informado. O algoritmo também 
deve apresentar a soma dos termos gerados. 

*/

using System;

namespace L03E09
{
    class Program
    {
        static void Main(string[] args)
        {
            int limite,
                //'termo1' e 'termo2' começam em 0 e 1, respectivamente;
                termo1 = 0,
                termo2 = 1,
                termo3 = 1; //termo3 = termo1 + termo2;

            Console.WriteLine("Digite o limite: ");
            limite = int.Parse(Console.ReadLine());
                        
            Console.Write(termo1 + " ");
            Console.Write(termo2 + " ");

            do //FAÇA o comando;
            {
                Console.Write(termo3 + " "); //Imprimir 'termo3' com espaçamentos;
                termo1 = termo2;
                termo2 = termo3;
                termo3 = termo2 + termo1;

            } while (termo3 < limite); //FAÇA o comando ENQUANTO o meu 'termo3' ser inferior ao 'limite';

            Console.ReadKey();
        }
    }
}
