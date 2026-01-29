using System;

public class Comment
{
    private string _commentName;
    private string _commentText;
    public Comment(string commentName, string commentText)
    {
        _commentName = commentName;
        _commentText = commentText;
    }

    public void GetCommentDisplay()
    {
        Console.WriteLine($"{_commentName}: {_commentText}");
    }
}