using System;
using System.Collections.Generic;
using System.Numerics;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.Write("Please enter a list of numbers. Type zero when finished: ");
        int number = int.Parse(Console.ReadLine());

        List<int> storage = new List<int>();

        while (number != 0)
        {
            storage.Add(number);
            Console.Write("Please enter a series of number: ");
            number = int.Parse(Console.ReadLine());
            
        }

        foreach (int item in storage)
        {
            Console.WriteLine(item + " ");
             
        }

        //Core Requirements
        //1. Compute the sum, or total, of the numbers in the list.
        int total = storage.Sum();

        //2. Compute the average of the numbers in the list.
        double average = storage.Average();

        //3. Find the maximum, or largest, number in the list.
        int max = storage.Max();


        Console.WriteLine($"The minimum nummber in the list is {average}.");
        Console.WriteLine($"The maximum nummber in the list is {max}.");
        Console.WriteLine($"The sum of all number in the ist is {total}");
        

        Console.WriteLine($"There are {storage.Count} numbers stored inside the storage");
    }
}