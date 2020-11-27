using System;

namespace _19º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Teorema de Pitágoras");

			double catetoOpo, catetoAdj, resultado, hipotenusa;

            Console.WriteLine("Digite o Cateto Oposto: ");
            catetoOpo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o Cateto Adjacente: ");
            catetoAdj = Convert.ToDouble(Console.ReadLine());

            double b = Math.Pow(catetoOpo, 2); //b²
            double c = Math.Pow(catetoAdj, 2); //c²

            resultado = b + c;

            hipotenusa = Math.Sqrt(resultado);
            Console.WriteLine("A hipotenusa é: " + hipotenusa.ToString("F1"));     
                       
        }
    }
}
