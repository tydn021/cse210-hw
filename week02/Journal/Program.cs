using System;
 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
 
        // ✅ minimal fix
        PromptGenerator _prompt = new PromptGenerator();
 
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
 
        string userInput = "";
 
        while (userInput != "5")
        {

            Console.WriteLine("1. Write Entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
 
            Console.WriteLine("What would you like to do? Type 1-5:");
            userInput = Console.ReadLine();
 
            if (userInput == "1")
            {
                Console.WriteLine(_prompt.GetRandomPrompt());
                Console.ReadLine();
            }
            else if (userInput == "2")
            {
                
            }
            else if (userInput == "3")
            {
            }
            else if (userInput == "4")
            {
            }
            else if (userInput == "5")
            {
                Console.WriteLine("Remember to write in your journal!");
            }
        }
    }
}