using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        //Console.WriteLine(firstName);

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        //Console.WriteLine(lastName);

        string fullName = firstName + " " + lastName;

        Console.WriteLine($"Your name is {lastName}, {fullName}.");

    }
}