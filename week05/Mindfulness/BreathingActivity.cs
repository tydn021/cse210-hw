using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() :
    base("Breathing Activity", "This will help you pace your breathing and relax...")
    {}

    public void Run()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe In...");
            Console.WriteLine();
            ShowCountDownSeconds(5);
            Console.WriteLine();
            Console.Write("Breathe Out...");
            Console.WriteLine();
            ShowCountDownSeconds(7);
            Console.Write("\b \b");
        }
    }
}