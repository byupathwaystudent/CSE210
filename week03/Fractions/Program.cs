
using System;

class Program
{
    static void Main(string[] args)
    {
        
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);

        
        Console.WriteLine("Fraction 1:");
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine();

        Console.WriteLine("Fraction 2:");
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.WriteLine();

        Console.WriteLine("Fraction 3:");
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Console.WriteLine();

        Console.WriteLine("Fraction 4:");
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        
        Console.WriteLine();
        Console.WriteLine("Testing Getters:");

        Console.WriteLine($"Top: {fraction3.GetTop()}");
        Console.WriteLine($"Bottom: {fraction3.GetBottom()}");

        
        Console.WriteLine();
        Console.WriteLine("Testing Setters:");

        fraction3.SetTop(6);
        fraction3.SetBottom(8);

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
    }
}
