using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        string userInput = "";

        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string words = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, words);

        Console.WriteLine("Proverbs 3:5-6 Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        Console.WriteLine("Press Enter to continue, or  type 'Quit' to end the program");

        userInput = Console.ReadLine();

        while (userInput != "Quit" || scripture.IsCompletelyHidden())
        {
            scripture.HideRandomWords(3);
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            userInput = Console.ReadLine();
            Console.ReadKey();
        }
    }
}