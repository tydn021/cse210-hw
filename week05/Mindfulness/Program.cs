using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();

        string userInput = "";
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine();
        Console.WriteLine("This program contains small activities to help you relax and stimulate your mind.");
        Console.WriteLine();
        Console.WriteLine("Please Choose from the following options(Type the corresponding number)");
        Console.WriteLine();

        while (userInput != "4")
        {
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.Write("<");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                breathingActivity.DisplayStartingMessage();
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
            }

            else if (userInput == "2")
            {
                reflectingActivity.DisplayStartingMessage();
                reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();
            }

            else if (userInput == "3")
            {
                listingActivity.DisplayStartingMessage();
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
            }

            else if (userInput == "4")
            {
                Console.WriteLine("Thanks for using this program!");
                break;
            }
        }
    }
}