using System;

namespace _23º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Terceiro Ângulo");

            int angulo1, angulo2, resultado, angulo3;

            Console.WriteLine("Digite o primeiro ângulo: ");
            angulo1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o primeiro ângulo: ");
            angulo2 = Convert.ToInt32(Console.ReadLine());

            //angulo1 + angulo2 + angulo3 = 180 -> Formula
            resultado = angulo1 + angulo2;
            angulo3 = 180 - resultado;

            Console.WriteLine("O terceiro ângulo: " + angulo3.ToString() + "º");

            Console.ReadLine();


        }
    }
}
