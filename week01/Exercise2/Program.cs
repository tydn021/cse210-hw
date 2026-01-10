using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! Welcome to my Grading program for Exercise2 Project.");

        Console.Write("Please enter your Grade Percentage: ");
        string gradeFromUser = Console.ReadLine();

        int grade = int.Parse(gradeFromUser);

        string letter = "";

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

        Console.WriteLine($"Your Letter Grade is: {letter}");

        if (grade >= 70)

        {
            Console.WriteLine("You passed!");
        }

        else
        {
            Console.WriteLine("Unfortunately, you didn't pass!");
        }
    }


}