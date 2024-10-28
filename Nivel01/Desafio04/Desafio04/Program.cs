/*
 * Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class contadorDeCaracteres
{
    static void Main()
    {
        List<string> palavras = new List<string>();

        Console.WriteLine("Digite uma palavra: ");
        palavras.Add(Console.ReadLine());

        foreach (string palavra in palavras)
        {
            bool isPalavra = palavra.All(Char.IsLetter);

            if (isPalavra)
            {
                Console.WriteLine($"A palavra '{palavra}' contem {palavra.Length} caracteres.");
            }
            else
            {
                Console.WriteLine($"'{palavra}' não é uma palavra válida.");
            }


        }
    }
}