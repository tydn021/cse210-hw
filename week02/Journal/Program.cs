using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator _prompt = new PromptGenerator();
        Journal _journal = new Journal();


        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");

        string userInput = "";

        while (userInput != "5")
        {

            Console.WriteLine("1. Write Entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");

            Console.WriteLine("What would you like to do? Type 1-5:");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Entry _entry = new Entry();
                _entry._promptText = _prompt.GetRandomPrompt();
                Console.WriteLine(_entry._promptText);
                _entry._entryText = Console.ReadLine();
                DateTime _now = DateTime.Now;
                _entry._date = _now.ToShortDateString();

                _journal.AddEntry(_entry);
            }
            else if (userInput == "2")
            {
                _journal.DisplayAll();
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Please name your file: ");
                string filename = Console.ReadLine();
                _journal.SaveToFile(filename);
            }
            else if (userInput == "4")
            {
                Console.WriteLine("Please name your file: ");
                string filename = Console.ReadLine();
                _journal.LoadFromFile(filename);
            }
            else if (userInput == "5")
            {
                Console.WriteLine("Remember to write in your journal!");
            }
        }
    }
}