using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        string userInput = "";

        while (userInput != "Quit")
        {
            Console.WriteLine("Proverbs 3:5-6 Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
            Console.WriteLine("Press Enter to continue, or  type 'Quit' to end the program");

            Reference reference = new Reference("Proverbs", 3, 5, 6);
            
            string words ="Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

            int numberToHide = 3;


               
        }
    }
}