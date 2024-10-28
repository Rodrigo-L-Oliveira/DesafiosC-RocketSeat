/*
 Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada.
 Com o nome dele é exibida:  "Olá, Welisson! Seja muito bem-vindo!"
 */

using System;

internal class Desafio01
{
    static void Main()
    {
        Console.Write("Por favor, digite seu nome: ");
        string nome = Console.ReadLine(); // Recebe o nome do usuário.

        Console.WriteLine("Digite seu gênero (M para Masculino, F para Feminino): ");
        string genero = Console.ReadLine(); // Recebe o gênero do usuário.

        string saudacao = genero.ToUpper() == "M" ? "Bem-vindo" : genero.ToUpper() == "F" ? "Bem-vinda" : "Bem-vindo(a)";
        // Valida o gênero do usuário para poder fazer a saudação correta
        // (caso o usuário não responda aparece: "Bem-vindo(a)".

        Console.WriteLine($"Olá, {nome}! Seja muito {saudacao}");
        // Mostra na tela a saudação com nome do usuário e a devida saudação.
    }
}