using System;

namespace _21º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iluminação de Casa");

            double lado1, lado2, area, w, potencia;

            Console.WriteLine("Vamos encontrar a área do seu cômodo!");

            Console.WriteLine("Digite o primeiro comprimento: ");
            lado1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo comprimento: ");
            lado2 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            area = lado1 * lado2;
            w = 18;   //18W por m²

            potencia = area * w;

            Console.WriteLine("Área de cômodo: " + area.ToString("F1") + "m²");
            Console.WriteLine("Potência necessária: " + potencia.ToString("F1") + "W");

            Console.ReadLine();

        }
    }
}
