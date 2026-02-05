using System;
using System.Formats.Asn1;

public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompt = new List<string>
    {
        "Who are people that you love and appreciate?",
        "What are some of your personal strengths?",
        "Can you list the names of people you helped?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of the greatest heroes ever?"
    };

    public ListingActivity() :
    base("Listing Activity", "This is an activity that will help you bring important things to mind.")
    { }

    public void Run()
    {
        GetRandomPrompt();
        ShowSpinnerSeconds(6);
        GetListFromUser();
        Console.WriteLine($"The amount of answers you gave is {_count}");
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompt.Count);
        Console.WriteLine(_prompt[index]);
    }

    public List<string> GetListFromUser()
    {
        List<string> yourAnswers = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Type Answers!: ");
            yourAnswers.Add(Console.ReadLine());
            _count++;
            Console.Clear();
        }
        return yourAnswers;
    }
}