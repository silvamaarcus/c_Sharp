/* Chico tem 1,50m e cresce 2 centímetros por ano, enquanto Juca tem 1,10m
 e cresce 3 cm por ano. Escreva um algoritmo que calcule e imprima quantos 
 anos serão necessários para que Juca seja maior que Chico.
 */

using System;

namespace L03E11
{
    class Program
    {
        static void Main(string[] args)
        {
            int chico, juca,
                anos = 41,
                cresc_Chico,
                cresc_Juca;

            cresc_Chico = anos * 2;
            cresc_Juca = anos * 3;

            chico = cresc_Chico + 150;
            juca = cresc_Juca + 110;

            Console.WriteLine("Altura de: " + chico);
            Console.WriteLine("Altura de: " + juca);
            Console.WriteLine("Serão necessários " + anos + " anos.");
        }
    }
}
