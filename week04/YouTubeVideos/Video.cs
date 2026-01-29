using System;

public class Video
{
    private string _title = "";
    private string _author = "";
    private int _length = 0;

    List<Comment> _comment = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comment.Add(comment);
    }
    public int CommentCount()
    {
        return _comment.Count;
    }

    public void GetVideoDisplay()
    {
        Console.WriteLine($"Title: {_title} \n Author: {_author} \n Length (In Seconds): {_length} \n Number of Comments: {CommentCount()}");
        
        foreach(Comment comment in _comment)
        {
            comment.GetCommentDisplay();
        }
    }

}