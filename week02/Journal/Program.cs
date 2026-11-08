using System;

class Program
{
    static void Main(string[] args)
    {

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            choice = Console.ReadLine();
        }
        
    
    if (choice == "1")
        {
            
            Console.WriteLine(">");
            string notes = Console.ReadLine();
        }

        

    }
}