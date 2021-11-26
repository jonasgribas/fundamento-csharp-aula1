using System;
using System.Linq;
using System.Collections.Generic;

namespace dotnetcore
{
    class Program
    {
        // Exercício 2:
        // - Fazer um programa que cadastre pessoas, contendo nome e idade;
        // - Imprimir a media de idade das pessoas
        // - Imprimir o nome e idade da pessoa mais velha
        // - Imprimir o nome e idade da pessoa mais nova
        // - Imprimir a quantidade de pessoas com maior idade
        // Requisítos:
        // - Utilizar List (Avg, Max, Min, Where)
        // - Utilizar Classe Pessoa
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Programa");

        var xPessoas = new List<Pessoa>();
        xPessoas.Add(new Pessoa(31,"Jonas"));
        xPessoas.Add(new Pessoa(32,"Eduardo"));

        // - Imprimir a media de idade das pessoas
        var xMedia = xPessoas.Select(p => p).Average(p => p.idade);
        Console.WriteLine(xMedia);
        
        // - Imprimir o nome e idade da pessoa mais velha
        var xVelha = xPessoas.OrderByDescending(p => p.idade).FirstOrDefault();
        Console.WriteLine(xVelha.nome + ": " + xVelha.idade);

        // - Imprimir o nome e idade da pessoa mais nova
        var xNova = xPessoas.OrderBy(p => p.idade).FirstOrDefault();
        Console.WriteLine(xNova.nome + ": " + xNova.idade);

        // - Imprimir a quantidade de pessoas com maior idade
        var xQtdeIdade = xPessoas.Where(p => p.idade>=18).Count();
        Console.WriteLine("Existem " + xQtdeIdade + " pessoas maiores de idade");
        }      
         
    }
}
