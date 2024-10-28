using System;
using System.Runtime.Intrinsics.Arm;

class contas
{
    static void Main()
    {
        double numero1 = 0, numero2 = 0;
        bool entradaValida = false;

        while (!entradaValida)
        {
            try
            {
                Console.WriteLine("Digite o primeiro número:");
                numero1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número:");
                numero2 = double.Parse(Console.ReadLine());

                entradaValida = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Por favor, digite apenas números.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Número muito grande ou muito pequeno. Tente novamente.");
            }
        }

        // Soma
        double soma = numero1 + numero2;
        Console.WriteLine($"Soma: {soma}");

        // Subtração
        double subtracao = numero1 - numero2;
        Console.WriteLine($"Subtração: {subtracao}");

        // Multiplicação
        double multiplicacao = numero1 * numero2;
        Console.WriteLine($"Multiplicação: {multiplicacao}");

        // Divisão (com verificação de divisão por zero)
        if (numero2 != 0)
        {
            double divisao = numero1 / numero2;
            Console.WriteLine($"Divisão: {divisao}");
        }
        else
        {
            Console.WriteLine("Não é possível dividir por zero.");
        }

        // Média
        double media = (numero1 + numero2) / 2;
        Console.WriteLine($"Média: {media}");
    }
}