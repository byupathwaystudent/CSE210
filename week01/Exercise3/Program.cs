
using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        //Console.Write("What is the magic number? ");
        // int magicNumber = 10; // int.Parse(Console.ReadLine());

        int guess = 0;
        int attempts = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            attempts++;

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
