
using System;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("=== Calculadora ===\n");
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.Write("Opção: ");

            string opcao = Console.ReadLine();

            if (opcao == "5")
            {
                continuar = false;
                Console.WriteLine("Saindo...");
                continue;
            }

            // Validação simples para evitar erros
            Console.Write("Digite o primeiro número: ");
            double num1;
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Valor inválido. Digite um número válido: ");
            }

            Console.Write("Digite o segundo número: ");
            double num2;
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Valor inválido. Digite um número válido: ");
            }

            double resultado = 0;
            bool operacaoValida = true;

            switch (opcao)
            {
                case "1":
                    resultado = num1 + num2;
                    Console.WriteLine($"\nResultado: {num1} + {num2} = {resultado}");
                    break;
                case "2":
                    resultado = num1 - num2;
                    Console.WriteLine($"\nResultado: {num1} - {num2} = {resultado}");
                    break;
                case "3":
                    resultado = num1 * num2;
                    Console.WriteLine($"\nResultado: {num1} * {num2} = {resultado}");
                    break;
                case "4":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"\nResultado: {num1} / {num2} = {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("\nErro: Divisão por zero não é permitida!");
                        operacaoValida = false;
                    }
                    break;
                default:
                    Console.WriteLine("\nOpção inválida!");
                    operacaoValida = false;
                    break;
            }

            if (operacaoValida)
            {
                Console.WriteLine("\nOperação realizada com sucesso!");
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
