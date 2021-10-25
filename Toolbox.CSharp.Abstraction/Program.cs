using System;
using Gym = Toolbox.CSharp.Abstraction.Model.Gym;
using Library = Toolbox.CSharp.Abstraction.Model.Libary;

namespace Toolbox.CSharp.Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Gym.Person person1 = new Gym.Person("Afonso Abreu", 1.80, 80);

            Library.Address address = new Library.Address();

            Library.Person person2 = new Library.Person(
                "Afonso Abreu"
                , new DateTime(1995, 12, 23)
                , address
                , "12345-1234");


            Console.WriteLine("Pessoa em Academia:");
            Console.WriteLine($"Nome: {person1.Name}");
            Console.WriteLine($"Altura: {person1.Height} m");
            Console.WriteLine($"Peso: {person1.Weight} kg");
            Console.WriteLine($"ICM: {person1.BMI.ToString("0.00")}");
            Console.WriteLine($"--------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Pessoa em Biblioteca:");
            Console.WriteLine($"Nome: {person2.Name}");
            Console.WriteLine($"Data de Nasc.: {person2.BirthDate.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Idade: {person2.Age}");
            Console.WriteLine($"Telefone: {person2.Phone}");
            Console.WriteLine($"--------------------------------------");
        }
    }
}
