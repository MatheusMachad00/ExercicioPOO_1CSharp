using ExercicioPOO_1;
using System;
using System.Globalization;


//Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            Pessoa x, y;

            x = new Pessoa();
            y = new Pessoa();   

            Console.WriteLine("Digite os dados da primeira pessoa");
            Console.WriteLine("Nome: ");
            x.name = Console.ReadLine();
            Console.WriteLine("Idade: ");
            x.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados da segunda pessoa");
            Console.WriteLine("Nome: ");
            y.name = Console.ReadLine();
            Console.WriteLine("Idade: ");
            y.age = int.Parse(Console.ReadLine());

            if (x.age > y.age) Console.WriteLine($"Pessoa mais velha: {x.name}");
            else if (x.age < y.age) Console.WriteLine($"Pessoa mais velha: {y.name}");
            else Console.WriteLine("Ambas as pessoas tem a mesma idade.");

        }
    }
}