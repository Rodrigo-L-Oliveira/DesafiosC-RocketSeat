/*
 Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.
 */

using System;

namespace Desafios
{
    internal class Desafio02
    {
        static void Main()
        {
            // Strings que recebem o nome e sobrenome do usuário.

            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Informe seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.WriteLine($"Bem vindo: {nome} {sobrenome}");
        }
    }
}
