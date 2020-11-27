using System;

namespace L02E04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando variáveis;
            double a, b, c, x, bhasX1, bhasX2, equacao1;

            //Validando valores;
            Console.WriteLine("Digite o valor de 'a': ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de 'b': ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de 'c': ");
            c = double.Parse(Console.ReadLine());

            //Equação de 2º Grau;
            x = ((Math.Pow(b, 2) - (4 * a * c)));            
            Console.WriteLine("Aplicando Bhaskara");
            bhasX1 = (((-b) + (Math.Sqrt(x))) / (2 * a));
            bhasX2 = (((-b) - (Math.Sqrt(x))) / (2 * a));
            
            //Condições de Equação;
            if (a == 0 && b == 0 && c != 0)
            {
                Console.WriteLine("Coeficientes informados incorretamente.");
            }
            else if (a == 0 && b != 0)
            {
                Console.WriteLine("Essa é uma equação de 1º Grau.");
                equacao1 = -c / b;
                Console.WriteLine("X = " + equacao1);
            }
            else if (x < 0)
            {
                Console.WriteLine("Esta equação não possui raízes reais.");
            }
            else if (x == 0)
            {
                Console.WriteLine("Esta equação possui duas raízes reais iguais. ");
                Console.WriteLine("x = " + x);              
            }
            else if (x > 0)
            {
                Console.WriteLine("Esta equação possui duas raízes reais diferentes. ");                
                Console.WriteLine("x' = " + bhasX1.ToString("F2"));
                Console.WriteLine("x'' = " + bhasX2.ToString("F2"));
            }
        }
    }
}
