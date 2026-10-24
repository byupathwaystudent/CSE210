using System;

class Program
{
    static void Main(string[] args)
    {
        // In this line we are asking the user to type their grade. We also use the int.Parse() to make sure that they will enter and return a number.
        Console.Write("Please enter your grade: ");
        int grade = int.Parse(Console.ReadLine());

        // We declare the variable name letter to be use later on and to assign value.
        string letter;
        string sign;

        int lastDigit = grade % 10;

        // This is the star of our if-else if-else as instructed in the core requirements we initialize the value of letter per block. 
        if (grade >= 90)
        {
            letter = "A";
    
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        else
        {
            sign = "";
        }
    

        //Console.WriteLine(letter);
        
        // Here what we do is settin up the passing grade if it's equal or greater than 70 it means they passed if not then failed.
        if (grade >= 70)
        {
            Console.WriteLine($"Congratulastions you passed. You got an {letter}{sign}");
        }
        else
        {
            Console.WriteLine($"You failed. You got an {letter}{sign} try again next block. I know you can do it.");
        }



    }
}