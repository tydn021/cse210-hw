using System.Collections.Generic;
using System.IO.Enumeration;

public class Journal
{
    public List<Entry> _entries;
 
    public Journal()
    {
        _entries = new List<Entry>();
    }
 
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
 
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
 
    public void SaveToFile(string filename)
    {
        Console.WriteLine("We're saving your file!");
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}, {entry._promptText}, {entry._entryText}");
            }
        }
    }
 
    public void LoadFromFile(string filename)
    {
        Console.WriteLine("Loading.....");
        string file = filename;
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string [] parts = line.Split(",");

            string date = parts[0];
            string prompt = parts [1];
            string entry = parts [2];
            
            Console.WriteLine($"{date}, {prompt}, {entry}");
        }
    }
}