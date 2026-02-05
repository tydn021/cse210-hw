using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompt = new List<string>
    {
        "You should think of a time when you helped someone else.",
        "Think of something interesting that happened to you today.",
        "Look outside and tell yourself how the current season is affecting you.",
        "THink of a conversation you've recently had that's affecting you.",
        "Think of a time when you did something really difficult.",
        "Think about a meal you've eaten."
    };
    private List<string> _questions = new List<string>
     {
         "What is one thing that you can do to improve this situation?",
         "Did this make you feel better or worse",
         "Can you think of a reason why you did this?",
         "How did you feel when it was complete?",
         "What is your favorite thing about this experience?",
         "What could you learn from this experience that applies to other situations?"
     };


    public ReflectingActivity() : base("Reflecting Activity", "This activity well allow you to reflect on your day so far...")
    { }

    public void Run()
    {
        DisplayPrompt();
        ShowCountDownSeconds(5);
        Console.ReadLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinnerSeconds(5);
            Console.Clear();
        }

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompt.Count);
        return _prompt[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(0, _questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"n---{prompt}---");
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.WriteLine($"> {question} ");
    }
}