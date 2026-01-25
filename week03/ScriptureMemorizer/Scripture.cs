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
        // List<Word> shownWords = new List<Word>();

        // foreach (Word word in _words)
        // {
        //     if (! word.IsHidden())
        //     {
        //         shownWords.Add(word);
        //     }
        // }

        // for (int i = numberToHide; i < shownWords.Count; i++)
        //     {

        //     }

        //     int randomIndex = random.Next(shownWords.Count);
        int hiddenCount = 0;


        while (hiddenCount < numberToHide)
        {
            int randomIndex = random.Next(_words.Count());

            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();

                hiddenCount++;
            }

        }
    }

    public string GetDisplayText()
    { }

    public bool IsCompletelyHidden()
    { }
}