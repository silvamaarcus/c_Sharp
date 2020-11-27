using System;

namespace _9º_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("| Comparação de Datas |");

            DateTime data1, data2;
            
            Console.WriteLine("Digite a primeira data: ");
            data1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda data: ");
            data2 = DateTime.Parse(Console.ReadLine());
            
            if (data1 < data2)
            {
                Console.WriteLine(data1.ToShortDateString() + " é antes de " + data2.ToShortDateString());
            }
            else if (data1 == data2)
            {
                Console.WriteLine(data1.ToShortDateString() + " é mesma data de " + data2.ToShortDateString());
            }
            else
            {
                Console.WriteLine(data1.ToShortDateString() + " é depois de " + data2.ToShortDateString());
            }
            
            Console.ReadKey();            

        }
    }
}
