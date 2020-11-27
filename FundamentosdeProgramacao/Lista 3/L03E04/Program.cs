using System;

namespace L03E04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1001, contador = 0;

            while (contador < 5) //Looping até o contador chegar a 5;
            {
                if (num % 11 == 5) //Validando o número dentro da contagem que divide por 11 e obtém 5 de resto;
                {
                    Console.WriteLine("Contador: " + contador); //Encontrando o primeiro número;
                    contador++; //Incremento de número até encontrar o último(quinto) número;
                }
                num++; //Incremento de unidade. EX -> 1001 + 1 = 1002...Assim por diante, até o contador contar 5 vezes;
            }
            Console.WriteLine("Númerrr: " + num); //Imprimindo o quinto número do contador;

        }
    }
}
