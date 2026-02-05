using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    private string _name = "";
    private string _description = "";
    protected int _duration = 0;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Hi! Welcome to the {_name}! Let's get started!");
        Console.WriteLine();
        Console.WriteLine($"{_description}!");
        Console.WriteLine();
        Console.Write("Please tell me how many seconds you'd like your session to be: ");
        string input = Console.ReadLine();
        _duration = int.Parse(input);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Wasn't that relaxing? Well done!");
        Console.WriteLine();
        ShowSpinnerSeconds(3);
        Console.WriteLine($"It took you {_duration} seconds to complete the {_name} activity");
    }

    public void ShowSpinnerSeconds(int seconds)
    {
        List<string> spinnerAnimation = new List<string>();
        spinnerAnimation.Add("/");
        spinnerAnimation.Add("—");
        spinnerAnimation.Add("|");
        spinnerAnimation.Add("\\");

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            foreach (string spin in spinnerAnimation)
            {
                if (DateTime.Now >= endTime)
                {break;}
                Console.Write(spin);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }

    public void ShowCountDownSeconds(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}