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
        Random random = new Random();

        int hiddenCount = 0;


        while (hiddenCount < numberToHide)
        {
            int randomIndex = random.Next(0, _words.Count);

            if (_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();

                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
       string scripture = "";
       foreach (Word word in _words)
        {
            scripture += word.GetDisplayText();
            scripture += " ";
        }
       return $"{_reference.GetDisplayText()}: {scripture}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (! word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}