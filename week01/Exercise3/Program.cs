using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = 0;
        int guess = 0;
        int attempts = 0;

        while (guess != magicNumber)
        {
        
        Console.Write("What is the magic number? ");
        magicNumber = int.Parse(Console.ReadLine());
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        attempts ++;

        if (guess == magicNumber)
        {
            Console.WriteLine($"Correct! You got it in {attempts} attempts.");
        } 
        
        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("Higher");
        }

        }
    

    }
}