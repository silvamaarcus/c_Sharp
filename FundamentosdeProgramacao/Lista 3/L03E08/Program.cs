/* 
 
Escreva o algoritmo que será empregado numa pesquisa entre os habitantes de 
uma dada região. Os dados coletados na pesquisa serão a altura e o sexo (0 =
feminino, 1 = masculino) das pessoas. O algoritmo deve ler esses dados da 
população a partir do teclado e informar na tela: 
a. A menor altura encontrada.
b. A maior altura encontrada.
c. A média da altura das mulheres.
d. A média da altura dos homens.
e. A média da altura da população.
f. O percentual de mulheres na população.
g. O percentual de homens na população.
 
 */


using System;

namespace L03E08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando variáveis de contador p/ mulheres e homens;
            int mulheres = 0,
                homens = 0;
            //Variáveis para altura;
            double altura,
                menorAltura = double.PositiveInfinity, //A menor altura começará com o maior (positivo) valor possível;
                maiorAltura = double.NegativeInfinity, //A maior altura começará com o menor (negativo) valor possível;
                somaAlturasMulheres = 0,
                somaAlturasHomens = 0;

            string sexo, opcao; //'opcao' é para saber se o usuário quer refazer o programa;

            //Criando repetição das perguntas ('opcao');
            do
            {
                //Criando repetição das perguntas ('sexo');
                do
                {
                    Console.WriteLine("Informe o sexo (f/m): ");
                    sexo = Console.ReadLine().ToLower();
                } while (!sexo.Equals("f") && !sexo.Equals("m")); //Executar o código enquanto o que for digitado ser diferente de 'f' ou 'm';

                //Após 'f' ou 'm' digitado, o programa entrará na  repetição das perguntas ('altura');
                do
                {
                    Console.WriteLine("Informe a altura: ");
                    altura = double.Parse(Console.ReadLine());
                } while (altura <= 0); //Executar o código até a 'altura' ser maior que 0;

                //Implementando condições;
                if (sexo == "f") //Se o 'sexo' for 'f';
                {
                    mulheres++; //Incremento de 1 mulher;
                    somaAlturasMulheres += altura; //A soma das alturas: 0 (atual) + 'altura'(digitada);
                }
                else //Se o 'sexo' não for 'f' -> Será 'm'; 
                {
                    homens++; //Incremento de 1 homem;
                    somaAlturasHomens += altura; //A soma das alturas: 0 (atual) + 'altura'(digitada);
                }

                if ((mulheres == 1 && homens == 0) || (mulheres == 0 && homens == 1))
                    //As três varávies terão o mesmo valor, pois será a primeira 'altura' informada, indenpedente do 'sexo' digitado;                 
                    menorAltura = maiorAltura = altura;

                //Caso o código seja executado novamente;
                else //Se 'altura'(digitada novamente) for MENOR que 'menorAltura'(atual);
                    if (altura < menorAltura)
                    menorAltura = altura; //A 'menorAltura' passa a ser a nova menor altura digitada;

                else //Senão, se 'altura' for MAIOR que 'maiorAltura'(atual);
                    if (altura > maiorAltura)
                    maiorAltura = altura; //A 'maiorAltura' passa a ser a nova maior altura digitada;

                Console.WriteLine("Deseja executar novamente? (sim/não)");
                opcao = Console.ReadLine().ToLower(); //Ler o que foi digitado e coverter para minúsculo;
            } while ((opcao == "sim") || (opcao == "s")); //Se for 'sim' ou 's', rodar o programa novamente;

            Console.WriteLine("Menor altura encontrada: " + menorAltura);
            Console.WriteLine("Maior altura encontrada: " + maiorAltura);

            //Imprimindo resultados com condições;
            if (mulheres > 0)
                Console.WriteLine("Média de altura entre as mulheres: " + (somaAlturasMulheres / mulheres));

            if (homens > 0)
                Console.WriteLine("Média de altura entre os homens: " + (somaAlturasHomens / mulheres));

            if ((mulheres + homens) > 0)
            {
                Console.WriteLine("Média de altura da população: " + (somaAlturasHomens + somaAlturasHomens / mulheres + homens));
                Console.WriteLine("Percentual de mulheres na população: " + ((double)(mulheres)) / (double)(mulheres+homens));
                Console.WriteLine("Percentual de homens na população: " + ((double)(homens)) / (double)(mulheres + homens));
            }

        }    
    }
}
