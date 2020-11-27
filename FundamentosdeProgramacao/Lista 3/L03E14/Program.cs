/* Uma rainha requisitou os serviços de um monge. O monge exigiu o pagamento em 
grãos de trigo da seguinte maneira: os grãos de trigo seriam dispostos em um 
tabuleiro de xadrez, de tal forma que a primeira casa do tabuleiro tivesse um grão, 
e as casas seguintes, o dobro da anterior. Escreva um algoritmo que calcule e 
apresente quantos grãos de trigo a Rainha deverá pagar ao monge.
*/

using System;

namespace L03E14
{
    class Program
    {
        static void Main(string[] args)
        {
            int casa;
            double soma = 1,
                   graos = 1;

            
            for (casa = 2; casa <= 64; casa++)
            {
                graos *= 2;
                soma += graos;

                Console.WriteLine("Valor a pagar: " + soma + " grãos");
            }
            
            
        }
    }
}
