using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string words)
    {
        _reference = reference; 

        string[] parts = words.Split(" ");

        foreach (string part in parts)
        {
            Word word = new Word(part);

            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Word shownWords = new Word();

        foreach 
    }

    public string GetDisplayText()
    {}

    public bool IsCompletelyHidden()
    {}
}