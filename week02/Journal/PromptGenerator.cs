using System;
using System.Collections.Generic;
 
public class PromptGenerator
{
    public List<string> _prompt;
 
    public PromptGenerator()
    {
        _prompt = new List<string>();
 
        _prompt.Add("Did anyone make you smile today?");
        _prompt.Add("What was the funniest thing to happen to you today?");
        _prompt.Add("Did any of your prayers come true today?");
        _prompt.Add("Did you have any particularly strong feelings today?");
        _prompt.Add("Have read your scriptures? What was something you felt from reading them?");
    }
 
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompt.Count);
        return _prompt[index];
    }
}