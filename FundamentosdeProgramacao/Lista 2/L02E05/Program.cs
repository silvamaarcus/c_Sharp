using System;

namespace L02E05
{
    class Program
    {
        static void Main(string[] args)
        {
			double r, area, volume, perimetro, num1, num2;
			int opcao;

			Console.WriteLine("Digite o primeiro número: ");
			num1 = double.Parse(Console.ReadLine());
			Console.WriteLine("Digite o segundo número: ");
			num2 = double.Parse(Console.ReadLine());

			Console.WriteLine("| Menu de Opções |");
			Console.WriteLine("1. Calcular Números - Perímetro do Círculo");
			Console.WriteLine("2. Calcular Números - Área do Círculo");
			Console.WriteLine("3. Calcular Números - Volume da Esfera");
			Console.Write("Digite a opção desejada!");

			opcao = int.Parse(Console.ReadLine());

			switch (opcao)
			{
				case 1:
					Console.WriteLine(num1 + "*" + num2 + "=" + (num1 * num2));
					Console.WriteLine(num1 + "/" + num2 + "=" + (num1 / num2));
					Console.WriteLine(num1 + "+" + num2 + "=" + (num1 + num2));
					Console.WriteLine(num1 + "-" + num2 + "=" + (num1 - num2));

					Console.WriteLine("Digite o raio: ");
					r = double.Parse(Console.ReadLine());
					perimetro = (2 * Math.PI * r);
					Console.WriteLine("Perímetro do círculo: " + perimetro.ToString("F2"));

					break;

				case 2:
					Console.WriteLine(num1 + "*" + num2 + "=" + (num1 * num2));
					Console.WriteLine(num1 + "/" + num2 + "=" + (num1 / num2));
					Console.WriteLine(num1 + "+" + num2 + "=" + (num1 + num2));
					Console.WriteLine(num1 + "-" + num2 + "=" + (num1 - num2));

					Console.WriteLine("Digite o raio: ");
					r = double.Parse(Console.ReadLine());
					area = ((Math.PI) * (Math.Pow(r, 2)));
					Console.WriteLine("Área do círculo: " + area.ToString("F2"));

					break;

				case 3:
					Console.WriteLine(num1 + "*" + num2 + "=" + (num1 * num2));
					Console.WriteLine(num1 + "/" + num2 + "=" + (num1 / num2));
					Console.WriteLine(num1 + "+" + num2 + "=" + (num1 + num2));
					Console.WriteLine(num1 + "-" + num2 + "=" + (num1 - num2));

					Console.WriteLine("Digite o raio: ");
					r = double.Parse(Console.ReadLine());
					volume = (4 * (Math.PI) * (Math.Pow(r, 3)) / 3);
					Console.WriteLine("Volume da Esfera: " + volume.ToString("F2"));

					break;

				default:
					Console.WriteLine("Opção inválida");
					break;
			}
		}
    }
}
