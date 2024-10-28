/*  Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
    - A placa deve ter 7 caracteres alfanuméricos;
    - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
    - Os quatro últimos caracteres são números;
    
    Ao final, o programa deve exibir ***Verdadeiro*** se a placa for válida e ***Falso*** caso contrário.
 */

using System;
using System.Text.RegularExpressions;

class palavraValida
{
    static void Main()
    {
        Console.WriteLine("Digite a placa de um veículo: ");
        string placa = Console.ReadLine();

        // Expressão regular para validar o padrão brasileiro de placa até 2018: 3 letras seguidas de 4 números
        string padrao = @"^[A-Za-z]{3}[0-9]{4}$";

        bool placaValida = Regex.IsMatch(placa, padrao);

        if (placaValida)
        {
            Console.WriteLine("Verdadeiro");
        }
        else {
            Console.WriteLine("Falso");
        }
    }
}