using System;

public class Entry
{
    public string _date = "";
    public string promptText = "";
    public string _entryText = "";

    public void Display()
    {
        Console.WriteLine($"Date: {_date} Prompt: {promptText}");
        Console.WriteLine($"{_entryText}");
    }
}