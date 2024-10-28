using System;
using System.Globalization;

class FormatosDatas
{
    static void Main()
    {
        DateTime dataAtual = DateTime.Now;

        Console.WriteLine("Escolha o formato de exibição da data e hora:");
        Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
        Console.WriteLine("2 - Apenas a data (formato: dd/MM/yyyy)");
        Console.WriteLine("3 - Apenas a hora (formato de 24 horas)");
        Console.WriteLine("4 - Data com o mês por extenso");

        Console.Write("Digite o número da opção desejada: ");
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                // Formato completo
                Console.WriteLine($"Data e hora completa: {dataAtual.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss", new CultureInfo("pt-BR"))}");
                break;

            case "2":
                // Apenas a data no formato dd/MM/yyyy
                Console.WriteLine($"Data (formato: dia/mês/ano): {dataAtual.ToString("dd/MM/yyyy")}");
                break;

            case "3":
                // Apenas a hora no formato de 24 horas
                Console.WriteLine($"Hora (Formato 24 horas): {dataAtual.ToString("HH:mm")}");
                break;

            case "4":
                // Data com o mês por extenso
                Console.WriteLine($"Data com o mês por extenso: {dataAtual.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR"))}");
                break;

            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }
}
