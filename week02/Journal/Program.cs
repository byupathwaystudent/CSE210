using System;
using System.ComponentModel;
using System.Threading.Tasks.Dataflow;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        string choice = "";

        Journal journal1 = new Journal();

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            choice = Console.ReadLine();


            if (choice == "1")
            {  
                PromptGenerator promptGen = new PromptGenerator();
                string randomPrompt = promptGen.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                Console.Write(">");

                string response = Console.ReadLine();
                string date = DateTime.Now.ToString();

                Entry entry1 = new Entry(date, randomPrompt, response);
                journal1.AddEntry(entry1);
            } 
            
            else if (choice == "2")
            {
                journal1.DisplayAll();
            } 

            else if (choice == "3")
            {
                Console.Write("Please enter the file to load: ");
                string filename = Console.ReadLine();
                journal1.LoadFromFile(filename);
                
              
            }
            else if (choice == "4")
            {
                Console.Write("Please enter the filename: ");
                string filename = Console.ReadLine();

                journal1.SaveToFile(filename);
                Console.WriteLine("File is saved!");
            }

        }
    }
}