using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        PromptUserName();
        PromptUserNumber();
        SquareNumber();










        

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            return favoriteNumber;
        }

        static int SquareNumber(int favoriteNumber)
        {
            int squared = favoriteNumber * favoriteNumber;
            return squared;
        }
        
        static void DisplayResult()
        {
            Console.WriteLine($({}))
        }

    }
}